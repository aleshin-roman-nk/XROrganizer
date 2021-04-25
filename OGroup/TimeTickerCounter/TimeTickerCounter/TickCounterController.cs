using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTickerCounter
{
	public class TickCounterController
	{
		Timer seconds = new Timer();
		Timer animation = new Timer();

		int second_amount = 0;
		bool timer_is_running = false;

		public Control TimeShow { get; set; } = null;
		public Control IsRunningShow { get; set; } = null;

		string animLine = @"|/-\";
		int anim_frame = -1;

		char next_frame
		{
			get
			{
				anim_frame++;
				if (anim_frame >= animLine.Length)
					anim_frame = 0;
				return animLine[anim_frame];
			}
		}

		public TickCounterController()
		{
			seconds.Tick += Seconds_Tick;
			animation.Tick += Animation_Tick;

			seconds.Interval = 1000;
			animation.Interval = 500;
		}
		bool tick_state = false;
		private void Animation_Tick(object sender, EventArgs e)
		{
			IsRunningShow.Text = ">>>";

			if (tick_state) IsRunningShow.BackColor = Color.Beige;
			else IsRunningShow.BackColor = Color.YellowGreen;
			tick_state = !tick_state;

			//IsRunningShow.Text = next_frame.ToString();
		}

		private void Seconds_Tick(object sender, EventArgs e)
		{
			TimeShow.Text = get_time_string(++second_amount);
		}

		public void Play()
		{
			if (TimeShow == null || IsRunningShow == null)
				throw new ArgumentNullException("TimeShow == null || IsRunningShow == null");

			seconds.Enabled = true;
			seconds.Start();
			timer_is_running = true;

			animation.Enabled = true;
			animation.Start();
		}

		public decimal TotalSeconds
		{
			get
			{
				return second_amount;
			}
		}
		public void Pause()
		{
			seconds.Enabled = false;
			animation.Enabled = false;
		}

		public void Stop()
		{
			if (!timer_is_running) return;
			
			seconds.Stop();
			seconds.Enabled = false;
			second_amount = 0;
			TimeShow.Text = get_time_string(second_amount);

			timer_is_running = false;

			animation.Stop();
			animation.Enabled = false;
		}

		private string get_time_string(int seconds)
		{
			var res = TimeSpan.FromSeconds(seconds);
			return $"{res.Hours:d2}:{res.Minutes:d2}:{res.Seconds:d2}";
		}

		public string TimeAsString
		{
			get
			{
				return get_time_string(second_amount);
			}
		}
	}
}
