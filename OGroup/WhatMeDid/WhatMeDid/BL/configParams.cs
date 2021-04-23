using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatMeDid.Tools;

namespace WhatMeDid.BL
{
	public class configParams
	{
		public int LastId { get; set; }
		public string note_dir { get; set; }
		public static configParams Load(string file_name)
		{
			return MyJson.Parse<configParams>(File.ReadAllText(file_name, Encoding.UTF8));
		}
		public void Save(string file_name)
		{
			var j = MyJson.ToString(this);
			File.WriteAllText(file_name, j, Encoding.UTF8);
		}
		public void ResetDefault()
		{
			LastId = 0;
			note_dir = "notes";
		}
		public configParams()
		{
			ResetDefault();
		}
	}
}
