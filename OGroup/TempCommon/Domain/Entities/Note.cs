using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{

	public class Note : INode
	{
		public int id { get; set; }
		public int owner_id { get; set; }
		public NType type { get; set; }
		public string name { get; set; }
		public string description { get; set; }
		public DateTime? date { get; set; }
		public string MiniText
		{
			get
			{
				int lenght = description.Length > 100 ? 100 : description.Length;
				return description.Substring(0, lenght) + "...";
			}
		}
	}
}
