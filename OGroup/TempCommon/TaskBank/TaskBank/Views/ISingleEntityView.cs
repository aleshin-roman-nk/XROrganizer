

using Domain.Entities;

namespace TaskBank.Views
{
	public interface ISingleEntityView<T>
	{
		ViewResult<T> Go(OTask tsk);
	}
}
