using Domain.Entities;
using System.Collections.Generic;


namespace Domain.Repos
{
	public interface INotesRepository
	{
		void Delete(Note t);
		IEnumerable<Note> GetAll();
		void Save(Note t);
	}
}