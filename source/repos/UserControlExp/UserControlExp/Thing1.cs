using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlExp
{
	public partial class Thing1 : Component, IButtonPanel
	{
		public Thing1()
		{
			InitializeComponent();
		}

		public Thing1(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}

		public Button SaveButton { get; set; }
		public Button DeleteButton { get; set; }
	}
}
