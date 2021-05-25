using Domain.Entities;
using Domain.Enums;
using Domain.Services.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace UIComponents.NodesNavigator
{
	public interface IDirNavigatorView
	{
		Dictionary<NType, Image> Icons { get; set; }
		Dictionary<NType, Color> RowColors { get; set; }

		event EventHandler<INode> ActivateNode;
		event EventHandler ExitNode;

		void SetDirImage(NodesImage dataImage);
	}
}