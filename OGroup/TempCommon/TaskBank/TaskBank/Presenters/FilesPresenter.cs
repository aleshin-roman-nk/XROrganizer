using Domain.Entities;
using Domain.Repos;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBank.Dlg.forms;
using TaskBank.Views;
using CommonUIComponents.ViewComponents;
using Domain.Enums;
using System.Windows.Forms;
using Domain.Tools;

namespace TaskBank.Presenters
{
	public class FilesPresenter
	{

		IFilesService _filesService;
		IFilesView _filesView;
		Hub _hub;

		List<INode> clipboard = new List<INode>();// по идее здесь и должен быть общий тип, так как мы идем к таблице разнотипных элементов.

		public FilesPresenter(IFilesService serv, IFilesView view, Hub h)
		{
			_filesService = serv;
			_filesView = view;

			_hub = h;

			wire();
		}

		private void wire()
		{
			_filesView.Save += _filesView_Save;
			_filesView.Create += _filesView_Create;
			_filesView.Delete += _filesView_Delete;
			_filesView.PutNodesToClipboard += _filesView_PutNodesToClipboard;
			_filesView.Paste += _filesView_Paste;

			_filesService.CollectionChanged += _filesService_CollectionChanged;
			_hub.CurrentDirectoryChanged += _hub_CurrentDirectoryChanged;
		}

		private void _filesView_Paste(object sender, EventArgs e)
		{
			_filesService.MoveFilesToDirectory(_hub.Current, clipboard);

			clipboard.Clear();
			_filesView.SetClipboardState(clipboard.Count());
		}

		private void _filesView_PutNodesToClipboard(object sender, IEnumerable<INode> e)
		{
			clipboard.Clear();
			clipboard.AddRange(e);
			_filesView.SetClipboardState(clipboard.Count());
		}

		private void _filesView_Delete(object sender, INode e)
		{
			if (e == null) return;

			if (DialCommuna.Dialogs.UserAnswerYes.Show($"Note {e.description} will be deleted. Are you sure?", "Deleting"))
				_filesService.Delete(e);
		}

		private void _filesView_Create(object sender, NType e)
		{
			// Здесь будет код выбора модуля, соответствующего типу NType e
			INode n = null;

			switch (e)
			{
				case NType.Note:
					n = new FNote { date = DateTime.Now };
					break;
				case NType.Task:
					n = new FTask { date = DateTime.Now, State = TaskState.Processing };
					break;
			}

			if(n != null)
				_filesService.Create(_hub.Current, n);
		}

		private void _filesView_Save(object sender, INode e)
		{
			_filesService.Save(e);
		}

		private void _hub_CurrentDirectoryChanged(object sender, EventArgs e)
		{
			
			_filesService.ChangeOwnerDirectory(_hub.Current);
		}

		private void _filesService_CollectionChanged(object sender, EventArgs e)
		{
			_filesView.DisplayFiles(_filesService.Items);
		}
	}
}
