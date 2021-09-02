using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTypesInOneTable.BL.Enities
{
	public class Node: INode
	{
		public int id { get; set; }
		public string name { get; set; }
		public string type { get; set; }
		public Node()
		{
			type = "common";
		}
	}
}