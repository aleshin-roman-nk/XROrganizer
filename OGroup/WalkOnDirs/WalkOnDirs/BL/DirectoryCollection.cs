using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkOnDirs.BL
{
	public class DirectoryCollection
	{
		List<Directory> _dirs;
		int _lastId;
		Directory _root;
		public DirectoryCollection()
		{
			_root = new Directory { Id = 0, Name = "Root" };

			_dirs = new List<Directory>();

			_dirs.Add(new Directory { Id = 1, Name = "English", ParentId = 0 });
			_dirs.Add(new Directory { Id = 2, Name = "Listening", ParentId = 1 });
			_dirs.Add(new Directory { Id = 3, Name = "Grammar", ParentId = 1 });

			_dirs.Add(new Directory { Id = 4, Name = "Programming", ParentId = 0 });
			_dirs.Add(new Directory { Id = 5, Name = ".NET", ParentId = 4 });
			_dirs.Add(new Directory { Id = 6, Name = "ASP", ParentId = 4 });
			_dirs.Add(new Directory { Id = 7, Name = "GIT", ParentId = 4 });

			_dirs.Add(new Directory { Id = 8, Name = "Spirit", ParentId = 0 });
			_dirs.Add(new Directory { Id = 9, Name = "Bible reading", ParentId = 8 });
			_dirs.Add(new Directory { Id = 10, Name = "Publishing", ParentId = 9 });
			_dirs.Add(new Directory { Id = 11, Name = "Meetings", ParentId = 9 });

			_dirs.Add(new Directory { Id = 12, Name = "Arduino", ParentId = 0 });
			_dirs.Add(new Directory { Id = 13, Name = "Kolonna", ParentId = 12 });
			_dirs.Add(new Directory { Id = 14, Name = "Teplitsa", ParentId = 12 });

			var dir = new Directory { Id = 15, Name = "Costs", ParentId = 5 };
			dir.PItems.Add(new PrjItem { ProjectId = 15, Text = "Добавить функцию учета дохода", Tag = ".NET-ASP"});
			dir.PItems.Add(new PrjItem { ProjectId = 15, Text = "Поменять логику презентеров", Tag = ".NET"});
			dir.PItems.Add(new PrjItem { ProjectId = 15, Text = "При добавлении пункта документа давать статус не распределен", Tag = ".NET"});

			_dirs.Add(dir);

			_lastId = _dirs.Max(x => x.Id);
		}

		public void AddProject(Directory d)
		{
			d.Id = ++_lastId;
			_dirs.Add(d);
		}

		public IEnumerable<Directory> GetChildrenOf(Directory dir)
		{
			return (from res in _dirs
				   where res.ParentId == dir.Id
					select res)
				   .ToList();
		}

		public string GetFullPathOf(Directory dir)
		{
			List<string> res = new List<string>();

			var d = dir;

			while(d != _root)
			{
				res.Add(d.Name);
				d = GetParentOf(d);
			}

			res.Reverse();

			StringBuilder strb = new StringBuilder();

			foreach (var item in res)
			{
				strb.Append($"{item}\\");
			}

			var str1 = strb.ToString().TrimEnd('\\');

			return str1;
		}

		public Directory GetParentOf(Directory dir)// подумать как возвращать не null
		{
			var res = _dirs.FirstOrDefault(x => x.Id == dir.ParentId);
			if (res == null) res = GetRoot();
			return res;
		}

		public Directory GetRoot()
		{
			return _root;
		}
	}
}
