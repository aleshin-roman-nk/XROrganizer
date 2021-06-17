using Domain.Cfg;
using Domain.DBContexts;
using Domain.Entities;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Repos
{
	public class NotesRepository : INoteRepository
	{
		public event EventHandler CollectionChanged;
		public event EventHandler Changed;

		NodeNavigator _nodeNavi;
		public void SetNodeNavigator(NodeNavigator nvi)
		{
			_nodeNavi = nvi;
			//_nodeNavi.OwnerChanged += _nodeNavi_CurrentOwnerChanged; ;
		}

		IEnumerable<Note> _currentCollection;
		public IEnumerable<Note> Items => _currentCollection;

		private INode CurrentOwner { get; set; }

		private void _nodeNavi_CurrentOwnerChanged(object sender, INode e)
		{
			CurrentOwner = e;
			OnCollectionChanged();
		}

		private void OnCollectionChanged()
		{
			_currentCollection = GetItemsByParentId(CurrentOwner.id);
			CollectionChanged?.Invoke(this, EventArgs.Empty);
		}
		public void Save(Note t)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				db.Entry(t).State = t.id == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
				OnCollectionChanged();
			}
		}

		public void Delete(Note t)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				db.Entry(t).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
				OnCollectionChanged();
			}
		}

		private IEnumerable<Note> GetItemsByParentId(int parent)
		{
			using (MainContext db = new MainContext(Settings.DbPath))
			{
				//tmp. getting date string and make Date field.
				//var i = db.Nodes.OrderByDescending(x => x.id).ToList();
				//foreach (var item in i)
				//{
				//	//string d = item.description.Substring(4, 16);
				//	//item.date = DateTime.Parse(d);
				//	item.type = Enums.NType.Task;
				//}
				//db.SaveChanges();

				return db.Notes.Where(x => x.owner_id == parent && x.owner_type == Enums.NType.Dir)
					.OrderByDescending(x => x.id).ToList();
			}
		}

		public Note Create(string name)
		{
			throw new NotImplementedException();
		}

		public void AttachToHost(INode n)
		{
			n.owner_id = CurrentOwner.id;
			n.owner_type = CurrentOwner.owner_type;
		}
	}
}