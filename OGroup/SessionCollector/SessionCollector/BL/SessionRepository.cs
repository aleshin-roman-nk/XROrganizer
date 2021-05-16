using SessionCollector.BL.Db;
using SessionCollector.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			return _appData.Sessions.Where(x => x.Start >= dt1 && x.Start < dt2).OrderBy(x=>x.Start).ToList();
		}

		public void Save(OSession e)
		{
			_appData.Entry(e).State = e.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
			_appData.SaveChanges();
		}
	}
}
