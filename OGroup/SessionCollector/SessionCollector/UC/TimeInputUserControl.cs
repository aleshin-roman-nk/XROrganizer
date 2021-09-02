using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionCollector.UC
{
	public partial class TimeInputUserControl : UserControl
	{
		TimeSpan _allTime;

		TimeSpan _mins = new TimeSpan(0, 5, 0);
		TimeSpan _hrs = new TimeSpan(1, 0, 0);

		public int TotalSeconds
		{
			get
			{
				return (int)_allTime.TotalSeconds;
			}
			set
			{
				_allTime = TimeSpan.FromSeconds(value);
				update();
			}
		}

		public TimeInputUserControl()
		{
			InitializeComponent();

			_allTime = new TimeSpan();
		}
		Color label6Backgfround;
		private void label5_MouseEnter(object sender, EventArgs e)
		{
			var lbl = sender as Label;

			label6Backgfround = lbl.BackColor;
			lbl.BackColor = ColorTranslator.FromHtml("#b8e994");
		}

		private void label5_MouseLeave(object sender, EventArgs e)
		{
			var lbl = sender as Label;
			lbl.BackColor = label6Backgfround;
		}

		// add min
		private void label3_Click(object sender, EventArgs e)
		{
			_allTime += _mins;
			update();
		}

		// dec min
		private void label4_Click(object sender, EventArgs e)
		{
			_allTime -= _mins;
			update();
		}
		
		// add hours
		private void label6_Click(object sender, EventArgs e)
		{
			_allTime += _hrs;
			update();
		}
		// dec hours
		private void label5_Click(object sender, EventArgs e)
		{
			_allTime -= _hrs;
			update();
		}

		private void update()
		{
			label7.Text = _allTime.ToString();
		}
	}
}
