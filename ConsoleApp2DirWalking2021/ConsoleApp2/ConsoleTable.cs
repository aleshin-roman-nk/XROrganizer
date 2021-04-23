using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
	public class ConsoleTable
	{
		private readonly int tableWidth;
		public ConsoleTable(int twidth)
		{
			tableWidth = twidth;
		}

		public void PrintLine()
		{
			Console.WriteLine(new string('-', tableWidth));
		}

		public void PrintRow(params string[] columns)
		{
			int width = (tableWidth - columns.Length) / columns.Length;
			string row = "|";

			foreach (string column in columns)
			{
				row += AlignCentre(column, width) + "|";
			}

			Console.WriteLine(row);
		}

		private string AlignCentre(string text, int width)
		{
			text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

			if (string.IsNullOrEmpty(text))
			{
				return new string(' ', width);
			}
			else
			{
				return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
			}
		}
	}
}
