using Domain.Entities;
using System.Collections.Generic;


namespace Domain.Repos
{
	public interface IRmTaskRepository
	{
		void Delete(OTask t);
		IEnumerable<OTask> GetAll();
		void Save(OTask t);
	}
}