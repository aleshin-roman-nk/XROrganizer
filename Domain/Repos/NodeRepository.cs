using Domain.DBContext;
using Domain.Entities;
using Domain.Repos.Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Domain.Repos
{
	public class NodeRepository : INodeRepository
	{
		IAppDataContextFactory _factory;
		ToolRepo _toolRepo;

		public NodeRepository(IAppDataContextFactory factory)
		{
			_factory = factory;
			_toolRepo = new ToolRepo(_factory);
		}

		public void Save(INode n)
		{
			using (var db = _factory.Create())
			{
				db.Entry(n).State = n.id == 0 ? EntityState.Added : EntityState.Modified;
				n.path = _toolRepo.GetPathOf(n);
				db.SaveChanges();
			}
		}
		
		public void Delete(INode n)
		{
			using (var db = _factory.Create())
			{
				db.Entry(n).State = EntityState.Deleted;
				db.SaveChanges();
			}
		}

		public INode Create(INode own, INode n)
		{
			using (var db = _factory.Create())
			{
				n.owner_id = own.id;
				n.path = _toolRepo.GetPathOf(n);
				db.Entry(n).State = EntityState.Added;
				db.SaveChanges();
				return n;
			}
		}

		public void SaveRange(IEnumerable<INode> nodes)
		{
			using (var db = _factory.Create())
			{
				foreach (var item in nodes)
				{
					db.Entry(item).State = item.id == 0 ? EntityState.Added : EntityState.Modified;
				}

				db.SaveChanges();
			}
		}

		public bool HasChildren(INode d)
		{
			using (var db = _factory.Create())
			{
				//var r = db.Dirs.FirstOrDefault(x => x.owner_id == d.id);
				var r = db.Nodes.FirstOrDefault(x => x.owner_id == d.id);
				return !(r == null);
			}
		}

		public IEnumerable<INode> GetAll(INode owner)
		{
			return _getNodes(owner, true);

			//using (var db = _factory.Create())
			//{
			//	// пусть сервисы сортирую как им надо
			//	var items = db.Nodes.Where(x => x.owner_id == owner.id).ToList();

			//	var path = _toolRepo.getFullPathOf(owner, db);

			//	foreach (var item in items)
			//	{
			//		item.path = path;
			//	}

			//	return items;
			//}
		}

		public IEnumerable<INode> GetAllExcludeCompletedTask(INode owner)
		{
			return _getNodes(owner, false);
		}

		private IEnumerable<INode> _getNodes(INode owner, bool loadCompleted)
		{
			using (var db = _factory.Create())
			{
				IEnumerable<INode> items;

				// пусть сервисы сортирую как им надо
				if (loadCompleted)
					items = db.Nodes.Where(x => x.owner_id == owner.id).ToList();
				else
					items = db.Nodes.Where(x => x.owner_id == owner.id && ( (x is FTask) ? ((x as FTask).IsCompleted == false) : (true) )).ToList();

				var path = _toolRepo.getFullPathOf(owner, db);

				foreach (var item in items)
					item.path = path;

				return items;
			}
		}

		public IEnumerable<INode> GetAll()
		{
			using (var db = _factory.Create())
			{
				return db.Nodes.ToList();
			}
		}

		public IEnumerable<INode> GetAllChildrenOf(INode n)
		{
			var stack = new Stack<INode>();

			var res = new List<INode>();

			using (var db = _factory.Create())
			{
				Func<INode, IEnumerable<INode>> getChildren = (owner) =>
				{
					return db.Nodes.Where(x => x.owner_id == owner.id).ToList();
				};

				stack.Push(n);
				while (stack.Any())
				{
					var next = stack.Pop();
					//yield return next;
					if (next.type == Enums.NType.Task) res.Add(next);
					foreach (var child in getChildren(next))
						stack.Push(child);
				}

				return res;
			}
		}

		public INode Get(int id)
		{
			using (var db = _factory.Create())
			{
				return db.Nodes.FirstOrDefault(x => x.id == id);
			}
		}

		public IEnumerable<FTask> GetCompletedTasks(/*period parameter*/)
		{
			using (var db = _factory.Create())
			{
				var res = db.Tasks.Where(x => x.IsCompleted /* && period parameter*/).ToList();

				foreach (var item in res)
					item.path = _toolRepo.getPathOf(item, db);

				return res;
			};
		}
	}
}