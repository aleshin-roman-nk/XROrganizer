using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.BL
{
	public interface IMainRepository
	{
		DirectoryRepository Directories { get; }
		SessionRepository Sessions { get; }
		void Save();
		bool HasAnyUnsavings();
	}
}
