namespace TaskBank.Views
{
	public class ViewResult<T>
	{
		public ViewResult(T t, bool accept)
		{
			accepted = accept;
			Output = t;
		}

		public bool accepted { get; set; }
		public T Output { get; set; }
	}

}
