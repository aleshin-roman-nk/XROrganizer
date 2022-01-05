using SessionCollector.BL.Entities;
using System;

namespace SessionCollector
{
	public interface ISingleSessionTicker
	{
		bool IsRunning { get; }
		OSession WatchedSession { get; }

		event EventHandler<int> WatchingFinishedAndSaveSecondsRequired;
		event EventHandler WatchingStoppedWithoutSave;

		OSession CollectTotalSecondsAndStop();
		void StartWatching(OSession sess);
	}
}