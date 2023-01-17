using Domain.dto;
using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Services.Nodes
{
	internal class TreeNavigator
	{
		Stack<NodeDTO> owners = new Stack<NodeDTO>();

		public event EventHandler OwnerChanged;

		public TreeNavigator()
		{
			OnCurrentOwnerChanged();
		}

		public void Enter(NodeDTO dir)
		{
			if (dir == null)
				return;

			// если на входе выходная директория
			// попытаться выйти на уровень вверх.
			if (IsTopExit(dir))
				tryToJumpBack();
			else
			{
				owners.Push(dir);
				_highlightedDir = null;
				OnCurrentOwnerChanged();
			}
		}

		public void JumpBack()
		{
			tryToJumpBack();
		}

		public NodeDTO HighlightedNode => _highlightedDir;
		public string CurrentNodeFullName
		{
			get
			{
				string res = "";

				foreach (var item in owners.Reverse())
				{
					res += $"{item.name} \\ ";
				}

				res = res.TrimEnd(' ', '\\', ' ');

				return res;
			}
		}
		private NodeDTO currentOwner
		{
			get
			{
				if (!owners.Any()) return NodeDTO.Root;
				return owners.Peek();
			}
		}

		public NodeDTO CurrentOwner => currentOwner;

		private NodeDTO _highlightedDir;

		void OnCurrentOwnerChanged()
		{
			OwnerChanged?.Invoke(this, EventArgs.Empty);
		}

		private bool IsTopExit(NodeDTO r)
		{
			return r.type == NType.exit_dir;
		}
		private bool StackIsOnRoot()
		{
			return !owners.Any();
		}
		private void tryToJumpBack()
		{
			// если сейчас мы не находимся на корневой директории
			// вернуться на уровень вверх
			if (!StackIsOnRoot())
			{
				_highlightedDir = owners.Pop();
				OnCurrentOwnerChanged();
			}
		}
	}
}
