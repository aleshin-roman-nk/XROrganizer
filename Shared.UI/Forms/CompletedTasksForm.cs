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

namespace Shared.UI.Forms
{
	public partial class CompletedTasksForm : Form, ICompletedTasksView
	{
		BindingSource bs;

		public CompletedTasksForm()
		{
			InitializeComponent();

			bs = new BindingSource();

			dataGridView1.AutoGenerateColumns = false;

			dataGridView1.DataSource = bs;
		}

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

			MessageBox.Show($"{e.RowIndex} {e.ColumnIndex} #{i.id}");
		}
	}
}
