using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Sessions.Entities.UI
{
	public class ChartItem
	{
		public int Seconds { get; set; }
		public TimeSpan Time
		{
			get
			{
				return TimeSpan.FromSeconds(Seconds);
			}
		}
		public string DayOfMonth { get; set; }
		public ChartItem(int mins, string dayName)
		{
			Seconds = mins;
			DayOfMonth = dayName;
		}
	}
}
