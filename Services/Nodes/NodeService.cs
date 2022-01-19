using Domain.Entities;
using Domain.Enums;
using Domain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xorg.Tools;

namespace Services.Nodes
{
	public class NodeService : INodeService
	{
		TreeNavigator _navigator = new TreeNavigator();
		INodeRepository _repo;

		public IEnumerable<INode> Items { get; private set; }
		public event EventHandler CollectionChanged;
		public INode CurrentOwner => _navigator.CurrentOwner;
		public string CurrentParentFullName => _navigator.CurrentNodeFullName;
		public INode HighlightedNode => _navigator.HighlightedNode;

		public NodeService(INodeRepository r)
		{
			_repo = r;
			_navigator.OwnerChanged += _navigator_OwnerChanged;// должно быть внутри сервиса. интерфейс сервиса должен быть плоским.

			updateData();
		}

		private void _navigator_OwnerChanged(object sender, EventArgs e)
		{
			updateData();
		}

		private void updateData()
		{
			Items = select(_navigator.CurrentOwner as Dir);
			OnCollectionChanged();
		}

		void OnCollectionChanged()
		{
			CollectionChanged?.Invoke(this, EventArgs.Empty);
		}

		private IEnumerable<INode> select(Dir own)
		{
			// Поменять, уйти от всяких _sys_root_dir, exit_dir
			//	ввести атрибуты директорий, да и вообще узлов.
			List<INode> res = new List<INode>();
			if (own.type != NType._sys_root_dir)
				res.Add(Dir.ExitTopDir);

			//var i = _repo.GetAll(own);
			var i = _repo.GetAllExcludeCompletedTask(own);

			res.AddRange(i.Where(x => x.type == NType.Dir).OrderBy(x=>x.name).ToList());
			res.AddRange(i.Where(x => x.type != NType.Dir).OrderByDescending(x=>x.date).ToList());

			return res;
		}

		public void MoveNodesToDirectory(Dir dir, IEnumerable<INode> nodes)
		{
			foreach (var item in nodes)
			{
				item.owner_id = dir.id;
			}

			_repo.SaveRange(nodes);

			updateData();
		}

		public INode Create(INode d)
		{
			var res = _repo.Create(_navigator.CurrentOwner, d);
			updateData();
			return res;
		}

		public void Save(INode d)
		{
			_repo.Save(d);
			//updateData();
		}

		public void Delete(INode d)
		{
			_repo.Delete(d);
			updateData();
		}

		public bool HasChildren(INode d)
		{
			return _repo.HasChildren(d);
		}

		public void JumpBack()
		{
			_navigator.JumpBack();
		}

		public void Enter(INode n)
		{
			_navigator.Enter(n);
		}

		public IEnumerable<FTask> GetCompletedTasks(int year, int month)
		{
			return _repo.GetCompletedTasks(year, month).OrderByDescending(x => x.completed_date);
		}

        public IEnumerable<OSession> GetTopSessions(DateTime today, int taskId, int top, int page)
        {
			return _repo.GetTopSessions(today, taskId, top, page);
        }
    }
}
