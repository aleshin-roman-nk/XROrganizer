using SessionCollector.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector
{
	public interface IMainView
	{
		void DisplaySessions(IEnumerable<OSession> list, decimal hours, decimal doneHrs, DateTime? endofday);

		event EventHandler<DateTime> CreateSession;
		event EventHandler<DateTime> DateChanged;
		event EventHandler<DateTime> OrderAndAlign;
		event EventHandler<OSession> EditSession;
		event EventHandler<OSession> DeleteSession;
		event EventHandler<OSession> StartSessionTick;
		event EventHandler<DateTime> ShowStata;
		event EventHandler<OSession> KickNextDay;
		event EventHandler<OSession> KickPrevDay;

		bool UserAnsweredYes(string qstr);
		void ShowMessage(string msg);

		DateTime CurrentDateTime { get; }
		//event EventHandler NotifyShown;
	}
}
