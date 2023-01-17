using Domain.dto;
using Domain.Entities;
using System;
using System.Collections.Generic;

namespace Domain.Repos
{
	public interface INodeRepository
	{
		int Update(INode o);
		void Delete(NodeDTO o);
		void DeleteNodeTextPage(NodeTextPage ntp);
		IEnumerable<FTask> GetCompletedTasks(int year, int month);
		INode Get(int id);
		void UpdateDNA();
		int UpdateName(NodeDTO node);

        ForParentNode AsParent(NodeDTO n);
    }
}
