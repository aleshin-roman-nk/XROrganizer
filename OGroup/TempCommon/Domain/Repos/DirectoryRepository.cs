using Domain.Cfg;
using Domain.DBContexts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repos
{
	public class DirectoryRepository : IDirectoryRepository
	{
		public void Delete(Dir dir)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				db.Entry(dir).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}
		}

		public IEnumerable<Dir> GetDirs()
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				return db.Dirs.ToList();
			}
		}

		public void Save(Dir dir)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				db.Entry(dir).State = dir.id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}

		public void Create(int owner_id, string name, DateTime date)
		{
			Dir d = new Dir { owner_id = owner_id, name = name, date = date };

			using (MainContext db = new MainContext(Settings.DbPath))
			{
				db.Entry(d).State = System.Data.Entity.EntityState.Added;
				db.SaveChanges();
			}

			//return d;
		}

		public IEnumerable<Dir> GetTrackedDirs()
		{
			throw new NotImplementedException();
		}
	}
}
