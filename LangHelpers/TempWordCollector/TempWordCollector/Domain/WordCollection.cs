using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempWordCollector.Domain
{
	public class WordCollection
	{
		List<Word> _words;
		int words_purpose;

		public IEnumerable<Word> Items => _words.OrderBy(x=>x.Text).ToList();

		public int TotalWords => Items.Count();

		public WordCollection(string f)
		{
			Load(f);
		}

		public void Load(string f)
		{
			if(File.Exists(f))
			{
				string j = File.ReadAllText(f, Encoding.UTF8);
				_words = JSONTool<List<Word>>.GetObj(j);
			}
			else
			{
				_words = new List<Word>();
			}
		}

		public void Save(string f)
		{
			File.WriteAllText(f, JSONTool<List<Word>>.SerObj(_words),  Encoding.UTF8);
		}

		public void SaveWord()
		{

		}

		private bool Exists(string w)
		{
			return _words.FirstOrDefault(x => x.Text.ToUpper().Equals(w.ToUpper())) != null;
		}

		public void AddWord(Word w)
		{
			if (string.IsNullOrEmpty(w.Text) || string.IsNullOrEmpty(w.meaning)) throw new Exception($"word must not be spice");
			if (Exists(w.Text)) throw new Exception($"{w.Text} already exists");
			_words.Add(w);
		}

		public void Delete(Word w)
		{
			_words.Remove(w);
		}
	}
}
