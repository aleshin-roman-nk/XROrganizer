using Domain.Entities;
using Domain.Enums;
using Domain.Services.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * DataGridService dgvS = new DataGridService().AddService().AddIconCustomizer(icons).AddColorCustomizer(colors).Build();
 * 
 * 
 */

namespace UIComponents.NodesNavigator
{
	public class DirNavigatorView : IDirNavigatorView
	{
		DataGridView _grid;
		Control _txtCurrentBranchName;

		BindingSource bs = new BindingSource();

		NodesImage _dirDataImage;

		// Так как внутри коллекции элемент выходной директории BaseDir, то при приведении типов получается null
		// Кажется нелогичным в этом модуле работы с разнотипными элементами коллекции в этом месте работать с конкретным типом.
		// Поэтому здесь необходтио работать с INode
		INode _current_dir => bs.Current as INode;

		private Dictionary<NType, Image> _icons = null;
		public Dictionary<NType, Image> Icons
		{
			get
			{
				return _icons;
			}
			set
			{
				if (value == null)
				{
					removeImgCol();
					_icons = value;
					return;
				}

				if (_icons != null)
					removeImgCol();

				addImgCol();
				_icons = value;
				markRowsWithIcons();
			}
		}
		public Dictionary<NType, Color> RowColors { get; set; } = null;
		public IGridCustomizer GridCustomizer { get; set; } = null;

		public DirNavigatorView(DataGridView grid, Control curbanchname)
		{
			_grid = grid;
			_txtCurrentBranchName = curbanchname;

			_grid.DataSource = bs;
			_grid.KeyDown += _grid_KeyDown;

			_grid.CellFormatting += _grid_CellFormatting;
		}

		//Добавлять автоматически, если устанвливается Icons. Если делается Icons = null, удалять колонку
		const string img_col = "col_img_icon_12045321563453453457";
		private void addImgCol()
		{
			DataGridViewImageColumn ic = new DataGridViewImageColumn();
			ic.HeaderText = "";
			ic.Image = null;
			ic.Name = img_col;
			ic.Width = 50;
			_grid.Columns.Add(ic);
			_grid.Columns[img_col].DisplayIndex = 0;
		}
		private void removeImgCol()
		{
			if (_icons != null)
				_grid.Columns.Remove(_grid.Columns[img_col]);
		}

		private void _grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (RowColors == null) return;

			var row = _grid.Rows[e.RowIndex];

			NType t = (row.DataBoundItem as INode).type;

			Color clr = getColor(t);
			if (clr == Color.Empty) return;

			e.CellStyle.ForeColor = clr;
		}

		public event EventHandler<INode> ActivateNode;
		public event EventHandler ExitNode;

		public void SetDirImage(NodesImage dataImage)
		{
			updateData(dataImage);
		}

		// Внешний модуль. Настраивыается и подключается извне.
		// Если его нет, происходит игнор иконок, и не создается столбец значков.
		private void markRowsWithIcons()
		{
			if (_icons == null) return;

			foreach (DataGridViewRow row in _grid.Rows)
			{
				var t = (row.DataBoundItem as INode).type;

				DataGridViewImageCell cell = row.Cells[img_col] as DataGridViewImageCell;

				cell.Value = getImg(t);
			}
		}

		private Image getImg(NType icontype)
		{
			if (Icons == null) return null;

			if (!Icons.ContainsKey(icontype))
				return null;

			return Icons[icontype];
		}

		private Color getColor(NType icontype)
		{
			if (RowColors == null) return Color.Empty;

			if (!RowColors.ContainsKey(icontype))
				return Color.Empty;

			return RowColors[icontype];
		}

		private void updateData(NodesImage image)
		{
			_dirDataImage = image;
			bs.DataSource = null;// происходит сброс текущей позиции при таком привоении. придется хранить текущий id, чтобы впоследствии вернуть курсор.
			bs.DataSource = _dirDataImage.CurrentBranch;
			placeCursor();
			_txtCurrentBranchName.Text = _dirDataImage.CurrentBranchName;
			markRowsWithIcons();
		}

		private void OnActivateNode(INode d)
		{
			ActivateNode?.Invoke(this, d);
		}

		private void OnExitNode()
		{
			ExitNode?.Invoke(this, EventArgs.Empty);
		}

		private void _grid_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				OnActivateNode(_current_dir);
				e.Handled = true;
			}
			else if (e.KeyCode == Keys.Back)
			{
				OnExitNode();
				placeCursor();
				e.Handled = true;
			}
		}

		private void placeCursor()
		{
			selectRowWithDir(_dirDataImage.HighlightedDir);
		}

		private void selectRowWithDir(INode d)
		{
			if (d == null) return;

			int rowIndex = -1;

			DataGridViewRow row = _grid.Rows
				.Cast<DataGridViewRow>()
				.Where(r => (r.DataBoundItem as INode).id == d.id)
				.FirstOrDefault();

			if (row == null) return;

			rowIndex = row.Index;

			_grid.Rows[rowIndex].Selected = true;
			_grid.CurrentCell = _grid[0, rowIndex];
		}

	}
}
