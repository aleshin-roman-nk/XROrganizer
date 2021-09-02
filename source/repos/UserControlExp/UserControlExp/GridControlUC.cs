using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlExp
{
	public partial class GridControlUC : UserControl
	{
		public GridControlUC()
		{
			InitializeComponent();
		}

		public DataGridView Grid => dataGridView1;

		public Button BtnSave { get; set; }
		public Button BtnClose { get; set; }
	}
}
