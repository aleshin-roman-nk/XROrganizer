using LngModules.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LngModules.Domain
{
	public interface IPhraseRepository
	{
		void Save(Lexem p);
		void Delete(Lexem p);
		Lexem FirstOrDefault(string phrase);
		IEnumerable<Lexem> GetPhrases(string first_letters);
	}
}
