using DirectoriesWolking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTest.DirNavigator
{
	public class EnterDirEventArg : EventArgs
	{
		public Dir Dir { get; set; }
		public EnterDirEventArg(Dir d)
		{
			Dir = d;
		}
		public LastMovment LastMovment { get; set; }
	}
}
