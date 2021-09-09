using SessionCollector.BL.Db;
using SessionCollector.Tools;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.BL.Repo
{
	public class MainRepository: IMainRepository
	{
		AppData _appData;

		public NodeRepository Nodes { get; }
		public SessionRepository Sessions { get; }

		public MainRepository(IDbConf db_src)
		{
			_appData = new AppData(db_src.DbSource);

			//#if DEBUG
			//			_appData.Database.Log = Logger.Write;
			//#endif
			Nodes = new NodeRepository(_appData);
			Sessions = new SessionRepository(_appData);
		}

		public void Save()
		{
			_appData.SaveChanges();
		}

		public bool HasAnyUnsavings()
		{
			return _appData.ChangeTracker.HasChanges();
				   //ObjectStateManager.
				   //GetObjectStateEntries(EntityState.Added |
							//			 EntityState.Deleted |
							//			 EntityState.Modified
							//			).Any();
		}
	}
}
