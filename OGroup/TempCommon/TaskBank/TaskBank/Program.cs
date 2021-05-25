using Domain.Repos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBank.Dlg.forms;

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

			Domain.Tools.Debugger.init();

			MainForm mf = new MainForm();
			RmTaskRepository r = new RmTaskRepository();
			RmTaskForm tf = new RmTaskForm();

			MainPresenter pr = new MainPresenter(mf, r, tf);

			Application.Run(mf);
		}
	}
}
