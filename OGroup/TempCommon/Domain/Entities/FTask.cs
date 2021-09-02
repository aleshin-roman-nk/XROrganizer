using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	[Table("Tasks")]
	public class FTask : Node
	{
		public FTask()
		{
			_type = NType.Task;
		}

		public int GivenSeconds { get; set; }
		public TaskState State { get; set; }
	}
}
