using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;


namespace Domain.DBContexts
{
	public class MainContext: DbContext
	{
		public MainContext(string cn) : base(cn)
		{

		}

		public DbSet<OTask> OTasks { get; set; }
		public DbSet<ODirectiry> ODirectiries { get; set; }
	}
}
