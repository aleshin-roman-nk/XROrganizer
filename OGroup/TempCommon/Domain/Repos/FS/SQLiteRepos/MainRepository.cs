using Domain.Cfg;
using Domain.DBContexts;
using Domain.Entities;
using Domain.Enums;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Repos.SQLiteRepos
{
	public class MainRepository : IRepository
	{
		public void Save(INode n)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				db.Entry(n).State = n.id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}
		
		public void Delete(INode n)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				db.Entry(n).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}
		}

		public INode Create(INode own, INode n)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				n.owner_id = own.id;
				db.Entry(n).State = System.Data.Entity.EntityState.Added;
				db.SaveChanges();
				return n;
			}
		}

		public void SaveRange(IEnumerable<INode> nodes)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				foreach (var item in nodes)
				{
					db.Entry(item).State = item.id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				}
				db.SaveChanges();
			}
		}

		public bool HasChildren(INode d)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				//var r = db.Dirs.FirstOrDefault(x => x.owner_id == d.id);
				var r = db.Nodes.FirstOrDefault(x => x.owner_id == d.id);
				return !(r == null);
			}
		}

		public IEnumerable<INode> GetFiles(INode owner)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				List<INode> res = new List<INode>();

				res.AddRange(db.Nodes.OfType<FNote>().Where(x => x.owner_id == owner.id).ToList());
				res.AddRange(db.Nodes.OfType<FTask>().Where(x => x.owner_id == owner.id).ToList());

				return res.OrderByDescending(x => x.id).ToList();
			}
		}

		public IEnumerable<INode> GetDirs(INode owner)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				return db.Nodes.OfType<Dir>().Where(x => x.owner_id == owner.id)
					//.OrderByDescending(x => x.id).ToList();
					.OrderBy(x => x.name).ToList();
			}
		}
	}
}