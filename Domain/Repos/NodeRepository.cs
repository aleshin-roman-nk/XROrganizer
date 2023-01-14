using Domain.DBContext;
using Domain.Entities;
using Domain.Repos.Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using xorg.Tools;

namespace Domain.Repos
{
	public class NodeRepository : INodeRepository
	{
		IAppDataContextFactory _factory;
		ToolRepo _toolRepo;

		public NodeRepository(IAppDataContextFactory factory)
		{
			_factory = factory;
			_toolRepo = new ToolRepo();
		}

		public int Update(INode n)
		{
			if (n.id == 0) throw new InvalidOperationException("This is a new object, its id is 0. For update  you have to use existing one");

			using (var db = _factory.Create())
			{
				//db.Entry(n).State = n.id == 0 ? EntityState.Added : EntityState.Modified;
				db.Entry(n).State = EntityState.Modified;
				var res = db.SaveChanges();
				n.path = _toolRepo.getFullPathOf(n, db);
				return res;
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

		public bool HasChildren(INode d)
		{
			using (var db = _factory.Create())
			{
				var r = db.Nodes.FirstOrDefault(x => x.owner_id == d.id);
				return !(r == null);
			}
		}

		public IEnumerable<INode> GetAllOf(INode owner, bool includeCompleted)
		{
			return _getNodes(owner, includeCompleted);
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
                {
					//item.path = item.type == Enums.NType.Dir ? $"{path} \\ {item.name}" : $"{path} \\ #{item.id}";
					item.path = string.IsNullOrEmpty(item.name) == false ? $"{path} \\ {item.name}" : $"{path} \\ #{item.id}";
                }

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

        public INode Get(int id)
		{
			using (var db = _factory.Create())
			{
				var res = db.Nodes.FirstOrDefault(x => x.id == id);
				if(res == null) return null;
				//res.path = _toolRepo.GetPathOf(res, db);
				res.path = _toolRepo.getFullPathOf(res, db);

				return res;
			}
		}

		public IEnumerable<FTask> GetCompletedTasks(int year, int month)
		{
			DateTime dt1 = new DateTime(year, month, 1, 0, 0, 0);
			DateTime dt2 = dt1.AddMonths(1);

			using (var db = _factory.Create())
			{
				var res = db.Tasks.Where(x => x.IsCompleted && (x.completed_date >= dt1 && 
				x.completed_date < dt2)).ToList();

				foreach (var item in res)
					item.path = _toolRepo.getFullPathOf(item, db);

				return res;
			};
		}

        public bool HasSessions(INode d)
        {
			using (var db = _factory.Create())
            {
				return db.Sessions.Any(x=> x.NodeId == d.id);
			}
		}

        public IEnumerable<INode> GetFirstLineChildren(int owner)
        {
			using (var db = _factory.Create())
            {
				var r = db.Nodes.Where(x => x.owner_id == owner).ToList();

				return r;
			}
		}

        public void UpdateDNA()
        {

            using (var db = _factory.Create())
            {
				var updateCounter = 0;

                Func<INode, IEnumerable<INode>> getChildren = (parent) =>
                {
                    return db.Nodes
						.Where(x => x.owner_id == parent.id)
						//.Select(x => new Node { id = x.id, DNA = x.DNA })
						.ToList();
                };

                var nodes = db.Nodes
					.Where(x => x.owner_id == 0)
					//.Select(x => new Node { id = x.id, DNA = x.DNA })
					.ToList();

                // корневые узлы
                foreach (var node in nodes)
                {
                    Console.Write($"p:{node.owner_id}; dna:{node.DNA} => ");

                    node.DNA = $"-{node.id}-";
					node.last_modified_date = node.last_modified_date == null ? node.date : node.last_modified_date;
					db.Entry(node).Property(x => x.DNA).IsModified = true;
					db.Entry(node).Property(x => x.last_modified_date).IsModified = true;
					_updateSessionsDNA(node, db);

                    Console.WriteLine($"p:{node.owner_id}; dna:{node.DNA}");

                    var parentsStack = new Stack<INode>();

                    parentsStack.Push(node);

                    // одно поколение узлов должно брать днк из предидущего поколения узлов
                    while (parentsStack.Any())
                    {
                        var thisParent = parentsStack.Pop();// текущий родитель

                        // обход всех дочерних объектов и обновление днк
                        foreach (var child in getChildren(thisParent))
                        {
                            Console.Write($"p:{child.owner_id}; dna:{child.DNA} => ");

                            child.DNA = $"{thisParent.DNA}{child.id}-";
                            child.last_modified_date = child.last_modified_date == null ? child.date : child.last_modified_date;
                            db.Entry(child).Property(x => x.DNA).IsModified = true;
                            db.Entry(child).Property(x => x.last_modified_date).IsModified = true;
                            _updateSessionsDNA(child, db);

                            Console.WriteLine($"p:{child.owner_id}; dna:{child.DNA}");

                            parentsStack.Push(child);
                        }
                    }

                }

				Console.WriteLine($"Total updates: {db.SaveChanges()}");
				Console.WriteLine("DONE !!!");
            }
        }

        private void _updateSessionsDNA(INode node, AppData db)
        {
            var sessions = db.Sessions.Where(x => x.NodeId == node.id).ToList();

            foreach (var item in sessions)
            {
                item.DNA = node.DNA;
                db.Entry(item).Property(x => x.DNA).IsModified = true;
            }
        }

        public ForParentNode AsParent(INode n)
        {
			return new ForParentNode(n, _factory);
        }
    }
}