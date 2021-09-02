using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTypesInOneTable.BL.Enities
{
	public class Cat
	{
		public int id { get; set; }
		public string name { get;set;}
		public int CatLoverId { get; set; }
		//public virtual CatLover CatLover { get; set; }
	}
}
