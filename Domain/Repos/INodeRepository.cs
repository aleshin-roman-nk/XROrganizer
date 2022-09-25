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
		IEnumerable<INode> GetAllOf(INode owner, bool includeCompleted);
		IEnumerable<FTask> GetCompletedTasks(int year, int month);
		IEnumerable<INode> GetAll();
		INode Get(int id);
		void SaveRange(IEnumerable<INode> notes);
		bool HasChildren(INode d);
		bool HasSessions(INode d);

		//IEnumerable<INode> GetAllChildTasksOf(INode n);
		IEnumerable<OSession> GetTopSessions(DateTime today, int taskId, int top, int page);
		IEnumerable<INode> GetFirstLineChildren(int owner);
	}
}
