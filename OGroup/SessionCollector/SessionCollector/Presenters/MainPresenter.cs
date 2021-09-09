using mvp_base;
using SessionCollector.BL;
using SessionCollector.BL.Entities;
using SessionCollector.BL.Repo;
using SessionCollector.BL.Services;
using SessionCollector.Forms;
using SessionCollector.Tools;
using SessionCollector.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector
{
	public class MainPresenter
	{
		IMainView _view;
		ISessionView _sessionview;
		IStataView _stataView;

		IMainRepository _mainRepository;

		IDirectoriesView _directoryView;

		IService _services;
		SingleSessionTicker _singleSessionTicker;

		public IMainView MainView => _view;

		public MainPresenter(IMainView v, ISessionView sess_view, IMainRepository r, IDirectoriesView dir_view, IStataView sts, IService s)
		{
			/*
			 * Разные презентеры:
			 * + просмотр и редактирование сессии
			 * + просмотр статистики
			 * + навигация и выбор узла
			 * 
			 * Сообщение всех презентеров через хаб.
			 * 
			 * 
			 */

			_mainRepository = r;
			_view = v;
			_sessionview = sess_view;
			_directoryView = dir_view;
			_services = s;
			_stataView = sts;

			_view.CreateSession += _view_CreateSession;
			_view.SaveDayImage += _view_SaveDayImage;
			_view.DateChanged += _view_DateChanged;
			_view.OrderAndAlign += _view_OrderAndAlign;
			_view.EditSession += _view_EditSession;
			_view.DeleteSession += _view_DeleteSession;
			_view.StartSessionTick += _view_StartSessionTick;
			_view.ShowStata += _view_ShowStata;

			_singleSessionTicker = new SingleSessionTicker();
			_singleSessionTicker.WatchingFinishedAndSaveSecondsRequired += _singleSessionTicker_WatchingFinishedAndSaveRequired;
			//_view.DisplaySessions(_mainRepository.Sessions.Get());

			_directoryView.CreateDirectory += _directoryView_CreateDirectory;
			_directoryView.DeleteDirectory += _directoryView_DeleteDirectory;

			_sessionview.ChangeDirectory += _sessionview_ChangeDirectory;
		}

		private void _directoryView_DeleteDirectory(object sender, INode e)
		{
			_mainRepository.Nodes.Delete(e);
			_directoryView.DisplayNodes(_mainRepository.Nodes.Get());
		}

		private void _view_ShowStata(object sender, DateTime e)
		{
			_directoryView.DisplayNodes(_mainRepository.Nodes.Get());
			var res = _directoryView.Go();

			if (res.Ok)
			{
				_stataView.Go(_mainRepository.Sessions.GetStatistic(e.Year, e.Month, res.Result), $"{e.ToString("MMMM, yyyy")} года");
			}
		}

		private void _sessionview_ChangeDirectory(object sender, ViewResultParams<OSession, INode> e)
		{
			_directoryView.DisplayNodes(_mainRepository.Nodes.Get(), e.Param.Node);
			var res = _directoryView.Go();

			if (res.Ok)
			{
				e.Result = res.Result;
				e.Ok = true;
			}			
		}

		private void _directoryView_CreateDirectory(object sender, EventArgs e)
		{
			InputDataDialog inputData = new InputDataDialog();

			if(inputData.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				ODirectory d = new ODirectory { Name = inputData.InputText };

				_mainRepository.Nodes.Save(d);
				_directoryView.DisplayNodes(_mainRepository.Nodes.Get());
			}
		}

		// 111. Обрабатываем результат
		private void _singleSessionTicker_WatchingFinishedAndSaveRequired(object sender, int e)
		{
			var ses = _singleSessionTicker.WatchedSession;
			ses.TotalSeconds = _singleSessionTicker.TotalSeconds;
			_mainRepository.Sessions.Save(ses);
			displaySessions(_view.CurrentDateTime);
		}

		// 111. Отправляем
		private void _view_StartSessionTick(object sender, OSession e)
		{
			if (_singleSessionTicker.IsRunning)
			{
				_view.ShowMessage("There is a session being already watched.");
				return;
			}
			_singleSessionTicker.StartWatching(e);
		}

		private void _view_DeleteSession(object sender, OSession e)
		{
			if (_view.UserAnsweredYes($"Session will be killed at all\n{e.Description}"))
			{
				_mainRepository.Sessions.Delete(e);
				displaySessions(_view.CurrentDateTime);
			}
		}

		private void _view_EditSession(object sender, OSession e)
		{
			// Make clone
			var res = _sessionview.Go(e.Clone());// здесь образуется другой экземпляр объекта, которые не отслеживается

			if (res.Ok)
			{
				// if ok, copy to the source in database

				e.CopyFrom(res.Result);

				_mainRepository.Sessions.Save(e);

				displaySessions(_view.CurrentDateTime);
			}
		}

		private void displaySessions(DateTime d)
		{
			var items = _mainRepository.Sessions.GetByDay(d);
			items = _services.Sessions.SortAndAlign(items);

			var hrs = _services.Sessions.GetAllocatedHours(items);
			var finish = _services.Sessions.GetLastSessionFinish(items);
			var doneSeconds = _services.Sessions.GetDoneWorkInSeconds(items);

			_view.DisplaySessions(items, hrs, doneSeconds, finish);
		}

		private void _view_OrderAndAlign(object sender, DateTime e)
		{
			//var items = _mainRepository.Sessions.GetByDay(e);
			//items = _services.Sessions.SortAndAlign(items);
			//_view.DisplaySessions(items);

			displaySessions(e);
		}

		private void _view_DateChanged(object sender, DateTime e)
		{
			displaySessions(e);
		}

		private void _view_SaveDayImage(object sender, EventArgs e)
		{
			_mainRepository.Save();
		}

		private void _view_CreateSession(object sender, DateTime e)
		{
			OSession session = new OSession();

			session.Start = e;
			session.ReservedHours = 1.0m;

			var res = _sessionview.Go(session);

			if (res.Ok)
			{
				_mainRepository.Sessions.Save(res.Result);

				displaySessions(e);
			}
		}
	}
}
