using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SessionCollector.BL.Entities
{
	[Table("Directories")]
	public class ODirectory
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}
}
