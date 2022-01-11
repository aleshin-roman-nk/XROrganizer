using Domain.Entities;
using Domain.Enums;
using Domain.Repos;
using Services.Nodes;
using SessionCollector;
using Shared.UI;
using Shared.UI.Dlg;
using Shared.UI.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using TaskBank.Views;
using Unity;
using xorg.Tools;

namespace TaskBank.Presenters
{
	public class TaskBankMainPresenter
	{
		List<INode> _openedNodes = new List<INode>();
		List<INode> _clipboard = new List<INode>();


		IUnityContainer _ioc;

		private readonly INodeService _service;
		private readonly IMainView _mainView;
		IDescriptionWindow _descView;

		SessionManagerMainPresenter _sessionManagerMainPresenter = null;

		IInputBox _dialogs;
 
		public TaskBankMainPresenter(IMainView mainView, IDescriptionWindow descriptionWindow, IInputBox dlg, INodeService srv, IUnityContainer cont)
		{
			_service = srv;
			_mainView = mainView;
			_descView = descriptionWindow;
			_dialogs = dlg;

			_ioc = cont;

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

			descriptionWindow.Save += DescView_Save;

			_service.CollectionChanged += _service_CollectionChanged;

			update();
		}

		private void _mainView_CreateSession(object sender, EventArgs e)
		{
			if(_sessionManagerMainPresenter != null)
			{
				if(_sessionManagerMainPresenter.IsRunning)
				{
					var i = _mainView.NodesView.SelectedNodes.SingleOrDefault();
					if(i != null)
					{
						if(i is FTask)
						{
							_sessionManagerMainPresenter.CreateSession((FTask)i);
						}
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
			//var _node_repo = _ioc.Resolve<INodeRepository>();
			//var items = _node_repo.GetAll();
			//_node_repo.FetchPathsAndSave(items);

			var frm = _ioc.Resolve<ICompletedTasksView>();
			frm.Display(_service.GetCompletedTasks());
		}

		private void _mainView_StartSessionCollector(object sender, EventArgs e)
		{
			// send to presenters hub
			// hub will check whether the presenter is already working.
			if (_sessionManagerMainPresenter == null)
			{
				_sessionManagerMainPresenter = _ioc.Resolve<SessionManagerMainPresenter>();
				_sessionManagerMainPresenter.Go();
				return;
			}

			if (_sessionManagerMainPresenter.IsRunning == false)
			{
				_sessionManagerMainPresenter = _ioc.Resolve<SessionManagerMainPresenter>();
				_sessionManagerMainPresenter.Go();
				GC.Collect();
			}
		}

		private void _mainView_StartCurrentBuffer(object sender, EventArgs e)
		{
			IBufferTaskView dlg = _ioc.Resolve<IBufferTaskView>();

			//>>> 28-12-2021 23:36
			// Здесь лучше использовать event hub, общую шину обмена событий, результатов работы окон, запросов окон.
			EventHandler<INode> _CreateSession = delegate(object o, INode ev)
			{
				var res = _dialogs.ChooseDateTime();

				if (res.Ok)
				{
					var s = new OSession { NodeId = ev.id, Start = res.Data, ProvidedSeconds = 3600, Description = "" };
					var rep_ses = _ioc.Resolve<ISessionRepository>();
					rep_ses.Save(s);
				}
			};

			IBufferTaskRepository repo = _ioc.Resolve<IBufferTaskRepository>();

			dlg.CreateSession += _CreateSession;
			dlg.Display(repo.GetAll());
			dlg.CreateSession -= _CreateSession;
		}

		private void _mainView_DeleteNode(object sender, EventArgs e)
		{
			var i = _mainView.NodesView.SelectedNodes.FirstOrDefault();
			if (i.type < 0) return;

			if (_dialogs.UserAnsweredYes($"Are you sure to kill {i.name} / {i.definition}"))
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
			if(e.type >= 0)
				_service.Save(e);
		}

		private void _service_CollectionChanged(object sender, EventArgs e)
		{
			update();
		}

		private void update()
		{
			_mainView.NodesView.DisplayNodes(_service.Items, _service.CurrentParentFullName, _service.HighlightedNode);
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
				openTask(e);
			}
		}

		bool openTask(INode n)
		{
			if(_openedNodes.Contains(n) == false)
			{
				_openedNodes.Add(n);
				var frm = _ioc.Resolve<IFTaskEditView>();
				//frm.AddProperty("node_full_path", _service.getFullPath(n));
				//frm.Go(n as FTask, handleFTaskEdirEnd);

				frm.Go(n as FTask,
				(x) =>
				{
					if (x.Ok)
						_service.Save(x.Data);

					_openedNodes.Remove(x.Data);
					_mainView.OpenedTasksCout = _openedNodes.Count;
				},
				(y) =>
				{
					_service.Save(y);
				});

				_mainView.OpenedTasksCout = _openedNodes.Count;
				return true;
			}

			return false;
		}
	}
}
