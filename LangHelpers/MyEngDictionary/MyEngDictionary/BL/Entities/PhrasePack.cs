using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngDictionary.BL.Entities
{
	public class PhrasePack// rename to "S(rudy)Module". Because we better work with modules. Module by module, I am improving my english... turkish. 
	{
		public PhrasePack()
		{
			Phrases = new List<Phrase>();
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string Info { get; set; }
		public DateTime? LastWrite { get; set; }
		virtual public ICollection<Phrase> Phrases { get; set; }
	}
}
