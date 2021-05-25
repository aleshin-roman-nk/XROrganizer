using DirectoriesWolking.Models.DirNavigator;
using DirectoryNavigator;
using DrRomic.Dialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsAppTest.DirNavigator;
using WindowsFormsAppTest.FormComponent;


namespace WindowsFormsAppTest
{
	public partial class Form1 : Form
	{
		DirectoryNavigatorService _dirModel;
		DirNavigatorView navigator;
		NodeRepository _repo;

		public Form1()
		{
			InitializeComponent();
		}

		private void Navigator_ExitDir(object sender, EventArgs e)
		{
			_dirModel.JumpBack();
		}

		private void Navigator_EnterDir(object sender, INode e)
		{
			// Эмуляция модуля работы с задачей.
			// Модуль маршрутизации может быть выполнен в виде словаря, ключ - тип узла, значение - лямбдя, принимающая узел
			// Но мне наверное больше удобно, чтобы задачи выводились в отдлельное окно.
			//	Задачи, заметки, проблемы - в одном окне.
			if (e.type == NType.task)
			{
				MessageBox.Show(e.name);
			}
			else if (e.type == NType.dir || e.type == NType.exit_dir)
			{
				_dirModel.EnterDir(e);
			}
		}

		// Сторона презентера
		private void btnCreatDir_Click(object sender, EventArgs e)
		{
			var _name = InputBox.GetText("Enter dirname");
			if (_name == null) return;

			// Недопустимо так создавать. Определить фабрику, создавать определенные ноды.
			// Иначе могу что то нето создать, что внесет сбой в алгоритмах.
			var d = new Dir { id = _repo.NextId(), name = _name, owner_id = _dirModel.CurrentOwner.id };

			_repo.Add(d);

			_dirModel.Update();

			dataGridView1.Focus();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_repo = new NodeRepository();// Лучше интерфейс, который только для чтения, чтобы быть уверенным, и очевидно, что сервис не меняет данные. А добавленир, сохранение, а потом обновление сервиса.
			_dirModel = new DirectoryNavigatorService(_repo);

			IconProvider img = new IconProvider(
				"..\\img\\icons8-folder-24.png",
				"..\\img\\icons8-task-24.png",
				"..\\img\\icons8-arrow-up-24.png");

			navigator = new DirNavigatorView(dataGridView1, txtPath);
			navigator.ActivateNode += Navigator_EnterDir;
			navigator.ExitNode += Navigator_ExitDir;
			navigator.Icons = new Dictionary<NType, Image> {
				{ NType.dir, img.Folder },
				{ NType.task, img.LTask },
				{ NType.exit_dir, img.OutFolder }
			};
			navigator.RowColors = new Dictionary<NType, Color> { { NType.task, Color.Red} };

			_dirModel.CurrentNodeChanged += _dirModel_CurrentNodeChanged;

			_dirModel.Update();
		}

		private void _dirModel_CurrentNodeChanged(object sender, NodesImage e)
		{
			navigator.SetDirImage(e);
		}

		private void btnHideIcons_Click(object sender, EventArgs e)
		{
			navigator.Icons = null;
		}

		private void btnShowIcons_Click(object sender, EventArgs e)
		{
			IconProvider img = new IconProvider(
				"..\\img\\icons8-folder-24.png",
				"..\\img\\icons8-task-24.png",
				"..\\img\\icons8-arrow-up-24.png");

			navigator.Icons = new Dictionary<NType, Image> {
				{ NType.dir, img.Folder },
				{ NType.task, img.LTask },
				{ NType.exit_dir, img.OutFolder }
			};
		}
	}
}
