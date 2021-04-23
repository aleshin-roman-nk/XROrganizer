using DirectoriesWolking;
using DirectoriesWolking.tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppTest.DirNavigator;

namespace WindowsFormsAppTest.Forms
{
	public class DirNavigatorView: IDirNavigatorView
	{
		DataGridView _grid;
		Control _txtCurrentBranchName;
		Control _txtCurrentDirName;
		BindingSource bs = new BindingSource();

		DirNavigatorDataImage _dirDataImage;

		// Так как внутри коллекции элемент выходной директории BaseDir, то при приведении типов получается null
		// Кажется нелогичным в этом модуле работы с разнотипными элементами коллекции в этом месте работать с конкретным типом.
		// Поэтому здесь необходтио работать с IDir
		IDir _current_dir => bs.Current as IDir;

		public DirNavigatorView(DataGridView grid, Control curbanchname, Control curdirname)
		{
			_grid = grid;
			_txtCurrentBranchName = curbanchname;
			_txtCurrentDirName = curdirname;

			_grid.DataSource = bs;
			_grid.KeyDown += _grid_KeyDown;
		}

		public event EventHandler<IDir> CommandEnterDir;

		public void SetDirImage(DirNavigatorDataImage dataImage)
		{
			_dirDataImage = dataImage;
			updateData();
			showCurrentDir();
		}

		private void updateData()
		{
			bs.DataSource = _dirDataImage.CurrentBranch;
			_txtCurrentBranchName.Text = _dirDataImage.CurrentBranchName;
		}

		private void OnEnterDir(IDir d)
		{
			CommandEnterDir?.Invoke(this, d);
		}

		private void _grid_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				// Важная операция по изменению состояния образа данных
				OnEnterDir(_current_dir);

				updateData();

				e.Handled = true;

				if (_dirDataImage.LastMovment == LastMovment.prev)
				{
					// select prev owner row
					selectRowWithDir(_dirDataImage.PreviousOwner);
					showCurrentDir();
				}
				else
				{
					// set cursor on the first row
					point_row(0);
					showCurrentDir();
				}
			}
			else if(e.KeyCode == Keys.Back)
			{

				e.Handled = true;
			}
		}

		private void showCurrentDir()
		{
			_txtCurrentDirName.Text = _dirDataImage.CurrentDir.name;
		}

		private void selectRowWithDir(IDir d)
		{
			int rowIndex = -1;

			DataGridViewRow row = _grid.Rows
				.Cast<DataGridViewRow>()
				.Where(r => (r.DataBoundItem as IDir).id == d.id)
				.First();

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
