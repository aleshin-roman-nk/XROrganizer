using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTest.DirNavigator
{
	public class HostRequest
	{
		object response;
		// Presenter sets response
		public void SetResponse(object data)
		{
			response = data;
		}
		// Presenter observes requests
		public event Action<object> RequestEvent;
		// view вызывает запрос
		public object Request(object arg)
		{
			RequestEvent?.Invoke(arg);
			return response;
		}
	}
}
