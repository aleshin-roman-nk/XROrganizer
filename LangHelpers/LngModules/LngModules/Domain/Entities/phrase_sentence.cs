using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LngModules.Domain.Entities
{
	public class phrase_sentence
	{
		public int id { get; set; }
		public int phraseId { get; set; }
		public int sentenceId { get; set; }
	}
}
