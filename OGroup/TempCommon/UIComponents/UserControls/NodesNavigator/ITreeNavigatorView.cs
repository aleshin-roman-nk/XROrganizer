using Domain.Entities;
using Domain.Enums;
using Domain.Services.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace CommonUIComponents.NodesNavigator
{
	public interface ITreeNavigatorView
	{
		Dictionary<NType, Image> Icons { get; set; }
		Dictionary<NType, Color> RowColors { get; set; }

		event EventHandler<INode> ActivateNode;
		event EventHandler ExitNode;

		/// <summary>
		/// Node under the cursor
		/// </summary>
		INode CurrentNode { get; }

		void DisplayData(NodeNavigatorImage dataImage);

		/*
		 * >>> 29-05-2021 00:36
		 * Icons и RowColors жить должны здесь. IDirNavigatorView дергает методы IGridCustomizer для кастомизации.
		 */
		INodeTypeCustomizer GridCustomizer { get; set; }
	}
}