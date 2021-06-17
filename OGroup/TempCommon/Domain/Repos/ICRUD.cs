using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repos
{
	public interface ICRUD<T>
		where T: class
	{
		void ExecOp(T o, CRUDOperation op);

		void Save(T o);
		//void Read(Func<IEnumerable<T>, >);
	}
}
