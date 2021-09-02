using ManyToManyExrc.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyExrc.repos
{
	public class MainRepo
	{
		List<Sentence> sentences = new List<Sentence>();

		public MainRepo()
		{
			sentences.Add(new Sentence { Text = "rrrr rrr rrrrr rrr"});
			sentences.Add(new Sentence { Text = "nnnn fffff eeeee www"});
			sentences.Add(new Sentence { Text = "rrrr ggdfg dfgdfg werwer"});
			sentences.Add(new Sentence { Text = "tryrty dfgdfg dfgdfg werwer"});
		}

		public IEnumerable<Sentence> GetSentences()
		{
			return sentences;
		}
	}
}
