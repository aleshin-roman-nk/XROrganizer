using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatMeDid.Tools
{
	public static class MyJson
	{
		public static string ToString(object o)
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
		}
		public static T Parse<T>(string obj)
		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(obj);
		}
	}
}
