using Domain.Cfg;
using Domain.DBContexts;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Repos
{
	public class NotesRepository : INotesRepository
	{
		//public void Save(string fname, TaskCollection collection)
		//{

		//}

		//public TaskCollection Load(string fname)
		//{

		//}


		public IEnumerable<Note> GetAll()
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				//tmp
				//var i = db.Nodes.OrderByDescending(x => x.id).ToList();
				//foreach (var item in i)
				//{
				//	//string d = item.description.Substring(4, 16);
				//	//item.date = DateTime.Parse(d);
				//	item.type = Enums.NType.Task;
				//}
				//db.SaveChanges();

				//

				return db.Notes.OrderByDescending(x => x.id).ToList();
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

		public void Save(Note t)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				db.Entry(t).State = t.id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}

		public void Delete(Note t)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}
		}
	}
}
