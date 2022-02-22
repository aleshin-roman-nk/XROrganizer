using Domain.Entities;
using Domain.Enums;
using Domain.Repos;
using Services.Nodes;
using SessionCollector;
using SessionCollector.Presenters;
using Shared.UI;
using Shared.UI.Dlg;
using Shared.UI.Forms;
using Shared.UI.Interfaces;
using Shared.UI.Interfaces.Enums;
using Shared.UI.Interfaces.EventArgsDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using TaskBank.Presenters.EventDefinition;
using TaskBank.Views;
using Unity;
using xorg.Tools;

namespace TaskBank.Presenters
{
	public class TaskBankMainPresenter
	{
		List<INode> _clipboard = new List<INode>();

		OpenObjectManager _openObjectManager;

		private readonly INodeService _service;
		private readonly IMainView _mainView;
		IDescriptionWindow _descView;

		IBufferTaskRepository _bufferTaskRepository;
		IBufferTaskView _currentTaskBufferView = null;

		ICompletedTasksView _completedTasksView = null;

		Func<IBufferTaskView> _bufferTaskViewFactory;
		Func<ICompletedTasksView> _completedTasksViewFactory;

		SessionManagerMainPresenter _sessionManagerMainPresenter = null;

		IInputBox _dialogs;
 
		public TaskBankMainPresenter(IMainView mainView, 
			IDescriptionWindow descriptionWindow,
			OpenObjectManager openObjManager,
			SessionManagerMainPresenter sessPres,
			IInputBox dlg, 
			INodeService srv,
			Func<ICompletedTasksView> CompletedTasksViewFactory,

			Func<IBufferTaskView> BufferTaskViewFactory,
			IBufferTaskRepository bufferTaskRepository
			)
		{
			_service = srv;
			_mainView = mainView;
			_descView = descriptionWindow;
			_dialogs = dlg;
			_openObjectManager = openObjManager;
			_sessionManagerMainPresenter = sessPres;
			_bufferTaskRepository = bufferTaskRepository;
			_bufferTaskViewFactory = BufferTaskViewFactory;
			_completedTasksViewFactory = CompletedTasksViewFactory;

			_mainView.NodesView.ActivateNode += _nodesView_ActivateNode;
			_mainView.NodesView.LeaveNode += _nodesView_LeaveNode;
			_mainView.NodesView.CurrentNodeChanged += NodesView_CurrentNodeChanged;
			_mainView.NodesView.Paste += NodesView_Paste;
			_mainView.StartDesriptionForm += _mainView_StartDesriptionForm;
			_mainView.StartCurrentBuffer += _mainView_StartCurrentBuffer;
			_mainView.StartSessionCollector += _mainView_StartSessionCollector;
			_mainView.StartWindowCompletedNodes += _mainView_StartWindowCompletedNodes;
			_mainView.CreateNode += _mainView_CreateNode;
			_mainView.RenameNode += _mainView_RenameNode;
			_mainView.DeleteNode += _mainView_DeleteNode;
			_mainView.NodesView.SendNodesToClipboard += NodesView_SendNodesToClipboard;
			_mainView.CreateSession += _mainView_CreateSession;
            _mainView.RestoreWorkingSessionWindow += _mainView_RestoreWorkingSessionWindow;
            _mainView.PutTaskToBuffer += _mainView_PutTaskToBuffer;
            _mainView.StartStatisticWindow += _mainView_StartStatisticWindow;
            _mainView.ApplicationClosing += _mainView_ApplicationClosing;
            _mainView.WorkingSessionPlayStateChanged += _mainView_WorkingSessionPlayStateChanged;
            _mainView.OpenNode += _mainView_OpenNode;

			_descView.Save += DescView_Save;

			_service.CollectionChanged += _service_CollectionChanged;

			_openObjectManager.SaveNode += _openObjectManager_SaveTask;
            _openObjectManager.SaveSession += _openObjectManager_SaveSession;
            _openObjectManager.OpenTasksCountChanged += _openObjectManager_OpenTasksCountChanged;
            _openObjectManager.WorkingSessionWindowOpen += _openObjectManager_WorkingSessionWindowOpen;
            _openObjectManager.WorkingSessionWindowCompleted += _openObjectManager_WorkingSessionWindowCompleted;
            _openObjectManager.WorkingSessionPlayStateChanged += _openObjectManager_WorkingSessionPlayStateChanged;
			_openObjectManager.SessionsRequired += _openObjectManager_SessionsRequired;
            _openObjectManager.CreateSession += _openObjectManager_CreateSession;
            _openObjectManager.FTaskRequired += _openObjectManager_FTaskRequired;

			_sessionManagerMainPresenter.StartSession += _sessionManagerMainPresenter_StartSession;
           
			update();
		}

        private void _mainView_OpenNode(object sender, EventArgs e)
        {
			var n = _mainView.NodesView.SelectedNodes.FirstOrDefault();
			if (n == null) return;
			if (n.type < NType.Dir) return;

			_openObjectManager.DefaultOpenNode(n);
		}

        private void _mainView_WorkingSessionPlayStateChanged(object sender, WorkingSessionPlayState e)
        {
			_openObjectManager.SetWorkingSessionPlayState(e);
		}

        private void _openObjectManager_WorkingSessionPlayStateChanged(object sender, WorkingSessionPlayState e)
        {
			_mainView.SessionWorkingState = e;

		}

        private void _openObjectManager_WorkingSessionWindowCompleted(object sender, EventArgs e)
        {
			_mainView.SessionState = false;
		}

        private void _openObjectManager_WorkingSessionWindowOpen(object sender, EventArgs e)
        {
			_mainView.SessionState = true;
        }

        private void _openObjectManager_FTaskRequired(object sender, RequestFTaskOpenObjectManagerEventArgs e)
        {
			var res = _service.GetNode(e.taskId);

			if(res == null)
            {
				e.NodeExists = false;
            }
            else
            {
				e.NodeExists = true;
				e.Node = res as Node;
            }
        }

        private void _mainView_ApplicationClosing(object sender, ApplicationClosingEventArgs e)
        {
			e.AnyWorkingWindows = _openObjectManager.AnyWorkingWindow;
        }

        private void _openObjectManager_CreateSession(object sender, INode e)
        {
			_createSession(e);
		}

        private void _openObjectManager_SessionsRequired(object sender, RequestSessionsPageOpenObjectManagerEvenArgs e)
        {
			e.Sessions = _service.GetTopSessions(e.Date, e.taskId, e.itemsPerPage, e.page);
        }

        private void _mainView_StartStatisticWindow(object sender, EventArgs e)
        {
			_sessionManagerMainPresenter.ShowStataWindow(
				_mainView.NodesView.SelectedNodes.SingleOrDefault()
				);
		}

        private void _mainView_PutTaskToBuffer(object sender, EventArgs e)
        {
            var i = _mainView.NodesView.SelectedNodes.SingleOrDefault();

            if (i != null)
            {
				if (_bufferTaskRepository.Exists(i.id))
					_dialogs.ShowMessage($"Task [{i.path}{i.id}] already exists in the buffer");
				else
					_bufferTaskRepository.Create(i.id);
            }

            //if (dlgCurrentTaskBuffer != null)
            _currentTaskBufferView?.Update(_bufferTaskRepository.GetAll());
        }

        private void _mainView_RestoreWorkingSessionWindow(object sender, EventArgs e)
        {
			_openObjectManager.TryRestoreSessionWindow();

		}

        private void _sessionManagerMainPresenter_StartSession(object sender, OSession e)
        {
			_openObjectManager.OpenSession(e);

		}

        private void _openObjectManager_OpenTasksCountChanged(object sender, int e)
        {
			_mainView.OpenedTasksCout = e;
		}

        private void _openObjectManager_SaveSession(object sender, OSession e)
        {
			_sessionManagerMainPresenter.SaveSession(e);
		}

        private void _openObjectManager_SaveTask(object sender, SaveNodeEventArgs e)
        {
			e.IsNodeSaved = _service.Save(e.Node) > 0;

            if (_completedTasksView != null)
                _completedTasksView.Display(
                    _service.GetCompletedTasks(
                        _completedTasksView.CurrentDate.Year,
                        _completedTasksView.CurrentDate.Month));

            update();
        }

        private void _mainView_CreateSession(object sender, EventArgs e)
		{
			_createSession(_mainView.NodesView.SelectedNodes.SingleOrDefault());
		}

        private void _createSession(INode n)
        {
            if (_sessionManagerMainPresenter.IsWindowRunning)
            {
                if (n != null)
                {
                    //if (n is FTask)
                    if (n.type >= NType.Dir)
                    {
                        //_sessionManagerMainPresenter.CreateSession((FTask)n);
                        _sessionManagerMainPresenter.CreateSession((Node)n);
                    }
                }
            }
        }

        private void NodesView_Paste(object sender, EventArgs e)
		{
			_service.MoveNodesToDirectory(_service.CurrentOwner as Dir, _clipboard);

			_clipboard.Clear();
			_mainView.ClipboardNodesCount = _clipboard.Count();
		}

		private void NodesView_SendNodesToClipboard(object sender, IEnumerable<INode> e)
		{
			_clipboard.Clear();
			_clipboard.AddRange(e);

			_mainView.ClipboardNodesCount = _clipboard.Count();
		}

		private void _mainView_StartWindowCompletedNodes(object sender, EventArgs e)
		{
			if (_completedTasksView != null) return;

			_completedTasksView = _completedTasksViewFactory();
            _completedTasksView.DateChanged += _completedTasksView_DateChanged;
            _completedTasksView.OpenNode += _completedTasksView_OpenNode;
            _completedTasksView.Completed += _completedTasksView_Completed;

			var d = DateTime.Now;
			_completedTasksView.Display(_service.GetCompletedTasks(d.Year, d.Month));
		}

        private void _completedTasksView_Completed(object sender, EventArgs e)
        {
			_completedTasksView.DateChanged -= _completedTasksView_DateChanged;
			_completedTasksView.OpenNode -= _completedTasksView_OpenNode;
			_completedTasksView.Completed -= _completedTasksView_Completed;

			_completedTasksView = null;
		}

        private void _completedTasksView_OpenNode(object sender, INode e)
        {
			_openObjectManager.OpenTask(e as FTask);
        }

        private void _completedTasksView_DateChanged(object sender, DateTime e)
        {
			_completedTasksView.Display(_service.GetCompletedTasks(e.Year, e.Month));
		}

        private void _mainView_StartSessionCollector(object sender, EventArgs e)
		{
			_sessionManagerMainPresenter.ShowWindow();
		}

		private void _mainView_StartCurrentBuffer(object sender, EventArgs e)
		{
			if (_currentTaskBufferView != null) return;

			_currentTaskBufferView = _bufferTaskViewFactory();
            _currentTaskBufferView.Completed += _currentTaskBufferView_Completed;
            _currentTaskBufferView.CreateSession += _currentTaskBufferView_CreateSession;
            _currentTaskBufferView.Delete += _currentTaskBufferView_Delete;
			_currentTaskBufferView.Go(_bufferTaskRepository.GetAll());
		}

        private void _currentTaskBufferView_Delete(object sender, BufferTask e)
        {
			_bufferTaskRepository.Delete(e.id);
			_currentTaskBufferView.Update(_bufferTaskRepository.GetAll());
		}

        private void _currentTaskBufferView_CreateSession(object sender, INode e)
        {
			_createSession(e);
		}

        private void _currentTaskBufferView_Completed(object sender, EventArgs e)
        {
			_currentTaskBufferView.Completed -= _currentTaskBufferView_Completed;
			_currentTaskBufferView.CreateSession -= _currentTaskBufferView_CreateSession;
			_currentTaskBufferView.Delete -= _currentTaskBufferView_Delete;
			_currentTaskBufferView = null;
		}

        private void _mainView_DeleteNode(object sender, EventArgs e)
		{
			var i = _mainView.NodesView.SelectedNodes.FirstOrDefault();
			if (i.type < 0) return;

            if (_service.HasChildren(i))
            {
                _dialogs.ShowMessage($"[{i.path}] has CHILD NODES and could not be deleted.");
                return;
            }

            if (_service.HasSessions(i))
            {
                _dialogs.ShowMessage($"[{i.path}] has SESSIONS and could not be deleted.");
                return;
            }

            if (_dialogs.UserAnsweredYes($"Are you sure to kill {i.name} / {i.text}"))
			{
				_service.Delete(i);
				update();
			}
		}

		private void _mainView_RenameNode(object sender, EventArgs e)
		{
			var i = _mainView.NodesView.SelectedNodes.FirstOrDefault();
			if (i.type < 0) return;

			var new_name = _dialogs.Show("Rename", i.name);

			if (string.IsNullOrEmpty( new_name) == false)
			{
				i.name = new_name;

				_service.Save(i);
				update();
			}
		}

		private void _mainView_CreateNode(object sender, EventArgs e)
		{
			var res = _dialogs.ChooseNType(new List<NType> { NType.Note, NType.Task, NType.Dir });

			if (res.Ok)
			{
				INode n = null;

				switch (res.Data)
				{
					case NType.Dir:
						var str = _dialogs.Show("Enter dir name");
						if (!string.IsNullOrEmpty(str))
							n = new Dir { name = str };
						break;
					case NType.Task:
						n = new FTask();
						break;
					case NType.Note:
						n = new FNote();
						break;
					default:
						break;
				}

				if(n != null)
				{
					n.date = DateTime.Now;
					var node = _service.Create(n);
					update();
					_mainView.NodesView.SetCursorAt(node);
				}
			}
		}

		private void _mainView_StartDesriptionForm(object sender, EventArgs e)
		{
			_descView.Put(_mainView.NodesView.SelectedNodes.FirstOrDefault());
			_descView.StickTo(_mainView);
			_descView.Display();
		}

		private void NodesView_CurrentNodeChanged(object sender, INode e)
		{
			_descView.Put(e);
		}

		private void DescView_Save(object sender, INode e)
		{
			if (e.type >= 0)
            {
                if (_openObjectManager.IsOpened(e.id))
                {
					_dialogs.ShowMessage($"[{e.path}] has already opened");
					return;
                }
				_service.Save(e);
            }
		}

		private void _service_CollectionChanged(object sender, EventArgs e)
		{
			update();
		}

		private void update()
		{
			_mainView.NodesView.DisplayNodes(
				_service.Items.Where(x => 
				{
					if (x is FTask) return !(x as FTask).IsCompleted; else return true;
				}).ToList(), 
				_service.CurrentParentFullName, 
				_service.HighlightedNode);
		}

		private void _nodesView_LeaveNode(object sender, EventArgs e)
		{
			_service.JumpBack();
		}

		private void _nodesView_ActivateNode(object sender, INode e)
		{
			if (e.type == NType.Dir || e.type == NType.exit_dir)
			{
				_service.Enter(e);
			}
			else if(e.type == NType.Task)
			{
				_openObjectManager.OpenTask(e as FTask);
			}
            else
            {
				_openObjectManager.DefaultOpenNode(e);
			}
		}
	}
}
