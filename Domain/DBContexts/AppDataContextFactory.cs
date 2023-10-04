using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xorg.Tools;

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
			try
			{
				AppData res = new AppData(db_connection_string);
				//Logger.Write("Data base is successful");
				//res.Database.Log = Logger.Write;
				return res;
			}
			catch (Exception ex)
			{
				Logger.Write(ex.Message);
			}

			throw new InvalidOperationException("Wrong with creating data base");
		}
	}
}
