using Domain.Entities;
using Shared.UI;
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
