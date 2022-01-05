using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.Views
{
	public interface ISessionTickerView
	{
		bool IsRunning { get; }
		int TotalSeconds { get; }
		event EventHandler<int> SaveSeconds;
		event EventHandler FinishedAndRejected;
		void StartWatching(int sec);
		string Title { get; set; }
	}
}
