using Domain.Entities;
using System.Collections.Generic;

namespace Domain.Repos
{
	public interface INodeRepository
	{
		void Save(INode o);
		INode Create(INode owner, INode n);
		void Delete(INode o);
		IEnumerable<INode> GetAll(INode owner);
		IEnumerable<INode> GetAll();
		INode Get(int id);
		void SaveRange(IEnumerable<INode> notes);
		bool HasChildren(INode d);
		IEnumerable<INode> GetAllChildrenOf(INode n);
	}
}
