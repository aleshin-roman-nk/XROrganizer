using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoriesWolking
{
	public class DirectoryRepository
	{
		List<Dir> _dirs = new List<Dir>();

		public DirectoryRepository()
		{
			_dirs.Add(new Dir { id = 1, name = "Novokuz", owner_id = 0 });

			_dirs.Add(new Dir { id = 11, name = "Mama", owner_id = 1 });
			_dirs.Add(new Dir { id = 111, name = "Roma", owner_id = 11 });
			_dirs.Add(new Dir { id = 112, name = "Paha", owner_id = 11 });
			_dirs.Add(new Dir { id = 113, name = "Anna", owner_id = 11 });

			_dirs.Add(new Dir { id = 12, name = "Pasha", owner_id = 1 });
			_dirs.Add(new Dir { id = 121, name = "Tania", owner_id = 12 });
			_dirs.Add(new Dir { id = 122, name = "Tamara", owner_id = 12 });

			_dirs.Add(new Dir { id = 2, name = "English", owner_id = 0 });
			_dirs.Add(new Dir { id = 24, name = "INBOX", owner_id = 2 });
			_dirs.Add(new Dir { id = 21, name = "Listening", owner_id = 2 });
			_dirs.Add(new Dir { id = 22, name = "Reading", owner_id = 2 });
			_dirs.Add(new Dir { id = 23, name = "Speaking", owner_id = 2 });
		}

		public IEnumerable<Dir> all => _dirs;

		public int NextId()
		{
			return _dirs.Max(x => x.id) + 1;
		}

		public void Add(Dir d)
		{
			_dirs.Add(d);
		}
	}
}
