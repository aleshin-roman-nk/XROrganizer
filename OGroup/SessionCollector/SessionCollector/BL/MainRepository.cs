using SessionCollector.BL.Db;
using SessionCollector.Tools;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.BL
{
	public class MainRepository: IMainRepository
	{
		AppData _appData;

		public DirectoryRepository Directories { get; }
		public SessionRepository Sessions { get; }

		public MainRepository(string app_data_path)
		{
			_appData = new AppData(app_data_path);
#if DEBUG
			_appData.Database.Log = Logger.Write;
#endif
			Directories = new DirectoryRepository(_appData);
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
