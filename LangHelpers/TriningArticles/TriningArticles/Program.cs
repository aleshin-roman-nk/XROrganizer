using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TriningArticles.BL.Repo;
using TriningArticles.BL.tools;
using TriningArticles.Presenters;
using Unity;

namespace TriningArticles
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

			logservices.init();

			UnityContainer container = new UnityContainer();
			container.RegisterType<IRepository, Repository>();
			container.RegisterType<IMainView, MainForm>();

			//var presenter = container.Resolve<MainPresenter>();// Проблема была в том, что конструктор Repository принимал строку



			//logservices.writelog("program has been started");

			Application.Run(new MainForm());
		}
	}
}
