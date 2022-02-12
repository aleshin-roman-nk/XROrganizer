using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using xorg.Tools;

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
		public bool IsCompleted { get; set; }

		public DateTime completed_date { get; set; }
	}
}
