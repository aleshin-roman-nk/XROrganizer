using Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIComponents.Forms
{
	public partial class NTypeChooseForm : Form, INTypeChooseView
	{
		public NTypeChooseForm()
		{
			InitializeComponent();
		}

		NType getChoosed()
		{
			return (NType)listView1.SelectedItems[0].Tag;
		}

		public ViewResult<NType> Choose(IEnumerable<NType> items)
		{
			foreach (var item in items)
			{
				listView1.Items.Add(item.ToString()).Tag = item;
			}

			if (DialogResult.OK == ShowDialog())
			{
				return new ViewResult<NType>(getChoosed(), true);
			}
			else return new ViewResult<NType>(NType.none, false);
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
