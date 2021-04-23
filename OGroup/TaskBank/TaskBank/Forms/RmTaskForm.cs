using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBank.BL.Entities;
using TaskBank.Views;

namespace TaskBank.Dlg.forms
{
	public partial class RmTaskForm : Form, ISingleEntityView<RmTask>
	{
		RmTask _rmTask;

		public RmTaskForm()
		{
			InitializeComponent();
		}

		private void placeObject(RmTask tsk)
		{
			richTextBox1.Text = tsk.Text;
			richTextBox1.SelectionStart = richTextBox1.Text.Length;
		}

		private void acceptObject()
		{
			_rmTask.Text = richTextBox1.Text;
		}

		ViewResult<RmTask> ISingleEntityView<RmTask>.Go(RmTask tsk)
		{
			_rmTask = tsk;
			placeObject(_rmTask);

			bool ok = this.ShowDialog() == DialogResult.OK;

			if (ok)
			{
				acceptObject();
				var res = new ViewResult<RmTask>(_rmTask, true);
				return res;
			}
			else
			{
				return new ViewResult<RmTask>(null, false);
			}
		}
	}
}
