using Domain.dto;
using Domain.Entities;
using Domain.Repos;
using Services.Sessions.Entities.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services.Sessions
{
	// Microservice
	public class SessionService : ISessionService
	{
		ISessionRepository _repo;

		IEnumerable<OSession> _items;

		public SessionService(ISessionRepository r)
		{
			_repo = r;
		}

		public ISessionRepository Repo => _repo;

		public IEnumerable<OSession> SortAndAlign(IEnumerable<OSession> list)
		{
			if (list.Count() <= 1) return list;

			var res = list.OrderBy(x => x.Start).ToList();

			/*
			 * Сортированный список выравнять по времени
			 * 
			 * 1. Сравнить с предидущим.
			 * 2. Если время конца предидущего позднее времени начала текущего, текущий приравнять конец предидущий + 10 мин.
			 */

			for (int i = 1; i < res.Count; i++)
			{
				if (res[i - 1].Finish >= res[i].Start)
					res[i].Start = res[i - 1].Finish.AddMinutes(10);
			}

			return res;
		}

		public void SetCollectionOfDate(DateTime d)
		{
			_items = _repo.GetOfDay(d);
		}

		public IEnumerable<ChartItem> GetStatistic(int year, int month, NodeDTO dir)
		{
			var dates = Enumerable.Range(1, DateTime.DaysInMonth(year, month))
						.Select(day => new DateTime(year, month, day))
						.ToList();

			var sessions = Repo.GetSessionOf(year, month, dir);

			Func<DateTime, int> _getSeconds = (dt) =>
			{
				DateTime dt1 = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
				DateTime dt2 = dt1.AddDays(1);
				return sessions.Where(x => x.Start >= dt1 && x.Start < dt2).ToList().Sum(x => x.TotalSeconds);
			};

			return dates.Select(x => new ChartItem(_getSeconds(x), x.Day.ToString())).ToList();
		}

		public decimal AllocatedHours
		{
			get
			{
				var secs =  _items.Sum(x => x.ProvidedSeconds);

				return secs / 60 / 60;
			}
		}

		public decimal DoneWorkInSeconds => _items.Sum(x => x.TotalSeconds);
			
		public DateTime? LastSessionFinish
		{
			get
			{
				if (_items.Count() == 0) return null;
				return _items.Max(x => x.Finish);
			}
		}

		public IEnumerable<OSession> Items => _items;
	}
}
