using Domain.Cfg;
using Domain.DBContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repos.T
{
	public class TrashTempRepo
	{
		public void ParseDateAndSetDateTimeForNotes()
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				//tmp. getting date string and make Date field.
				var i = db.Notes.OrderByDescending(x => x.id).ToList();
				foreach (var item in i)
				{
					string d = item.description.Substring(4, 16);
					DateTime date;
					if (DateTime.TryParse(d, out date))
					{
						item.date = date;
						item.description = item.description.Remove(0, 21);
					}
				}
				db.SaveChanges();
			}
		}


	}
}
