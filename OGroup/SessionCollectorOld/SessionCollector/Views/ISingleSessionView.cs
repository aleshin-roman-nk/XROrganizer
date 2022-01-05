using mvp_base;
using SessionCollector.BL.Entities;
using System;

namespace SessionCollector.Views
{
	public interface ISingleSessionView
	{
		void Go(OSession o);
		event EventHandler<ViewRequest<OSession, INode>> ChangeDirectory;
		event EventHandler<ViewResponse<OSession>> WorkCompleted;
		event EventHandler<OSession> SaveRequired;

		bool IsWorking { get; }
		//void SetOwner(INode o);
	}
}
