using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatMeDid.BL;
using WhatMeDid.Tools;

/*
 * >>> 21-09-2020 11:16
 * 
 * По сути, работаем только с телом.
 * Но загружать надо сущность, так как будем потом расширять функционал, а не только текст менять.
 * 
 * 1. Отдаем View ссылку на сущность.
 * 2. Внутри View логика отображения сущности.
 * 2.1 Изменение текста фиксируется только отдельной командой сохранить.
 * 
 * >>> 07-11-2020 21:29
 * Нужен Централизованный единый банк идей, по всем проектам.
 * Т.е. создавать банк наименований проектов, и каждому банк заметок идей.
 * 
 * 
 */

namespace WhatMeDid.Presenters
{
	public class MainPresenter
	{
		ReportCollection reportCollection;
		TaskCollection taskCollection;

		Repository repo;

		IMainView _view;

		string dbfileReports = "report.json";
		string dbfileTasks = "task.json";

		string notes_dir = "notes";

		public MainPresenter(IMainView v)
		{
			_view = v;

			repo = new Repository();

			reportCollection = repo.LoadReports(dbfileReports);
			taskCollection = repo.LoadTasks(dbfileTasks);

			_view.SaveNotation += _view_SaveNotation;
			_view.DateChanged += _view_DateChanged;
			_view.NotationLevelChanged += _view_NotationLevelChanged;
			_view.CustomOperation += _view_CustomOperation;

			putNotation(_view.CurrentDate, _view.CurrentLevel);
		}

		private void _view_CustomOperation()
		{
			//taskCollection.ReindexAll();
			//DbAccess.SaveTasks(taskCollection, dbfileTasks);

			//reportCollection.ReindexAll();
			//DbAccess.SaveReports(reportCollection, dbfileReports);

			repo.TransformIntoPiecesReports(reportCollection, notes_dir);
			repo.TransformIntoPiecesTasks(taskCollection, notes_dir);
		}

		private void _view_NotationLevelChanged(NotationLevel obj)
		{
			putNotation(_view.CurrentDate, _view.CurrentLevel);
		}

		private void _view_DateChanged(DateTime obj)
		{
			putNotation(_view.CurrentDate, _view.CurrentLevel);
		}

		private void _view_SaveNotation(IDayNotation obj)
		{
			saveNotation(obj);
		}

		private void saveNotation(IDayNotation obj)
		{
			if (_view.CurrentLevel == NotationLevel.Task)
			{
				taskCollection.Accept(obj as DayTask);
				repo.SaveTasks(taskCollection, dbfileTasks);
			}
			else if (_view.CurrentLevel == NotationLevel.Report)
			{
				reportCollection.Accept(obj as DayReport);
				repo.SaveReports(reportCollection, dbfileReports);
			}
		}

		private void putNotation(DateTime dt, NotationLevel level)
		{
			if (level == NotationLevel.Task)
			{
				var t = taskCollection.GetOrCreate(dt);
				//Logger.Write($"{Serializer.ToString(t)}");
				_view.PutNotation(t);
			}
			else if(level == NotationLevel.Report)
			{
				var r = reportCollection.GetOrCreate(dt);
				//Logger.Write($"{Serializer.ToString(r)}");
				_view.PutNotation(r);
			}
		}
	}
}
