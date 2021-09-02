using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TempWordCollector.Domain;

namespace TempWordCollector.Views
{
	public interface IMainView
	{
		void DisplayWords(IEnumerable<Word> words);
		event EventHandler CreateWord;
		event EventHandler<Word> DeleteWord;
		event EventHandler Save;
	}
}
