using Domain.Cfg;
using Domain.DBContexts;
using Domain.Entities;
using Domain.Enums;
using Domain.Services;
using Domain.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repos
{
	public class DirectoryRepository : IDirectoryRepository
	{
		public event EventHandler Changed;

		public DirectoryRepository()
		{
			
		}

		private void OnChanged()
		{
			Changed?.Invoke(this, EventArgs.Empty);
		}

		public void Delete(Dir dir)
		{
			if (dir == null) return;
			if (dir.type != NType.Dir) return;

			using (MainContext db = new MainContext(Settings.DbPath))
			{
				db.Entry(dir).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
				OnChanged();
			}
		}

		public void Save(Dir dir)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				db.Entry(dir).State = dir.id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
				OnChanged();
			}
		}

		public Dir Create(string name)
		{
			Dir d = new Dir { name = name };

			using (MainContext db = new MainContext(Settings.DbPath))
			{
				db.Entry(d).State = System.Data.Entity.EntityState.Added;
				db.SaveChanges();
				OnChanged();
			}

			return d;
		}

		public IEnumerable<INode> SelectByOwner(INode owner)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				var r = (from d in db.Dirs where d.owner_id == owner.id select d).ToList().OrderBy(x => x.type).ThenBy(x => x.name).ToList();

				return r;
			}
		}
	}
}
