using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBank.BL.Entities;

/*
 * GOAL:
 *	Перемещение по элементам коллекции
 *	Отслеживание изменений в текущем элементе коллекции
 *	Оповещение, что нужно сохранить текущий элемент.
 *	Доступ к текущему элементу.
 * 
 * 
 */

namespace TaskBank.ViewModules
{
	public class TaskCollectionView
	{
		DataGridView _grid;
		RichTextBox _taskBody;

		SavingObserver savingObserver;
		BindingSource bs;

		public OTask CurrentTask => bs.Current as OTask;
		OTask _previousTask { get; set; }

		public event EventHandler<OTask> SaveTaskNeeded;
		public event EventHandler<IEnumerable<OTask>> MoveTaskCollection;

		public TaskCollectionView(DataGridView task_grid, Control saveIndicator, RichTextBox taskBody)
		{
			_grid = task_grid;
			_taskBody = taskBody;

			bs = new BindingSource();
			bs.CurrentItemChanged += Bs_CurrentItemChanged;
			
			_grid.CellFormatting += _grid_CellFormatting;
			_grid.KeyDown += _grid_KeyDown;
			_grid.DataSource = bs;

			_taskBody.TextChanged += _taskBody_TextChanged;
			_taskBody.KeyDown += _taskBody_KeyDown;

			savingObserver = new SavingObserver();
			savingObserver.Indicator = saveIndicator;

			_buildColumns();
		}

		private void _buildColumns()
		{
			_grid.AutoGenerateColumns = false;

			DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn
			{
				Width = 40,
				HeaderText = "#",
				DataPropertyName = "Id",
				Name = "Id"
			};

			DataGridViewTextBoxColumn cMarker = new DataGridViewTextBoxColumn
			{
				Width = 30,
				HeaderText = "!",
				Name = "Imp"
			};

			DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn
			{
				Width = 800,
				HeaderText = "Задачи",
				DataPropertyName = "MiniText",
				//DataPropertyName = "Text",
				Name = "Text"
			};

			DataGridViewTextBoxColumn c3 = new DataGridViewTextBoxColumn
			{
				Width = 80,
				HeaderText = "Дир",
				DataPropertyName = "DirectoryId",
				Name = "DirId"
			};

			_grid.Columns.Add(c1);
			_grid.Columns.Add(cMarker);
			_grid.Columns.Add(c2);
			_grid.Columns.Add(c3);
			_grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			_grid.Columns["Text"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
		}

		private void _grid_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F6)
			{
				MoveTaskCollection?.Invoke(this, _getSelectedTasks());
				e.Handled = true;
				bs.ResetBindings(false);
			}
		}

		private void _grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			var row = _grid.Rows[e.RowIndex];
			row.Cells["Imp"].Style.BackColor = imp_to_color((row.DataBoundItem as OTask).Imp);
			row.Cells["Imp"].Style.SelectionBackColor = imp_to_color((row.DataBoundItem as OTask).Imp);

			//row.Cells["Imp"].Value = "=>";// работает. для указания, что этот период сейчас текущий по времени
		}

		// In module
		private Color imp_to_color(ImportanceLevel imp)
		{
			if (imp == ImportanceLevel.Total) return Color.Red;
			else if (imp == ImportanceLevel.Middle) return Color.BlueViolet;
			else if (imp == ImportanceLevel.Low) return Color.Green;

			return Color.LightGreen;
		}

		private void _taskBody_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.S)
			{
				_commitAndSave(CurrentTask);
				e.Handled = true;
			}
		}

		private void _taskBody_TextChanged(object sender, EventArgs e)
		{
			savingObserver.Saved = false;
		}

		private void Bs_CurrentItemChanged(object sender, EventArgs e)
		{
			_commitAndSave(_previousTask);
			_put(CurrentTask);
			_previousTask = CurrentTask;
		}

		private void _commitAndSave(OTask task)
		{
			if (!savingObserver.Saved)
			{
				task.Text = _taskBody.Text;
				if (SaveTaskNeeded == null) throw new ArgumentNullException("SaveTaskNeeded must be subscribed but it is not.");
				SaveTaskNeeded.Invoke(this, task);// спросить ответ что действительно сохранено.
				savingObserver.Saved = true;
			}
		}

		public void CommitAndSave()
		{
			if (CurrentTask != null)
				_commitAndSave(CurrentTask);
		}

		private void _put(OTask task)
		{
			_taskBody.Text = task.Text;
			savingObserver.Saved = true;
		}

		private IEnumerable<OTask> _getSelectedTasks()
		{
			//List<RmTask> res = new List<RmTask>();

			return _grid.SelectedRows.Cast<DataGridViewRow>().Select(x=>x.DataBoundItem as OTask);

			//foreach (DataGridViewRow item in _grid.SelectedRows)
			//{
			//	item.DataBoundItem as RmTask
			//}
		}

		public void DisplayTaskCollection(IEnumerable<OTask> tcollection)
		{
			savingObserver.Saved = true;
			bs.DataSource = tcollection;
			_previousTask = CurrentTask;
		}
	}
}
