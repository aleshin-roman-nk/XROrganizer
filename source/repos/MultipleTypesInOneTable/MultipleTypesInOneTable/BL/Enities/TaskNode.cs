using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleTypesInOneTable.BL.Enities
{
	[Table("TaskNodes")]
	public class TaskNode: Node
	{
		public int AllotedTime { get; set; }
		public TaskNode()
		{
			type = "task";
		}
	}
}
