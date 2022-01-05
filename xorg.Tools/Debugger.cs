using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xorg.Tools
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

		public static void ShowObject(object o)
		{
			var j = Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
			MessageBox.Show(j);
		}

		public static void ShowObjectConsole(object o)
		{
			var j = Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
			Console.WriteLine(j);
		}
	}
}