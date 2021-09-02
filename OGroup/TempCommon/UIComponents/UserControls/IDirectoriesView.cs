using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonUIComponents.NodesNavigator;

namespace CommonUIComponents
{
	public interface IDirectoriesView
	{
		ITreeNavigatorView Navigator { get; }

		event EventHandler<INode> Delete;
		event EventHandler<string> Create;
	}
}
