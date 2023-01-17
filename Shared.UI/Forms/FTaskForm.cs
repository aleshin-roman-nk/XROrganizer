using Domain.dto;
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
     * text = 219; 164; 14
     * 
     */

    public partial class FTaskForm : Form, IFTaskEditView
	{
		SavingObserver savingObserver;

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

			isCompleted = _ent.IsCompleted;
			lblDate.Text = _ent.date.Value.ToShortDateString();
			txtFullPath.Text = $"{_ent.path}";
			checkBox1Pinned.Checked = _ent.pinned;
            nodeTextPagesUC1.SetNode(_ent);
        }

		private FTask _get()
		{
			_ent.IsCompleted = isCompleted;
			_ent.pinned = checkBox1Pinned.Checked;
			nodeTextPagesUC1.CommitCurrentPage();

			updateName(_ent);

			return _ent;
		}

		private void updateName(FTask ent)
        {
			if (!string.IsNullOrEmpty(_ent.name)) return;

			string str = nodeTextPagesUC1.FirstPageText();

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
        public event EventHandler<DisplaySessionsPageEventArg> ShowTopSessions;// вполне пойдет для строкогово запроса
		public event EventHandler<NodeDTO> CreateSession;// вполне пойдет для строкогово запроса
        public event EventHandler<int> OpenNodeById;// вполне пойдет для строкогово запроса
        public event EventHandler<NodeTextPage> DeleteNodeTextPage;

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
			CreateSession?.Invoke(this, new NodeDTO { id = _ent.id });
        }

        private void btnTimeTag_Click(object sender, EventArgs e)
        {
            nodeTextPagesUC1.SelectedText = $">>> {DateTime.Now.ToString("dd-MM-yyyy HH:mm")}";
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

        private void nodeTextPagesUC1_AddPageRequired(object sender, EventArgs e)
        {
            nodeTextPagesUC1.AddPage("", "");
        }

        private void nodeTextPagesUC1_ObjectChanged(object sender, EventArgs e)
        {
            savingObserver.Saved = false;
        }

        private void FTaskForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                OnNodeSave();
                e.Handled = true;
            }
        }

        private void nodeTextPagesUC1_RemovePageRequired(object sender, NodeTextPage e)
        {
			DeleteNodeTextPage?.Invoke(sender, e);
        }

        private void nodeTextPagesUC1_OpenNodeById(object sender, string e)
        {
            //var txt = nodeTextPagesUC1.SelectedText;

            if (!string.IsNullOrEmpty(e))
            {
                int i = 0;
                if (int.TryParse(e, out i))
                    OpenNodeById?.Invoke(this, i);
            }
        }
    }
}
