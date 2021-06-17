using Domain.Entities;
using Domain.Enums;
using Domain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * >>> 17-06-2021 21:14
 * Универсальный сервис. Хранит коллекцию текущих объектов, принадлежащих текущему владельцу.
 * Репозиторий используется для сохранения объектов, этот класс подписан на изменения репо.
 * При поступлении объекта проводится проверка, что этот объект принадлежит текущей коллекции.
 * И нам без разницы типы, мы работаем с общим интерфейсом сущностей.
 * 
 * 
 * >>> 17-06-2021 22:02
 * Нужно два разных сервиса навигации по репозиторию.
 * Один оповещает всех что выбран новый владелец. И другие сервисы изменяют свои коллекции.
 * Другой необходим просто чтобы выбрать владельца.
 * 
 * >>> 17-06-2021 22:34
 * Сервисы разные (экземпляры) репозиторий один.
 * При создании экземпляра сервиса передается один и тот же экземпляр репозитория.
 * Поэтому всетаки разумно укомплектовывать чтобы не приходилось черезмерно конфигурировать презентер.
 * 
 * 
 */

namespace Domain.Services
{
	public class NavigatorService : INavigatorService
	{
		NodeNavigator _navigator = new NodeNavigator();
		IRepository _repo;

		public IEnumerable<INode> Items { get; private set; }
		public event EventHandler CollectionChanged;

		public INodeNavigator Navigator => _navigator;

		public NavigatorService(IRepository r)
		{
			_repo = r;
			_repo.Changed += _repo_Changed;
			_navigator.OwnerChanged += _navigator_OwnerChanged;
		}

		private void _repo_Changed(object sender, EventArgs e)
		{
			Items = select(Navigator.CurrentOwner);
			OnCollectionChanged();
		}

		private void _navigator_OwnerChanged(object sender, EventArgs e)
		{
			Items = select(Navigator.CurrentOwner);
			OnCollectionChanged();			
		}

		void OnCollectionChanged()
		{
			CollectionChanged?.Invoke(this, EventArgs.Empty);
		}

		private IEnumerable<INode> select(INode own)
		{
			List<INode> res = new List<INode>();
			if (own.type != NType._sys_root_dir)
				res.Add(TopExitNode.Value);

			res.AddRange(_repo.SelectByOwner(own));

			return res;
		}

		public void Attach(INode n)
		{
			n.owner_id = Navigator.CurrentOwner.id;
			n.owner_type = Navigator.CurrentOwner.type;
		}

		public void Update()
		{
			Items = select(Navigator.CurrentOwner);
			OnCollectionChanged();
		}
	}
}
