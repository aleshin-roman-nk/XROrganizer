using Domain.dto;
using Domain.Entities;
using Domain.Enums;
using Shared.UI.Interfaces;
using Shared.UI.Interfaces.Enums;
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
		List<INodeDefaultView> _openedNodes = new List<INodeDefaultView>();

		ISingleSessionView _openedSession = null;
		ITopSessionsOfTaskView _topSessions = null;

		Func<IFTaskEditView> _FTaskWindowfactory;
		Func<INodeDefaultView> _DefaultWindowfactory;
		Func<ISingleSessionView> _sessionWindowFactory;
		Func<ITopSessionsOfTaskView> _topSessionsFactory;

		public event EventHandler<SaveNodeEventArgs> SaveNode;
		public event EventHandler<NodeTextPage> DeleteNodeTextPage;

		public event EventHandler<OSession> SaveSession;
		public event EventHandler<int> OpenTasksCountChanged;
		public event EventHandler WorkingSessionWindowOpen;
		public event EventHandler WorkingSessionWindowCompleted;
		public event EventHandler<WorkingSessionPlayState> WorkingSessionPlayStateChanged;
		public event EventHandler<GetSessionsEvenArgs> GetSessions;
		public event EventHandler<GetNodeEventArgs> GetNode;
		public event EventHandler<NodeDTO> CreateSession;

        public bool IsOpened(int inodeId)
        {
			return _openedTasks.Any(x => x.ObjId == inodeId);
		}

		public bool AnyWorkingWindow
		{
			get
			{
				return _openedTasks.Count > 0 || _openedSession != null || _openedNodes.Count > 0;
			}
		}

		public OpenObjectManager(
			Func<IFTaskEditView> FTaskWindowfactory, 
			Func<INodeDefaultView> DefaultWindowfactory, 
			Func<ISingleSessionView> sessionWindowFactory,
			Func<ITopSessionsOfTaskView> topSessionsFactory)
        {
			_sessionWindowFactory = sessionWindowFactory;
			_FTaskWindowfactory = FTaskWindowfactory;
			_topSessionsFactory = topSessionsFactory;
			_DefaultWindowfactory = DefaultWindowfactory;
        }

		public void TryRestoreSessionWindow()
        {
			if (_openedSession == null) return;

			_openedSession.Restore();
		}

		public void DefaultOpenNode(INode n)
        {
			var op = _openedNodes.SingleOrDefault(x => x.ObjId == n.id);

			if (op != null)
			{
				op.Restore();
			}
			else
			{
				createDefaultNodeView(n);
			}
		}

		private void createDefaultNodeView(INode n)
        {
			var frmDefaultNode = _DefaultWindowfactory();

            frmDefaultNode.Save += FrmDefaultNode_Save;
            frmDefaultNode.Completed += FrmDefaultWindow_Completed;
            frmDefaultNode.DeleteNodeTextPage += event_DeleteNodeTextPage;
			frmDefaultNode.OpenNodeById += Frm_OpenNodeById;

            _openedNodes.Add(frmDefaultNode);
			OpenTasksCountChanged?.Invoke(this, _openedTasks.Count + _openedNodes.Count);

			frmDefaultNode.Go(n);
		}

        private void event_DeleteNodeTextPage(object sender, NodeTextPage e)
        {
            DeleteNodeTextPage?.Invoke(this, e);
        }

        private void FrmDefaultNode_Save(object sender, SaveNodeEventArgs e)
        {
			OnSaveNode(e);
		}

        private void FrmDefaultWindow_Completed(object sender, EventArgs e)
        {
			var sender_frm = sender as INodeDefaultView;
			var frm = _openedNodes.SingleOrDefault(x => x.ObjId == sender_frm.ObjId);

			if (frm != null)
			{
				frm.Save -= FrmDefaultNode_Save;
				frm.Completed -= FrmDefaultWindow_Completed;
				frm.DeleteNodeTextPage -= event_DeleteNodeTextPage;
				frm.OpenNodeById -= Frm_OpenNodeById;

				_openedNodes.Remove(frm);
				OpenTasksCountChanged?.Invoke(this, _openedTasks.Count + _openedNodes.Count);
			}
		}

        public void OpenSession(OSession s)
		{
			if (_openedSession == null)
			{
				_openedSession = _sessionWindowFactory();
				_openedSession.Completed += _openedSession_Completed;
				_openedSession.Save += _openedSession_Save;
				_openedSession.OpenOwner += _openedSession_OpenOwner;
                _openedSession.SessionWindowWorkStateChanged += _openedSession_SessionWindowWorkStateChanged;
				WorkingSessionWindowOpen?.Invoke(this, EventArgs.Empty);
				_openedSession.Go(s);
			}
			else
				_openedSession.Restore();
		}

		public void SetWorkingSessionPlayState(WorkingSessionPlayState st)
        {
			if (_openedSession == null) return;

			_openedSession.SetWorkingSesionPlayState(st);
		}

        private void _openedSession_SessionWindowWorkStateChanged(object sender, WorkingSessionPlayState e)
        {
			WorkingSessionPlayStateChanged?.Invoke(this, e);
		}

        private void _openedSession_OpenOwner(object sender, Node e)
        {
			if(e.type == NType.Task) OpenTask(e as FTask);
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
			_openedSession.SessionWindowWorkStateChanged -= _openedSession_SessionWindowWorkStateChanged;
			WorkingSessionWindowCompleted?.Invoke(this, EventArgs.Empty);

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
			frm.DeleteNodeTextPage += event_DeleteNodeTextPage;

            _openedTasks.Add(frm);
			OpenTasksCountChanged?.Invoke(this, _openedTasks.Count + _openedNodes.Count);

			frm.Go(t);
		}

        private void Frm_OpenNodeById(object sender, int e)
        {
			var args = new GetNodeEventArgs(e);

			GetNode?.Invoke(this, args);

            if (args.NodeExists)
            {
				if(args.Node.type == NType.Task)
					OpenTask(args.Node as FTask);
				else
					DefaultOpenNode(args.Node);
			}
		}

		private void OnSaveNode(SaveNodeEventArgs n)
        {
			SaveNode?.Invoke(this, n);
		}

		private void Frm_CreateSession(object sender, NodeDTO e)
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
			var req = new GetSessionsEvenArgs(
				e.page,
				e.itemsPerPage,
				e.date,
				e.taskId);

			GetSessions?.Invoke(this, req);
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
				frm.DeleteNodeTextPage -= event_DeleteNodeTextPage;

                _openedTasks.Remove(frm);
				OpenTasksCountChanged?.Invoke(this, _openedTasks.Count);
			}
		}

        private void Frm_Save(object sender, SaveNodeEventArgs e)
        {
			OnSaveNode(e);
		}
    }
}
