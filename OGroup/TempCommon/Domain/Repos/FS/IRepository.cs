using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Repos
{
	public interface IRepository
	{
		void Save(INode o);
		INode Create(INode owner, INode n);
		void Delete(INode o);
		IEnumerable<INode> GetFiles(INode owner);
		IEnumerable<INode> GetDirs(INode owner);
		void SaveRange(IEnumerable<INode> notes);
		bool HasChildren(INode d);
	}
}
