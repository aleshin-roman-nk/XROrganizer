using Domain.Enums;
using Shared.UI.Dlg.Forms;
using Shared.UI.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using xorg.Tools;

namespace Shared.UI.Interfaces
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

		public ViewResponse<NType> ChooseNType(IEnumerable<NType> items)
		{
			NTypeChooseForm frm = new NTypeChooseForm();

			return frm.Choose(items);
		}

		public ViewResponse<DateTime> ChooseDateTime()
		{
			ChooseDateForm frm = new ChooseDateForm();

			return frm.Choose();
		}

		public void ShowObject(object o)
		{
			MessageBox.Show(JsonTool.Serialize(o));
		}
	}
}
