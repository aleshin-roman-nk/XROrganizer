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
	public partial class StopwatchForm : Form
	{
		int second_amount = 0;
		bool timer_is_running = false;
		public StopwatchForm()
		{
			InitializeComponent();

			timer1.Interval = 1000;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblOut.Text = get_time_string(++second_amount);
		}

		string get_time_string(int seconds)
		{
			var res = TimeSpan.FromSeconds(seconds);
			return $"{res.Hours:d2}:{res.Minutes:d2}:{res.Seconds:d2}";
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			timer1.Enabled = true;
			timer1.Start();
			timer_is_running = true;

			timer2.Enabled = true;
			timer2.Start();
		}

		private void btnPause_Click(object sender, EventArgs e)
		{
			//timer1.Stop();
			timer1.Enabled = false;
			timer2.Enabled = false;
		}

		bool resetHasConfirmed()
		{
			return UserAnswerYesBox.ShowDialog("The timer is going to be reset. Are you sure you want it to be this way?");
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			if (!timer_is_running) return;
			if (!resetHasConfirmed()) return;

			timer1.Stop();
			timer1.Enabled = false;
			second_amount = 0;
			lblOut.Text = get_time_string(second_amount);

			timer_is_running = false;

			timer2.Stop();
			timer2.Enabled = false;
		}

		private void btnClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.Clear();
			Clipboard.SetText(get_time_string(second_amount));
		}

		bool tick_state = false;

		private void timer2_Tick(object sender, EventArgs e)
		{
			if (tick_state) label1.BackColor = Color.Beige;
			else label1.BackColor = Color.YellowGreen;
			tick_state = !tick_state;
		}
	}
}
