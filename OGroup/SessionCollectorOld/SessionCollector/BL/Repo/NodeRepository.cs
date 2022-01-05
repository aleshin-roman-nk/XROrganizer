using SessionCollector.BL.Db;
using SessionCollector.BL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SessionCollector.BL.Repo
{
	public class NodeRepository: INodeRepository
	{
		IAppDataContextFactory _contextFactory;

		public NodeRepository(IAppDataContextFactory contextFactory)
		{
			_contextFactory = contextFactory;
		}

		public void Delete(INode e)
		{
			using (var db = _contextFactory.Create())
			{
				db.Entry(e).State = EntityState.Deleted;
				db.SaveChanges();
			}
		}

		public IEnumerable<INode> Get()
		{
			using (var db = _contextFactory.Create())
			{
				return db.Directories.ToList();
			}
		}

		public INode GetById(int id)
		{
			using (var db = _contextFactory.Create())
			{
				return db.Nodes.FirstOrDefault(x => x.Id == id);
			}
		}

		public void Save(INode e)
		{
			using (var db = _contextFactory.Create())
			{
				db.Entry(e).State = e.Id == 0 ? EntityState.Added : EntityState.Modified;
				db.SaveChanges();
			}
		}
	}
}
