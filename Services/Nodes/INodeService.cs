using Domain.dto;
using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Services.Nodes
{
	public interface INodeService
	{
        NodeDTO CurrentOwner { get; }
		string CurrentParentFullName { get; }
        NodeDTO HighlightedNode { get; }
		void JumpBack();
		void Enter(NodeDTO n);
        NodeDTO Create(INode d);
		int Update(INode d);
		int UpdateName(NodeDTO node);
		void Delete(NodeDTO d);
		void DeleteNodeTextPage(NodeTextPage ntp);
		bool HasChildren(NodeDTO d);
		bool HasSessions(NodeDTO d);
		//void MoveNodesToDirectory(Dir owner, IEnumerable<INode> notes);
		void Move(IEnumerable<NodeDTO> notes);
		IEnumerable<NodeDTO> Items { get; }
		event EventHandler CollectionChanged;

		IEnumerable<FTask> GetCompletedTasks(int year, int month);

		IEnumerable<OSession> GetTopSessions(DateTime today, int taskId, int top, int page);

		INode GetNode(int taskId);
	}
}