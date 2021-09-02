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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			entityBindingSource.DataSource = new List<Entity> { new Entity { Name = "Roman", Age = 41 } };
			gridControlUC1.Grid.DataSource = entityBindingSource;
		}
	}
}
