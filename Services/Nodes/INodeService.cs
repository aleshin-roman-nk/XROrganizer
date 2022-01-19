using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Services.Nodes
{
	public interface INodeService
	{
		INode CurrentOwner { get; }
		string CurrentParentFullName { get; }
		INode HighlightedNode { get; }
		void JumpBack();
		void Enter(INode n);
		INode Create(INode d);
		void Save(INode d);
		void Delete(INode d);
		bool HasChildren(INode d);
		void MoveNodesToDirectory(Dir owner, IEnumerable<INode> notes);
		IEnumerable<INode> Items { get; }
		event EventHandler CollectionChanged;

		IEnumerable<FTask> GetCompletedTasks(int year, int month);

		IEnumerable<OSession> GetTopSessions(DateTime today, int taskId, int top, int page);
	}
}