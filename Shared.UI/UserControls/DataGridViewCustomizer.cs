using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared.UI.UserControls
{
	public class DataGridViewCustomizer
	{
		private readonly DataGridView _grid;

		public DataGridViewCustomizer(DataGridView grd)
		{
			_grid = grd;

			_grid.CellFormatting += _grid_CellFormatting;
		}

		public Dictionary<NType, Color> RowColors { get; set; } = null;

		public void markRowsWithIcons()
		{
			if (_icons == null) return;

			foreach (DataGridViewRow row in _grid.Rows)
			{
				var t = (row.DataBoundItem as INode).type;

				DataGridViewImageCell cell = row.Cells[img_col] as DataGridViewImageCell;

				cell.Value = getImg(t);
			}
		}

		private Color getColor(NType icontype)
		{
			if (RowColors == null) return Color.Empty;

			if (!RowColors.ContainsKey(icontype))
				return Color.Empty;

			return RowColors[icontype];
		}

		private Image getImg(NType icontype)
		{
			if (Icons == null) return null;

			if (!Icons.ContainsKey(icontype))
				return null;

			return Icons[icontype];
		}

		private void _grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
            if (RowColors == null) return;

            var row = _grid.Rows[e.RowIndex];

            NType t = (row.DataBoundItem as INode).type;

			// 13-09-2022 временно, закрытую задачу показываем, но она серая

            /*
			 * >>> 30-01-2022
			 * Придумать лямбду, условие - функция.
			 * входные параметры в лямбду: INode, DataGridViewCellStyle
			 */
            if ((row.DataBoundItem as INode).pinned)
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
			else if(t == NType.Task)
			{
				if((row.DataBoundItem as FTask).IsCompleted)
				{
                    e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Strikeout);
                    e.CellStyle.ForeColor = ColorTranslator.FromHtml("#9EA3B0");
					return;
                }
			}

            Color clr = getColor(t);
            if (clr == Color.Empty) return;
            e.CellStyle.ForeColor = clr;
        }

		private void removeImgCol()
		{
			if (_icons != null)
				_grid.Columns.Remove(_grid.Columns[img_col]);
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
	}
}
