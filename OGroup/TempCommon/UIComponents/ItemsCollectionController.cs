using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * GOAL:
 *	Перемещение по элементам коллекции
 *	Отслеживание изменений в текущем элементе коллекции
 *	Оповещение, что нужно сохранить текущий элемент.
 *	Доступ к текущему элементу.
 * 
 * 
 */

namespace UIComponents.ViewComponents 
{

	/// <summary>
	/// 1. Отображение коллекции в гриде.
	/// 2. Вывод текста текущего элемента грида в текстовом поле
	/// 3. Отслеживание изменения текста текущего элемента. Установка состояния сохраненности.
	/// 4. Если текущий элемент изменен, при смене текущего элемента автоматически сохранить.
	/// </summary>
	public class ItemsCollectionController
	{
		DataGridView _grid;
		RichTextBox _taskBody;

		SavingObserver savingObserver;
		BindingSource bs;

		public INode Current => bs.Current as INode;
		INode _previousTask { get; set; }

		public event EventHandler<INode> SaveTaskNeeded;
		public event EventHandler<IEnumerable<INode>> MoveTaskCollection;

		public ItemsCollectionController(DataGridView task_grid, Control saveIndicator, RichTextBox taskBody)
		{
			_grid = task_grid;
			_taskBody = taskBody;

			bs = new BindingSource();
			bs.CurrentItemChanged += Bs_CurrentItemChanged;

			_grid.KeyDown += _grid_KeyDown;
			_grid.DataSource = bs;

			_taskBody.TextChanged += _taskBody_TextChanged;
			_taskBody.KeyDown += _taskBody_KeyDown;

			savingObserver = new SavingObserver();
			savingObserver.Indicator = saveIndicator;
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

		private void _taskBody_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.S)
			{
				_commitAndSave(Current);
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
			_put(Current);
			_previousTask = Current;
		}

		private void _commitAndSave(INode task)
		{
			if (!savingObserver.Saved)
			{
				task.description = _taskBody.Text;
				if (SaveTaskNeeded == null) throw new ArgumentNullException("SaveTaskNeeded must be subscribed but it is not.");
				SaveTaskNeeded.Invoke(this, task);// спросить ответ что действительно сохранено.
				savingObserver.Saved = true;
			}
		}

		public void CommitAndSave()
		{
			if (Current != null)
				_commitAndSave(Current);
		}

		private void _put(INode task)
		{
			if (task == null) _taskBody.Clear();
			else
				_taskBody.Text = task.description;
			savingObserver.Saved = true;
		}

		private IEnumerable<INode> _getSelectedTasks()
		{
			return _grid.SelectedRows.Cast<DataGridViewRow>().Select(x => x.DataBoundItem as INode);
		}

		public void DisplayFiles(IEnumerable<INode> tcollection)
		{
			_put(null);
			savingObserver.Saved = true;
			bs.DataSource = tcollection;
			_previousTask = Current;
		}
	}
}
