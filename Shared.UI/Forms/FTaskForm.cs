using Domain.Entities;
using Shared.UI;
using Shared.UI.Interfaces;
using Shared.UI.Interfaces.EventArgsDefinition;
using Shared.UI.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xorg.Tools;

namespace Shared.UI.Forms
{

/*
 * Black theme:
 * backgroung = 37; 37; 38
 * text = 219; 164; 14
 * 
 * orange theme:
 * backgroung = #4B5A20
 * text = #DBA40E
 * 
 */

	public partial class FTaskForm : Form, IFTaskEditView
	{
		SavingObserver savingObserver;
		NodeTextPages nodeTextPages;

		FTask _ent = null;

		IInputBox _dlg;

		public FTaskForm(IInputBox dlg)
		{
			InitializeComponent();

			_dlg = dlg;

			savingObserver = new SavingObserver();
			savingObserver.Indicator = lblSaved;
			savingObserver.Saved = true;

			typeof(Control).GetProperty("ResizeRedraw", BindingFlags.NonPublic | BindingFlags.Instance)
				.SetValue(panel1, true, null);

			typeof(Panel).GetProperty("DoubleBuffered",
						  BindingFlags.NonPublic | BindingFlags.Instance)
				.SetValue(panel1, true, null);
		}

		bool _isCompleted;
		private bool isCompleted
		{
			get
			{
				return _isCompleted;
			}
			set
			{
				_isCompleted = value;
				if (_isCompleted)
				{
					btnComlete.BackgroundImage = Properties.Resources.icons8_task_completed_48;
					btnComlete.BackColor = ColorTranslator.FromHtml("#94d2bd");
				}
				else
				{
					btnComlete.BackgroundImage = Properties.Resources.icons8_task_planning_48;
					btnComlete.BackColor = ColorTranslator.FromHtml("#ee9b00");
				}
			}
		}

		public int ObjId => _ent.id;

		private void _set(FTask o)
		{
			_ent = o;

			//richTextBoxDescription.Text = o.text;
			isCompleted = _ent.IsCompleted;
			lblDate.Text = _ent.date.Value.ToShortDateString();
			txtFullPath.Text = $"{_ent.path}";
			checkBox1Pinned.Checked = _ent.pinned;

			nodeTextPages = new NodeTextPages(_ent.text);
			richTextBoxDescription.Text = nodeTextPages.Page;
			txtPageText.Text = $"{nodeTextPages.PageNo}/{nodeTextPages.MaxPage}";
		}

		private FTask _get()
		{
			// todo: collect all properties
			_ent.IsCompleted = isCompleted;
			//_ent.text = richTextBoxDescription.Text;
			_ent.pinned = checkBox1Pinned.Checked;
			_ent.text = nodeTextPages.DbText;

			nodeTextPages.Page = richTextBoxDescription.Text;
			_ent.text = nodeTextPages.DbText;
			updateName(_ent);

			return _ent;
		}

		private void updateName(FTask ent)
        {
			if (!string.IsNullOrEmpty(_ent.name)) return;

			string str = nodeTextPages.FirstPageText();

			// c# 8.0 or higher
			//using var reader = new StringReader(str);
			//string first = reader.ReadLine();

			using (var reader = new StringReader(str))
			{
				ent.name = reader.ReadLine();
			}
		}

		private void btnComlete_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Close the task?", "TASK", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				isCompleted = !isCompleted;

			if (isCompleted)
				_ent.completed_date = DateTime.Now;
		}

        public event EventHandler Completed;
        public event EventHandler<SaveNodeEventArgs> Save;
        public event EventHandler<DisplaySessionsPageEventArg> ShowTopSessions;
		public event EventHandler<INode> CreateSession;
        public event EventHandler<int> OpenNodeById;

        private void FTaskForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Completed?.Invoke(this, EventArgs.Empty);
		}

		private void OnNodeSave()
        {
			SaveNodeEventArgs ev = new SaveNodeEventArgs(_get());
			Save?.Invoke(this, ev);
			savingObserver.Saved = ev.IsNodeSaved;
        }

		private void button1save_Click(object sender, EventArgs e)
		{
			OnNodeSave();
			Close();
		}

		public void AddProperty(string name, string value)
		{
			var i = Controls.Cast<Control>().FirstOrDefault((x) => { if (x.Tag != null) return (x.Tag as string).Equals(name); return false; });

			if (i != null)
				i.Text = value;
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			var p = sender as Panel;
			ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color.Yellow, ButtonBorderStyle.Solid);
		}

		private void richTextBoxDescription_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.S && e.Control)
			{
				//Save?.Invoke(this, _get());
				//savingObserver.Saved = true;
				OnNodeSave();
				e.Handled = true;
			}
		}

		private void richTextBoxDescription_TextChanged(object sender, EventArgs e)
		{
			savingObserver.Saved = false;
		}

        public void Go(FTask o)
        {
			_set(o);
			Show();
		}

        public void Restore()
        {
			this.Show();
			this.WindowState = FormWindowState.Normal;
			this.Focus();
        }

        private void btnAllSessions_Click(object sender, EventArgs e)
        {
			ShowTopSessions?.Invoke(
				this, new DisplaySessionsPageEventArg(
					DateTime.Now, 
					$"{_ent.path}#{_ent.id}",
					_ent.id));
		}

        private void btnCreateSession_Click(object sender, EventArgs e)
        {
			CreateSession?.Invoke(this, _ent);
        }

        private void toolStripMenuItem1OpenNodeById_Click(object sender, EventArgs e)
        {
			var txt = richTextBoxDescription.SelectedText;

			if (!string.IsNullOrEmpty(txt))
            {
				int i = 0;
				if (int.TryParse(txt, out i))
					OpenNodeById?.Invoke(this, i);
            }
        }

        private void btnTimeTag_Click(object sender, EventArgs e)
        {
			richTextBoxDescription.SelectedText = $">>> {DateTime.Now.ToString("dd-MM-yyyy HH:mm")}";

			//try
			//{
			//	Clipboard.Clear();
			//	Clipboard.SetText(res);
			//}
			//catch (Exception)
			//{

			//}
		}

        private void btnNextPage_Click(object sender, EventArgs e)
        {
			bool saved = savingObserver.Saved;// we want to remember if any page is not saved in db
			nodeTextPages.Page = richTextBoxDescription.Text;// забираем текст перед сменой страницы.
			nodeTextPages.nextPage();
			richTextBoxDescription.Text = nodeTextPages.Page;
			txtPageText.Text = $"{nodeTextPages.PageNo}/{nodeTextPages.MaxPage}";
			savingObserver.Saved = saved;
		}

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
			bool saved = savingObserver.Saved;
			nodeTextPages.Page = richTextBoxDescription.Text;
			nodeTextPages.prevPage();
			richTextBoxDescription.Text = nodeTextPages.Page;
			txtPageText.Text = $"{nodeTextPages.PageNo}/{nodeTextPages.MaxPage}";
			savingObserver.Saved = saved;
		}

        private void brnAddPage_Click(object sender, EventArgs e)
        {
			bool saved = savingObserver.Saved;
			nodeTextPages.Page = richTextBoxDescription.Text;
			nodeTextPages.AddPage("", "");
			richTextBoxDescription.Text = nodeTextPages.Page;
			txtPageText.Text = $"{nodeTextPages.PageNo}/{nodeTextPages.MaxPage}";
			savingObserver.Saved = saved;
		}

        private void btnKillPage_Click(object sender, EventArgs e)
        {
			bool saved = savingObserver.Saved;
			nodeTextPages.killPage();
			richTextBoxDescription.Text = nodeTextPages.Page;
			txtPageText.Text = $"{nodeTextPages.PageNo}/{nodeTextPages.MaxPage}";
			savingObserver.Saved = saved;
		}

        private void FTaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!savingObserver.Saved)
            {
				var resp = _dlg.AskUser("There are something unsaved. Do you want to save?");
				if(resp == DlgAnswerCode.yes)
                {
					OnNodeSave();
                }
				else if (resp == DlgAnswerCode.cancel)
                {
					e.Cancel = true;
                }
			}
        }
    }
}
