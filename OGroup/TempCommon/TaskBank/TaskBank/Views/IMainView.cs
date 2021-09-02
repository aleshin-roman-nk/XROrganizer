using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonUIComponents;
using CommonUIComponents.NodesNavigator;
using CommonUIComponents.ViewComponents;

namespace TaskBank
{
	public interface IMainView
	{
		IFilesView DirectoryFilesView { get; }
		IDirectoriesView DirectoryNavigator { get; }
		event EventHandler ShowHotTasks;
	}
}