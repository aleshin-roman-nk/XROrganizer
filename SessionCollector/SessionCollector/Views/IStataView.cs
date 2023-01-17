using Domain.dto;
using Domain.Entities;
using Services.Sessions.Entities.UI;
using System;
using System.Collections.Generic;

namespace SessionCollector.Views
{
	public interface IStataView
	{
		void Go(NodeDTO d);

        NodeDTO Node { get; }
		DateTime CurrentDate { get; }

		event EventHandler DateChanged;
		event EventHandler Completed;
		void Display(IEnumerable<ChartItem> lst, string Title);
	}
}