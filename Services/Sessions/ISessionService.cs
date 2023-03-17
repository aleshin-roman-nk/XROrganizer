using Domain.dto;
using Domain.Entities;
using Domain.Repos;
using Services.Sessions.Entities.UI;
using System;
using System.Collections.Generic;

namespace Services.Sessions
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
		IEnumerable<ChartItem> GetStatistic(int year, int month, NodeDTO dir);


	}
}