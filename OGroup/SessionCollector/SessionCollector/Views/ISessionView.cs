using mvp_base;
using SessionCollector.BL.Entities;
using System;

namespace SessionCollector.Views
{
	public interface ISessionView
	{
		ViewResult<OSession> Go(OSession o);
		event EventHandler<ViewResultParams<OSession, INode>> ChangeDirectory;
	}
}
