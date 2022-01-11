using Domain.Entities;
using Shared.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.UI
{
	public interface IFTaskEditView: IEntityInstanceWindow<FTask>
	{
		void Go(FTask o, Action<ViewResponse<FTask>> workCompletedHandlr, Action<FTask> saveTaskHndlr);
		void AddProperty(string name, string value);
	}
}
