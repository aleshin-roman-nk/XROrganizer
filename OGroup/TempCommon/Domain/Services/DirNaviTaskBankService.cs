using Domain.Entities;
using Domain.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
	// One single navi. Observing current dir and 
	public class DirNaviTaskBankService
	{
		public DirNaviTaskBankService(IDirectoryRepository dirRepo, INotesRepository notesRepo)
		{

		}

		public Dir CurrentDir { get; }
		public IEnumerable<Dir> CurrentChildrenDir { get; }
		public IEnumerable<Note> Notes { get; }
		/// <summary>
		/// Creating a dir in a current owner.
		/// </summary>
		public void CreateDir()
		{

		}
	}
}
