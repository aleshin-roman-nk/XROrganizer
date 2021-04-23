using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskBank.BL.Entities;

namespace TaskBank.BL.Repos
{
	public class RmTaskRepository : IRmTaskRepository
	{
		//public void Save(string fname, TaskCollection collection)
		//{

		//}

		//public TaskCollection Load(string fname)
		//{

		//}

#if DEBUG
		string src = @"Data Source = ..\db\dbg\data.db";
#else
		string src = @"Data Source = ..\db\data.db";
#endif

		public IEnumerable<RmTask> GetAll()
		{
			using (MainContext db = new MainContext(src))
			{
				return db.RmTasks.OrderByDescending(x => x.Id).ToList();
			}
		}

		//public RmTask Create(string newrmtask)
		//{
		//	using (MainContext db = new MainContext())
		//	{
		//		RmTask t = new RmTask { Text = newrmtask, Imp = ImportanceLevel.Low };
		//		db.RmTasks.Add(t);
		//		db.SaveChanges();
		//		return t;
		//	}
		//}

		public void Save(RmTask t)
		{
			using (MainContext db = new MainContext(src))
			{
				db.Entry(t).State = t.Id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}

		public void Delete(RmTask t)
		{
			using (MainContext db = new MainContext(src))
			{
				db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}
		}
	}
}
