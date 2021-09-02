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
using CommonUIComponents;
using CommonUIComponents.NodesNavigator;
using Domain.Services.Directory;

namespace TaskBank.Presenters
{
	public class DirectoriesPresenter
	{
		IDirectoriesView _view;
		IDirectoriesService _service;
		Hub _hub;

		NodeNavigatorImage Image { get; } = new NodeNavigatorImage();

		public DirectoriesPresenter(IDirectoriesService s, IDirectoriesView v, Hub h)
		{
			_view = v;
			_service = s;
			_hub = h;

			_view.Navigator.ActivateNode += _dirNaviView_ActivateNode;
			_view.Navigator.ExitNode += _dirNaviView_ExitNode;

			_view.Create += _view_Create;
			_view.Delete += _view_Delete;

			_service.CollectionChanged += _service_CollectionChanged;
			
			_service.Update();
		}

		private void _view_Delete(object sender, INode e)
		{
			if (_service.HasChildren(e as Dir))
			{
				InputBoxes.InputBox.ShowMessage($"{e.name} has childern");
			}
			else
				_service.Delete(e as Dir);
		}

		private void _view_Create(object sender, string e)
		{
			_service.Create(new Dir { name = e, date = DateTime.Now });
		}

		private void _service_CollectionChanged(object sender, EventArgs e)
		{
			_hub.ChangeCurrent(_service.Parent as Dir);

			Image.Items = _service.Items;
			Image.CurrentDirFullName = _service.CurrentParentFullName;
			Image.HighlightedDir = _service.HighlightedNode;

			_view.Navigator.DisplayData(Image);
		}

		private void _dirNaviView_ExitNode(object sender, EventArgs e)
		{
			_service.JumpBack();
		}

		private void _dirNaviView_ActivateNode(object sender, INode e)
		{
			if (e.type == NType.Dir || e.type == NType.exit_dir)
			{
				_service.Enter(e);
			}
		}
	}
}
