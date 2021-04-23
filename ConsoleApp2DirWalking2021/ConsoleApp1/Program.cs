using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			//DateTime dt = DateTime.Now;
			//TimeSpan ts = TimeSpan.FromMinutes(120);

			//Console.WriteLine($"{dt + ts}");

			string s = "### Article 1 df sdf всапрвапdcghd fg şşjklş /(%*87657^5456.\nRoman";

			Console.WriteLine(s);

			Console.WriteLine("====== REGEX RESULR ======");

			Console.WriteLine(getNameTag(s));


			Console.ReadLine();
		}

		public static int GetSentencesCount(string text)
		{
			Regex r = new Regex(@"(\.\s)|(\.\w)|(\?\w)|(\?\s)|(\.$)|(\.\n)|(\!\s)");
			return r.Matches(text).Count;
		}

		private static string getNameTag(string str)
		{
			Regex r = new Regex(@"^###(.*?)$", RegexOptions.Multiline);
			//Regex r = new Regex(@"^###(.*?)$");
			var res = r.Match(str);

			//foreach (var item in res.Groups)
			//{
			//	Console.WriteLine(item.ToString());
			//}

			if (res.Groups.Count == 2)
				return res.Groups[1].Value.TrimStart(' ');
			else return "---";
		}

		private static void f1()
		{
			string str = "How are your doings? My home is fine! And my wife is kind... But we do not live there.And my pain is not very strong.\nThe lake next to our house is red.";

			// patterns: ". " ".[w]" "? " "?[w]" "! " "![w]"

			Console.WriteLine(str);

			Regex r = new Regex(@"(\.\s)|(\.\w)|(\?\w)|(\?\s)|(\.$)|(\.\n)|(\!\s)");
			MatchCollection matches = r.Matches(str);



			foreach (Match item in matches)
			{
				Console.WriteLine($"<{item.Value}>");
			}

			Console.WriteLine($"Total sentences :{matches.Count}");
		}
	}
}
