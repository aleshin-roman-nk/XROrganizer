using Domain.Entities;
using Shared.UI;
using Shared.UI.Interfaces.EventArgsDefinition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.UI.Interfaces
{
	public interface IFTaskEditView
	{
		void Go(FTask o);

		int ObjId { get; }
		void Restore();
		event EventHandler Completed;
		event EventHandler<FTask> Save;
		event EventHandler<DisplaySessionsPageEventArg> ShowTopSessions;
	}
}
