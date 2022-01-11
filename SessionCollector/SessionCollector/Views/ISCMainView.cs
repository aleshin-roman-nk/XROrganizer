using Domain.Entities;
using System;
using System.Collections.Generic;

namespace SessionCollector
{
	public interface ISCMainView
	{
		void DisplaySessions(IEnumerable<OSession> list, decimal hours, decimal doneHrs, DateTime? endofday);

		void ShowWindow();

		event EventHandler<DateTime> CreateSession;
		event EventHandler<DateTime> DateChanged;
		event EventHandler<DateTime> OrderAndAlign;
		event EventHandler<OSession> StartSession;
		event EventHandler<OSession> DeleteSession;
		event EventHandler<OSession> StartSessionTick;
		event EventHandler<DateTime> ShowStata;
		event EventHandler<OSession> KickNextDay;
		event EventHandler<OSession> KickPrevDay;
		event EventHandler WindowClosed;

		bool UserAnsweredYes(string qstr);
		void ShowMessage(string msg);

		DateTime CurrentDateTime { get; }
		//event EventHandler NotifyShown;
	}
}
