using Domain.Entities;
using Domain.Repos;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIComponents.ViewComponents;

namespace TaskBank.Presenters
{
	public class DirectoryFilesPresenter
	{

		IDirectoryFilesService _notesService;
		IDirectoryFilesView _taskView;

		public DirectoryFilesPresenter(IDirectoryFilesService serv, IDirectoryFilesView view)
		{
			_notesService = serv;
			_taskView = view;

			wire();
		}

		private void wire()
		{
			//_taskView.SaveFileNeeded += _taskView_SaveTaskNeeded;
			_notesService.CollectionChanged += NotesService_CollectionChanged;
		}

		private void _taskView_SaveTaskNeeded(object sender, Note e)
		{
			_notesService.Save(e);
		}

		private void NotesService_CollectionChanged(object sender, EventArgs e)
		{
			_taskView.DisplayFiles(_notesService.Items);
		}
	}
}
