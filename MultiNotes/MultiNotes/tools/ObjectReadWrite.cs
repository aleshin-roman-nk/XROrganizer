using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aleshin_rv.tools
{
	public static class ObjectReadWrite
	{
		public static void Write(object o, string fname)
		{
			var j = JsonTool.Serialize(o);

			File.WriteAllText(fname, j, Encoding.UTF8);
		}

		public static T Read<T>(string fname)
		{
			var j = File.ReadAllText(fname, Encoding.UTF8);

			return JsonTool.Deserialize<T>(j);
		}

		public static void Delete(string fname)
		{
			try
			{
				File.Delete(fname);
			}
			catch (Exception ex)
			{
				File.AppendAllText("log.txt", ex.Message, Encoding.UTF8);
			}

		}
	}
}
