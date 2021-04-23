using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoriesWolking
{
	public class BaseDir : IDir
	{
		public int id { get; set; }
		public int owner_id { get; set; }
		public string name { get; set; }
		public int type { get; set; }
	}
}
