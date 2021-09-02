using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempWordCollector.Domain
{
	public class CoreData
	{
		public List<Word> Words { get; set; }
		public int lastId { get; set; }
		public int WordsPurpose { get; set; }
	}
}
