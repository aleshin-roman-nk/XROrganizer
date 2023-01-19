using Domain.DBContext;
using Domain.dto;
using Domain.Entities;
using Domain.Repos.Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Repos
{
	public class ForParentNode
	{
		private readonly NodeDTO _parentNode;
		private readonly IAppDataContextFactory dbFactory;
		ToolRepo _toolRepo = new ToolRepo();

		public ForParentNode(NodeDTO n, IAppDataContextFactory dbFactory)
		{
			this._parentNode = n;
			this.dbFactory = dbFactory;
		}

		public NodeDTO Create(INode n)
		{
			using (var db = dbFactory.Create())
			{
				n.owner_id = _parentNode.type == Enums.NType._sys_root_dir ? 0 : _parentNode.id;

				db.Entry(n).State = EntityState.Added;
				db.SaveChanges();

				if (_parentNode.type == Enums.NType._sys_root_dir) n.DNA = $"-{n.id}-";
				else
				{
					string parentDNA = db.Nodes.Where(x => x.id == _parentNode.id).Select(x => x.DNA).FirstOrDefault();
					n.DNA = $"{parentDNA}{n.id}-";
				}

				//n.DNA = _parentNode.type == Enums.NType._sys_root_dir ? $"-{n.id}-" : ;

				db.Entry(n).Property(x => x.DNA).IsModified = true;
				db.SaveChanges();
			}

			return new NodeDTO { id = n.id, date = n.date, name = n.name, pinned = n.pinned, type = n.type, path = n.path};
		}

		public void Move(IEnumerable<NodeDTO> nodes)//мы ведь из другого контекста вытащили эту коллекцию
		{

			using (var db = dbFactory.Create())
			{
				Func<Node, IEnumerable<Node>> getChildren = (parent) =>
				{
					return db.Nodes
						.Where(x => x.owner_id == parent.id)
						//.Select(x => new Node { id = x.id, DNA = x.DNA })
						.ToList();
				};

				string parentDNA = db.Nodes.Where(x => x.id == _parentNode.id).Select(x => x.DNA).FirstOrDefault();
				var db_nodes = nodes.Select(x => new Node { id = x.id });

                // корневые узлы
                foreach (var node in db_nodes)
				{
					db.Nodes.Attach(node);

					node.DNA = _parentNode.type == Enums.NType._sys_root_dir ? $"-{node.id}-" : $"{parentDNA}{node.id}-";

					node.owner_id = _parentNode.type == Enums.NType._sys_root_dir ? 0 : _parentNode.id;
					db.Entry(node).Property(x => x.DNA).IsModified = true;
					db.Entry(node).Property(x => x.owner_id).IsModified = true;
					_updateSessionsDNA(node, db);

					var parentsStack = new Stack<Node>();

					parentsStack.Push(node);

					// одно поколение узлов должно брать днк из предидущего поколения узлов
					while (parentsStack.Any())
					{
						var thisParent = parentsStack.Pop();// текущий родитель

						// обход всех дочерних объектов и обновление днк
						foreach (var child in getChildren(thisParent))
						{
							child.DNA = $"{thisParent.DNA}{child.id}-";
							db.Entry(child).Property(x => x.DNA).IsModified = true;
							_updateSessionsDNA(child, db);

							parentsStack.Push(child);
						}
					}

				}

				db.SaveChanges();
			}
		}

		private void _updateSessionsDNA(INode node, AppData db)
		{
			var sessions = db.Sessions.Where(x => x.NodeId == node.id).ToList();

			foreach (var item in sessions)
			{
				item.DNA = node.DNA;
				db.Entry(item).Property(x => x.DNA).IsModified= true;
			}
		}

		public IEnumerable<OSession> GetTopSessions(DateTime today, int top, int page)
		{
			DateTime dt1 = new DateTime(today.Year, today.Month, today.Day, 0, 0, 0);
			DateTime dt2 = dt1.AddDays(1);

			using (var db = dbFactory.Create())
			{
				return db.Sessions.Where(sess =>
					sess.NodeId == _parentNode.id && (sess.Start < dt2)
				).OrderByDescending(sess => sess.Start).Skip(top * page).Take(top).ToList();
			};
		}

		//public IEnumerable<INode> Children(bool includeCompleted)
		public IEnumerable<NodeDTO> Children(bool includeCompleted)
		{
			using (var db = dbFactory.Create())
			{
				IEnumerable<NodeDTO> itemsDTO = new List<NodeDTO>();

				//// пусть сервисы сортирую как им надо
				//if (includeCompleted)
				//	items = db.Nodes.Where(x => x.owner_id == _parentNode.id)
				//		.Select(x => new NodeDTO
				//		{
				//			id = x.id,
				//			name = x.name,
				//			pinned = x.pinned,
				//			//type = x.type,
				//			date = x.date
				//			//owner_id = x.owner_id
				//		}).ToList();
				//else
				//	items = db.Nodes.Where(x => x.owner_id == _parentNode.id && ((x is FTask) ? ((x as FTask).IsCompleted == false) : (true)))
				//		.Select(x => new NodeDTO
				//		{
				//			id = x.id,
				//			name = x.name,
				//			pinned = x.pinned,
				//			//type = x.type,
				//                        date = x.date
				//                        //owner_id = x.owner_id
				//                    }).ToList();

				IEnumerable<Node> items_db;

                if (includeCompleted)
				{
					items_db = db.Nodes.Where(x => x.owner_id == _parentNode.id).ToList();
                }
				else items_db = db.Nodes.Where(x => x.owner_id == _parentNode.id && ((x is FTask) ? ((x as FTask).IsCompleted == false) : (true))).ToList();

                //var items = items_db.Select(x => new { 
                //	dto = new NodeDTO {
                //			id = x.id,
                //			name = x.name,
                //			pinned = x.pinned,
                //			type = x.type,
                //			date = x.date }, 
                //	db = x});

                itemsDTO = items_db.Select(x => 

				x.type == Enums.NType.Task ? 

					new NodeDTO
					{
						id = x.id,
						name = x.name,
						pinned = x.pinned,
						type = x.type,
						date = x.date,
						text = x.text,
						IsCompleted = (x as FTask).IsCompleted
					}
					:
                    new NodeDTO
                    {
                        id = x.id,
                        name = x.name,
                        pinned = x.pinned,
                        type = x.type,
                        date = x.date,
                        text = x.text,
                    }
                    );

				//IEnumerable<Node> items = db.Nodes
				// .SqlQuery($"SELECT * FROM Nodes WHERE owner_id = @id", new SQLiteParameter("@id", _parentNode.id))
				// .ToList();

				var path = _toolRepo.getFullPathOf(_parentNode.id, db);

				foreach (var item in itemsDTO)
				{
					item.path = string.IsNullOrEmpty(item.name) == false ? $"{path} \\ {item.name}" : $"{path} \\ #{item.id}";
				}

				return itemsDTO;
			}
		}

		public bool HasChildren()
		{
			using (var db = dbFactory.Create())
			{
				var r = db.Nodes.FirstOrDefault(x => x.owner_id == _parentNode.id);
				return !(r == null);
			}
		}

		public bool HasSessions()
		{
			using (var db = dbFactory.Create())
			{
				return db.Sessions.Any(x => x.NodeId == _parentNode.id);
			}
		}
	}
}
