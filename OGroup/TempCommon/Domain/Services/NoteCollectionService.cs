using Domain.Entities;
using Domain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
	public class NoteCollectionService
	{
//		IMasterNodeNavigatorService _master;
		//IObservableCollection _noteRepo;

		private IEnumerable<Note> _items;

		public IEnumerable<Note> Items => _items;

		public event EventHandler CollectionChanged;

		//public NoteCollectionService(IObservableCollection nrep)
		//{
		//	_noteRepo = nrep;
		//}

		//public void SetMaster(IMasterNodeNavigatorService master)
		//{
		//	_master = master;
		//	_master.MasterNodeChanged += _master_MasterNodeChanged;
		//}

		private void OnCollectionChanged()
		{
			CollectionChanged?.Invoke(this, EventArgs.Empty);
		}

		private void _master_MasterNodeChanged(object sender, EventArgs e)
		{
			//_items = _noteRepo.GetItemsByParentId(_master.Image.CurrentOwner.id);
			OnCollectionChanged();
		}

		public void SaveToCurrentBranch(Note o)
		{
			throw new NotImplementedException();
		}
	}
}
