using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{

	/*
	 * >>> 01-06-2021 10:16
	 * Перенавправление в модули. Расчитано, чт другой модуль имеет этот модуль, и имеет коллекцию сервисов обработки.
	 * Например сервис NodesNavigatorService.
	 * В коллекции дерева могут быть не только Dir, но и директории-марафоны. Открывая такую диретория с помощью 
	 * ctrl+enter открывается окно настроек, где есть запланированные часы.
	 * Тогда где маршрутизатор должен быть расположен?
	 * По активации узла должно открыться окно свойств-настроек.
	 * Значит располагается в презентере.
	 * Добавить проект CommonPresenterServices где располагаются многократно используемые классы компоненты презентеров.
	 * Маршрутизация, передача узла в INodePresenter<T:INode> - презентер узла. Такой презентер редактирует, показывает,
	 * сохраняет узел.
	 * 
	 * 
	 */
	public class NodeTypeRouter
	{
		public void AddRoute(NType type, Action<INode> func)
		{

		}

		public void AddRangeOfRoutes(Dictionary<NType, Action<INode>> routes)
		{

		}

		public void Resolve(INode o)
		{

		}
	}
}
