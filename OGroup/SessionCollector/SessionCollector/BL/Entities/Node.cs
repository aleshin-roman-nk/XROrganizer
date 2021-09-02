using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.BL.Entities
{
	public class Node : INode
	{
		public int Id { get; set; }
		public int owner_id { get; set; }
		public string Name { get; set; }
		public string description { get; set; }
	}
}
