using Domain.Entities;
using Domain.Enums;
using Shared.UI;
using System;
using System.Collections.Generic;

namespace TaskBank.Presenters
{
	public class FilesPresenter
	{
		//IFilesService _filesService;
		//INodesView _filesView;
		IFTaskEditView _taskViewEdit;
		Hub _hub;

		List<INode> clipboard = new List<INode>();

		//public FilesPresenter(IFilesService serv, INodesView view, IFTaskEditView tskView, Hub h)
		//{
		//	_filesService = serv;
		//	_filesView = view;
		//	_taskViewEdit = tskView;

		//	_hub = h;

		//	wire();
		//}

		private void wire()
		{
			//_filesView.Save += _filesView_Save;
			//_filesView.Create += _filesView_Create;
			//_filesView.Delete += _filesView_Delete;
			//_filesView.SendNodesToClipboard += _filesView_PutNodesToClipboard;
			//_filesView.Paste += _filesView_Paste;
			//_filesView.MakeNodePathTag += _filesView_MakeFilePathTag;
			//_filesView.ActivateNode += _filesView_NodeActivated;

			//_filesService.CollectionChanged += _filesService_CollectionChanged;
			//_hub.CurrentDirectoryChanged += _hub_CurrentDirectoryChanged;
		}

		private void _filesView_NodeActivated(object sender, INode e)
		{
			//if(e is FTask)
			//	_taskViewEdit.Go((FTask)e);
		}

		private void _filesView_MakeFilePathTag(object sender, EventArgs e)
		{
			//if (_filesView.Selected == null)
			//{
			//	//InputBox.ShowMessage("Nothing for making a tag...");
			//	return;
			//}

			//var res = $"task_bank: {_hub.CurrentDirPath} \\ #{_filesView.Selected.id}";

			//try
			//{
			//	Clipboard.Clear();
			//	Clipboard.SetText(res);
			//}
			//catch (Exception)
			//{

			//}
		}

		private void _filesView_Paste(object sender, EventArgs e)
		{
			//_filesService.MoveFilesToDirectory(_hub.Current, clipboard);

			//clipboard.Clear();
			//_filesView.SetClipboardState(clipboard.Count());
		}

		private void _filesView_PutNodesToClipboard(object sender, IEnumerable<INode> e)
		{
			//clipboard.Clear();
			//clipboard.AddRange(e);
			//_filesView.SetClipboardState(clipboard.Count());
		}

		private void _filesView_Delete(object sender, INode e)
		{
			//if (e == null) return;

			//if (DialCommuna.Dialogs.UserAnswerYes.Show($"Note {e.description} will be deleted. Are you sure?", "Deleting"))
			//	_filesService.Delete(e);
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
					n = new FTask { date = DateTime.Now, IsCompleted = false };
					break;
			}

			//if(n != null)
			//	_filesService.Create(_hub.Current, n);
		}

		private void _filesView_Save(object sender, INode e)
		{
			//_filesService.Save(e);
		}

		private void _hub_CurrentDirectoryChanged(object sender, EventArgs e)
		{
			
			//_filesService.ChangeOwnerDirectory(_hub.Current);
		}

		private void _filesService_CollectionChanged(object sender, EventArgs e)
		{
			//_filesView.DisplayFiles(_filesService.Items);
		}
	}
}
