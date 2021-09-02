using LngModules.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LngModules.Domain
{
	public class ModuleModel
	{
		public StudyModule Module { get; set; }
		public IEnumerable<Sentence> Sentences { get; set; }

		public void Save()
		{

		}
		public 
	}
}
