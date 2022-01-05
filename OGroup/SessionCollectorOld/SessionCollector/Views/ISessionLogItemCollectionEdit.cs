using mvp_base;
using SessionCollector.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionCollector.Views
{
	public interface ISessionLogItemCollectionEdit
	{
		void Go(IEnumerable<NoteRec> recs);
		event EventHandler<ViewResponse<IEnumerable<NoteRec>>> WorkCompleted;
	}
}
