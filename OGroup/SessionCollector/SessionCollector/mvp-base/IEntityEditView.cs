using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvp_base
{
	public interface IEntityEditView<TEntity>
	{
		ViewResult<TEntity> Go(TEntity e);
	}
}
