using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Entities
{
	public class TaskBankImage
	{
		public NodeNavigatorImage NodesNavigatorImage { get; set; }
		public IEnumerable<Note> NotesCollection { get; set; }
	}
}
