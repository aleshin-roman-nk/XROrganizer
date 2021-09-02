using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyExrc.Entities
{
	public class Paragraph
	{
		public Paragraph()
		{
			Sentences = new List<Sentence>();
		}

		public int id { get; set; }
		public string Text { get; set; }
		public virtual ICollection<Sentence> Sentences { get; set; }
	}
}
