using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using SessionCollector.Tools;

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
		public decimal TotalHours
		{
			get
			{
				return TotalSeconds / (60.0m * 60.0m);
			}
		}
		public int TotalSeconds { get; set; }
		public bool Closed { get; set; }
		public string TotalWorkTime
		{
			get
			{
				var res = TimeSpan.FromSeconds(TotalSeconds);
				return $"{res.Hours:d2}:{res.Minutes:d2}:{res.Seconds:d2}";
			}
		}

		public OSession Clone()
		{
			return JsonTool.Clone(this);
		}

		public void Accept(OSession o)
		{
			//PropertyCopy.Copy(o, this);
			o.CopyPropertiesTo(this);
		}
	}
}
