using Domain.Entities;
using Shared.UI;
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

		//public ViewResponse<FTask> Go(FTask o)
		//{
		//	_ent = o;

		//	_set(_ent);

		//	if (this.ShowDialog() == DialogResult.OK)
		//	{
		//		return new ViewResponse<FTask> { Data = _get(), Ok = true };
		//	}
		//	else
		//	{
		//		return new ViewResponse<FTask> { Data = null, Ok = false };
		//	}

		//}

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

//			string _before_str = JsonTool.Serialize(_origin);
			_ent.CopyPropertiesTo(_origin);
//			string _after_str = JsonTool.Serialize(_origin);

//			MessageBox.Show($"before\n{_before_str}\nafter\n{_after_str}");

			return _ent;
		}

		private void btnComlete_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Close the task?", "TASK", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				isCompleted = !isCompleted;

			if (isCompleted)
				_ent.completed_date = DateTime.Now;
		}

		Action<ViewResponse<FTask>> _resultHandler;
		Action<FTask> _saveTaskHndlr;

		public void Go(FTask o, Action<ViewResponse<FTask>> resultHandler, Action<FTask> saveTaskHndlr)
		{
			_resultHandler = resultHandler;
			_saveTaskHndlr = saveTaskHndlr;
			_set(o);
			Show();
		}

		private void FTaskForm_FormClosed(object sender, FormClosedEventArgs e)
		{

		}

		private void button1save_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void FTaskForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			ViewResponse<FTask> res;

			if (DialogResult == DialogResult.OK)
				res = new ViewResponse<FTask> { Ok = true, Data = _get() };
			else
				res = new ViewResponse<FTask> { Ok = false, Data = _origin };

			_resultHandler(res);
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
				_saveTaskHndlr(_get());
				savingObserver.Saved = true;
				e.Handled = true;
			}
		}

		private void richTextBoxDescription_TextChanged(object sender, EventArgs e)
		{
			savingObserver.Saved = false;
		}
	}
}
