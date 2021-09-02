using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;

namespace CommonUIComponents.ViewComponents
{
	/// <summary>
	/// Вход:
	/// Функции:
	/// Выход:
	/// </summary>
	public interface IFilesView
	{
		INode Selected { get; }
		void DisplayFiles(IEnumerable<INode> tcollection);
		void SetClipboardState(int cnt);

		void SetFileGridCustomizer(INodeTypeCustomizer customizer);

		event EventHandler<IEnumerable<INode>> PutNodesToClipboard;
		event EventHandler Paste;
		event EventHandler<NType> Create;
		event EventHandler<INode> Delete;
		event EventHandler<INode> Save;
	}
}