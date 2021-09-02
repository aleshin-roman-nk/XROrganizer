using EntityFrameworkJoin.BL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkJoin.BL.Db
{
	public class AppData: DbContext
	{
		public AppData(string cn): base(cn)
		{

		}

		public DbSet<Note> Notes { get; set; }
		public DbSet<Node> Nodes { get; set; }
	}
}
