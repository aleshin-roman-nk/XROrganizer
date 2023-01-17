using Domain.dto;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.UI.Interfaces
{
	public interface IBufferTaskView
	{
		void Go(IEnumerable<BufferTask> bufferTasks);
		event EventHandler<NodeDTO> CreateSession;
		event EventHandler Completed;
		event EventHandler<BufferTask> Delete;
		void Update(IEnumerable<BufferTask> bufferTasks);
	}
}
