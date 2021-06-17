using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Entities
{
	public class NodeNavigatorImage
	{
		public IEnumerable<INode> CurrentBranch { get; set; }
		public string CurrentDirFullName { get; set; }
		public INode CurrentOwner { get; set; }
		public INode HighlightedDir { get; set; }
	}
}
