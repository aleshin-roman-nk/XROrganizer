using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteCodeFirstExrc
{
	class Program
	{
		static void Main(string[] args)
		{
			AppData db = new AppData("Data Source = data.db");

			try
			{
				printObject("start");
				var items = db.Employeers.ToList();
				printObject("loaded");
				printObject(items);
			}
			catch (Exception ex)
			{
				
				Console.WriteLine(ex.Message);

				while( ex.InnerException != null)
				{
					Console.WriteLine(ex.InnerException.Message);
					ex = ex.InnerException;
				}
			}

			Console.ReadLine();
		}

		static void printObject(object o)
		{
			Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented));
		}
	}
}
