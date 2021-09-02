using MultipleTypesInOneTable.BL.Enities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTypesInOneTable.BL
{
	public class AppDb: DbContext
	{
		public AppDb(string cn) : base(cn)
		{

		}

		public DbSet<Node> Nodes { get; set; }
		public DbSet<NoteNode> NoteNodes { get; set; }
		public DbSet<TaskNode> TaskNodes { get; set; }
		//public DbSet<Cat> Cats { get; set; }
		public DbSet<CatLover> CatLovers { get; set; }
	}
}
