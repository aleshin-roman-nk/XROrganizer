using SessionCollector.BL.Entities;
using SessionCollector.Forms;
using SessionCollector.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector
{
	public class SingleSessionTicker
	{
		ISessionTickerView _frm = new SessionTickerForm();

		public OSession WatchedSession { get; private set; }

		public event EventHandler<int> WatchingFinishedAndSaveSecondsRequired;
		bool _is_running = false;
		public bool IsRunning => _is_running;
		public int TotalSeconds { get; private set; }

		public SingleSessionTicker()
		{
			_frm.SaveSeconds += _frm_SaveSeconds;
			_frm.FinishedAndRejected += _frm_FinishedAndRejected;
		}

		private void _frm_FinishedAndRejected(object sender, EventArgs e)
		{
			_is_running = false;
		}

		public void StartWatching(OSession sess)
		{
			_is_running = true;
			WatchedSession = sess;
			_frm.Title = WatchedSession.ShorName;
			_frm.StartWatching(WatchedSession.TotalSeconds);
		}
		private void _frm_SaveSeconds(object sender, int e)
		{
			TotalSeconds = e;
			WatchingFinishedAndSaveSecondsRequired?.Invoke(this, e);
			_is_running = false;
		}
	}
}
