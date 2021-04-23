using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTickerCounter
{
	public partial class UserAnswerYes : Form
	{
		public string _msg { get => txtText.Text; set { txtText.Text = value; } }

		public UserAnswerYes()
		{
			InitializeComponent();
		}
	}

	public static class UserAnswerYesBox
	{
		public static bool ShowDialog(string msg)
		{
			UserAnswerYes _slg = new UserAnswerYes();
			_slg._msg = msg;

			return _slg.ShowDialog() == DialogResult.OK;
		}
	}
}
