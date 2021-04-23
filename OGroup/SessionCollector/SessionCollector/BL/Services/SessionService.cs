using SessionCollector.BL.Entities;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.BL.Services
{
	// Microservice
	public class SessionService
	{
		public IEnumerable<OSession> SortAndAlign(IEnumerable<OSession> list)
		{
			if (list.Count() <= 1) return list;

			var res = list.OrderBy(x=>x.PlanStart).ToList();

			/*
			 * Сортированный список выравнять по времени
			 * 
			 * 1. Сравнить с предидущим.
			 * 2. Если время конца предидущего позднее времени начала текущего, текущий приравнять конец предидущий + 10 мин.
			 */

			for(int i = 1; i < res.Count; i++)
			{
				if(res[i - 1].PlanFinish >= res[i].PlanStart )
					res[i].PlanStart = res[i - 1].PlanFinish.AddMinutes(10);
			}

			return res;
		}

		public decimal GetAllocatedHours(IEnumerable<OSession> l)
		{
			return l.Sum(x => x.PlanHours);
		}

		public DateTime GetLastSessionFinish(IEnumerable<OSession> l)
		{
			return l.Max(x => x.PlanFinish);
		}
	}
}
