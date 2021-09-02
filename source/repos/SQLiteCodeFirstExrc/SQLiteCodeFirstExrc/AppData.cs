using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteCodeFirstExrc
{
	public class AppData: DbContext
	{
		public AppData(string cn) : base(cn)
		{

		}

		public DbSet<Employeer> Employeers { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			var sqliteConnectionInitializer = new SqliteDropCreateDatabaseWhenModelChanges<AppData>(modelBuilder);
			Database.SetInitializer(sqliteConnectionInitializer);
		}
	}

	public class AppDataInitializer : SqliteDropCreateDatabaseWhenModelChanges<AppData>
	{
		public AppDataInitializer(DbModelBuilder modelBuilder)
			: base(modelBuilder, typeof(CustomHistory))
		{ }
	}

	public class CustomHistory : IHistory
	{
		public int Id { get; set; }
		public string Hash { get; set; }
		public string Context { get; set; }
		public DateTime CreateDate { get; set; }
	}
}
