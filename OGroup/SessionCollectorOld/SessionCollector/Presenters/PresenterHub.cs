using mvp_base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace SessionCollector.Presenters
{
	public class PresenterHub
	{
		//public ViewResult<object> Request();

		IUnityContainer _container;

		public PresenterHub(IUnityContainer container)
		{
			_container = container;
		}

		public IDirectorySelectorBoxPresenter CreateDirectoryDialogBox()
		{
			return _container.Resolve<IDirectorySelectorBoxPresenter>();
		}
		public ISessionDialogBox CreateSessionDialogBox()
		{
			return _container.Resolve<ISessionDialogBox>();
		}
	}
}
