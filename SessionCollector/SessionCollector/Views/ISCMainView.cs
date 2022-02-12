using Domain.Entities;
using System;
using System.Collections.Generic;

namespace SessionCollector
{
	public interface ISCMainView
	{
		void DisplaySessions(IEnumerable<OSession> list, decimal hours, decimal doneHrs, DateTime? endofday);

		void ShowWindow();

		event EventHandler<DateTime> DateChanged;
		event EventHandler<OSession> StartSession;
		event EventHandler<OSession> DeleteSession;
		event EventHandler<OSession> KickNextDay;
		event EventHandler<OSession> KickPrevDay;
		event EventHandler WindowClosed;
		event EventHandler<OSession> ExtendSessionTomorrow;

		DateTime CurrentDateTime { get; }
		//event EventHandler NotifyShown;
	}
}
