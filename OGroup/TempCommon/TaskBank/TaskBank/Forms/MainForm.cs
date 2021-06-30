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
using UIComponents;
using UIComponents.NodesNavigator;
using UIComponents.ViewComponents;

namespace TaskBank
{
	public partial class MainForm : Form, IMainView
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public IDirectoryFilesView DirectoryFilesView => throw new NotImplementedException();

		public IDirectoriesView DirectoryNavigator => directoriesViewUC1;

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
	}
}