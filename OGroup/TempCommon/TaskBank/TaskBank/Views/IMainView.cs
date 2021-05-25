using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskBank
{
	public interface IMainView
	{
		event EventHandler<DateTime> CreateNoteCommand;
		event EventHandler<OTask> SaveNoteCommand;
		event EventHandler<OTask> DeleteNoteCommand;
		event EventHandler<string> CreateDir;
		void DisplayTaskCollection(IEnumerable<OTask> tlist);
	}
}
