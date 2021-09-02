using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp_base
{
	public class ViewResultParams<TParam, TResult>
	{
		public bool Ok { get; set; }
		public TParam Param { get; set; }
		public TResult Result { get; set; }
	}
}
