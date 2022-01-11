using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Presenters
{
	public class OpenObjectManager
	{
		List<INode> _openedTasks = new List<INode>();
		OSession _openedSession = null;

		public EventHandler<FTask> SaveTask;
		public EventHandler<OSession> SaveSession;

		public void OpenSession(OSession s)
		{

		}

		public void OpenTask(FTask t)
		{
			var op = _openedTasks.FirstOrDefault(x => x.id == t.id);

			if (op != null)
			{
				// It is not nessesary since we remove the view from the collection.
				// Thus _openObjects.FirstOrDefault is going to return null after a view is completed.
				//if (op.IsClosed)
				//{
				//	createView(o);
				//}
				//else
				op.Restore();
			}
			else
			{
				createView(t);
			}

			//***********************************************************
			if (_openedNodes.Contains(n) == false)
			{
				_openedNodes.Add(n);
				var frm = _ioc.Resolve<IFTaskEditView>();

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

				_mainView.OpenedTasksCout = _openedNodes.Count;// изменить на событие изменения колдичества открытых объектов.
				return true;
			}

			return false;
			//***********************************************************

		}

		private void createView(FTask t)
		{
			throw new NotImplementedException();
		}

		public void StartSession(OSession s)
		{
			_openedSession = s;
		}
	}
}
