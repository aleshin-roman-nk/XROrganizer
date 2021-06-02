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

namespace TaskBank
{
	public class MainPresenter
	{
		IMainView _mainView;
		INotesRepository _taskRepo;
		ISingleEntityView<Note> _task_view;
		IDirectoryRepository _dirRepo;

		NodesNavigatorService dirNavigator;

		public MainPresenter(IMainView mv, 
			ISingleEntityView<Note> task_view, 
			INotesRepository repo, 
			IDirectoryRepository dir_repo)
		{
			_mainView = mv;
			_taskRepo = repo;
			_task_view = task_view;

			_dirRepo = dir_repo;
			dirNavigator = new NodesNavigatorService(_dirRepo);
			
			wireEvents();

			updateDisplayTaskCollection();

			dirNavigator.Update();
		}

		// !!!!! >>> 28-05-2021 09:12
		// Сделать отдельный сабпрезентер, соединяющий ui и сервис. Я не ъочу каждый раз вспоминать как их соединять.
		// Вывести событие если добавлена директория.
		private void DirNavigator_ExitNode(object sender, EventArgs e)
		{
			dirNavigator.JumpBack();
		}

		private void DirNavigator_ActivateNode(object sender, INode e)
		{
			if (e.type == NType.Dir || e.type == NType.exit_dir)
			{
				dirNavigator.EnterDir(e);
			}
		}

		private void DirNavigator_CurrentNodeChanged(object sender, NodesImage e)
		{
			_mainView.DirNavigator.SetDirImage(e);
		}

		private void wireEvents()
		{
			_mainView.NewTask += _mainView_NewTask;
			_mainView.DeleteTask += _mainView_DeleteTask;
			_mainView.SaveTask += _mainView_SaveTask;
			_mainView.CreateDir += _mainView_CreateDir;

			_mainView.DirNavigator.ActivateNode += DirNavigator_ActivateNode;
			_mainView.DirNavigator.ExitNode += DirNavigator_ExitNode;

			dirNavigator.CurrentNodeChanged += DirNavigator_CurrentNodeChanged;
		}

		private void _mainView_CreateDir(object sender, string e)
		{
			// >>> 30-05-2021 01:28
			// method like currentDir.CreateChild(string name) is better
			// it means that we have to have a service providing dir-children mechanism
			_dirRepo.Create(dirNavigator.CurrentOwner.id, e, DateTime.Now );
			dirNavigator.Update();
		}

		private void _mainView_SaveTask(object sender, Note e)
		{
			_taskRepo.Save(e);
			_mainView.DisplayTaskCollection(_taskRepo.GetAll());
		}

		private void _mainView_DeleteTask(object sender, Note e)
		{
			if (e == null) return;

			if (DialCommuna.Dialogs.UserAnswerYes.Show($"Message {e.MiniText} will be removed. Are you sure?", "Deleting"))
			{
				_taskRepo.Delete(e);
				updateDisplayTaskCollection();
			}
		}

		private void _mainView_NewTask(object sender, DateTime e)
		{
			var res = _task_view.Go(new Note {type = NType.Task, description = $"{getTimeStringOfNow(e)}{Environment.NewLine}" });

			if (res.accepted)
			{
				res.Output.date = DateTime.Now;
				_taskRepo.Save(res.Output);
				updateDisplayTaskCollection();
			}
		}
		private string getTimeStringOfNow(DateTime d)
		{
			return $">>> {d.ToString("dd-MM-yyyy HH:mm")}";
		}

		private void updateDisplayTaskCollection()
		{
			_mainView.DisplayTaskCollection(_taskRepo.GetAll());
		}
	}
}
