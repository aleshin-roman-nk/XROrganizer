using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoriesWolking.Models.DirNavigator
{
	// Один образ состояние. При любом изменении, образ задается новый. Или просто меняются переменные образа по запросу view
	public class DirNavigatorDataImage
	{
		public IEnumerable<IDir> CurrentBranch { get; set; }
		public LastMovment LastMovment { get; set; }
		public string CurrentBranchName { get; set; }
		public IDir PreviousOwner { get; set; }
		public IDir CurrentDir { get; set; }
	}
}
