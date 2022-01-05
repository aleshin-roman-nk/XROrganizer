using SessionCollector.BL.Entities;
using SessionCollector.BL.Entities.UI;
using SessionCollector.BL.Repo;
using System;
using System.Collections.Generic;

namespace SessionCollector.BL.Services
{
	public interface ISessionService
	{
		decimal AllocatedHours { get; }
		decimal DoneWorkInSeconds { get; }
		DateTime? LastSessionFinish { get; }
		IEnumerable<OSession> SortAndAlign(IEnumerable<OSession> list);
		void SetCollectionOfDate(DateTime d);
		IEnumerable<OSession> Items { get; }
		ISessionRepository Repo { get; }
		IEnumerable<ChartItem> GetStatistic(int year, int month, INode dir);
		void KickSessionToNextDay(OSession s);
		void KickSessionToPrevDay(OSession s);
	}
}