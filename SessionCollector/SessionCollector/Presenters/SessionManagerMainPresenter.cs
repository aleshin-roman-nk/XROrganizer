using Domain.Entities;
using Services.Sessions;
using SessionCollector.Views;
using Shared.UI;
using System;
using xorg.Tools;

namespace SessionCollector
{
	/// <summary>
	/// 1. Загружает список сессий на выбранную дату.
	/// 2. Создает сессию.
	/// 3. Открывает сессию в окне сессий.
	/// 4. Сохраняет сессию, если нажато сохранить.
	/// 5. Запрещает открытие другой сессии.
	/// </summary>
	public class SessionManagerMainPresenter
	{
		ISCMainView _view;
		ISingleSessionView _sessionview;
		IStataView _stataView;

		ISessionService _sessionService;
		//ISingleSessionTicker _singleSessionTicker;

		public ISCMainView MainView => _view;

		private bool _IsRunning;
		public bool IsRunning => _IsRunning;
		public void Go()
		{
			_view.ShowWindow();
		}

		public void CreateSession(FTask t)
		{
			OSession session = new OSession { Owner = t, NodeId = t.id};

			session.Start = _view.CurrentDateTime;
			session.ProvidedSeconds = 3600;

			_sessionService.Repo.Save(session);

			displaySessions(_view.CurrentDateTime);
		}

		public void CloseApplication()
		{
			//if (_singleSessionTicker.IsRunning)
			//{
			//	_sessionService.Repo.Save(_singleSessionTicker.CollectTotalSecondsAndStop());
			//}
		}

		public SessionManagerMainPresenter(
			ISCMainView v, 
			ISingleSessionView sess_view,
			IStataView sts, 
			ISessionService s)
		{			
			_view = v;
			_sessionview = sess_view;
			_sessionService = s;
			_stataView = sts;

			_view.CreateSession += _view_CreateSession;
			_view.DateChanged += _view_DateChanged;
			_view.OrderAndAlign += _view_OrderAndAlign;
			_view.StartSession += _view_StartSession;
			_view.DeleteSession += _view_DeleteSession;
			_view.StartSessionTick += _view_StartSessionTick;
			_view.ShowStata += _view_ShowStata;
			_view.KickNextDay += _view_KickNextDay;
			_view.KickPrevDay += _view_KickPrevDay;
			_view.WindowClosed += _view_WindowClosed;

			//_singleSessionTicker.WatchingFinishedAndSaveSecondsRequired += _singleSessionTicker_WatchingFinishedAndSaveRequired;
			//_singleSessionTicker.WatchingStoppedWithoutSave += _singleSessionTicker_WatchingStoppedWithoutSave;

			_sessionview.ChangeDirectory += _sessionview_ChangeDirectory;
			_sessionview.WorkCompleted += _sessionview_WorkCompleted;
			_sessionview.SaveRequired += _sessionview_SaveRequired;

			_IsRunning = true;
		}

		private void _view_WindowClosed(object sender, EventArgs e)
		{
			_view.CreateSession -= _view_CreateSession;
			_view.DateChanged -= _view_DateChanged;
			_view.OrderAndAlign -= _view_OrderAndAlign;
			_view.StartSession -= _view_StartSession;
			_view.DeleteSession -= _view_DeleteSession;
			_view.StartSessionTick -= _view_StartSessionTick;
			_view.ShowStata -= _view_ShowStata;
			_view.KickNextDay -= _view_KickNextDay;
			_view.KickPrevDay -= _view_KickPrevDay;
			_view.WindowClosed -= _view_WindowClosed;

			_sessionview.ChangeDirectory -= _sessionview_ChangeDirectory;
			_sessionview.WorkCompleted -= _sessionview_WorkCompleted;
			_sessionview.SaveRequired -= _sessionview_SaveRequired;

			_IsRunning = false;
		}

		private void _view_KickPrevDay(object sender, OSession e)
		{
			if (e == null) return;
			_sessionService.KickSessionToPrevDay(e);
			displaySessions(_view.CurrentDateTime);
		}

		private void _view_KickNextDay(object sender, OSession e)
		{
			if (e == null) return;
			_sessionService.KickSessionToNextDay(e);
			displaySessions(_view.CurrentDateTime);
		}

		private void _sessionview_SaveRequired(object sender, OSession e)
		{
			_sessionService.Repo.Save(e);
			displaySessions(_view.CurrentDateTime);
		}

		private void _sessionview_WorkCompleted(object sender, ViewResponse<OSession> e)
		{
			if (e.Ok)
			{
				_sessionService.Repo.Save(e.Data);
				displaySessions(_view.CurrentDateTime);
			}
		}

		private void _singleSessionTicker_WatchingStoppedWithoutSave(object sender, EventArgs e)
		{
			displaySessions(_view.CurrentDateTime);
		}

		private void _view_ShowStata(object sender, DateTime e)
		{
			//// var res = hub.GetThing(HubCmdCode.GetOwnerForSession, null);

			//var res = _directorySelectorBoxPresenter.Go();

			//if (res.Ok)
			//{
			//	_stataView.Go(_sessionService.GetStatistic(e.Year, e.Month, res.Data), $"{e.ToString("MMMM, yyyy")} года");
			//}
		}

		/*
		 * >>> 21-10-2021 23:44
		 * А может передавать целиком объект (сылку на объект) передавать с указанием что изменить.
		 * Или поменять название события DirectoryIsRequested
		 * 
		 */
		private void _sessionview_ChangeDirectory(object sender, ViewRequest<OSession, INode> e)
		{
			//var res = _directorySelectorBoxPresenter.Go(e.Parameter.Owner);

			//e.Response = res;		
		}

		// 111. Обрабатываем результат
		// >>> 25-09-2021 02:20
		// Заменить на изменение состояние. Тогда можно оперативно изменять цвет состояния сессии.
		// >>> 25-09-2021 02:30
		// И если уйдем от коннектед сценарои к дисконнектед, тогда это состояние надо мапить в бд.
		//		и при загрузке приложения искать среди сессий в этом состоянии, автоматом открывать для нее счетчик.
		//	Либо при закрытии забывать и все. С автосохранением остатка времени.
		private void _singleSessionTicker_WatchingFinishedAndSaveRequired(object sender, int e)
		{
			////var ses = _singleSessionTicker.WatchedSession;
			////ses.TotalSeconds = _singleSessionTicker.TotalSeconds;// it is not necessary to do it. About it _singleSessionTicker has tooken care of this
			//_sessionService.Repo.Save(_singleSessionTicker.WatchedSession);
			//displaySessions(_view.CurrentDateTime);
		}

		// 111. Отправляем
		private void _view_StartSessionTick(object sender, OSession e)
		{
			//if (_singleSessionTicker.IsRunning)
			//{
			//	_view.ShowMessage("There is a session being already watched.");
			//	return;
			//}
			//_singleSessionTicker.StartWatching(e);
			//displaySessions(_view.CurrentDateTime);
		}

		private void _view_DeleteSession(object sender, OSession e)
		{
			if (_view.UserAnsweredYes($"Session will be killed at all\n{e.Description}"))
			{
				_sessionService.Repo.Delete(e);
				displaySessions(_view.CurrentDateTime);
			}
		}

		private void _view_StartSession(object sender, OSession e)
		{
			if (_sessionview.IsWorking)
			{
				_view.ShowMessage("There is a working session");
				return;
			}
			_sessionview.Go(e.Clone());
		}

		private void displaySessions(DateTime d)
		{
			//var items = _repoSessions.GetOfDay(d);
			////items = _sessionService.SortAndAlign(items);

			//var hrs = _sessionService.AllocatedHours(items);
			//var finish = _sessionService.LastSessionFinish(items);
			//var doneSeconds = _sessionService.DoneWorkInSeconds(items);

			_sessionService.SetCollectionOfDate(d);

			_view.DisplaySessions(
				_sessionService.Items, 
				_sessionService.AllocatedHours,
				_sessionService.DoneWorkInSeconds,
				_sessionService.LastSessionFinish);
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

		private void _view_CreateSession(object sender, DateTime e)
		{
			if (_sessionview.IsWorking)
			{
				_view.ShowMessage("There is a working session");
				return;
			}

			OSession session = new OSession();

			session.Start = e;
			session.ProvidedSeconds = 3600;

			_sessionview.Go(session);
		}
	}
}
