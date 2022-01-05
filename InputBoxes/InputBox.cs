using InputBoxes.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputBoxes
{
	public class InputBox: IInputBox
	{
		public string Show(string title, string default_msg = "")
		{
			InputBoxForm f = new InputBoxForm();

			f.Prompt = title;
			f.UserInput = default_msg;

			if (DialogResult.OK == f.ShowDialog())
				return f.UserInput;
			else
				return string.Empty;
		}

		public bool UserAnsweredYes(string q)
		{
			DialogResult dr = MessageBox.Show(q, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			return DialogResult.Yes == dr;
		}

		public void ShowMessage(string msg)
		{
			MessageBox.Show(msg);
		}
	}
}
