namespace UIComponents
{
	public class ViewResult<T>
	{
		public ViewResult(T t, bool accept)
		{
			accepted = accept;
			Result = t;
		}

		public bool accepted { get; set; }
		public T Result { get; set; }
	}
}
