using Domain.Entities;
using System;

namespace TaskBank.Presenters
{

	/*
	 * Перенос вложенности. Переносить можем что угодно.
	 * Буфер должен хранится здесь.
	 * 
	 */
	public class Hub
	{
		Dir _current;

		public event EventHandler CurrentDirectoryChanged;
		//public event EventHandler DirectoryRepositoryChanged;

		public Dir Current => _current;
		public string CurrentDirPath { get; set; }
		public void ChangeCurrent(Dir o)
		{
			_current = o;
			OnCurrentChanged();
		}

		private void OnCurrentChanged()
		{
			CurrentDirectoryChanged?.Invoke(this, EventArgs.Empty);
		}
	}
}
