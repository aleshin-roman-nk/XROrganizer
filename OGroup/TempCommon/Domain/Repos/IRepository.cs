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
		void Save(T o);
		T Create(string name);
		void Delete(T o);
	}

	public interface IRepository
	{
		event EventHandler Changed;
		IEnumerable<INode> SelectByOwner(INode owner);
	}
}
