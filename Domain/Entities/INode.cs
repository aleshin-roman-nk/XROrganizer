using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public interface INode
	{
		int id { get; set; }
		int owner_id { get; set; }
		NType type { get; }
		bool CanHaveChildren { get; }
		string name { get; set; }
		string text { get; set; }
		DateTime? date { get; set; }
		string NTypeString { get; }
		string path { get; set; }
		bool pinned { get; set; }
		bool deleted { get; set; }
	}
}
