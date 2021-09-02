using LngModules.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LngModules.Domain.Entities
{
	public class Phrase
	{
		public int id { get; set; }
		public string text { get; set; }
		public LngCode lang { get; set; }
	}
}
