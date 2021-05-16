using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTickerCounter
{
	public class TickCounterAnimator
	{
		Timer seconds = new Timer();
		Timer animation = new Timer();

		int second_amount = 0;
		bool timer_is_running = false;

		public Control DisplayTime { get; set; } = null;
		public Control DisplayRunningAnimation { get; set; } = null;
		public bool IsRunning => timer_is_running;

		string[] animFrames = new string[]{ "=>     ", " =>    ", "  =>   ", "   =>  ", "    => ", "     =>",
		"      =", "      <", "     <=", "    <= ", "   <=  ", "  <=   ", " <=    ", "<=     ", "=     ", ">     "};

		string pauseFrame = "[ | ]";

		int anim_frame = -1;

		string next_frame
		{
			get
			{
				anim_frame++;
				if (anim_frame >= animFrames.Length)
					anim_frame = 0;
				return animFrames[anim_frame];
			}
		}

		public TickCounterAnimator()
		{
			seconds.Tick += Seconds_Tick;
			animation.Tick += Animation_Tick;

			seconds.Interval = 1000;
			animation.Interval = 100;
		}
		bool tick_state = false;
		private void Animation_Tick(object sender, EventArgs e)
		{
			//if (tick_state) DisplayIsRunning.BackColor = Color.Beige;
			//else DisplayIsRunning.BackColor = Color.YellowGreen;
			//tick_state = !tick_state;

			DisplayRunningAnimation.Text = next_frame;
		}

		private void Seconds_Tick(object sender, EventArgs e)
		{
			DisplayTime.Text = get_time_string(++second_amount);
		}

		public void Play()
		{
			if (DisplayTime == null || DisplayRunningAnimation == null)
				throw new ArgumentNullException("TimeShow == null || IsRunningShow == null");

			seconds.Enabled = true;
			seconds.Start();
			timer_is_running = true;

			animation.Enabled = true;
			animation.Start();
		}

		public int TotalSeconds
		{
			get
			{
				return second_amount;
			}
			set
			{
				second_amount = value;
				DisplayTime.Text = get_time_string(second_amount);
			}
		}
		public void Pause()
		{
			seconds.Enabled = false;
			animation.Enabled = false;
			DisplayRunningAnimation.Text = pauseFrame;
		}

		public void ResetSeconds()
		{
			second_amount = 0;
			DisplayTime.Text = get_time_string(second_amount);
		}

		public void Stop()
		{
			if (!timer_is_running) return;
			
			seconds.Stop();
			seconds.Enabled = false;
			
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
