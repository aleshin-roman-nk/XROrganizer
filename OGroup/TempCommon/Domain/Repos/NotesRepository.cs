using Domain.Cfg;
using Domain.DBContexts;
using Domain.Entities;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Repos
{
	public class NotesRepository : INoteRepository
	{
		public event EventHandler Changed;

		private void OnChanged()
		{
			Changed?.Invoke(this, EventArgs.Empty);
		}
		public void Save(Note t)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				db.Entry(t).State = t.id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
				OnChanged();
			}
		}

		public void Delete(Note t)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
				OnChanged();
			}
		}

		public Note Create(INode own, string name, DateTime dd)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Note> SelectByOwner(INode owner)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				//tmp. getting date string and make Date field.
				//var i = db.Nodes.OrderByDescending(x => x.id).ToList();
				//foreach (var item in i)
				//{
				//	//string d = item.description.Substring(4, 16);
				//	//item.date = DateTime.Parse(d);
				//	item.type = Enums.NType.Task;
				//}
				//db.SaveChanges();

				return db.Notes.Where(x => x.owner_id == owner.id)
					.OrderByDescending(x => x.id).ToList();
			}
		}
	}
}