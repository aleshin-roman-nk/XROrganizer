using Domain.DBContext;
using Domain.dto;
using Domain.Entities;
using Domain.Repos.Shared;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Domain.Repos
{
	public class SessionRepository: ISessionRepository
	{
		IAppDataContextFactory _contextFactory;
		ToolRepo _toolRepo;

		public SessionRepository(IAppDataContextFactory contextFactory)
		{
			_contextFactory = contextFactory;
			_toolRepo = new ToolRepo();
		}

		public void Delete(OSession e)
		{
			using (var db = _contextFactory.Create())
			{
				db.Entry(e).State = EntityState.Deleted;
				db.SaveChanges();
			}
		}

		public IEnumerable<OSession> GetOfDay(DateTime date)
		{
			DateTime dt1 = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
			DateTime dt2 = dt1.AddDays(1);

			using (var db = _contextFactory.Create())
			{
				var res = db.Sessions.Include(x => x.Owner).Where(x => x.Start >= dt1 && x.Start < dt2)
					.OrderBy(x => x.Start).ToList();

				foreach (var item in res)
                {
					item.Owner.path = _toolRepo.getFullPathOf(item.Owner.id, db);
				}

				return res;
			}
		}

		//16-01-2023
		// Самое время начать искать по днк

		public IEnumerable<int> GetAllChildIdOf(NodeDTO n)// дать коллекцию
		{
			/*
			 * Возможна оптимизация: не загружать задачи, дата закрытия которых
			 * в предидущем и более ранних месяцах.
			 * Сессии этих задач гарантированно немогут быть в текущем месяце.
			 * 
			 */

			var stack = new Stack<Node>();

			var res = new List<int>();

			using (var db = _contextFactory.Create())
			{
				Func<Node, IEnumerable<Node>> getChildren = (owner) =>
				{
					return db.Nodes.Where(x => x.owner_id == owner.id).ToList();
				};

				stack.Push(new Node { id = n.id });
				while (stack.Any())
				{
					var next = stack.Pop();
					//if (next.type == Enums.NType.Task) res.Add(next.id);
					if (next.type >= Enums.NType.Dir) res.Add(next.id);
					foreach (var child in getChildren(next))
						stack.Push(child);
				}

				return res;
			}
		}

		public IEnumerable<OSession> GetSessionOf(int year, int month, NodeDTO n)
		{
			DateTime dt1 = new DateTime(year, month, 1, 0, 0, 0);
			DateTime dt2 = dt1.AddMonths(1);

			List<OSession> res = new List<OSession>();

			var task_id_collection = GetAllChildIdOf(n);

			using (var db = _contextFactory.Create())
			{
				res = db.Sessions/*.Include(x => x.Owner)*/.Where(sess =>
					  task_id_collection.Contains(sess.NodeId) &&
					  (sess.Start >= dt1 && sess.Start < dt2)
				).ToList();

				//foreach (var item in res)
				//	item.Owner.path = _toolRepo.GetPathOf(item.Owner, db);
			}

			return res;
		}

		public void Update(OSession e)
		{
            if (e.Id == 0) throw new InvalidOperationException("This is a new object, its id is 0. For update you have to use existing one");

            using (var db = _contextFactory.Create())
			{
				var owner = db.Nodes.FirstOrDefault(x => x.id == e.NodeId);
				if (owner != null)
				{
					e.Owner = owner;
					//e.NodeId = dir.Id;
				}

				//db.Entry(e).State = e.Id == 0 ? EntityState.Added : EntityState.Modified;
				db.Entry(e).State = EntityState.Modified;

				db.SaveChanges();
			}
		}
		public int GetSecondsOfDay(DateTime dt, INode own)
		{
			DateTime dt1 = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
			DateTime dt2 = dt1.AddDays(1);

			using (var db = _contextFactory.Create())
			{
				return db.Sessions.Where(x => x.NodeId == own.id && x.Start >= dt1 && x.Start < dt2).ToList().Sum(x => x.TotalSeconds);
			}
		}

   //     public SessionForNode ForNode(INode n)
   //     {
			//return new SessionForNode(n, _contextFactory);
   //     }

        public SessionForNode ForNode(int parentNode)
        {
            return new SessionForNode(parentNode, _contextFactory);
        }
    }
}
