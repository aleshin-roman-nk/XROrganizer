using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkJoin.BL.Entities
{
	public class Note
	{
		public int id { get; set; }
		public string description { get; set; }
		public int NodeId { get; set; }
	}
}
