using Domain.Entities;
using Domain.Tools;
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

namespace CommonUIComponents.ViewComponents 
{

	/// <summary>
	/// 
	/// 
	/// Вход:
	/// Коллекция файлов (показать).
	/// 
	/// Выход:
	/// События:
	/// + Сохранить файл;
	/// + Положить коллекцию файлов в буффер;
	/// + Вставить файлы из буффера;
	/// Свойства:
	/// Текущий выбранный файл.
	/// 
	/// Внутренние функции:
	/// Отслеживание изменений в тексте текущего файла. Вывод отметки, если изменения не зафиксированны.
	/// 
	/// </summary>
	internal class FilesCollectionController
	{
		DataGridView _grid;
		RichTextBox _taskBody;

		SavingObserver savingObserver;
		BindingSource bs;

		public INode Current => bs.Current as INode;
		INode _previousFile { get; set; }

		public event EventHandler<INode> SaveTaskNeeded;
		public event EventHandler<IEnumerable<INode>> PutNodesToClipboard;
		public event EventHandler Paste;

		public FilesCollectionController(DataGridView task_grid, Control saveIndicator, RichTextBox taskBody)
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
			//if (e.KeyCode == Keys.F6)
			if (e.Control && e.KeyCode == Keys.X)
			{
				PutNodesToClipboard?.Invoke(this, _getSelectedTasks());
				e.Handled = true;
				//bs.ResetBindings(false);
			}
			else if(e.Control && e.KeyCode == Keys.V)
			{
				Paste?.Invoke(this, EventArgs.Empty);
				e.Handled = true;
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
			_commitAndSave(_previousFile);
			_put(Current);
			_previousFile = Current;
		}

		private void _commitAndSave(INode task)
		{
			if (!savingObserver.Saved)
			{
				task.description = _taskBody.Text;
				if (SaveTaskNeeded == null) throw new ArgumentNullException("SaveTaskNeeded must be subscribed but it is not.");
				SaveTaskNeeded.Invoke(this, task);// спросить ответ что действительно сохранено.
				savingObserver.Saved = true;
				_grid.Refresh();
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

		INodeTypeCustomizer nodeTypeCustomizer;

		public void SetCustomizer(INodeTypeCustomizer customizer)
		{
			nodeTypeCustomizer = customizer;
		}

		private void CusromizeGrid()
		{
			if (nodeTypeCustomizer == null) return;

			//кастомизировать сетку grid
		}

		public void DisplayFiles(IEnumerable<INode> tcollection)
		{
			_put(null);
			savingObserver.Saved = true;
			bs.DataSource = null;
			bs.DataSource = tcollection;
			_previousFile = Current;
		}
		private class SavingObserver
		{
			bool _savedValue = false;

			public Control Indicator { get; set; }
			public bool Saved
			{
				get
				{
					return _savedValue;
				}
				set
				{
					_savedValue = value;

					if (_savedValue)
					{
						Indicator.BackColor = Color.Green;
						Indicator.Text = "[OK]";
					}
					else
					{
						Indicator.BackColor = Color.Red;
						Indicator.Text = "[X]";
					}
				}
			}
		}
	}
}
