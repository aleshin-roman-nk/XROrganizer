using Domain.DBContext;
using Domain.dto;
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
				foreach (var textPage in n.textPages)
				{
					textPage.nodeid = n.id;
					db.Entry(textPage).State = textPage.id == 0 ? EntityState.Added : EntityState.Modified;
                }

                db.Entry(n).State = EntityState.Modified;
                var res = db.SaveChanges();
				n.path = _toolRepo.getFullPathOf(n.id, db);
				return res;
			}
		}
		
		public void Delete(NodeDTO n)
		{
			using (var db = _factory.Create())
			{
				db.Entry(new Node { id = n.id }).State = EntityState.Deleted;
				db.SaveChanges();
			}
		}

        public INode Get(int id)
		{
			using (var db = _factory.Create())
			{
				var res = db.Nodes.Include(x => x.textPages).FirstOrDefault(x => x.id == id);
				if(res == null) return null;
				res.path = _toolRepo.getFullPathOf(res.id, db);

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
					item.path = _toolRepo.getFullPathOf(item.id, db);

				return res;
			};
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

        public ForParentNode AsParent(NodeDTO n)
        {
			return new ForParentNode(n, _factory);
        }

        public int UpdateName(NodeDTO node)
        {
			var o = new Node { id = node.id, name = node.name };

            using (var db = _factory.Create())
			{
				db.Nodes.Attach(o);
				db.Entry(o).Property(x => x.name).IsModified = true;
				return db.SaveChanges();
			}
        }

        public void DeleteNodeTextPage(NodeTextPage ntp)
        {
			if (ntp == null) return;
			if (ntp.id == 0) return;
            using (var db = _factory.Create())
			{
				db.Entry(ntp).State = EntityState.Deleted;
				db.SaveChanges();
			}
        }
    }
}