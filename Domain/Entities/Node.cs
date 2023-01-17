using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domain.Entities
{

	public /*abstract*/ class Node : INode
	{
		protected NType _type = NType.none;
		/// <summary>
		/// cant have children by default
		/// </summary>
		protected bool _canHaveChildren = false;
		public int id { get; set; }
		public int owner_id { get; set; }
		public NType type => _type;
		public virtual string name { get; set; }
		public string text { get; set; }
		public DateTime? date { get; set; }
		public bool CanHaveChildren => _canHaveChildren;
		public string NTypeString { get { return type.ToString(); } }
		[NotMapped]
		public string path { get; set; }
		public bool pinned { get; set; }
		public bool deleted { get; set; }
		public string DNA { get; set; }
		public DateTime? last_modified_date { get; set; }
        public ICollection<NodeTextPage> textPages { get; set; }

		//public abstract INode CreateNewNode();

		public Node()
		{
            textPages = new List<NodeTextPage>();
        }

        public override bool Equals(object obj)
		{
			INode ob = obj as INode;

			if (ob == null) return false;

			return ob.id == this.id;
		}
		public override int GetHashCode()
		{
			return id;
		}
	}
}
