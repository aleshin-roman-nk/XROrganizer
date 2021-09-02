using ManyToManyExrc.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyExrc
{
	public class AppData: DbContext
	{
		public AppData(string cn) : base(cn)
		{

		}

	}
}
