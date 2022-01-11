using Shared.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Presenters
{
	public interface IEntityInstanceWindow<TEntity>
	{
		int ObjId { get; }
		void Show();
		void Restore();
		event EventHandler<ViewResponse<TEntity>> Completed;
	}
}
