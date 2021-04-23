using SessionCollector.BL;
using SessionCollector.BL.Db;
using SessionCollector.BL.Services;
using SessionCollector.Forms;
using SessionCollector.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

			var m = new MainForm();
			var s = new SessionForm();
			var r = new MainRepository(@"Data Source=..\db\sessions.db");// забыл написать Data Source ))))))
			var ss = new Services();

			MainPresenter presenter = new MainPresenter(m, s, r, ss);

			Application.Run(m);
		}
	}
}
