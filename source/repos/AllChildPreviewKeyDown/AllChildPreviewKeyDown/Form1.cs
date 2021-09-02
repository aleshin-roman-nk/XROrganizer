using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllChildPreviewKeyDown
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			listBox2.Items.Add($"KeyCode {e.KeyCode},Shift {e.Shift},Alt {e.Alt},Control {e.Control}");
		}
	}
}
