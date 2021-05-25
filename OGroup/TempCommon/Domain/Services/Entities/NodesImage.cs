using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Entities
{
	public class NodesImage
	{
		public IEnumerable<INode> CurrentBranch { get; set; }
		public string CurrentBranchName { get; set; }
		public INode CurrentOwner { get; set; }
		public INode HighlightedDir { get; set; }
	}
}
