using Domain.Entities;
using Shared.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.UI
{
	public interface IFTaskEditView
	{
		void Go(FTask o, Action<ViewResponse<FTask>> resultHandler);
		void AddProperty(string name, string value);
	}
}
