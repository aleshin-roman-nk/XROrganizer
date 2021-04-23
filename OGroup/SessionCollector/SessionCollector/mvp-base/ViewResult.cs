using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp_base
{
	public class ViewResult<TData>
	{
		public bool Accept { get; set; }
		public TData Data { get; set; }
	}
}
