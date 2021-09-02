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
		public int? NodeId { get; set; }// любой объект из таблицы в которой задачи, заметки, идеи.
											// можно создать сессию без хозяина. но привязать можно только к записи внутри проекта.
		public string Name
		{
			get
			{
				if (string.IsNullOrEmpty(Description)) return "-";
				
				string res = Description.Split(new[] { '\r', '\n' }).FirstOrDefault();

				if (string.IsNullOrEmpty(res)) return "-";
				else return res;
			}
		}

		public virtual Node Node { get; set; }
		public string Description { get; set; }
		public string Report { get; set; }
		public DateTime Start { get; set; }
		public decimal ReservedHours { get; set; }
		public string DirName
		{
			get
			{
				return Node == null ? "---" : Node.Name;
			}
		}
		public string ShorName
		{
			get
			{
				if (Description.Length < 10) return Description;
				return Description.Substring(0, 10);
			}
		}
		public DateTime Finish
		{
			get
			{
				return Start + TimeSpan.FromHours(Convert.ToDouble(ReservedHours));
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
				//return $"{res.Hours:d2}:{res.Minutes:d2}:{res.Seconds:d2}";
				return $"{res.Hours:d2}:{res.Minutes:d2}";
			}
		}

		public OSession Clone()
		{
			return JsonTool.Clone(this);
		}

		public void CopyFrom(OSession o)
		{
			o.CopyPropertiesTo(this);
		}
	}
}
