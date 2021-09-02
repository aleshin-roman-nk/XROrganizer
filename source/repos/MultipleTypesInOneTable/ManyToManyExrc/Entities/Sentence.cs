using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyExrc.Entities
{
	public class Sentence
	{
		public int id { get; set; }
		public string Text { get; set; }
		public string Description { get; set; }
		public int ParagraphId { get; set; }
		public virtual ICollection<Lexem> Lexems { get; set; }
	}
}
