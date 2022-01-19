using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.UI.Interfaces
{
	public interface ICompletedTasksView
	{
		void Display(IEnumerable<INode> nodes);
		event EventHandler<DateTime> DateChanged;
		event EventHandler<INode> OpenNode;
		event EventHandler Completed;
		DateTime CurrentDate { get; }
	}
}
