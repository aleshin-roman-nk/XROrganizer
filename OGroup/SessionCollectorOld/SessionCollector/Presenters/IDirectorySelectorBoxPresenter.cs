using mvp_base;
using SessionCollector.BL.Entities;
using System.Collections.Generic;

namespace SessionCollector.Presenters
{
	public interface IDirectorySelectorBoxPresenter
	{
		ViewResponse<INode> Go(INode selectedNode = null);
	}
}