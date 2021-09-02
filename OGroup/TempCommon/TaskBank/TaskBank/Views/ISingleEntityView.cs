using Domain.Entities;
using UIComponents;

namespace TaskBank.Views
{
	public interface ISingleEntityView<T>
	{
		ViewResult<T> Go(T tsk);
	}
}
