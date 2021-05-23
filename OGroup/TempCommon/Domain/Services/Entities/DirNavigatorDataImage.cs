using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Entities
{
	public class DirNavigatorDataImage
	{
		public IEnumerable<INode> CurrentBranch { get; set; }
		public LastMovment LastMovment { get; set; }
		public string CurrentBranchName { get; set; }
		public INode PreviousOwner { get; set; }
		public INode CurrentDir { get; set; }
	}
}
