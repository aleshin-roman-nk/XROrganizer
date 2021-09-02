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
 * >>> 11-07-2021 15:57
 * Если трудно определить архитектуру, просто втупую накидывать функционал интерфейса. Определиться с набором методов и  событий, потом смотреть логику
 *	и выделять общее.
 * 
 */

namespace Domain.Services.Directory
{
	public class DirectoriesService : IDirectoriesService
	{
		TreeNavigator _navigator = new TreeNavigator();
		IRepository _repo;

		public IEnumerable<INode> Items { get; private set; }
		public event EventHandler CollectionChanged;
		public INode Parent => _navigator.CurrentOwner;
		public string CurrentParentFullName => _navigator.CurrentNodeFullName;
		public INode HighlightedNode => _navigator.HighlightedNode;

		public DirectoriesService(IRepository r)
		{
			_repo = r;
			_navigator.OwnerChanged += _navigator_OwnerChanged;// должно быть внутри сервиса. интерфейс сервиса должен быть плоским.
		}

		private void _navigator_OwnerChanged(object sender, EventArgs e)
		{
			updateData();
		}

		private void updateData()
		{
			Items = select(_navigator.CurrentOwner as Dir);
			OnCollectionChanged();
		}

		void OnCollectionChanged()
		{
			CollectionChanged?.Invoke(this, EventArgs.Empty);
		}

		private IEnumerable<INode> select(Dir own)
		{
			List<INode> res = new List<INode>();
			if (own.type != NType._sys_root_dir)
				res.Add(Dir.ExitTopDir);

			res.AddRange(_repo.GetDirs(own));

			return res;
		}

		//public void Attach(INode n)
		//{
		//	n.owner_id = Navigator.CurrentOwner.id;
		//	n.owner_type = Navigator.CurrentOwner.type;
		//}

		public void Update()
		{
			_navigator.Update();
		}

		public void Create(Dir d)
		{
			_repo.Create(_navigator.CurrentOwner, d);
			updateData();
		}

		public void Save(Dir d)
		{
			_repo.Save(d);
		}

		public void Delete(Dir d)
		{
			_repo.Delete(d);
			updateData();
		}

		public bool HasChildren(INode d)
		{
			return _repo.HasChildren(d);
		}

		public void JumpBack()
		{
			_navigator.JumpBack();
		}

		public void Enter(INode n)
		{
			_navigator.Enter(n);
		}
	}
}
