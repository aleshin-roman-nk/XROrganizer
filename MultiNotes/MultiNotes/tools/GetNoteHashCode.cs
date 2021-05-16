using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiNotes.tools
{
	public static class GetNoteHashCode
	{
		public static UInt64 Calculate(string read)
		{
			UInt64 hashedValue = 3074457345618258791ul;
			for (int i = 0; i < read.Length; i++)
			{
				hashedValue += read[i];
				hashedValue *= 3074457345618258799ul;
			}
			return hashedValue;
		}
	}
}
