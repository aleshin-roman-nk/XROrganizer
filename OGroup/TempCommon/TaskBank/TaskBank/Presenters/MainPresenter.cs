using Domain.Entities;
using Domain.Enums;
using Domain.Repos;
using Domain.Repos.SQLiteRepos;
using Domain.Services;
using Domain.Services.Directory;
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
		Hub _hub;

		DirectoriesPresenter directoriesPresenter;
		FilesPresenter filesPresenter;

		public MainPresenter(IMainView mv)
		{
			_mainView = mv;

			_hub = new Hub();

			IRepository repo = new MainRepository();

			IFilesService fs = new FilesService(repo);

			filesPresenter = new FilesPresenter(fs, _mainView.DirectoryFilesView, _hub);
			directoriesPresenter = new DirectoriesPresenter(new DirectoriesService(repo), _mainView.DirectoryNavigator, _hub);
		}

		private string getTimeStringOfNow(DateTime d)
		{
			return $">>> {d.ToString("dd-MM-yyyy HH:mm")}";
		}
	}
}
