using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempWordCollector.Domain
{
	public class JSONTool<T>
	{
		public static T GetObj(string j)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(j);
		}
		public static string SerObj(T o)
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(o);
		}
	}
}
