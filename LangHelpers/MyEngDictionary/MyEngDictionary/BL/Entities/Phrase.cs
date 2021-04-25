using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

/*
 * >>> 29.07.2020 16:01
 * 
 * Сделать карточки слов.
 * Отношение многие ко многим joining table
 * 
 * 
 */

namespace MyEngDictionary.BL.Entities
{
	public class Phrase// rename to "LangUnit". This can be a word, idiom, grammar, etc.
	{
		public int Id { get; set; }
		public int? PhrasePackId { get; set; }
		public int LangId { get; set; }
		public string TextEng { get; set; }
		public string Explanation { get; set; }
		public PhraseType PhraseType { get;set;}// Doesn't care if it is a word of an idiom. I belive all of that are vocabulary. But there is difference: type of a thing - grammar rule. It is descriprion, examples. A can collect wards and grammars together and make it a group. And exercise them.
		public bool IsKnown { get; set; }// rename to "IsHide"
		public string Exercises { get; set; }
		public DateTime? LastChange { get; set; }
	}
}
