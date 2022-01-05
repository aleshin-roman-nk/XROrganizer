using SessionCollector.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.Presenters
{
	public class SingleSessionPresenter
	{
		ISingleSessionView _view;

		public SingleSessionPresenter(ISingleSessionView sess_view)
		{
			_view = sess_view;
		}
	}
}
