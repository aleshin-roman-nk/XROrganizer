using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskBank.BL.Entities;

namespace TaskBank
{
	public interface IMainView
	{
		event EventHandler<DateTime> CreateNoteCommand;
		event EventHandler<OTask> SaveTaskCommand;
		event EventHandler<OTask> DeleteNoteCommand;
		void DisplayTaskCollection(IEnumerable<OTask> tlist);
	}
}
