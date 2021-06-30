using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
	public interface IDirectoryFilesService: IObservableCollection<Note>
	{
		void Save(Note n);
		void Delete(Note n);
	}
}
