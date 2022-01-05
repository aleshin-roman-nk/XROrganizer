using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	public class BufferTask
	{
		public int id { get; set; }

		public int node_id { get; set; }
		[ForeignKey("node_id")]
		public Node Node { get; set; }
		public string node_id_str
		{
			get
			{
				string str = Node == null ? "no owner loaded" : Node.id.ToString();
				return $"#{str}";
			}
		}
		public string descr
		{
			get
			{
				return Node == null ? "" : Node.definition;
			}
		}
		public string path
		{
			get
			{
				if (Node == null) return "";
				return $"{Node.path}#{node_id}";
			}
		}
	}
}
