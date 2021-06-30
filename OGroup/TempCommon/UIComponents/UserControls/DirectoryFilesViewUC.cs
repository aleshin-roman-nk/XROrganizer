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
using UIComponents.ViewComponents;

namespace UIComponents.UserControls
{
	public partial class DirectoryFilesViewUC : UserControl, IDirectoryFilesView
	{
		ItemsCollectionController _itemCollection;

		public DataGridView FilesGrid => itemsGrid;

		public DirectoryFilesViewUC()
		{
			InitializeComponent();

			_itemCollection = new ItemsCollectionController(itemsGrid, lblSaved, currentFileText);

			_itemCollection.SaveTaskNeeded += _itemCollection_SaveTaskNeeded;
			_itemCollection.MoveTaskCollection += _itemCollection_MoveTaskCollection;
		}

		private void _itemCollection_MoveTaskCollection(object sender, IEnumerable<INode> e)
		{
			MoveFiles?.Invoke(this, e);
		}

		private void _itemCollection_SaveTaskNeeded(object sender, INode e)
		{
			Save?.Invoke(this, e);
		}

		public INode Current => _itemCollection.Current;

		public event EventHandler<IEnumerable<INode>> MoveFiles;
		public event EventHandler Create;
		public event EventHandler<INode> Delete;
		public event EventHandler<INode> Save;

		public void DisplayFiles(IEnumerable<INode> tcollection)
		{
			_itemCollection.DisplayFiles(tcollection);
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			Create?.Invoke(this, EventArgs.Empty);
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			Delete?.Invoke(this, _itemCollection.Current);
		}
	}
}
