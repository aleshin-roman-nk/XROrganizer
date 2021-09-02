using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LngModules.Domain.Entities
{
	public class phrase_phrase
	{
		public int id { get; set; }
		public int phraseAId { get; set; }
		public int phraseBId { get; set; }
	}
}
