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
		event EventHandler<RmTask> SaveTaskCommand;
		event EventHandler<RmTask> DeleteNoteCommand;
		void DisplayTaskCollection(IEnumerable<RmTask> tlist);
	}
}
