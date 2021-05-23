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

namespace UIComponents.DirNavigator
{
	public class DirNavigatorView: IDirNavigatorView
	{
		DataGridView _grid;
		Control _txtCurrentBranchName;

		BindingSource bs = new BindingSource();

		DirNavigatorDataImage _dirDataImage;

		// Так как внутри коллекции элемент выходной директории BaseDir, то при приведении типов получается null
		// Кажется нелогичным в этом модуле работы с разнотипными элементами коллекции в этом месте работать с конкретным типом.
		// Поэтому здесь необходтио работать с IDir
		INode _current_dir => bs.Current as INode;

		private Dictionary<ntype, Image> _icons = null;
		public Dictionary<ntype, Image> Icons
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

				addImgCol();
				_icons = value;
			}
		}
		public Dictionary<ntype, Color> RowColors { get; set; } = null;
		public DirNavigatorView(DataGridView grid, Control curbanchname)
		{
			_grid = grid;
			_txtCurrentBranchName = curbanchname;

			_grid.DataSource = bs;
			_grid.KeyDown += _grid_KeyDown;

			_grid.CellFormatting += _grid_CellFormatting;

			//addImgCol();
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

			ntype t = (row.DataBoundItem as INode).type;

			Color clr = getColor(t);
			if (clr == Color.Empty) return;

			e.CellStyle.ForeColor = clr;
		}

		public event EventHandler<INode> CommandEnterDir;
		public event EventHandler CommandExitDir;

		public void SetDirImage(DirNavigatorDataImage dataImage)
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

		private Image getImg(ntype icontype)
		{
			if (Icons == null) return null;

			if (!Icons.ContainsKey(icontype))
				return null;

			return Icons[icontype];
		}

		private Color getColor(ntype icontype)
		{
			if (RowColors == null) return Color.Empty;

			if (!RowColors.ContainsKey(icontype))
				return Color.Empty;

			return RowColors[icontype];
		}

		private void updateData(DirNavigatorDataImage image)
		{
			_dirDataImage = image;
			INode d = bs.Current as INode;
			bs.DataSource = null;// происходит сбой текущей позиции при таком привоении. придется хранить текущий id, чтобы впоследствии вернуть курсор.
			bs.DataSource = _dirDataImage.CurrentBranch;
			selectRowWithDir(d);
			_txtCurrentBranchName.Text = _dirDataImage.CurrentBranchName;
			markRowsWithIcons();
		}

		private void OnEnterDir(INode d)
		{
			CommandEnterDir?.Invoke(this, d);
		}

		private void OnExitDir()
		{
			CommandExitDir?.Invoke(this, EventArgs.Empty);
		}

		private void _grid_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				// Важная операция по изменению состояния образа данных
				OnEnterDir(_current_dir);
				placeCursor();
				e.Handled = true;
			}
			else if (e.KeyCode == Keys.Back)
			{
				OnExitDir();
				placeCursor();
				e.Handled = true;
			}
		}

		private void placeCursor()
		{
			// анализируем резальтат перемещения после вызова OnEnterDir
			// если вынырнули, поместить курсор на родительсткой директории
			if (_dirDataImage.LastMovment == LastMovment.prev)
			{
				// select prev owner row
				selectRowWithDir(_dirDataImage.PreviousOwner);
			}
			// если вошли в директорию, помещаем курсор на верхней ".."
			else if (_dirDataImage.LastMovment == LastMovment.next)
			{
				// set cursor on the first row
				point_row(0);
			}
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

			point_row(rowIndex);
		}

		private void point_row(int row_index)
		{
			_grid.Rows[row_index].Selected = true;
			_grid.CurrentCell = _grid[1, row_index];
		}
	}
}
