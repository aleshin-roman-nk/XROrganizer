using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.BL.Entities
{
	[Table("Tasks")]
	public class OTask: Node
	{
		public int GivenSeconds { get; set; }
	}
}
