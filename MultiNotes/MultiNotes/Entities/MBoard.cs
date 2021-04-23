using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiNotes.Entities
{
	public class MBoard
	{
		public string gdid { get; set; }
		public string title { get; set; }
		public int numord { get; set; }
		public int id { get; set; }
		public int color { get; set; }
		public long datemod { get; set; }
		public string Date => new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime().AddMilliseconds(datemod).ToString("yyyy.MM.dd HH:mm");
	}
}
