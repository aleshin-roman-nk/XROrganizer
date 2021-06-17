using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIComponents.NodesNavigator;

namespace TaskBank
{
	public interface IMainView
	{
		event EventHandler NewTask;
		event EventHandler<Note> SaveTask;
		event EventHandler<Note> DeleteTask;

		event EventHandler<string> CreateDir;
		event EventHandler<Dir> DeleteDir;
		void DisplayTaskCollection(IEnumerable<Note> tlist);

		INodeNavigatorView DirNavigator { get; }

		INodeNavigatorView TargetDirs { get; }
	}
}
