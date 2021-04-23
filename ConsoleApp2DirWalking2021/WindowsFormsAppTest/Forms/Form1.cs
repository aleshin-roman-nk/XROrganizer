using DirectoriesWolking;
using DirectoriesWolking.tools;
using DrRomic.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * >>> 27-03-2021 00:58
 * При выходе из директории текущая остается та, из которой вышел.
 * 
 * 
 */

namespace WindowsFormsAppTest
{
	public partial class Form1 : Form
	{
		DirectoryNavigatorModel _dirModel;
		Forms.DirNavigatorView navigator;
		DirectoryRepository _repo;

		public Form1()
		{
			InitializeComponent();

			_repo = new DirectoryRepository();
			_dirModel = new DirectoryNavigatorModel(_repo);

			navigator = new Forms.DirNavigatorView(dataGridView1, txtPath, this);
			navigator.CommandEnterDir += Navigator_CommandEnterDir;

			navigator.SetDirImage(_dirModel.GetDataImage());
		}

		private void Navigator_CommandEnterDir(object sender, IDir e)
		{
			_dirModel.EnterDir(e);
			navigator.SetDirImage(_dirModel.GetDataImage());
		}

		// Сторона презентера
		private void btnCreatDir_Click(object sender, EventArgs e)
		{
			var _name = InputBox.GetText("Enter dirname");
			if (_name == null) return;

			var d = new Dir { id = _repo.NextId(), name = _name, owner_id = _dirModel.GetCurrentDir().id };

			_repo.Add(d);

			navigator.SetDirImage(_dirModel.GetDataImage());

			dataGridView1.Focus();
		}
	}
}
