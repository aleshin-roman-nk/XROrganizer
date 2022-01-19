using Domain.Entities;
using Services.Sessions;
using SessionCollector.Views;
using Shared.UI;
using Shared.UI.Interfaces;
using System;
using xorg.Tools;

namespace SessionCollector
{
	public class SessionManagerMainPresenter
	{
		ISCMainView _view = null;
		Func<ISCMainView> _createMainViewFactory;
		IInputBox _dialogs;

		ISessionService _sessionService;

		Func<IStataView> _stataViewFactory;
		IStataView _stataView = null;

		public bool IsWindowRunning => _view != null;
		public void ShowWindow()
		{
			if(_view == null)
            {
				_view = _createMainViewFactory();

				_view.DateChanged += _view_DateChanged;
				_view.StartSession += _view_StartSession;
				_view.DeleteSession += _view_DeleteSession;
				_view.KickNextDay += _view_KickNextDay;
				_view.KickPrevDay += _view_KickPrevDay;
				_view.WindowClosed += _view_WindowClosed;
			}

			_view.ShowWindow();
		}

		public void ShowStataWindow(INode n)
        {
			if (n == null) return;

			if(_stataView == null)
            {
				_stataView = _stataViewFactory();

				_stataView.Completed += _stataView_Completed;
                _stataView.DateChanged += _stataView_DateChanged;

				_stataView.Go(n);
			}
		}

        private void _stataView_DateChanged(object sender, EventArgs e)
        {
			var i = _sessionService.GetStatistic(
				_stataView.CurrentDate.Year,
				_stataView.CurrentDate.Month,
				_stataView.Node);

			_stataView.Display(i, $"{_stataView.Node.path}{_stataView.Node.name}");
		}

        private void _stataView_Completed(object sender, EventArgs e)
        {
			_stataView.Completed += _stataView_Completed;
			_stataView.DateChanged += _stataView_DateChanged;

			_stataView = null;
		}

        public void CreateSession(FTask t)
		{
			OSession session = new OSession { Owner = t, NodeId = t.id};

			session.Start = _view.CurrentDateTime;
			session.ProvidedSeconds = 3600;

			_sessionService.Repo.Save(session);

			displaySessions(_view.CurrentDateTime);
		}

		public void SaveSession(OSession s)
        {
			_sessionService.Repo.Save(s);
			if(_view != null)
				displaySessions(_view.CurrentDateTime);
		}

		public event EventHandler<OSession> StartSession;

		public SessionManagerMainPresenter(
			Func<ISCMainView> SCMainViewFactory,
			Func<IStataView> stataViewFactiry,

			IInputBox dlg,
			ISessionService s)
		{
			_createMainViewFactory = SCMainViewFactory;
			_stataViewFactory = stataViewFactiry;
			_sessionService = s;
			_dialogs = dlg;
		}

		private void _view_WindowClosed(object sender, EventArgs e)
		{
			_view.DateChanged -= _view_DateChanged;
			_view.StartSession -= _view_StartSession;
			_view.DeleteSession -= _view_DeleteSession;
			_view.KickNextDay -= _view_KickNextDay;
			_view.KickPrevDay -= _view_KickPrevDay;
			_view.WindowClosed -= _view_WindowClosed;

			_view = null;
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

		private void _view_DeleteSession(object sender, OSession e)
		{
			if (_dialogs.UserAnsweredYes($"Session will be killed at all\n{e.Description}"))
			{
				_sessionService.Repo.Delete(e);
				displaySessions(_view.CurrentDateTime);
			}
		}

		private void _view_StartSession(object sender, OSession e)
		{
			StartSession?.Invoke(this, e);
		}

		private void displaySessions(DateTime d)
		{
			_sessionService.SetCollectionOfDate(d);

			_view.DisplaySessions(
				_sessionService.Items, 
				_sessionService.AllocatedHours,
				_sessionService.DoneWorkInSeconds,
				_sessionService.LastSessionFinish);
		}

		private void _view_DateChanged(object sender, DateTime e)
		{
			displaySessions(e);
		}
	}
}
