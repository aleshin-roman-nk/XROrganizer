using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoriesWolking.Models.DirNavigator
{
	// Один образ состояние. При любом изменении, образ задается новый. Или просто меняются переменные образа по запросу view
	public class NodesImage
	{
		public IEnumerable<INode> CurrentBranch { get; set; }
		public string CurrentBranchName { get; set; }
		public INode CurrentOwner { get; set; }
		public INode HighlightedDir { get; set; }
	}
}
