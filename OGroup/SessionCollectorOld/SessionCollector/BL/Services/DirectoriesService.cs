using SessionCollector.BL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.BL.Services
{
	public class DirectoriesService : IDirectoriesService
	{
		INodeRepository _repo;
		public INodeRepository Repo => _repo;

		public DirectoriesService(INodeRepository r)
		{
			_repo = r;
		}
	}
}
