using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.Tools
{
	public static class JsonTool
	{
		public static string Serialize(object o)
		{
			return JsonConvert.SerializeObject(o, Formatting.Indented);
		}

		public static T Deserialize<T>(string j)
		{
			return JsonConvert.DeserializeObject<T>(j);
		}

		public static T Clone<T>(T o)
		{
			return Deserialize<T>(Serialize(o));
		}
	}
}
