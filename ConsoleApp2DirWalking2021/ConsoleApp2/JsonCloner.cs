using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	public static class JsonCloner
	{
		public static T Clone<T>(object o)
		{
			var j = Newtonsoft.Json.JsonConvert.SerializeObject(o);
			return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(j);
		}
	}
}
