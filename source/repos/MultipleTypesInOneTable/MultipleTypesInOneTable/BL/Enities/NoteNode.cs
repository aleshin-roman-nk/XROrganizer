using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTypesInOneTable.BL.Enities
{
	[Table("NoteNodes")]
	public class NoteNode : Node
	{
		public string description { get; set; }
		public NoteNode()
		{
			type = "note";
		}
	}
}
