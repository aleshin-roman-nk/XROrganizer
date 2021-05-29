using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cfg
{
	public class Settings
	{

		public static string DbPath
		{
			get
			{
#if DEBUG
				return @"Data Source = ..\..\..\..\db\_debug\data.db";
#else
				return @"Data Source = ..\..\..\..\db\data.db";
#endif
			}
		}
	}
}
