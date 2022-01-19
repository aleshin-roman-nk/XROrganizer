using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.UI.Interfaces
{
	public interface IDescriptionView
	{
		void Put(INode n);
		event EventHandler<INode> Save;
	}
}
