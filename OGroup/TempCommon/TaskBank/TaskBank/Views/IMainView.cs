using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIComponents;
using UIComponents.NodesNavigator;
using UIComponents.ViewComponents;

namespace TaskBank
{
	public interface IMainView
	{
		IDirectoryFilesView DirectoryFilesView { get; }
		IDirectoriesView DirectoryNavigator { get; }
	}
}