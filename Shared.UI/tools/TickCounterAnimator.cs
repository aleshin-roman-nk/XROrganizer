using Shared.UI.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared.UI.tools
{
	public class TickCounterAnimator
	{
		Timer seconds = new Timer();
		Timer animation = new Timer();

		int second_amount = 0;
		bool timer_is_running = false;

		public Control DisplayTime { get; set; } = null;
		public Control DisplayRunningAnimation { get; set; } = null;
		public PictureBox PictureBox { get; set; } = null;
		public event EventHandler<int> TotalSecondsChanged;
		public bool IsRunning => timer_is_running;

		Image[] animFramesImg = new Image[] { Resources.sessAnim01, Resources.sessAnim02 };

		string pauseFrame = "[ | ]";

		int anim_frame = -1;
		int anim_frame_img = -1;

		Image next_frame_img
		{
			get
			{
				anim_frame_img++;
				if (anim_frame_img >= animFramesImg.Length)
					anim_frame_img = 0;
				return animFramesImg[anim_frame_img];
			}
		}

		public TickCounterAnimator()
		{
			seconds.Tick += Seconds_Tick;
			animation.Tick += Animation_Tick;

			seconds.Interval = 1000;
			animation.Interval = 300;
		}

		private void Animation_Tick(object sender, EventArgs e)
		{
			if(PictureBox != null)
			{
				PictureBox.Image = next_frame_img;
			}
		}

		private void Seconds_Tick(object sender, EventArgs e)
		{
			++second_amount;

			if (DisplayTime != null)
			{
				DisplayTime.Text = get_time_string(second_amount);
			}
			TotalSecondsChanged?.Invoke(this, second_amount);
		}

		public void Play()
		{
			//if (DisplayTime == null || DisplayRunningAnimation == null)
			//	throw new ArgumentNullException("TimeShow == null || IsRunningShow == null");

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
				if(DisplayTime != null)
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
