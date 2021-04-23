using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriningArticles.BL.tools
{
	class logservices
	{
		static ILogger log;

		public static void init()
		{
			log = new LoggerConfiguration()
						.WriteTo.File("log.txt")
						.CreateLogger();
		}

		public static void writelog(string str)
		{
			//log.Information(str);
			log.Fatal(str);
		}
	}
}
