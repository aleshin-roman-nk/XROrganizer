using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyExrc.Entities
{
	/*
	 * Документ слова выглядит так:
	 * Слово
	 * Документацая: значение, примеры.
	 * 
	 * 
	 */


	public class Lexem
	{
		public int id { get; set; }
		public string name { get; set; }
		public string description { get; set; }
	}
}
