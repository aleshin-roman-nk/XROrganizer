using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{

	public class Node : INode
	{
		protected NType _type = NType.none;
		/// <summary>
		/// cant have children by default
		/// </summary>
		protected bool _canHaveChildren = false;
		public int id { get; set; }
		public int owner_id { get; set; }
		public NType type => _type;
		public string name { get; set; }
		public string description { get; set; }
		public DateTime? date { get; set; }
		public bool CanHaveChildren => _canHaveChildren;
		public string NTypeString { get { return type.ToString(); } }
	}
}
