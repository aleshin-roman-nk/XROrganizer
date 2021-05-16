using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiNotes.Entities
{
	public class MNote
	{
		public string boardid { get; set; }
		public string gdid { get; set; }
		public int color { get; set; }
		public long date { get; set; }
		public long datemod { get; set; }
		public int id { get; set; }
		public string notetxt { get; set; }
		public string _Date => new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime().AddMilliseconds(date).ToString("yyyy.MM.dd HH:mm");
	}
}
