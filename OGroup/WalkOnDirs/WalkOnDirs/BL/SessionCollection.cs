using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkOnDirs.BL
{
	public class SessionCollection
	{
		public List<Session> Sessions { get; } = new List<Session>();
		public IEnumerable<Session> GetSessionsOnDate(DateTime dt)
		{
			DateTime dt1 = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0, 0);
			DateTime dt2 = dt1.AddDays(1);

			return from i in Sessions where i.Date >= dt1 && i.Date < dt2 select i;
		}
		public Session CreateNewSession(DateTime d, string text)
		{
			return new Session { Date = d, Text = text };
		}
		private IEnumerable<Session> readSessionsFromFile(DateTime dt)
		{
			throw new NotImplementedException();
		}
		public Session FromPrjItem(PrjItem prjItem, DateTime dt)
		{
			return new Session
			{
				Date = dt,
				Text = prjItem.Text
			};
		}
	}
}
