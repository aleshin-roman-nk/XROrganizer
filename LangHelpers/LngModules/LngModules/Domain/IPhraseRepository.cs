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
		void Save(Phrase p);
		void Delete(Phrase p);
		Phrase FirstOrDefault(string phrase);
		IEnumerable<Phrase> GetPhrases(string first_letters);
	}
}
