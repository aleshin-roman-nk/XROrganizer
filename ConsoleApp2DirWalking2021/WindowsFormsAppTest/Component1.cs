using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
	public partial class Component1 : Component
	{
		public DataGridView Grid { get; set; }

		public Component1()
		{
			InitializeComponent();
		}

		public Component1(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}
	}
}
