using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LngModules.Domain.Entities
{
	public class Paragraph
	{
		public Paragraph()
		{
			Sentences = new List<Sentence>();
		}

		public int id { get; set; }
		public string text { get; set; }
		public string practiceText { get; set; }
		public virtual ICollection<Sentence> Sentences { get; set; }
	}
}
