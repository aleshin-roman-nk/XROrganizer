using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Tools
{
	public class Debugger
	{
		static ILogger log;

		public static void init()
		{
			File.Delete("log.txt");

			log = new LoggerConfiguration()
						.WriteTo.File("log.txt")
						.CreateLogger();
		}

		public static void writelog(string str)
		{
			//log.Information(str);
			log.Information(str);
		}
	}
}