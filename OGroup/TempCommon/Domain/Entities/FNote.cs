using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	[Table("Notes")]
	public class FNote : Node
	{
		public FNote()
		{
			_type = NType.Note;
		}

		public string MiniText
		{
			get
			{
				if (description == null) return "";
				int lenght = description.Length > 100 ? 100 : description.Length;
				return description.Substring(0, lenght) + "...";
			}
		}

	}
}
