using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTypesInOneTable.BL.Enities
{
	public interface INode
	{
		int id { get; set; }
		string name { get; set; }
		string type { get; set; }
	}
}
