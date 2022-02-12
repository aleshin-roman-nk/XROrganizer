using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Repos
{
	public interface INodeRepository
	{
		int Save(INode o);
		INode Create(INode owner, INode n);
		void Delete(INode o);
		IEnumerable<INode> GetAll(INode owner);
		IEnumerable<INode> GetAllExcludeCompletedTask(INode owner);
		IEnumerable<FTask> GetCompletedTasks(int year, int month);
		IEnumerable<INode> GetAll();
		INode Get(int id);
		void SaveRange(IEnumerable<INode> notes);
		bool HasChildren(INode d);
		//IEnumerable<INode> GetAllChildrenOf(INode n);

		IEnumerable<INode> GetAllChildTasksOf(INode n);

		IEnumerable<OSession> GetTopSessions(DateTime today, int taskId, int top, int page);
	}
}
