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
		ntype type { get; set; }
		string name { get; set; }
		string description { get; set; }
		DateTime date { get; set; }
	}
}
