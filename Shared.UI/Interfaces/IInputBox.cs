using Domain.Enums;
using System;
using System.Collections.Generic;

namespace Shared.UI.Interfaces
{
	public interface IInputBox
	{
		string Show(string title, string default_msg = "");
		bool UserAnsweredYes(string q);
		void ShowMessage(string msg);
		void ShowObject(object o);
		ViewResponse<NType> ChooseNType(IEnumerable<NType> items);
		ViewResponse<DateTime> ChooseDateTime();
	}
}
