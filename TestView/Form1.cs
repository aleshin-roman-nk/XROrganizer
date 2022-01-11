using Shared.UI.Forms;
using System;
using System.Windows.Forms;

namespace TestView
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Text = InputBoxes.InputBox.Show("Enter your age");

			FTaskForm fff = new FTaskForm();
			fff.ShowDialog();
		}
	}
}
