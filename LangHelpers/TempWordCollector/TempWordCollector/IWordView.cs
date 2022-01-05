using TempWordCollector.Domain;

namespace TempWordCollector
{
	internal interface IWordView
	{
		bool ShowWord(Word w);
	}
}