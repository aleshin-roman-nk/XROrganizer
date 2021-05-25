using DirectoriesWolking.Models.DirNavigator;
using DirectoryNavigator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * >>> 26-03-2021 12:08
 * Попытка обобщить.
 * А зачем?
 * Все узлы системы должны иметь свой тип просто. И допустить вложенные данные.
 *		И вложенные данные, дополнительную информацию.
 *		
 * Основная задача - в одной системе иметь объекты разных типов.
 * Одно из решений - иметь тип объекта. Таблица типов. Таблица методов работы над конкретным типом.
 * 
 * Подумать как можно применить дженерики или работа с интерфейсами.
 * Задача - навигация по древовидной структуре разнородных элементов..
 * 
 * В любом случае элемент системы должен подчинятся определенному интерфейсу.
 * В любом случае исследовать как применяются интерфейсы и как применяются обобщения.
 *
 * Обобщения - это означает, что все элементы массива одно типа TEntity.
 * Поэтому нужно работать с интерфейсом, без этого никак не получить массив с разнотипными элементами.
 * (var#002)Другой случай, в данный момент, пусть массив узлов будет одного типа - Dir, но по его id в базе данных можно найти все что нужно.
 *	Кажется вариант var#002 более рационален и расширяем. Мы просто добавляем новую сущность, модуль в систему. Эту сущность нетрудно цеплять к Dir
 *
 * >>>21-05-2021
 * Думаю что состояние подсвеченной директории нужно брать отсюда, так как это образ состояния
 * дерева.
 *
 */

namespace DirectoriesWolking.Models.DirNavigator
{
	/*
	 * Оформить с интерфейсом API
	 * 
	 */

	public class DirectoryNavigatorService
	{
		NodeRepository _repo;
		Stack<INode> owners = new Stack<INode>();

		readonly INode _root = new BaseDir { name = "", id = 0, type = NType._sys_root_dir };
		readonly INode _exit_top_dir = new BaseDir { name = "..", id = -1, type = NType.exit_dir };

		private INode _highlightedDir;

		public DirectoryNavigatorService(NodeRepository r)
		{
			_repo = r;
		}

		public event EventHandler<NodesImage> CurrentNodeChanged;

		public INode CurrentOwner
		{
			get
			{
				if (!owners.Any()) return _root;
				return owners.Peek();
			}
		}

		public void Update()
		{
			OnCurrentNodeChanged();
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
			if(!StackIsOnRoot())
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

			var all_items = _repo.all;

			var items = (from d in all_items where d.owner_id == own_id select d).OrderBy(x=>x.type).ThenBy(x=>x.name).ToList();

			res.AddRange(items);

			return res;
		}
	}
}
