using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SessionCollector.BL.Entities
{
	[Table("Sessions")]
	public class OSession
	{
		public int Id { get; set; }
		//public int OwnerId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime PlanStart { get; set; }
		public decimal PlanHours { get; set; }
		public DateTime PlanFinish
		{
			get
			{
				return PlanStart + TimeSpan.FromHours(Convert.ToDouble(PlanHours));
			}
		}
		// Фактический счетчик
		public decimal ActualHours { get; set; }
		public bool Closed { get; set; }
	}
}
