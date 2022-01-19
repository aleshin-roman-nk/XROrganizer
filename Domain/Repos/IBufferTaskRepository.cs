using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repos
{
	public interface IBufferTaskRepository
	{
		BufferTask Create(int ftaskId);
		IEnumerable<BufferTask> GetAll();
		void Delete(int id);
		bool Exists(int taskId);
	}
}
