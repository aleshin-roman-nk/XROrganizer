using DirectoriesWolking.Models.DirNavigator;
using DirectoryNavigator;
using DrRomic.Dialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsAppTest.DirNavigator;
using WindowsFormsAppTest.FormComponent;

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


		DirectoryNavigatorService _dirModel;
		DirNavigatorView navigator;
		DirectoryRepository _repo;

		public Form1()
		{
			InitializeComponent();
		}

		private void _dirModel_CurrentDirChanged(object sender, IDir e)
		{
			Text = e.name;
		}

		private void Navigator_CommandExitDir(object sender, EventArgs e)
		{
			_dirModel.JumpBack();
			navigator.SetDirImage(_dirModel.GetDataImage());
		}

		private void Navigator_CommandEnterDir(object sender, IDir e)
		{
			// Эмуляция модуля работы с задачей.
			// Модуль маршрутизации может быть выполнен в виде словаря, ключ - тип узла, значение - лямбдя, принимающая узел
			// Но мне наверное больше удобно, чтобы задачи выводились в отдлельное окно.
			//	Задачи, заметки, проблемы - в одном окне.
			if(e.type == NodeType.task)
			{
				MessageBox.Show(e.name);

				var p = _dirModel.GetDataImage();
				p.LastMovment = LastMovment.nomovement;
				navigator.SetDirImage(p);

				return;
			}
			else if(e.type == NodeType.dir || e.type == NodeType.exit_dir)
			{
				_dirModel.EnterDir(e);
				navigator.SetDirImage(_dirModel.GetDataImage());
			}
		}

		// Сторона презентера
		private void btnCreatDir_Click(object sender, EventArgs e)
		{
			var _name = InputBox.GetText("Enter dirname");
			if (_name == null) return;

			// Недопустимо так создавать. Определить фабрику, создавать определенные ноды.
			// Иначе могу что то нето создать, что внесет сбой в алгоритмах.
			var d = new Dir { id = _repo.NextId(), name = _name, owner_id = _dirModel.GetCurrentDir().id };

			_repo.Add(d);

			navigator.SetDirImage(_dirModel.GetDataImage());

			dataGridView1.Focus();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_repo = new DirectoryRepository();// Лучше интерфейс, который только для чтения, чтобы быть уверенным, и очевидно, что сервис не меняет данные. А добавленир, сохранение, а потом обновление сервиса.
			_dirModel = new DirectoryNavigatorService(_repo);

			IconProvider img = new IconProvider(
				"..\\img\\icons8-folder-24.png",
				"..\\img\\icons8-task-24.png",
				"..\\img\\icons8-arrow-up-24.png");

			navigator = new DirNavigatorView(dataGridView1, txtPath);
			navigator.CommandEnterDir += Navigator_CommandEnterDir;
			navigator.CommandExitDir += Navigator_CommandExitDir;
			navigator.Icons = new Dictionary<NodeType, Image> {
				{ NodeType.dir, img.Folder },
				{ NodeType.task, img.LTask },
				{ NodeType.exit_dir, img.OutFolder }
			};
			navigator.RowColors = new Dictionary<NodeType, Color> { { NodeType.task, Color.Red} };

			_dirModel.CurrentDirChanged += _dirModel_CurrentDirChanged;

			navigator.SetDirImage(_dirModel.GetDataImage());
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

			navigator.Icons = new Dictionary<NodeType, Image> {
				{ NodeType.dir, img.Folder },
				{ NodeType.task, img.LTask },
				{ NodeType.exit_dir, img.OutFolder }
			};
		}
	}
}
