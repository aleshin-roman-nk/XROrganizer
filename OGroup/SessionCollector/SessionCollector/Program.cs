using SessionCollector.BL;
using SessionCollector.BL.Db;
using SessionCollector.BL.Repo;
using SessionCollector.BL.Services;
using SessionCollector.Forms;
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

			container.RegisterType<IMainView, MainForm>()
				.RegisterType<ISessionView, SessionForm>()
				.RegisterType<IMainRepository, MainRepository>()
				.RegisterType<IService, Services>()
				.RegisterType<IDirectoriesView, DirectoriesForm>()
				.RegisterType<IDbConf, DbConf>()
				.RegisterType<IStataView, StataForm>();

			MainPresenter presenter = (MainPresenter)container.Resolve(typeof(MainPresenter));

			Application.Run((Form)presenter.MainView);
		}
	}
}
