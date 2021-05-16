using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class BaseDir: INode
	{
		public int id { get; set; }
		public int owner_id { get; set; }
		public string name { get; set; }
		public ntype type { get; set; }
		public string description { get; set; }
		public DateTime date { get; set; }
	}
}
