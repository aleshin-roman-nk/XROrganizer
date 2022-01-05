using SessionCollector.BL;
using SessionCollector.BL.Db;
using SessionCollector.BL.Repo;
using SessionCollector.BL.Services;
using SessionCollector.Forms;
using SessionCollector.Presenters;
using SessionCollector.Tools;
using SessionCollector.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace SessionCollector
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Logger.Clear();

			IUnityContainer container = new UnityContainer();

			IDbConf dbConf = new DbConf();

			container.RegisterType<IMainView, MainForm>()
				.RegisterType<ISingleSessionView, SessionForm>()
				.RegisterType<ISessionService, SessionService>()
				.RegisterType<ISessionTickerView, SessionTickerForm>()
				.RegisterType<IDirectoriesView, DirectoriesForm>()
				.RegisterType<ISessionRepository, SessionRepository>()
				.RegisterType<INodeRepository, NodeRepository>()
				.RegisterType<IDirectoriesService, DirectoriesService>()
				.RegisterType<IAppDataContextFactory, AppDataContextFactory>()
				.RegisterType<IDirectorySelectorBoxPresenter, DirectorySelectorBoxPresetner>()
				.RegisterType<ISingleSessionTicker, SingleSessionTicker>()
				//.RegisterType<IDbConf, DbConf>()
				.RegisterInstance(dbConf)
				.RegisterType<IStataView, StataForm>()
				.RegisterInstance<IUnityContainer>(container);

			// >>> 19-09-2021 22:23
			// Нужно добавить в контейнер экземпляр хаба презентеров.
			// В этом месте регистрируются все необходимые презентеры.


			var servicePresentersContainer = new UnityContainer();

			MainPresenter presenter = (MainPresenter)container.Resolve(typeof(MainPresenter));

			Application.Run((Form)presenter.MainView);

			presenter.CloseApplication();
		}
	}
}
