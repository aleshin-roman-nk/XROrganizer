using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Shared.UI.UserControls
{
	public partial class NodesViewUC : UserControl, INodesView
	{
		BindingSource bsNodes = new BindingSource();

		DataGridViewCustomizer _customizer;

		INode _currentNode => bsNodes.Current as INode;

		public IEnumerable<INode> SelectedNodes => _getSelectedNodes();

		public NodesViewUC()
		{
			InitializeComponent();

			typeof(DataGridView).InvokeMember(
			"DoubleBuffered",
			BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
			null,
			nodeGrid,
			new object[] { true });

			nodeGrid.AutoGenerateColumns = false;

			bsNodes.CurrentItemChanged += BsNodes_CurrentItemChanged;
			nodeGrid.DataSource = bsNodes;
		}

		private void BsNodes_CurrentItemChanged(object sender, EventArgs e)
		{
			if(_currentNode != null)
				CurrentNodeChanged?.Invoke(this, _currentNode);
		}

		public event EventHandler<IEnumerable<INode>> SendNodesToClipboard;
		public event EventHandler Paste;
		public event EventHandler MakeNodePathTag;
		public event EventHandler<INode> ActivateNode;
		public event EventHandler LeaveNode;
		public event EventHandler<INode> CurrentNodeChanged;

		string _lastPath = "";
		public void DisplayNodes(IEnumerable<INode> nodes, string path, INode highlightedNode)
		{
			bool isPathSame = _lastPath.Equals(path);

			int indexBeforeUpdate = -1;
			if (nodeGrid.CurrentCell != null)
				 indexBeforeUpdate = nodeGrid.CurrentCell.RowIndex;

			bsNodes.DataSource = null;
			bsNodes.DataSource = nodes;
			txtDirectoryFullName.Text = $"[{path}]";
			placeCursor(highlightedNode);

			if(indexBeforeUpdate >= 0 && isPathSame)
				placeCursorByRowIndex(indexBeforeUpdate);

			_lastPath = path;

			if(_customizer != null)
				_customizer.markRowsWithIcons();
		}

		private void placeCursorByRowIndex(int i)
		{
			if(i < nodeGrid.Rows.Count)
			{
				nodeGrid.Rows[i].Selected = true;
				nodeGrid.CurrentCell = nodeGrid[0, i];
			}
		}

		public void SetFileGridCustomizer(INodeTypeCustomizer customizer)
		{

		}

		private void itemsGrid_KeyDown(object sender, KeyEventArgs e)
		{
			if(Keys.Enter == e.KeyCode)
			{
				ActivateNode?.Invoke(this, _currentNode);
				e.Handled = true;
			}
			else if(e.KeyCode == Keys.Back)
			{
				LeaveNode?.Invoke(this, EventArgs.Empty);
				e.Handled = true;
			}
			else if (e.Control && e.KeyCode == Keys.X)
			{
				SendNodesToClipboard?.Invoke(this, _getSelectedNodes());
				e.Handled = true;
			}
			else if (e.Control && e.KeyCode == Keys.V)
			{
				Paste?.Invoke(this, EventArgs.Empty);
				e.Handled = true;
			}
		}

		private void placeCursor(INode n)
		{
			if (n == null) return;

			int rowIndex = -1;

			DataGridViewRow row = nodeGrid.Rows
				.Cast<DataGridViewRow>()
				.Where(r => (r.DataBoundItem as INode).id == n.id)
				.FirstOrDefault();

			if (row == null) return;

			rowIndex = row.Index;

			nodeGrid.Rows[rowIndex].Selected = true;
			nodeGrid.CurrentCell = nodeGrid[0, rowIndex];
		}

		private IEnumerable<INode> _getSelectedNodes()
		{
			return nodeGrid.SelectedRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem as INode);
		}

		public void SetCursorAt(INode n)
		{
			placeCursor(n);
		}

		private void NodesViewUC_Load(object sender, EventArgs e)
		{
			_customizer = new DataGridViewCustomizer(nodeGrid);
			_customizer.RowColors = new Dictionary<NType, Color>();
			_customizer.RowColors[NType.Dir] = ColorTranslator.FromHtml("#414833");
			_customizer.RowColors[NType.Task] = Color.Green;

			var d = new Dictionary<NType, Image>();
			d[NType.Task] = Properties.Resources.task_list_24;
			d[NType.Dir] = Properties.Resources.folder_241;
			d[NType.Note] = Properties.Resources.note_24;
			d[NType.exit_dir] = Properties.Resources.exit_24;

			_customizer.Icons = d;

			_customizer.markRowsWithIcons();
		}
	}
}
