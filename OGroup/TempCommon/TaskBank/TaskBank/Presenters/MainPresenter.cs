using Domain.Entities;
using Domain.Enums;
using Domain.Repos;
using Domain.Services;
using Domain.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBank.Views;

namespace TaskBank.Presenters
{
	public class MainPresenter
	{
		IMainView _mainView;

		DirectoriesPresenter leftDirsPresenter;

		DirectoryFilesPresenter filesPresenter;

		IDirectoryRepository dirRepo;
		IDirectoriesService dirNavigator;
		IDirectoriesService dirNavigatorTarget;

		IDirectoryFilesService noteService;

		public MainPresenter(IMainView mv)
		{
			_mainView = mv;

			dirRepo = new DirectoryRepository();
			dirNavigator = new DirectoriesService(dirRepo);
			dirNavigatorTarget = new DirectoriesService(dirRepo);

			//notePresenter = new DirectoryFilesPresenter(
			//	new DirectoryFilesService(new NotesRepository(), dirNavigator.Navigator),
			//	_mainView.DirectoryFilesView);

			leftDirsPresenter = new DirectoriesPresenter(dirNavigator, _mainView.DirectoryNavigator);
		}

		//private void _mainView_NewTask(object sender, EventArgs e)
		//{
		//	var res = _task_view.Go(
		//		new Note
		//		{
		//			description = $"{getTimeStringOfNow(DateTime.Now)}{Environment.NewLine}"
		//		});

		//	if (res.accepted)
		//	{
		//		dirNavigator.Attach(res.Output);
		//		_noteRepo.Save(res.Output);
		//	}
		//}

		private void _mainView_CreateDir(object sender, string e)
		{
			var d = new Dir { name = e };
			dirNavigator.Attach(d);
			dirRepo.Save(d);
		}

		//private void _mainView_SaveTask(object sender, Note e)
		//{
		//	_noteRepo.Save(e);
		//}

		//private void _mainView_DeleteTask(object sender, Note e)
		//{
		//	if (e == null) return;

		//	if (DialCommuna.Dialogs.UserAnswerYes.Show($"Note {e.MiniText} will be removed. Are you sure?", "Deleting"))
		//	{
		//		_noteRepo.Delete(e);
		//	}
		//}

		private string getTimeStringOfNow(DateTime d)
		{
			return $">>> {d.ToString("dd-MM-yyyy HH:mm")}";
		}
	}
}
