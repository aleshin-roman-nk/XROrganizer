using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutingMessing
{
	public interface IModule
	{
		void Save(IClass o);
		void Delete(IClass o);
	}
}
