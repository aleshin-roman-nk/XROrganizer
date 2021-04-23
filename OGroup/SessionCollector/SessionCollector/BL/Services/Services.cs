using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.BL.Services
{
	public class Services
	{
		SessionService _srvVar = new SessionService();
		public SessionService Sessions => _srvVar;
	}
}
