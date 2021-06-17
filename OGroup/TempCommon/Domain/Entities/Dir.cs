using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class Dir : INode
	{
		public int id { get; set; }
		public NType type => NType.Dir;
		public int owner_id { get; set; }
		public NType owner_type { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public DateTime? date { get; set; }

		//private static Dir _root = null;
		//private static Dir _exit_top = null;
		//public static Dir Root()
		//{
		//	if(_root == null)
		//	{
		//		_root = new Dir { id = 0, type = NType._sys_root_dir };
		//	}

		//	return _root;
		//}
		//public static Dir ExitTopDir()
		//{
		//	if (_root == null)
		//	{
		//		_root = new Dir { id = -1, type = NType.exit_dir };
		//	}

		//	return _root;
		//}
	}
}
