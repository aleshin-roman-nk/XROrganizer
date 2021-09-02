using Domain.Repos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBank.Dlg.forms;
using TaskBank.Presenters;
using Unity;

namespace TaskBank
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			String thisprocessname = Process.GetCurrentProcess().ProcessName;

			if (Process.GetProcesses().Count(p => p.ProcessName == thisprocessname) > 1)
			{
				MessageBox.Show("I am already running =)");

				return;
			}

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			IUnityContainer container = new UnityContainer();



			Domain.Tools.Debugger.init();

			MainForm mf = new MainForm();
			RmTaskForm tf = new RmTaskForm();

			MainPresenter pr = new MainPresenter(mf);

			Application.Run(mf);
		}
	}
}
