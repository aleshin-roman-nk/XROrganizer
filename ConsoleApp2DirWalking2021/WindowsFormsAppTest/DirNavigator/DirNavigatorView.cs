using DirectoriesWolking.Models.DirNavigator;
using DirectoryNavigator;
using DirectoryNavigator.tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppTest.DirNavigator;

namespace WindowsFormsAppTest.FormComponent
{

	/*
	 * >>> 03-05-2021 02:13
	 * Этот класс не должен быть жестко привязан только к сервису навигации по узлам.
	 * Здесь происходит только слежение, какой элемент активирован.
	 * 
	 * Я хочу добавить модуль маршрутизатор, который получает активированную сущность и решает, в какой модуль ее отправлять.
	 * Если это директория, в модуль навигации по узлам.
	 * Если заметка или задача, в модуль редактирования (морда).
	 * 
	 * Возникла проблема: после активации задачи, курсор помещается на первую строчку текущей ветки директорий.
	 * Причина - мы считываем состояние модуля навигации для решения, куда поместить курсор.
	 * 
	 * Получается, модуль маршрутизации должен отдавать DirNavigatorDataImage.
	 * Это промежуточный узел между DirectoryNavigatorService и DirNavigatorView который принимает решение о формировании DirNavigatorDataImage.
	 * 
	 * 
	 */

	public class DirNavigatorView: IDirNavigatorView
	{
		DataGridView _grid;
		Control _txtCurrentBranchName;

		BindingSource bs = new BindingSource();

		DirNavigatorDataImage _dirDataImage;

		// Так как внутри коллекции элемент выходной директории BaseDir, то при приведении типов получается null
		// Кажется нелогичным в этом модуле работы с разнотипными элементами коллекции в этом месте работать с конкретным типом.
		// Поэтому здесь необходтио работать с IDir
		IDir _current_dir => bs.Current as IDir;

		private Dictionary<NodeType, Image> _icons = null;
		public Dictionary<NodeType, Image> Icons
		{
			get
			{
				return _icons;
			}
			set
			{
				if(value == null)
				{
					removeImgCol();
					_icons = value;
					return;
				}

				addImgCol();
				_icons = value;
			}
		}
		public Dictionary<NodeType, Color> RowColors { get; set; } = null;
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
			if(_icons != null)
				_grid.Columns.Remove(_grid.Columns[img_col]);
		}

		private void _grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (RowColors == null) return;

			var row = _grid.Rows[e.RowIndex];

			NodeType t = (row.DataBoundItem as IDir).type;

			Color clr = getColor(t);
			if (clr == Color.Empty) return;

			e.CellStyle.ForeColor = clr;
		}

		public event EventHandler<IDir> CommandEnterDir;
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
				var t = (row.DataBoundItem as IDir).type;

				DataGridViewImageCell cell = row.Cells[img_col] as DataGridViewImageCell;

				cell.Value = getImg(t);
			}
		}

		private Image getImg(NodeType icontype)
		{
			if (Icons == null) return null;

			if (!Icons.ContainsKey(icontype))
				return null;

			return Icons[icontype];
		}

		private Color getColor(NodeType icontype)
		{
			if (RowColors == null) return Color.Empty;

			if (!RowColors.ContainsKey(icontype))
				return Color.Empty;

			return RowColors[icontype];
		}

		private void updateData(DirNavigatorDataImage image)
		{
			_dirDataImage = image;
			IDir d = bs.Current as IDir;
			bs.DataSource = null;// происходит сбой текущей позиции при таком привоении. придется хранить текущий id, чтобы впоследствии вернуть курсор.
			bs.DataSource = _dirDataImage.CurrentBranch;
			selectRowWithDir(d);
			_txtCurrentBranchName.Text = _dirDataImage.CurrentBranchName;
			markRowsWithIcons();
		}

		private void OnEnterDir(IDir d)
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
			else if(e.KeyCode == Keys.Back)
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

		private void selectRowWithDir(IDir d)
		{
			if (d == null) return;

			int rowIndex = -1;

			DataGridViewRow row = _grid.Rows
				.Cast<DataGridViewRow>()
				.Where(r => (r.DataBoundItem as IDir).id == d.id)
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
