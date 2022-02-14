using Domain.Entities;
using Shared.UI;
using Shared.UI.Interfaces.Enums;
using System;

namespace Shared.UI.Interfaces
{
	public interface ISingleSessionView
	{
		int ObjId { get; }
		void Go(OSession o);
		void Restore();

		void SetWorkingSesionPlayState(WorkingSessionPlayState st);
		//WorkingSessionPlayState workingSessionPlayState { get; }

		event EventHandler Completed;
		event EventHandler<OSession> Save;
		event EventHandler<Node> OpenOwner;
		event EventHandler<WorkingSessionPlayState> SessionWindowWorkStateChanged;
	}
}
