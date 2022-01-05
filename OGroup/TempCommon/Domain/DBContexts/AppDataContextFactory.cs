using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DBContext
{
	public class AppDataContextFactory : IAppDataContextFactory
	{
		string db_connection_string;

		public AppDataContextFactory(IDbConf db_src)
		{
			db_connection_string = db_src.DbSource;
		}

		public AppData Create()
		{
			return new AppData(db_connection_string);
		}
	}
}
