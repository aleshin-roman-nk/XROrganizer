using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class TopExitNode : INode
	{
		public int id { get; set; }
		public int owner_id { get; set; }
		public NType owner_type { get; set; }
		public NType type => NType.exit_dir;
		public string name { get; set; }
		public string description { get; set; }
		public DateTime? date { get; set; }
		private static TopExitNode _value = null;
		public static TopExitNode Value
		{
			get
			{
				if (_value == null)
					_value = new TopExitNode { id = -1, name = ".." };

				return _value;
			}
		}
		private TopExitNode()
		{

		}
	}
}
