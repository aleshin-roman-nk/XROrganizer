using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using SessionCollector.BL.Entities;

namespace SessionCollector.BL.Db
{
	public class AppData: DbContext
	{
		public AppData(string cn) : base(cn)
		{

		}

		public DbSet<ODirectory> Directories { get; set; }
		public DbSet<OSession> Sessions { get; set; }
	}
}
