using Domain.Entities;
using Shared.UI.Interfaces;
using Shared.UI.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBank.Views
{
	public interface IMainView: IStickable
	{
		INodesView NodesView { get; }
		event EventHandler StartDesriptionForm;
		event EventHandler StartCurrentBuffer;
		event EventHandler StartSessionCollector;
		event EventHandler StartWindowCompletedNodes;
		event EventHandler StartStatisticWindow;
		event EventHandler DeleteNode;
		event EventHandler CreateNode;
		event EventHandler RenameNode;
		event EventHandler CreateSession;
		event EventHandler RestoreWorkingSessionWindow;
		event EventHandler PutTaskToBuffer;
		int OpenedTasksCout { get; set; }
		bool SessionState { get; set; }
		int ClipboardNodesCount { get; set; }
	}
}
