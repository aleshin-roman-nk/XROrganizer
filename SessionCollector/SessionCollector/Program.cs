using Domain.DBContext;
using Domain.Repos;
using Services.Sessions;
using SessionCollector.Forms;
using SessionCollector.Views;
using Shared.UI;
using Shared.UI.Forms;
using System;
using System.Windows.Forms;
using Unity;
using xorg.Tools;

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

			container
				.RegisterType<ISCMainView, SCMainForm>()
				.RegisterType<ISessionService, SessionService>()
				.RegisterType<ISessionRepository, SessionRepository>()
				.RegisterType<IAppDataContextFactory, AppDataContextFactory>()
				.RegisterInstance(dbConf)
				.RegisterType<IStataView, StataForm>();

			// >>> 19-09-2021 22:23
			// Нужно добавить в контейнер экземпляр хаба презентеров.
			// В этом месте регистрируются все необходимые презентеры.


			var servicePresentersContainer = new UnityContainer();

			SessionManagerMainPresenter presenter = (SessionManagerMainPresenter)container.Resolve(typeof(SessionManagerMainPresenter));

			Application.Run();
		}
	}
}
