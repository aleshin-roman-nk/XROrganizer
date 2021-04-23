using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBank.BL.Tools
{
	public class CloneObject
	{
		public static T Clone<T>(object o)
		{
			var j = Newtonsoft.Json.JsonConvert.SerializeObject(o);
			return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(j);
		}
	}
}
