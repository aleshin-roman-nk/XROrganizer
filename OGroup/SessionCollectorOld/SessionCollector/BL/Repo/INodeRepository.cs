using SessionCollector.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.BL.Repo
{
	public interface INodeRepository
	{
		void Delete(INode e);
		IEnumerable<INode> Get();
		INode GetById(int id);
		void Save(INode e);
	}
}
