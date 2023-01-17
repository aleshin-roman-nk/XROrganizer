using Domain.Entities;
using System.Data.Entity;

namespace Domain.DBContext
{
	public class AppData: DbContext
	{
		public AppData(string cn) : base(cn)
		{

		}

		public DbSet<OSession> Sessions { get; set; }
		public DbSet<Node> Nodes { get; set; }
		public DbSet<FNote> Notes { get; set; }
		public DbSet<Dir> Dirs { get; set; }
		public DbSet<FTask> Tasks { get; set; }
		public DbSet<BufferTask> BufferTasks { get; set; }
		public DbSet<NodeTextPage> NodeTextPages { get; set; }
	}
}
