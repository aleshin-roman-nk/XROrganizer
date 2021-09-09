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
	public class NodeRepository : IRepository<INode>
	{
		AppData _appData;

		public NodeRepository(AppData data)
		{
			_appData = data;
		}

		public void Delete(INode e)
		{
			_appData.Directories.Remove(e as ODirectory);
			_appData.SaveChanges();
		}

		public IEnumerable<INode> Get()
		{
			return _appData.Directories.ToList();
		}

		public INode GetById(int id)
		{
			return _appData.Nodes.FirstOrDefault( x=> x.Id == id);
		}

		public void Save(INode e)
		{
			_appData.Entry(e).State = e.Id == 0 ? EntityState.Added : EntityState.Modified;
			_appData.SaveChanges();
		}
	}
}
