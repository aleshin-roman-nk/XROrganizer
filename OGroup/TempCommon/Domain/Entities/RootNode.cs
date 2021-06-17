using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class RootNode : INode
	{
		public int id { get; set; }
		public int owner_id { get; set; }
		public NType owner_type { get; set; }
		public NType type => NType._sys_root_dir;
		public string name { get; set; }
		public string description { get; set; }
		public DateTime? date { get; set; }
		private static RootNode _value = null;
		public static RootNode Value
		{
			get
			{
				if (_value == null)
					_value = new RootNode { id = 0, name = "" };

				return _value;
			}
		}
		private RootNode()
		{

		}
	}
}
