using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;

namespace Shared.UI.Interfaces
{
	/// <summary>
	/// Вход:
	/// Функции:
	/// Выход:
	/// </summary>
	public interface INodesView
	{
		void DisplayNodes(IEnumerable<INode> tcollection, string path, INode highlightedNode);
		void SetFileGridCustomizer(INodeTypeCustomizer customizer);

		IEnumerable<INode> SelectedNodes { get; }

		void SetCursorAt(INode n);

		event EventHandler<IEnumerable<INode>> SendNodesToClipboard;
		event EventHandler Paste;
		event EventHandler<INode> ActivateNode;

		event EventHandler LeaveNode;
		event EventHandler<INode> CurrentNodeChanged;

		void RenderData(IEnumerable<INode> nodes, IEnumerable<INode> parents);
	}
}