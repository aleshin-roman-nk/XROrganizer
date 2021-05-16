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
		void DisplaySessions(IEnumerable<OSession> list, decimal hours, DateTime? endofday);

		event EventHandler<DateTime> CommandCreateSession;
		event EventHandler CommandSaveDayImage;
		event EventHandler<DateTime> CommandDateChanged;
		event EventHandler<DateTime> CommandOrderAndAlign;
		event EventHandler<OSession> CommandWorkSession;
		event EventHandler<OSession> CommandDeleteSession;
		event EventHandler<OSession> CommandStartSessionTick;

		bool UserAnsweredYes(string qstr);
		void ShowMessage(string msg);

		DateTime CurrentDateTime { get; }
		//event EventHandler NotifyShown;
	}
}
