using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DBContext
{
	public class DbConf : IDbConf
	{
#if DEBUG
		string _source = @"Data Source=..\db\_debug\xorgData.db";
#else
		string _source = @"Data Source=..\db\xorgData.db";
#endif
		public string DbSource => _source;
	}
}
