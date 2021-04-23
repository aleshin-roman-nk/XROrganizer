using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aleshin_rv.UIHelpers
{
	public static class DataGridViewEx
	{
		public static void AddCol(this DataGridView dgv, int width, string headerText, string dataPropertyName, string name)
		{
			dgv.Columns.Add(
				new DataGridViewTextBoxColumn
				{
					Width = width,
					HeaderText = headerText,
					DataPropertyName = dataPropertyName,
					Name = name
				});
		}
	}
}
