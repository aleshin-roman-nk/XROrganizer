using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIComponents.NodesNavigator;

namespace UIComponents
{
	public interface IDirectoriesView
	{
		ITreeNavigatorView Navigator { get; }

		event EventHandler<INode> Delete;
		event EventHandler<string> Create;
	}
}
