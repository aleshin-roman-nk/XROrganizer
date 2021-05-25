using DirectoriesWolking.Models.DirNavigator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoriesWolking.Models.DirNavigator
{
	public class BaseDir : INode
	{
		public int id { get; set; }
		public int owner_id { get; set; }
		public string name { get; set; }
		public NType type { get; set; }
	}
}
