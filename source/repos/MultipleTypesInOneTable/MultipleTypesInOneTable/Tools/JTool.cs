using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleTypesInOneTable.Tools
{
	public static class JTool
	{
		public static void DisplayObj(object o)
		{
			string j = Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
			Console.WriteLine(j);
		}

		public static void DisplayObjMessage(object o)
		{
			string j = Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
			MessageBox.Show(j);
		}

		public static string Ser(object o)
		{
			return Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
		}
	}
}
