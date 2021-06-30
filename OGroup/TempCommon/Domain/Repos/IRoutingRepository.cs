using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repos
{
	public interface IRoutingRepository
	{
		void Save(INode n);
		void Delete(INode n);
		void AddRepository(IRoutableRepository rr);
	}
}
