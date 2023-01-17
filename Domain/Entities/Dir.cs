using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
	[Table("Dirs")]
	public class Dir : Node
	{
		public Dir()
		{
			_type = NType.Dir;
			_canHaveChildren = true;
		}
	}
}
