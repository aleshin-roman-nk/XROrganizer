using System.Collections.Generic;
using TaskBank.BL.Entities;

namespace TaskBank.BL.Repos
{
	public interface IRmTaskRepository
	{
		void Delete(RmTask t);
		IEnumerable<RmTask> GetAll();
		void Save(RmTask t);
	}
}