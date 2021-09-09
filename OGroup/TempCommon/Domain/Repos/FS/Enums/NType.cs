using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
	public enum NType
	{
		none = -100,
		exit_dir = -3,
		_sys_root_dir = -2,
		Dir = 0,
		Task = 1,
		Note = 2,
		Session = 3,
		ComplexSession = 4
	}
}
