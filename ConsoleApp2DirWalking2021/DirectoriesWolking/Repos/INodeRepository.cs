using DirectoriesWolking.Models.DirNavigator;
using System.Collections.Generic;

namespace DirectoryNavigator
{
	public interface INodeRepository
	{
		IEnumerable<Dir> all { get; }
		void Add(Dir d);
		int NextId();
	}
}