using Domain.DBContext;
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
			_toolRepo = new ToolRepo(contextFactory);
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
					item.Owner.path = _toolRepo.GetPathOf(item.Owner, db);

				return res;
			}
		}

		public IEnumerable<int> GetAllChildTaskIdOf(INode n)
		{
			/*
			 * Возможна оптимизация: не загружать задачи, дата закрытия которых
			 * в предидущем и более ранних месяцах.
			 * Сессии этих задач гарантированно немогут быть в текущем месяце.
			 * 
			 */

			var stack = new Stack<INode>();

			var res = new List<int>();

			using (var db = _contextFactory.Create())
			{
				Func<INode, IEnumerable<INode>> getChildren = (owner) =>
				{
					return db.Nodes.Where(x => x.owner_id == owner.id).ToList();
				};

				stack.Push(n);
				while (stack.Any())
				{
					var next = stack.Pop();
					if (next.type == Enums.NType.Task) res.Add(next.id);
					foreach (var child in getChildren(next))
						stack.Push(child);
				}

				return res;
			}
		}

		public IEnumerable<OSession> GetSessionOf(int year, int month, INode n)
		{
			DateTime dt1 = new DateTime(year, month, 1, 0, 0, 0);
			DateTime dt2 = dt1.AddMonths(1);

			List<OSession> res = new List<OSession>();

			var task_id_collection = GetAllChildTaskIdOf(n);

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

		public void Save(OSession e)
		{
			using (var db = _contextFactory.Create())
			{
				var owner = db.Nodes.FirstOrDefault(x => x.id == e.NodeId);
				if (owner != null)
				{
					e.Owner = owner;
					//e.NodeId = dir.Id;
				}

				db.Entry(e).State = e.Id == 0 ? EntityState.Added : EntityState.Modified;

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
			/*
			 * Если INode dir это директория.
			 * + найти все сессии, прямо висящие на директории
			 * + найти все задачи, найти все поддиретории и найти все сессии, для этих объектов
			 * вообще, задачи могут иметь подзадачи. так что просто нийти все дочерние объекты.
			 * 
			 * 
			 * 
			 * 1. Загружаем всю коллекцию директорий. !!!Для БД это одна плоская таблица!!!
			 * 
			 * 
			 */
		}

   //     public IEnumerable<INode> GetAllChildren(INode root)
   //     {

			//using (var db = _contextFactory.Create())
   //         {
			//	var stack = new Stack<INode>();

   //         }

			//	var dirs = _contextFactory.Directories.ToList();

            

   //         Func<INode, IEnumerable<INode>> getChildren = (owner) =>
   //         {
   //             return dirs.Where(x => x.owner_id == owner.Id).ToList();
   //         };

   //         stack.Push(root);
   //         while (stack.Any())
   //         {
   //             var next = stack.Pop();
   //             yield return next;
   //             foreach (var child in getChildren(next))
   //                 stack.Push(child);
   //         }
   //     }
    }
}
