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
	public class NodesNavigatorService
	{
		INodeRepositoryReadOnly _repo;
		Stack<INode> owners = new Stack<INode>();

		readonly INode _root = new BaseNode { name = "", id = 0, type = NType._sys_root_dir };
		readonly INode _exit_top_dir = new BaseNode { name = "..", id = -1, type = NType.exit_dir };

		public event EventHandler<NodesImage> CurrentNodeChanged;

		public void Update()
		{
			OnCurrentNodeChanged();
		}

		public INode CurrentOwner
		{
			get
			{
				if (!owners.Any()) return _root;
				return owners.Peek();
			}
		}

		public NodesNavigatorService(INodeRepositoryReadOnly r)
		{
			_repo = r;
		}

		private INode _highlightedDir;

		private void OnCurrentNodeChanged()
		{
			NodesImage arg = new NodesImage
			{
				CurrentBranch = GetCurrentBranch(),
				CurrentBranchName = GetCurrentBranchName(),
				CurrentOwner = CurrentOwner,
				HighlightedDir = _highlightedDir
			};

			CurrentNodeChanged?.Invoke(this, arg);
		}

		private IEnumerable<INode> GetCurrentBranch()
		{
			if (!StackIsOnRoot())
				return select(owners.Peek().id);
			else
				return select(_root.id);
		}

		private string GetCurrentBranchName()
		{
			string res = "";

			foreach (var item in owners.Reverse())
			{
				res += $"{item.name}.";
			}

			res = res.TrimEnd('.');

			return res;
		}

		private bool IsTopExit(INode r)
		{
			return r.id == _exit_top_dir.id;
		}

		private bool StackIsOnRoot()
		{
			return !owners.Any();
		}

		public void EnterDir(INode dir)
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
				_highlightedDir = _exit_top_dir;
				OnCurrentNodeChanged();
			}
		}

		public void JumpBack()
		{
			tryToJumpBack();
		}

		private void tryToJumpBack()
		{
			// если сейчас мы не находимся на корневой директории
			// вернуться на уровень вверх
			if (!StackIsOnRoot())
			{
				_highlightedDir = owners.Pop();
				OnCurrentNodeChanged();
			}
		}

		private IEnumerable<INode> select(int own_id)
		{
			List<INode> res = new List<INode>();
			if (!StackIsOnRoot())
				res.Add(_exit_top_dir);

			var all_items = _repo.All;

			var items = (from d in all_items where d.owner_id == own_id select d).OrderBy(x => x.type).ThenBy(x => x.name).ToList();

			res.AddRange(items);

			return res;
		}
	}
}
