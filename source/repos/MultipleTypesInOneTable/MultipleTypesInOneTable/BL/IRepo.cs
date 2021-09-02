using MultipleTypesInOneTable.BL.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleTypesInOneTable.BL
{
	public interface IRepo
	{
		IEnumerable<INode> GetAll();
		void Save(INode n);
		void Kill(INode n);
		void Create(INode n);
	}
}
