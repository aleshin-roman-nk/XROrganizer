using Domain.Entities;
using Domain.Enums;
using Domain.Repos;
using Domain.Services.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Services
{

	/*
	 * >>> 12-06-2021 13:17
	 * !!!!!!! От этого класса нужно только событие об изменении и выбранная директория
	 * // этот класс только отдает одну единственную сущность, которую нужно раскрыть.
	 */

	/*
	 * >>> 12-06-2021 17:26
	 * Произошла расстыковка пространства одной очереди узлов.
	 * То есть теоретически можно запихнуть в EnterDir(INode dir) все что угодно.
	 *	Поэтому этот класс должен быть частью особого репозитория, который является управляющим.
	 * 
	 * 
	 */

	public class NodeNavigator : INodeNavigator
	{
		Stack<INode> owners = new Stack<INode>();

		public event EventHandler OwnerChanged;

		public NodeNavigator()
		{
			OnCurrentOwnerChanged();
		}

		public void Enter(INode dir)
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

		public INode HighlightedNode => _highlightedDir;

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
		private INode currentOwner
		{
			get
			{
				if (!owners.Any()) return RootNode.Value;
				return owners.Peek();
			}
		}

		public INode CurrentOwner => currentOwner;

		private INode _highlightedDir;

		void OnCurrentOwnerChanged()
		{
			OwnerChanged?.Invoke(this, EventArgs.Empty);
		}

		private bool IsTopExit(INode r)
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
