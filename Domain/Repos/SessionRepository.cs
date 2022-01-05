using Domain.DBContext;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Domain.Repos
{
	public class SessionRepository: ISessionRepository
	{
		IAppDataContextFactory _contextFactory;

		public SessionRepository(IAppDataContextFactory contextFactory)
		{
			_contextFactory = contextFactory;
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
				return db.Sessions.Include(x => x.Owner).Where(x => x.Start >= dt1 && x.Start < dt2)
					.OrderBy(x => x.Start).ToList();
			}
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

		//private IEnumerable<INode> ReadAllChildren(INode root)
		//{
		//	var dirs = _contextFactory.Directories.ToList();

		//	var stack = new Stack<INode>();

		//	Func<INode, IEnumerable<INode>> getChildren = (owner) =>
		//	{
		//		return dirs.Where(x => x.owner_id == owner.Id).ToList();
		//	};

		//	stack.Push(root);
		//	while (stack.Any())
		//	{
		//		var next = stack.Pop();
		//		yield return next;
		//		foreach (var child in getChildren(next))
		//			stack.Push(child);
		//	}
		//}
	}
}
