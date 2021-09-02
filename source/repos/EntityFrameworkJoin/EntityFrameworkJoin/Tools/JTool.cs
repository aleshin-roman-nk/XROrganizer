using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkJoin.Tools
{
	public static class JTool
	{
		public static void DisplayObj(object o)
		{
			string j = Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
			Console.WriteLine(j);
		}
	}
}
