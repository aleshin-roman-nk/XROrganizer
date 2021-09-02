using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp_base
{
	public class ViewRequest<TData, TResult>
	{
		public bool Ok { get; set; }
		public TData Data { get; set; }
		public TResult Result { get; set; }
	}
}
