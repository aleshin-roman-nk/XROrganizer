using SessionCollector.BL.Entities;
using SessionCollector.BL.Entities.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.BL.Repo
{
	public interface ISessionRepository
	{
		void Delete(OSession e);
		IEnumerable<OSession> GetOfDay(DateTime date);
		void Save(OSession e);
		int GetSecondsOfDay(DateTime dt, INode dir);
	}
}
