using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.UI
{
	public class ViewResponse<TData>
	{
		public bool Ok { get; set; }
		public TData Data { get; set; }
	}
}
