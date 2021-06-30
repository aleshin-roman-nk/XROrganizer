using Domain.Entities;
using Domain.Enums;
using Domain.Services.Entities;
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
using UIComponents.NodesNavigator;

namespace UIComponents.UserControls
{
	public partial class DirectoriesViewUC : UserControl, IDirectoriesView
	{
		ITreeNavigatorView _viewNavigator;
		
		public DirectoriesViewUC()
		{
			InitializeComponent();

			_viewNavigator = new TreeNavigatorView(dgvDirectories, txtDirectoryFullName);
		}

		public ITreeNavigatorView Navigator => _viewNavigator;

		public event EventHandler<INode> Delete;
		public event EventHandler<string> Create;

		private void btnNewDir_Click(object sender, EventArgs e)
		{
			var str = InputBox.Show("Enter new directory name");
			if (!string.IsNullOrEmpty(str))
				Create?.Invoke(this, str);
		}

		private void btnDeleteDir_Click(object sender, EventArgs e)
		{
			if (_viewNavigator.CurrentNode == null) return;
			if (InputBox.UserAnsweredYes($"Directory '{_viewNavigator.CurrentNode.name}' will be removed. Are you sure?"))
				Delete?.Invoke(this, _viewNavigator.CurrentNode);
		}
	}
}
