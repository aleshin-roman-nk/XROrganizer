using System.Collections.Generic;
using TaskBank.BL.Entities;

namespace TaskBank.BL.Repos
{
	public interface IRmTaskRepository
	{
		void Delete(OTask t);
		IEnumerable<OTask> GetAll();
		void Save(OTask t);
	}
}