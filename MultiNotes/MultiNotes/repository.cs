using aleshin_rv.tools;
using MultiNotes.Entities;
using MultiNotes.tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiNotes
{
	public class repository
	{
		List<MNote> _notes;
		IEnumerable<MBoard> _boards;

		public IEnumerable<MBoard> Boards => _boards;

		readonly string _path;
		public repository(string path)
		{
			_path = path;
			_notes = new List<MNote>();
			_boards = GetAllBoards().OrderBy(x=>x.id).ToList();
		}

		private IEnumerable<MBoard> GetAllBoards()
		{
			var files = Directory.GetFiles(_path, "board*.txt");

			foreach (var file in files)
				yield return ObjectReadWrite.Read<MBoard>(file);
		}

		private bool exists(MNote note)
		{
			var nHC = GetNoteHashCode.Calculate(note.notetxt);
			return _notes.FirstOrDefault(x => GetNoteHashCode.Calculate(x.notetxt) == nHC) != null;

			//return _notes.FirstOrDefault(x => x.id.Equals(note.id)) != null;
		}

		public void LoadContent()
		{
			LoadAllNotes();
		}

		private void LoadAllNotes()
		{
			var files = Directory.GetFiles(_path, "note*.txt");
			foreach (var file in files)
			{
				var o = ObjectReadWrite.Read<MNote>(file);
				if (!exists(o))
					_notes.Add(o);
				else
					File.Delete(file);
			}

			//_notes = _notes.OrderBy(x => x.id).ToList();
			_notes = _notes.OrderByDescending(x => x.date).ToList();
		}

		public IEnumerable<MNote> GetNotesOf(MBoard brd)
		{
			return _notes.Where(x => x.boardid.Equals(brd.gdid)).ToList();
		}
	}
}
