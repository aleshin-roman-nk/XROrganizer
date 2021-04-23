using TaskBank.BL.Entities;

namespace TaskBank.Views
{
	public interface ISingleEntityView<T>
	{
		ViewResult<T> Go(RmTask tsk);
	}
}
