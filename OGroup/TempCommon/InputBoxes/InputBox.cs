using InputBoxes.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputBoxes
{
	public class InputBox
	{
		public static string Show(string title, string default_msg = "")
		{
			InputBoxForm f = new InputBoxForm();

			f.Prompt = title;
			f.UserInput = default;

			if (DialogResult.OK == f.ShowDialog())
				return f.UserInput;
			else
				return string.Empty;
		}

		public static bool UserAnsweredYes(string q)
		{
			DialogResult dr = MessageBox.Show(q, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			return DialogResult.Yes == dr;
		}

		public static void ShowMessage(string msg)
		{
			MessageBox.Show(msg);
		}
	}
}
