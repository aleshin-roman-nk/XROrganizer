using Domain.Enums;
using Shared.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Shared.UI.Dlg.Forms
{
	public partial class NTypeChooseForm : Form
	{
		public NTypeChooseForm()
		{
			InitializeComponent();
		}

		string getChoosed()
		{
			return (string)listView1.SelectedItems[0].Tag;
		}

		public ViewResponse<string> Choose(IEnumerable<string> items)
		{
			foreach (var item in items)
			{
				listView1.Items.Add(item.ToString()).Tag = item;
			}

			if (DialogResult.OK == ShowDialog())
			{
				return new ViewResponse<string>{Data = getChoosed(), Ok = true};
			}
			else return new ViewResponse<string> { Ok = false };
		}

		private void listView1_DoubleClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
