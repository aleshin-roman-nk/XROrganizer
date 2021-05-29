using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBank.Views;

namespace TaskBank.Dlg.forms
{
	public partial class RmTaskForm : Form, ISingleEntityView<Note>
	{
		Note _rmTask;

		public RmTaskForm()
		{
			InitializeComponent();
		}

		private void placeObject(Note tsk)
		{
			textBox1.Text = tsk.description;
			textBox1.SelectionStart = textBox1.Text.Length;
		}

		private void acceptObject()
		{
			_rmTask.description = textBox1.Text;
		}

		ViewResult<Note> ISingleEntityView<Note>.Go(Note tsk)
		{
			_rmTask = tsk;
			placeObject(_rmTask);

			bool ok = this.ShowDialog() == DialogResult.OK;

			if (ok)
			{
				acceptObject();
				var res = new ViewResult<Note>(_rmTask, true);
				return res;
			}
			else
			{
				return new ViewResult<Note>(null, false);
			}
		}

		private void RmTaskForm_Load(object sender, EventArgs e)
		{
			textBox1.Select();
		}
	}
}
