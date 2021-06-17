using Domain.Entities;
using Domain.Enums;
using Domain.Repos;
using Domain.Services;
using Domain.Services.Entities;
using PresenterServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBank.Views;

namespace TaskBank
{
	public class MainPresenter
	{
		IMainView _mainView;
		ISingleEntityView<Note> _task_view;

		DirNaviPresenter leftDirsPresenter;
		DirNaviPresenter targetDirsPresenter;

		INoteRepository noteRepo;


		IDirectoryRepository dirRepo;
		INavigatorService dirNavigator;
		INavigatorService dirNavigatorTarget;

		public MainPresenter(IMainView mv, 
			ISingleEntityView<Note> task_view)
		{
			_mainView = mv;
			_task_view = task_view;

			dirRepo = new DirectoryRepository();
			dirNavigator = new NavigatorService(dirRepo);
			dirNavigatorTarget = new NavigatorService(dirRepo);

			//noteRepo = new NotesRepository();

			//noteRepo.SetNodeNavigator(dirRepo.Navigator);

			wireEvents();

			leftDirsPresenter = new DirNaviPresenter(_mainView.DirNavigator, dirNavigator);
			targetDirsPresenter = new DirNaviPresenter(_mainView.TargetDirs, dirNavigatorTarget);
		}


		private void wireEvents()
		{
			_mainView.NewTask += _mainView_NewTask;
			_mainView.DeleteTask += _mainView_DeleteTask;
			_mainView.SaveTask += _mainView_SaveTask;
			_mainView.CreateDir += _mainView_CreateDir;
			_mainView.DeleteDir += _mainView_DeleteDir;
			//noteRepo.CollectionChanged += NoteRepo_CollectionChanged;
		}

		private void NoteRepo_CollectionChanged(object sender, EventArgs e)
		{
			//_mainView.DisplayTaskCollection(noteRepo.Items);
		}

		private void _mainView_DeleteDir(object sender, Dir e)
		{
			if (e == null) return;
			if (DialCommuna.Dialogs.UserAnswerYes.Show($"Directory '{e.name}' will be removed. Are you sure?", "Deleting"))
				dirRepo.Delete(e);
		}

		private void _mainView_NewTask(object sender, EventArgs e)
		{
			var res = _task_view.Go(
				new Note
				{
					description = $"{getTimeStringOfNow(DateTime.Now)}{Environment.NewLine}"
				});

			if (res.accepted)
			{
				//noteRepo.AttachToHost(res.Output);
				//noteRepo.Save(res.Output);
			}
		}

		private void _mainView_CreateDir(object sender, string e)
		{
			var d = new Dir { name = e };
			dirNavigator.Attach(d);
			dirRepo.Save(d);
		}

		private void _mainView_SaveTask(object sender, Note e)
		{
			//noteRepo.Save(e);
		}

		private void _mainView_DeleteTask(object sender, Note e)
		{
			if (e == null) return;

			if (DialCommuna.Dialogs.UserAnswerYes.Show($"Note {e.MiniText} will be removed. Are you sure?", "Deleting"))
			{
				//noteRepo.Delete(e);
			}
		}

		private string getTimeStringOfNow(DateTime d)
		{
			return $">>> {d.ToString("dd-MM-yyyy HH:mm")}";
		}
	}
}
