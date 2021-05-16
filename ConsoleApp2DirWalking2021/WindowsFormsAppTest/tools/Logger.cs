using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class Logger
{
	static int enterexitlevel = 0;

	private static string filename = "log.txt";
	public static void WriteLine(string msg)
	{
		File.AppendAllText(filename, _buildReport(msg), Encoding.UTF8);
		File.AppendAllText(filename, "\n", Encoding.UTF8);
	}

	static string level_to_spases(int lvl)
	{
		return new string('\t', lvl);
	}

	public static void WriteEnter(string mname)
	{
		WriteLine($"{level_to_spases(enterexitlevel)}>>> {mname}");
		enterexitlevel++;
	}

	public static void WriteExit(string mname)
	{
		enterexitlevel--;
		WriteLine($"{level_to_spases(enterexitlevel)}<<< {mname}");
	}

	static string _buildReport(string msg)
	{
		string dt = DateTime.Now.ToString("HH:mm:ss:ffff");
		return $"{dt} |> {msg}";
	}

	public static void Write(string msg)
	{
		File.AppendAllText(filename, msg, Encoding.UTF8);
	}
	public static void Clear()
	{
		File.WriteAllText(filename, "", Encoding.UTF8);
	}
}

