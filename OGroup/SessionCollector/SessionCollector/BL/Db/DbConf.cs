using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.BL.Db
{
	public class DbConf : IDbConf
	{
		string _source = @"Data Source=..\db\sessions.db";
		public string DbSource => _source;
	}
}
