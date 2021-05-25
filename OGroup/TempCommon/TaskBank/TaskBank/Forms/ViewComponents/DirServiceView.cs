using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIComponents.NodesNavigator;

namespace TaskBank.Forms.ViewComponents
{
	/*
	 * Лучше UserControl делать.
	 * Каждый компонент должен соответсвовать интерфейсу, и нести полную отвественность за события.
	 *	Каждому такому компоненту соответсвует свой презентер, который может быть субпрезентером.
	 * 
	 */
	public class DirServiceView
	{
		IDirNavigatorView dirNavigatorView;

		public DirServiceView()
		{
			dirNavigatorView = new DirNavigatorView();
		}
	}
}
