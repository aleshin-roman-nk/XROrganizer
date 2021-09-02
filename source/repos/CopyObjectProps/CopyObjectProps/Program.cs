using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyObjectProps
{
	class Program
	{
		static void Main(string[] args)
		{
			Obj o = new Obj { id = 22, Nam = "RRrrrr" };

			Obj4324 ooo = new Obj4324 { name = "Nnnnsfn" };
			Obj4324 ooouuu = new Obj4324 { name = "nnRrrrrr", Sub = ooo };
			Obj4324 ddd = new Obj4324 { name = "Ggg gggg" };
			ooo.Sub = ddd;

			Obj4324 ffffff = new Obj4324 { name = "My cool" };

			o.Items.Add(ooouuu);
			o.Items.Add(ffffff);

			Console.WriteLine($"source:");
			Console.WriteLine($"{JsonTool.Serialize(o)}");

			Obj cln = new Obj();
			o.CopyPropertiesTo(cln);

			Console.WriteLine($"copy:");
			Console.WriteLine($"{JsonTool.Serialize(cln)}");

			Console.ReadLine();
		}
	}

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
