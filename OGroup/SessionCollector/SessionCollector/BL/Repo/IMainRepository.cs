using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.BL.Repo
{
	public interface IMainRepository
	{
		NodeRepository Nodes { get; }
		SessionRepository Sessions { get; }
		void Save();
		bool HasAnyUnsavings();
	}
}
