using mvp_base;
using SessionCollector.BL.Entities;
using SessionCollector.Tools;
using SessionCollector.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionCollector.Forms
{
	public partial class DirectoriesForm : Form, IDirectoriesView
	{
		BindingSource bs = new BindingSource();

		public DirectoriesForm()
		{
			InitializeComponent();

			dgvDirs.DataSource = bs;
			oDirectoryBindingSource.CurrentItemChanged += ODirectoryBindingSource_CurrentItemChanged;
		}

		private void ODirectoryBindingSource_CurrentItemChanged(object sender, EventArgs e)
		{
			//label1.Text = current == null ? "-" : current.Name;
		}

		public event EventHandler<INode> RenameDirectory;
		public event EventHandler<INode> DeleteDirectory;
		public event EventHandler CreateDirectory;

		INode current => bs.Current as INode;

		private void createToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CreateDirectory?.Invoke(this, EventArgs.Empty);
		}

		private void renameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RenameDirectory?.Invoke(this, current);
		}

		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DeleteDirectory?.Invoke(this, current);
		}

		public void SetNodes(IEnumerable<INode> lst, INode d = null)
		{
			bs.DataSource = null;
			bs.DataSource = lst;

			placeCursor(d);
		}

		private void placeCursor(INode n)
		{
			if (n == null) return;

			int rowIndex = -1;

			DataGridViewRow row = dgvDirs.Rows
				.Cast<DataGridViewRow>()
				.Where(r => (r.DataBoundItem as INode).Id == n.Id)
				.FirstOrDefault();

			if (row == null) return;

			rowIndex = row.Index;

			dgvDirs.Rows[rowIndex].Selected = true;
			dgvDirs.CurrentCell = dgvDirs[0, rowIndex];
		}

		private void button4_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void dgvDirs_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				DialogResult = DialogResult.OK;
				e.Handled = true;
			}
		}

		public ViewResponse<INode> Go()
		{
			ViewResponse<INode> res = new ViewResponse<INode>();

			res.Ok = this.ShowDialog() == DialogResult.OK;

			if (res.Ok)
				res.Data = current;

			return res;
		}
	}
}
