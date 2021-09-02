using Domain.Entities;
using InputBoxes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBank.Dlg;
using TaskBank.Dlg.forms;
using CommonUIComponents;
using CommonUIComponents.NodesNavigator;
using CommonUIComponents.ViewComponents;

namespace TaskBank
{
	public partial class MainForm : Form, IMainView
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public IFilesView DirectoryFilesView => directoryFilesViewUC1;

		public IDirectoriesView DirectoryNavigator => directoriesViewUC1;

		public event EventHandler ShowHotTasks;

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void btnHotBank_Click(object sender, EventArgs e)
		{
			ShowHotTasks?.Invoke(this, EventArgs.Empty);
		}
	}
}