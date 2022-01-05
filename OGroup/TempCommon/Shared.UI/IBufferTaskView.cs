using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.UI
{
	public interface IBufferTaskView
	{
		void Display(IEnumerable<BufferTask> bufferTasks);
		//INode SelectNode(IEnumerable<BufferTask> bufferTasks);
		event EventHandler<INode> CreateSession;
	}
}
