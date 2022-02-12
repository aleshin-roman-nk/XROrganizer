using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xorg.Tools
{
	public static class JsonTool
	{
		public static string Serialize(object o)
		{
			return JsonConvert.SerializeObject(o, Formatting.Indented);
		}

		public static T Deserialize<T>(string j)
		{
			var settings = new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore,
				MissingMemberHandling = MissingMemberHandling.Ignore
			};
			//var jsonModel = JsonConvert.DeserializeObject<Customer>(jsonString, settings);
			return JsonConvert.DeserializeObject<T>(j, settings);
		}

		public static T Clone<T>(T o)
		{
			return Deserialize<T>(Serialize(o));
		}

		public static void ShowObject(object o)
		{
			MessageBox.Show(Serialize(o));
		}
	}
}
