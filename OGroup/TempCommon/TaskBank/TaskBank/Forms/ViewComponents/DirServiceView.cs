using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIComponents.NodesNavigator;

namespace TaskBank.Forms.ViewComponents
{
	/*
	 * >>> 29-05-2021 00:11 --- не помню зачем этот класс...
	 *		вспомнил - я хочу вынести логику коммуникации dir_service <-> dirnav_view в отдельный модуль из main_presenter
	 * 
	 * 
	 * Лучше UserControl делать.
	 * Каждый компонент должен соответсвовать интерфейсу, и нести полную отвественность за события.
	 *	Каждому такому компоненту соответсвует свой презентер, который может быть субпрезентером.
	 * 
	 * >>> 29-05-2021 07:36
	 * Расределение по проектам, папкам.
	 *	В папке сервиса и папке uiкомпонента сервисные части.
	 *	Давать аналогичные именования.
	 * 
	 */
	public class DirServiceView
	{
		IDirNavigatorView dirNavigatorView;

		public DirServiceView()
		{
			//dirNavigatorView = new DirNavigatorView();
		}
	}
}
