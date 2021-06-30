using Domain.Entities;
using Domain.Enums;
using System.Collections;
using System.Collections.Generic;

namespace Domain.Repos
{
	public interface IRoutableRepository
	{
		NType NodeType { get; }
		void Save(INode n);
		void Delete(INode n);
		IEnumerable<INode> GetByParent(INode n);
	}
}