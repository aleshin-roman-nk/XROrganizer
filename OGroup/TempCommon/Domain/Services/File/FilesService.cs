using Domain.Entities;
using Domain.Enums;
using Domain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
	public class FilesService: IFilesService
	{
		Dir _owner;

		IRepository _repo;

		private List<INode> _items = new List<INode>();
		public IEnumerable<INode> Items => _items;

		public event EventHandler CollectionChanged;

		public FilesService(IRepository repo)
		{
			_repo = repo;
		}

		private void OnCollectionChanged()
		{
			CollectionChanged?.Invoke(this, EventArgs.Empty);
		}

		private void updateCollection(Dir d)
		{
			_items.Clear();

			_items.AddRange(_repo.GetFiles(d));

			OnCollectionChanged();
		}

		public void Save(INode n)
		{
			_repo.Save(n);
		}

		public void Delete(INode n)
		{
			_repo.Delete(n);
			updateCollection(_owner);
		}

		public void ChangeOwnerDirectory(Dir dir)
		{
			_owner = dir;
			updateCollection(_owner);
		}

		public void Create(INode own, INode n)
		{
			_repo.Create(own, n);
			updateCollection(_owner);
		}

		public void MoveFilesToDirectory(Dir dir, IEnumerable<INode> nodes)
		{
			foreach (var item in nodes)
				item.owner_id = dir.id;

			_repo.SaveRange(nodes);

			updateCollection(_owner);
		}		
	}
}
