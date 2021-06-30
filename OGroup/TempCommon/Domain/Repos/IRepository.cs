using Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * >>> 14-06-2021 12:10
 * Задача!
 * Все подчиненные коды перенести из репозиториев в сервисы.
 * Общий интерфейс репозитория IRepository<T> не включает select (пока, изучить тему обобщенных репо)
 * Для сервиса диреторий будет репозиторий IDirectoryRepository, который имеет метод select(int owner_id)
 * 
 * 
 * 
 * 
 */

namespace Domain.Repos
{
	public interface IRepository<T>
		where T: INode
	{
		void Save(T o);// >>> 21-06-2021 10:50 Составить схему. Когда какой репо куди идет. С INode или TNode

		// >>> 21-06-2021 10:56
		/*
		 * !!!
		 * Прорисовать схему, перечислить *конкретные* репо. На основани этого рассчитать что и как резделить в интерфейсы.
		 *	Схема сервисов. Как устанавливать сервис - репо связь в контексте данного проекта (навигация). Хотя навигация не во всем проекте.
		 *		Есть область навигационные сервисы - подчиненные. Есть просто репо - сервис (части проекта где просто какая то статистика, расчет чего то из облака данных)
		 * 
		 * На основании того рассчитать на будущее расширение. Какой вход у модуля, какой результат.
		 * 
		 * 
		 */
		T Create(INode owner, string name, DateTime d);
		void Delete(T o);
		IEnumerable<T> SelectByOwner(INode p);
		event EventHandler Changed;
	}
}
