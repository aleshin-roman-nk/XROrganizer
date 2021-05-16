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
 */

namespace DirectoriesWolking.Models.DirNavigator
{
	/*
	 * Оформить с интерфейсом API
	 * 
	 */

	public class DirectoryNavigatorService
	{
		DirectoryRepository _repo;
		Stack<IDir> owners = new Stack<IDir>();

		readonly IDir _root = new BaseDir { name = "root", id = 0, type = NodeType._sys_root_dir };
		readonly IDir _exit_top_dir = new BaseDir { name = "..", id = -1, type = NodeType.exit_dir };

		public event EventHandler<IDir> CurrentDirChanged;

		public DirectoryNavigatorService(DirectoryRepository r)
		{
			_repo = r;
			owners.Push(_root);
		}

		private IDir _previous_owner;

		private IDir GetPreviousOwner()
		{
			return _previous_owner;
		}

		public IDir GetCurrentDir()
		{
			return owners.Peek();
		}

		private DirNavigatorDataImage dirNavigatorDataImage = new DirNavigatorDataImage();

		public DirNavigatorDataImage GetDataImage()
		{
			updateImage();
			return dirNavigatorDataImage;
		}

		private void OnCurrentDirChanged()
		{
			CurrentDirChanged?.Invoke(this, GetCurrentDir());
		}

		private void updateImage()
		{
			dirNavigatorDataImage.CurrentBranch = GetCurrentBranch();
			dirNavigatorDataImage.CurrentBranchName = GetCurrentBranchName();
			dirNavigatorDataImage.PreviousOwner = GetPreviousOwner();
			dirNavigatorDataImage.LastMovment = LastMovment;
			dirNavigatorDataImage.CurrentDir = GetCurrentDir();
		}

		private IEnumerable<IDir> GetCurrentBranch()
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

		private bool IsTopExit(IDir r)
		{
			return r.id == _exit_top_dir.id;
		}

		private bool StackIsOnRoot()
		{
			return owners.Peek().id == _root.id;
		}

		public void EnterDir(IDir dir)
		{
			if (dir == null)
			{
				LastMovment = LastMovment.nomovement;
				return;
			}

			// если на входе выходная директория
			// попытаться выйти на уровень вверх.
			if (IsTopExit(dir))
				tryToJumpBack();
			else
			{
				owners.Push(dir);
				LastMovment = LastMovment.next;
				_previous_owner = dir;
				OnCurrentDirChanged();
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
				_previous_owner = owners.Pop();
				LastMovment = LastMovment.prev;
				OnCurrentDirChanged();
			}
			else
				LastMovment = LastMovment.nomovement;
		}

		private LastMovment LastMovment { get; set; } = LastMovment.nomovement;
		private IEnumerable<IDir> select(int own_id)
		{
			List<IDir> res = new List<IDir>();
			if (owners.Peek() != _root)
				res.Add(_exit_top_dir);

			var all_items = _repo.all;

			var items = (from d in all_items where d.owner_id == own_id select d).OrderBy(x=>x.type).ThenBy(x=>x.name).ToList();

			res.AddRange(items);

			return res;
		}
	}
}
