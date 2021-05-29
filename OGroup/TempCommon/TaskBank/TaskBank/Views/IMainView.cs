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
		event EventHandler<DateTime> NewTask;
		event EventHandler<Note> SaveTask;
		event EventHandler<Note> DeleteTask;
		event EventHandler<string> CreateDir;
		void DisplayTaskCollection(IEnumerable<Note> tlist);

		IDirNavigatorView DirNavigator { get; }
	}
}
