using Domain.dto;
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
		void DisplayNodes(IEnumerable<NodeDTO> tcollection, string path, NodeDTO highlightedNode);
		void SetFileGridCustomizer(INodeTypeCustomizer customizer);

		IEnumerable<NodeDTO> SelectedNodes { get; }

		void SetCursorAt(NodeDTO n);

		event EventHandler<IEnumerable<NodeDTO>> SendNodesToClipboard;
		event EventHandler Paste;
		event EventHandler<NodeDTO> ActivateNode;

		event EventHandler LeaveNode;
		event EventHandler<NodeDTO> CurrentNodeChanged;
	}
}