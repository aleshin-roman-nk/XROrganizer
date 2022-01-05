using SessionCollector.BL.Entities;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SessionCollector.BL.Repo;
using SessionCollector.BL.Entities.UI;

namespace SessionCollector.BL.Services
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

		public IEnumerable<ChartItem> GetStatistic(int year, int month, INode dir)
		{
			var dates = Enumerable.Range(1, DateTime.DaysInMonth(year, month))
						.Select(day => new DateTime(year, month, day))
						.ToList();

			return dates.Select(x => new ChartItem(Repo.GetSecondsOfDay(x, dir), x.Day.ToString())).ToList();
		}

		public void KickSessionToNextDay(OSession s)
		{
			s.Start = s.Start.AddDays(1);
			_repo.Save(s);

		}

		public void KickSessionToPrevDay(OSession s)
		{
			s.Start = s.Start.AddDays(-1);
			_repo.Save(s);
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
