using EntityFrameworkJoin.BL.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkJoin
{
	class Program
	{
		static void Main(string[] args)
		{
			AppData db = new AppData("Data Source = data.db");

			var res = db.Notes.Join(
				db.Nodes,
				nt => nt.NodeId,
				nd => nd.id,
				(nt, nd) => new
				{
					descr = nt.description,
					nme = nd.name,
					bb = nd.id,
					gg = nt.id
				}).ToList();

			Console.WriteLine($"type :{res.GetType().Name}");

			//Tools.JTool.DisplayObj(res);

			foreach (var item in res)
			{
				Console.WriteLine($"{item.bb}");
			}

			Console.ReadLine();
		}
	}
}
