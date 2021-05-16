using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBank.BL.Entities;
using TaskBank.BL.Repos;
using TaskBank.Views;

namespace TaskBank
{
	public class MainPresenter
	{
		IMainView _mainView;
		IRmTaskRepository _repo;
		ISingleEntityView<OTask> _task_view;

		public MainPresenter(IMainView mv, IRmTaskRepository repo, ISingleEntityView<OTask> task_view)
		{
			_mainView = mv;
			_repo = repo;
			_task_view = task_view;

			wireEvents();

			updateDisplayTaskCollection();
		}

		private void wireEvents()
		{
			_mainView.CreateNoteCommand += _mainView_CreateNoteCommand;
			_mainView.DeleteNoteCommand += _mainView_DeleteNoteCommand;
			_mainView.SaveTaskCommand += _mainView_SaveTaskCommand;
		}

		private void _mainView_SaveTaskCommand(object sender, OTask e)
		{
			_repo.Save(e);
			_mainView.DisplayTaskCollection(_repo.GetAll());
		}

		private void _mainView_DeleteNoteCommand(object sender, OTask e)
		{
			if (e == null) return;

			if (DialCommuna.Dialogs.UserAnswerYes.Show($"Message {e.MiniText} will be removed. Are you sure?", "Deleting"))
			{
				_repo.Delete(e);
				updateDisplayTaskCollection();
			}
		}

		private void _mainView_CreateNoteCommand(object sender, DateTime e)
		{
			var res = _task_view.Go(new OTask { Text = $"{getTimeStringOfNow(e)}{Environment.NewLine}" });

			if (res.accepted)
			{
				_repo.Save(res.Output);
				updateDisplayTaskCollection();
			}
		}
		private string getTimeStringOfNow(DateTime d)
		{
			return $">>> {d.ToString("dd-MM-yyyy HH:mm")}";
		}

		private void updateDisplayTaskCollection()
		{
			_mainView.DisplayTaskCollection(_repo.GetAll());
		}
	}
}
