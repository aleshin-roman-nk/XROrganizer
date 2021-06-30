using Domain.Entities;
using System;
using System.Collections.Generic;

namespace UIComponents.ViewComponents
{
	public interface IDirectoryFilesView
	{
		INode Current { get; }
		void DisplayFiles(IEnumerable<INode> tcollection);

		event EventHandler<IEnumerable<INode>> MoveFiles;
		event EventHandler Create;
		event EventHandler<INode> Delete;
		event EventHandler<INode> Save;
	}
}