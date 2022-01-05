using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputBoxes
{
	public interface IInputBox
	{
		string Show(string title, string default_msg = "");
		bool UserAnsweredYes(string q);
		void ShowMessage(string msg);
	}
}
