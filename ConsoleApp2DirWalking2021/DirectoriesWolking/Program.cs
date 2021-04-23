using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoriesWolking
{
	class Program
	{
		static void Main(string[] args)
		{
			string i = "";

			//DirectoryController ctrl = new DirectoryController();

			//showDirs(ctrl.GetDirs());

			//while (!i.Equals("exit"))
			//{
			//	Console.Write(">");
			//	i = Console.ReadLine();

			//	//ctrl.EnterDir(int.Parse(i));

			//	showDirs(ctrl.GetDirs());
			//}
		}

		static void showDirs(IEnumerable<Dir> list)
		{
			foreach (var item in list)
			{
				Console.WriteLine($"{item.id} - {item.name}");
			}
		}
	}
}
