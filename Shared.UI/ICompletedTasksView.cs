using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.UI
{
	public interface ICompletedTasksView
	{
		void Display(IEnumerable<INode> nodes);
	}
}
