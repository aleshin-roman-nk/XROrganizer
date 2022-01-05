using Domain.Entities;
using Shared.UI;
using System;
using System.Collections.Generic;

namespace SessionCollector.Views
{
	public interface ISessionLogItemCollectionEdit
	{
		void Go(IEnumerable<NoteRec> recs);
		event EventHandler<ViewResponse<IEnumerable<NoteRec>>> WorkCompleted;
	}
}
