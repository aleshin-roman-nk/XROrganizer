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
using UIComponents.NodesNavigator;

namespace PresenterServices
{
	/*
	 * отдлельить логику н6авигации и логику репозитория димреорий,
	 * то есть отдельно композиция навигатора и добавлятеля в текущую что то.
	 * 
	 */

	public class DirNaviPresenter
	{
		INodeNavigatorView _dirNaviView;
		INavigatorService _dirHostService;

		NodeNavigatorImage Image { get; } = new NodeNavigatorImage();

		public DirNaviPresenter(INodeNavigatorView dirMorda, INavigatorService dirHS)
			// сервис сделать более универсальным. моя цель - использовать алгоритм для реализации любой древовидной коллекции
			// например статьи, мой словарь, бюджет (категории - покупки).
		{
			_dirNaviView = dirMorda;

			_dirHostService = dirHS;

			_dirNaviView.ActivateNode += _dirNaviView_ActivateNode;
			_dirNaviView.ExitNode += _dirNaviView_ExitNode;

			_dirHostService.CollectionChanged += _dirRep_CollectionChanged;

			_dirHostService.Update();
		}

		private void _dirRep_CollectionChanged(object sender, EventArgs e)
		{
			Image.CurrentBranch = _dirHostService.Items;
			Image.CurrentDirFullName = _dirHostService.Navigator.CurrentNodeFullName;
			Image.HighlightedDir = _dirHostService.Navigator.HighlightedNode;

			_dirNaviView.DisplayData(Image);
		}

		private void _dirNaviView_ExitNode(object sender, EventArgs e)
		{
			_dirHostService.Navigator.JumpBack();
		}

		private void _dirNaviView_ActivateNode(object sender, INode e)
		{
			if (e.type == NType.Dir || e.type == NType.exit_dir)
			{
				_dirHostService.Navigator.Enter(e);
			}
		}
	}
}
