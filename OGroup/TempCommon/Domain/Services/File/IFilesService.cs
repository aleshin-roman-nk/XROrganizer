using Domain.Entities;
using Domain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
	public interface IFilesService
	{
		void Save(INode n);
		void Create(INode own, INode n);
		void Delete(INode n);
		void ChangeOwnerDirectory(Dir dir);
		void MoveFilesToDirectory(Dir owner, IEnumerable<INode> notes);

		IEnumerable<INode> Items { get; }

		event EventHandler CollectionChanged;
	}
}
