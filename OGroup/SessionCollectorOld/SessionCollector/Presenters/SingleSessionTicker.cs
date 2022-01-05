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
	public class SingleSessionTicker : ISingleSessionTicker
	{
		ISessionTickerView _frm;

		public OSession WatchedSession { get; private set; }

		public event EventHandler<int> WatchingFinishedAndSaveSecondsRequired;
		public event EventHandler WatchingStoppedWithoutSave;
		bool _is_running = false;
		public bool IsRunning => _is_running;

		public SingleSessionTicker(ISessionTickerView f)
		{
			_frm = f;
			_frm.SaveSeconds += _frm_SaveSeconds;
			_frm.FinishedAndRejected += _frm_FinishedAndRejected;
		}

		private void _frm_FinishedAndRejected(object sender, EventArgs e)
		{
			_is_running = false;
			WatchedSession.IsTickered = false;
			WatchingStoppedWithoutSave?.Invoke(this, EventArgs.Empty);
		}
		public OSession CollectTotalSecondsAndStop()
		{
			WatchedSession.TotalSeconds = _frm.TotalSeconds;
			return WatchedSession;
		}
		public void StartWatching(OSession sess)
		{
			_is_running = true;
			WatchedSession = sess;
			WatchedSession.IsTickered = true;
			_frm.Title = WatchedSession.ShorName;
			_frm.StartWatching(WatchedSession.TotalSeconds);
		}
		private void _frm_SaveSeconds(object sender, int e)
		{
			WatchedSession.TotalSeconds = e;
			WatchedSession.IsTickered = false;
			WatchingFinishedAndSaveSecondsRequired?.Invoke(this, e);
			_is_running = false;
		}
	}
}
