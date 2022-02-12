using Domain.Entities;
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
				if (text == null) return "";
				int lenght = text.Length > 100 ? 100 : text.Length;
				return text.Substring(0, lenght) + "...";
			}
		}

	}
}
