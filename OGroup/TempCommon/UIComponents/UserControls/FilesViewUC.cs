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
using CommonUIComponents.ViewComponents;
using Domain.Enums;
using UIComponents.Forms;
using Domain.Tools;

namespace CommonUIComponents.UserControls
{
	public partial class FilesViewUC : UserControl, IFilesView
	{
		FilesCollectionController _itemCollection;
		//public DataGridView FilesGrid => itemsGrid;

		public FilesViewUC()
		{
			InitializeComponent();

			_itemCollection = new FilesCollectionController(itemsGrid, lblSaved, currentFileText);

			_itemCollection.SaveTaskNeeded += _itemCollection_SaveTaskNeeded;
			_itemCollection.PutNodesToClipboard += _itemCollection_PutNodesToClipboard;
			_itemCollection.Paste += _itemCollection_Paste;

			setBufferState(0);
		}

		private void _itemCollection_Paste(object sender, EventArgs e)
		{
			Paste?.Invoke(this, EventArgs.Empty);
		}

		void setBufferState(int items_cnt)
		{
			if (items_cnt == 0)
				txtBufferState.BackColor = Color.Gray;
			else
				txtBufferState.BackColor = Color.Yellow;

			txtBufferState.Text = $"{items_cnt}";
		}

		private void _itemCollection_PutNodesToClipboard(object sender, IEnumerable<INode> e)
		{
			PutNodesToClipboard?.Invoke(this, e);
		}

		private void _itemCollection_SaveTaskNeeded(object sender, INode e)
		{
			Save?.Invoke(this, e);
		}

		public INode Selected => _itemCollection.Current;

		public event EventHandler<IEnumerable<INode>> PutNodesToClipboard;
		public event EventHandler<NType> Create;
		public event EventHandler<INode> Delete;
		public event EventHandler<INode> Save;
		public event EventHandler Paste;

		public void DisplayFiles(IEnumerable<INode> tcollection)
		{
			_itemCollection.DisplayFiles(tcollection);
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			INTypeChooseView ntypeChooseForm = new NTypeChooseForm();

			var res = ntypeChooseForm.Choose(new List<NType> { NType.Note, NType.Task });

			if (res.accepted)
			{
				Create?.Invoke(this, res.Result);
			}
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			Delete?.Invoke(this, _itemCollection.Current);
		}

		public void SetClipboardState(int cnt)
		{
			setBufferState(cnt);
		}

		public void SetFileGridCustomizer(INodeTypeCustomizer customizer)
		{
			_itemCollection.SetCustomizer(customizer);
		}
	}
}
