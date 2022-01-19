using Domain.Entities;
using Shared.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared.UI.Forms
{
	public partial class CompletedTasksForm : Form, ICompletedTasksView
	{
		BindingSource bs;

		public DateTime CurrentDate => dateTimePicker1.Value;

        public CompletedTasksForm()
		{
			InitializeComponent();

			bs = new BindingSource();

			dataGridView1.AutoGenerateColumns = false;

			dataGridView1.DataSource = bs;
		}

        public event EventHandler<DateTime> DateChanged;
        public event EventHandler<INode> OpenNode;
        public event EventHandler Completed;

        public void Display(IEnumerable<INode> nodes)
		{
			bs.DataSource = nodes;
			bs.ResetBindings(true);

			this.Show();
		}

		private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex < 0) return;

			var i = dataGridView1.Rows[e.RowIndex].DataBoundItem as INode;

			//MessageBox.Show($"{e.RowIndex} {e.ColumnIndex} #{i.id}");

			OpenNode?.Invoke(this, i);
		}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
			DateChanged?.Invoke(this, dateTimePicker1.Value);
		}

        private void CompletedTasksForm_FormClosed(object sender, FormClosedEventArgs e)
        {
			Completed?.Invoke(this, EventArgs.Empty);
        }
    }
}
