using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Domain.Repos
{
	public interface IDirectoryRepository
	{
		IEnumerable<Dir> GetDirs();
		IEnumerable<Dir> GetTrackedDirs();
		void Save(Dir dir);
		void Delete(Dir dir);
		void Create(int owner_id, string name, DateTime date);
	}
}
