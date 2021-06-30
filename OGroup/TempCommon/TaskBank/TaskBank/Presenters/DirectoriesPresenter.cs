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
using UIComponents;
using UIComponents.NodesNavigator;

namespace TaskBank.Presenters
{
	/*
	 * отдлельить логику н6авигации и логику репозитория димреорий,
	 * то есть отдельно композиция навигатора и добавлятеля в текущую что то.
	 * 
	 */

	public class DirectoriesPresenter
	{
		IDirectoriesView _view;
		IDirectoriesService _service;

		NodeNavigatorImage Image { get; } = new NodeNavigatorImage();

		public DirectoriesPresenter(IDirectoriesService s, IDirectoriesView v)
			// сервис сделать более универсальным. моя цель - использовать алгоритм для реализации любой древовидной коллекции
			// например статьи, мой словарь, бюджет (категории - покупки).
		{
			_view = v;
			_service = s;

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
			_service.Create(e, DateTime.Now);
		}

		private void _service_CollectionChanged(object sender, EventArgs e)
		{
			Image.Items = _service.Items;
			Image.CurrentDirFullName = _service.Navigator.CurrentNodeFullName;
			Image.HighlightedDir = _service.Navigator.HighlightedNode;

			_view.Navigator.DisplayData(Image);
		}

		private void _dirNaviView_ExitNode(object sender, EventArgs e)
		{
			_service.Navigator.JumpBack();
		}

		private void _dirNaviView_ActivateNode(object sender, INode e)
		{
			if (e.type == NType.Dir || e.type == NType.exit_dir)
			{
				_service.Navigator.Enter(e);
			}
		}
	}
}
