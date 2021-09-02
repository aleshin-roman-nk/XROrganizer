using MultipleTypesInOneTable.BL.Enities;
using MultipleTypesInOneTable.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace MultipleTypesInOneTable.BL
{
	public class MainPresenterDisconnected: IRepo
	{
		string db_path = "Data Source = data.db";
		Action<string> _logger;

		public MainPresenterDisconnected(Action<string> logger)
		{
			_logger = logger;
		}

		public void Create(INode n)
		{
			using (AppDb db = new AppDb(db_path))
			{
				db.Database.Log = _logger;
				//db.Nodes.Add(n as Node);
				db.Entry(n).State = EntityState.Added;
				db.SaveChanges();
			}
		}

		public IEnumerable<INode> GetAll()
		{
			using (AppDb db = new AppDb(db_path))
			{
				db.Database.Log = _logger;
				return db.Nodes.ToList();
			}
		}

		public void Kill(INode n)
		{
			if (n == null) return;

			_db_action(db => {
				
				if(n is CatLover)
				{
					var o = db.CatLovers.Include(x=>x.Cats).FirstOrDefault(x => x.id == n.id);
					db.CatLovers.Remove(o);
					db.SaveChanges();
				}
				else
				{
					db.Entry(n).State = EntityState.Deleted;
					db.SaveChanges();
				}

			});
		}

		public void Save(INode n)
		{
			if (n == null) return;

			_db_action(db => {

				db.Entry(n).State = n.id == 0 ? EntityState.Added : EntityState.Modified;
				db.SaveChanges();
			});
		}

		private void _db_action(Action<AppDb> db_ac_code)
		{
			using (AppDb db = new AppDb(db_path))
			{
				db.Database.Log = _logger;
				db_ac_code(db);
			}
		}
	}
}
