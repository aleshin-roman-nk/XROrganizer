using Domain.Entities;
using Domain.Repos;
using System;
using System.Collections.Generic;

namespace Domain.Services.Directory
{
	public interface IDirectoriesService
	{
		INode Parent { get; }
		string CurrentParentFullName { get; }
		INode HighlightedNode { get; }
		void JumpBack();
		void Enter(INode n);
		void Create(Dir d);
		void Update();
		void Save(Dir d);
		void Delete(Dir d);
		bool HasChildren(INode d);
		IEnumerable<INode> Items { get; }
		event EventHandler CollectionChanged;
	}
}