using Domain.Entities;
using Shared.UI;
using System;

namespace Shared.UI.Interfaces
{
	public interface ISingleSessionView
	{
		int ObjId { get; }
		void Go(OSession o);
		void Restore();

		event EventHandler Completed;
		event EventHandler<OSession> Save;
		event EventHandler<Node> OpenOwner;
	}
}
