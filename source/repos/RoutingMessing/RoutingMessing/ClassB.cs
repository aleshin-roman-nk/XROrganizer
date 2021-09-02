using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutingMessing
{
	class ClassB : IClass
	{
		public string name { get; set; }
		public type t { get; set; }

		public string full_name => $"{t}::{name}";
	}
}
