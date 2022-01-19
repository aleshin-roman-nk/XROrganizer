using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xorg.Tools
{
	public static class Logger
	{
		private static string filename = "log1.txt";
		public static void WriteLine(string msg)
		{
			File.AppendAllText(filename, msg, Encoding.UTF8);
			File.AppendAllText(filename, "\n", Encoding.UTF8);
		}
		public static void Write(string msg)
		{
			File.AppendAllText(filename, msg, Encoding.UTF8);
		}
		public static void Clear()
		{
			File.WriteAllText(filename, "", Encoding.UTF8);
		}

		public static void WriteObject(object o)
        {
			WriteLine(JsonTool.Serialize(o));
		}
	}
}
