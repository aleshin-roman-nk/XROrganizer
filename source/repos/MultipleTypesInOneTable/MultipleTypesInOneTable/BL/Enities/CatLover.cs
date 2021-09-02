using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTypesInOneTable.BL.Enities
{
	[Table("CatLovers")]
	public class CatLover: Node
	{
		public CatLover()
		{
			Cats = new List<Cat>();
		}
		//public virtual ICollection<Cat> Cats { get; set; }
		public ICollection<Cat> Cats { get; set; }
	}
}
