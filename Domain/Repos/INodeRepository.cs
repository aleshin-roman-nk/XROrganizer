using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Repos
{
	public interface INodeRepository
	{
		int Update(INode o);
		//INode Create(INode owner, INode n);
		void Delete(INode o);
		IEnumerable<INode> GetAllOf(INode owner, bool includeCompleted);
		IEnumerable<FTask> GetCompletedTasks(int year, int month);
		IEnumerable<INode> GetAll();
		INode Get(int id);
		bool HasChildren(INode d);
		bool HasSessions(INode d);
		
		IEnumerable<INode> GetFirstLineChildren(int owner);

		void UpdateDNA();
		ForParentNode AsParent(INode n);
    }
}
