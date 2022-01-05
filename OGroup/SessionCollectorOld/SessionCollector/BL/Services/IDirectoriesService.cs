using SessionCollector.BL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.BL.Services
{
	public interface IDirectoriesService
	{
		INodeRepository Repo { get; }
	}
}
