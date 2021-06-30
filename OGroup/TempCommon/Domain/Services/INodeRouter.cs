using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
	public interface INodeRouter
	{
		void Dispatch(INode n);
		void AddModule(NType t, INodeHandlerModule m);
	}
}
