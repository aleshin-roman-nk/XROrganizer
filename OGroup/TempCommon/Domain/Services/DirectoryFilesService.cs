using Domain.Entities;
using Domain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
	public class DirectoryFilesService: IDirectoryFilesService
	{
		ITreeNavigator _navigator;
		INoteRepository _noteRepo;

		private IEnumerable<Note> _items;
		public IEnumerable<Note> Items => _items;

		public event EventHandler CollectionChanged;

		public DirectoryFilesService(INoteRepository nrep, ITreeNavigator nav)
		{
			_noteRepo = nrep;
			_navigator = nav;

			_navigator.OwnerChanged += _navigator_OwnerChanged;
			_noteRepo.Changed += _noteRepo_Changed;
		}

		private void _noteRepo_Changed(object sender, EventArgs e)
		{
			_items = (IEnumerable<Note>)_noteRepo.SelectByOwner(_navigator.CurrentOwner);
			OnCollectionChanged();
		}

		private void _navigator_OwnerChanged(object sender, EventArgs e)
		{
			_items = (IEnumerable<Note>)_noteRepo.SelectByOwner(_navigator.CurrentOwner);
			OnCollectionChanged();
		}

		private void OnCollectionChanged()
		{
			CollectionChanged?.Invoke(this, EventArgs.Empty);
		}

		public void Save(Note n)
		{
			_noteRepo.Save(n);
		}

		public void Delete(Note n)
		{
			_noteRepo.Delete(n);
		}
	}
}
