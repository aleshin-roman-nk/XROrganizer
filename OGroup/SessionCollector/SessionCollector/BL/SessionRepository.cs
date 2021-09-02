using SessionCollector.BL.Db;
using SessionCollector.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SessionCollector.BL.Entities.UI;

namespace SessionCollector.BL
{
	public class SessionRepository : IEntityRepository<OSession>
	{
		AppData _appData;

		public SessionRepository(AppData src)
		{
			_appData = src;
		}

		public void Delete(OSession e)
		{
			_appData.Sessions.Remove(e);
			_appData.SaveChanges();
		}

		public IEnumerable<OSession> Get()
		{
			return _appData.Sessions.ToList();
		}

		public OSession GetById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<OSession> GetByDay(DateTime date)
		{
			DateTime dt1 = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
			DateTime dt2 = dt1.AddDays(1);
			return _appData.Sessions.Include(x => x.Node).Where(x => x.Start >= dt1 && x.Start < dt2)
				.OrderBy(x=>x.Start).ToList();
		}

		public void Save(OSession e)
		{
			if (e.Id == 0)
				_appData.Sessions.Add(e);

			// Костыль, но как по другому?
			var dir = _appData.Directories.FirstOrDefault(x => x.Id == e.NodeId);
			if(dir != null)
			{
				//e.DirectoryId = dir.Id;
				e.Node = dir;
			}

			//_appData.Entry(e).State = e.Id == 0 ? EntityState.Added : EntityState.Modified;
			_appData.SaveChanges();
		}

		public IEnumerable<ChartItem> GetStatistic(int year, int month, INode dir)
		{
			var dates =  Enumerable.Range(1, DateTime.DaysInMonth(year, month))
					.Select(day => new DateTime(year, month, day))
					.ToList();

			return dates.Select(x => new ChartItem(getSecondsOfDay(x, dir), x.Day.ToString())).ToList();
		}

		private int getSecondsOfDay(DateTime dt, INode dir)
		{
			DateTime dt1 = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
			DateTime dt2 = dt1.AddDays(1);

			var res = _appData.Sessions.Where(x => x.NodeId == dir.Id && x.Start >= dt1 && x.Start < dt2).ToList().Sum(x => x.TotalSeconds);
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

			return res;
		}


		private IEnumerable<INode> ReadAllChildren(INode root)
		{
			var dirs = _appData.Directories.ToList();

			var stack = new Stack<INode>();

			Func<INode, IEnumerable<INode>> getChildren = (owner) =>
			{
				return dirs.Where(x => x.owner_id == owner.Id).ToList();
			};

			stack.Push(root);
			while (stack.Any())
			{
				var next = stack.Pop();
				yield return next;
				foreach (var child in getChildren(next))
					stack.Push(child);
			}
		}
	}
}
