using Domain.Entities;
using Shared.UI.Interfaces;
using Shared.UI.Interfaces.EventArgsDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using TaskBank.Presenters.EventDefinition;

namespace TaskBank.Presenters
{
	public class OpenObjectManager
	{
		List<IFTaskEditView> _openedTasks = new List<IFTaskEditView>();
		ISingleSessionView _openedSession = null;
		ITopSessionsOfTaskView _topSessions = null;

		Func<IFTaskEditView> _FTaskWindowfactory;
		Func<ISingleSessionView> _sessionWindowFactory;
		Func<ITopSessionsOfTaskView> _topSessionsFactory;

		public event EventHandler<SaveNodeEventArgs> SaveTask;
		public event EventHandler<OSession> SaveSession;
		public event EventHandler<int> OpenTasksCountChanged;
		public event EventHandler<bool> WorkingSessionStateChanged;
		public event EventHandler<RequestSessionsPageOpenObjectManagerEvenArgs> SessionsRequired;
		public event EventHandler<RequestFTaskOpenObjectManagerEventArgs> FTaskRequired;
		public event EventHandler<INode> CreateSession;

		public bool IsOpened(int inodeId)
        {
			return _openedTasks.Any(x => x.ObjId == inodeId);
		}

		public bool AnyWorkingWindow
		{
			get
			{
				return _openedTasks.Count > 0 || _openedSession != null;
			}
		}

		public OpenObjectManager(
			Func<IFTaskEditView> FTaskWindowfactory, 
			Func<ISingleSessionView> sessionWindowFactory,
			Func<ITopSessionsOfTaskView> topSessionsFactory)
        {
			_sessionWindowFactory = sessionWindowFactory;
			_FTaskWindowfactory = FTaskWindowfactory;
			_topSessionsFactory = topSessionsFactory;
		}

		public void TryRestoreSessionWindow()
        {
			if (_openedSession == null) return;

			_openedSession.Restore();
		}

		public void OpenSession(OSession s)
		{
			if (_openedSession == null)
			{
				_openedSession = _sessionWindowFactory();
				_openedSession.Completed += _openedSession_Completed;
				_openedSession.Save += _openedSession_Save;
				_openedSession.OpenOwner += _openedSession_OpenOwner;
				WorkingSessionStateChanged?.Invoke(this, true);
				_openedSession.Go(s);
			}
			else
				_openedSession.Restore();
		}

        private void _openedSession_OpenOwner(object sender, Node e)
        {
			OpenTask(e as FTask);
		}

        private void _openedSession_Save(object sender, OSession e)
        {
			SaveSession?.Invoke(this, e);
		}

        private void _openedSession_Completed(object sender, EventArgs e)
        {
			var frm = sender as ISingleSessionView;

			frm.Completed -= _openedSession_Completed;
			frm.Save -= _openedSession_Save;
			frm.OpenOwner -= _openedSession_OpenOwner;
			WorkingSessionStateChanged?.Invoke(this, false);

			_openedSession = null;
		}

        public void OpenTask(FTask t)
		{
			var op = _openedTasks.SingleOrDefault(x => x.ObjId == t.id);

			if (op != null)
			{
				op.Restore();
			}
			else
			{
				createView(t);
			}
		}

		private void createView(FTask t)
		{
			var frm = _FTaskWindowfactory();

            frm.Save += Frm_Save;
            frm.Completed += Frm_Completed;
            frm.ShowTopSessions += Frm_ShowTopSessions;
            frm.CreateSession += Frm_CreateSession;
            frm.OpenNodeById += Frm_OpenNodeById;

			_openedTasks.Add(frm);
			OpenTasksCountChanged?.Invoke(this, _openedTasks.Count);

			frm.Go(t);
		}

        private void Frm_OpenNodeById(object sender, int e)
        {
			var args = new RequestFTaskOpenObjectManagerEventArgs(e);

			FTaskRequired?.Invoke(this, args);

            if (args.NodeExists)
            {
				OpenTask(args.Node as FTask);
			}
		}

        private void Frm_CreateSession(object sender, INode e)
        {
            CreateSession?.Invoke(this, e);
        }

        private void Frm_ShowTopSessions(object sender, DisplaySessionsPageEventArg e)
        {
			if (_topSessions == null)
            {
				_topSessions = _topSessionsFactory();
                _topSessions.Completed += _topSessions_Completed;
                _topSessions.PageChanged += _topSessions_PageChanged;
			}

			_topSessions.Go(e.fullPath, e.Date, e.taskId);
		}

        private void _topSessions_PageChanged(object sender, SessionsPageRequiredEventArgs e)
        {
			var req = new RequestSessionsPageOpenObjectManagerEvenArgs(
				e.page,
				e.itemsPerPage,
				e.date,
				e.taskId);

			SessionsRequired?.Invoke(this, req);
			if (req.Sessions == null) return;

			_topSessions.Display(req.Sessions);
		}

        private void _topSessions_Completed(object sender, EventArgs e)
        {
			_topSessions.Completed -= _topSessions_Completed;
			_topSessions.PageChanged -= _topSessions_PageChanged;
			_topSessions = null;
		}

        private void Frm_Completed(object sender, EventArgs e)
        {
			var sender_frm = sender as IFTaskEditView;
			var frm = _openedTasks.SingleOrDefault(x => x.ObjId == sender_frm.ObjId);

			if(frm != null)
            {
				frm.Save -= Frm_Save;
				frm.Completed -= Frm_Completed;
				frm.ShowTopSessions -= Frm_ShowTopSessions;
				frm.CreateSession -= Frm_CreateSession;
				frm.OpenNodeById -= Frm_OpenNodeById;

				_openedTasks.Remove(frm);
				OpenTasksCountChanged?.Invoke(this, _openedTasks.Count);
			}
		}

        private void Frm_Save(object sender, SaveNodeEventArgs e)
        {
			SaveTask?.Invoke(this, e);
		}
    }
}
