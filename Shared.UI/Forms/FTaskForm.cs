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

		FTask _ent = null;
		FTask _origin = null;

		public FTaskForm()
		{
			InitializeComponent();

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
					btnComlete.BackgroundImage = Shared.UI.Properties.Resources.icons8_task_completed_48;
					btnComlete.BackColor = ColorTranslator.FromHtml("#94d2bd");
				}
				else
				{
					btnComlete.BackgroundImage = Shared.UI.Properties.Resources.icons8_task_planning_48;
					btnComlete.BackColor = ColorTranslator.FromHtml("#ee9b00");
				}
			}
		}

		public int ObjId => _origin.id;

		private void _set(FTask o)
		{
			_origin = o;
			_ent = JsonTool.Clone(_origin);

			richTextBoxDescription.Text = o.definition;
			isCompleted = o.IsCompleted;
			lblDate.Text = o.date.Value.ToShortDateString();
			textBox1Name.Text = o.name;
			lblFullPath.Text = $"{o.path}#{o.id}";
		}

		private FTask _get()
		{
			// todo: collect all properties
			_ent.IsCompleted = isCompleted;
			_ent.definition = richTextBoxDescription.Text;
			_ent.name = textBox1Name.Text;

			_ent.CopyPropertiesTo(_origin);

			return _ent;
		}

		private void btnComlete_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Close the task?", "TASK", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				isCompleted = !isCompleted;

			if (isCompleted)
				_ent.completed_date = DateTime.Now;
		}

        public event EventHandler Completed;
        public event EventHandler<FTask> Save;
        public event EventHandler<DisplaySessionsPageEventArg> ShowTopSessions;

        private void FTaskForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			Completed?.Invoke(this, EventArgs.Empty);
		}

		private void button1save_Click(object sender, EventArgs e)
		{
			Save?.Invoke(this, _get());
			Close();
		}

		private void btnUpdateTaskName_Click(object sender, EventArgs e)
		{
			_ent.definition = richTextBoxDescription.Text;
			_ent.updateNameFromDescription();
			textBox1Name.Text = _ent.name;
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
				Save?.Invoke(this, _get());
				savingObserver.Saved = true;
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
    }
}
