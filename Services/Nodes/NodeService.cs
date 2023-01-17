using Domain.dto;
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

		public IEnumerable<NodeDTO> Items { get; private set; }
		public event EventHandler CollectionChanged;
		public NodeDTO CurrentOwner => _navigator.CurrentOwner;
		public string CurrentParentFullName => _navigator.CurrentNodeFullName;
		public NodeDTO HighlightedNode => _navigator.HighlightedNode;

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
			Items = select(_navigator.CurrentOwner);
			OnCollectionChanged();
		}

		void OnCollectionChanged()
		{
			CollectionChanged?.Invoke(this, EventArgs.Empty);
		}

		private IEnumerable<NodeDTO> select(NodeDTO own)
		{
			// Поменять, уйти от всяких _sys_root_dir, exit_dir
			//	ввести атрибуты директорий, да и вообще узлов.
			List<NodeDTO> res = new List<NodeDTO>();
			if (own.type != NType._sys_root_dir)
				res.Add(NodeDTO.ExitTopDir);

			var i = _repo.AsParent(own).Children(true);

			//res.AddRange(i.Where(x => x.type == NType.Dir).OrderBy(x=>x.pinned).ThenBy(x=>x.name).ToList());
			//res.AddRange(i.Where(x => x.type != NType.Dir).OrderByDescending(x=>x.pinned).ThenByDescending(x=>x.date).ToList());

			//res.AddRange(i.OrderBy(x=>x.type).ThenBy(x=>x.name).ThenBy(x=>x.pinned).ToList());

			res.AddRange(i);

			return res;
		}

        public void Move(IEnumerable<NodeDTO> nodes)
		{
            _repo.AsParent(_navigator.CurrentOwner).Move(nodes);
            updateData();
        }


        public NodeDTO Create(INode d)
		{
			d.last_modified_date = DateTime.Now;

			var res = _repo.AsParent(_navigator.CurrentOwner).Create(d);
			updateData();
			return res;
		}

		// почему мы не вызываем событие при сохранении ноды? Ведь коллекция изменилась.
		// в базе данных объект изменился, а в загруженной коллекции старый объект.
		public int Update(INode d)
		{
			d.last_modified_date = DateTime.Now;

			var res = _repo.Update(d);

			updateData();

			return res;
		}

		public void Delete(NodeDTO d)
		{
			_repo.Delete(d);
			updateData();
		}

		public bool HasChildren(NodeDTO d)
		{
			return _repo.AsParent(d).HasChildren();
		}

		public void JumpBack()
		{
			_navigator.JumpBack();
		}

		public void Enter(NodeDTO n)
		{
			_navigator.Enter(n);
		}

		public IEnumerable<FTask> GetCompletedTasks(int year, int month)
		{
			return _repo.GetCompletedTasks(year, month).OrderByDescending(x => x.completed_date);
		}

        public IEnumerable<OSession> GetTopSessions(DateTime today, int taskId, int top, int page)
        {
			return _repo.AsParent(new NodeDTO { id = taskId }).GetTopSessions(today, top, page);
        }

        public INode GetNode(int nodeId)
        {
			return _repo.Get(nodeId);
		}

        public bool HasSessions(NodeDTO d)
        {
            return _repo.AsParent(d).HasSessions();
        }

        public int UpdateName(NodeDTO node)
        {
			return _repo.UpdateName(node);
        }

        public void DeleteNodeTextPage(NodeTextPage ntp)
        {
            _repo.DeleteNodeTextPage(ntp);
        }
    }
}
