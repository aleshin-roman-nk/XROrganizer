using SessionCollector.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTickerCounter;

namespace SessionCollector.Forms
{
	public partial class SessionTickerForm : Form, ISessionTickerView
	{

		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		TickCounterAnimator tickAnimator = new TickCounterAnimator();

		public bool IsRunning { get { return tickAnimator.IsRunning; } }
		public int TotalSeconds => tickAnimator.TotalSeconds;

		public string Title { get => lblTitle.Text; set { lblTitle.Text = value; } }

		public event EventHandler<int> SaveSeconds;
		public event EventHandler FinishedAndRejected;

		public SessionTickerForm()
		{
			InitializeComponent();

			tickAnimator.DisplayTime = lblTime;
			tickAnimator.DisplayRunningAnimation = lblAnimation;
			tickAnimator.PictureBox = pictureBox1;
		}

		//protected override void WndProc(ref Message m)
		//{
		//	switch (m.Msg)
		//	{
		//		case 0x84:
		//			base.WndProc(ref m);
		//			if ((int)m.Result == 0x1)
		//				m.Result = (IntPtr)0x2;
		//			return;
		//	}

		//	base.WndProc(ref m);
		//}

		private void button1_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnStopAndSave_Click(object sender, EventArgs e)
		{
			tickAnimator.Stop();
			SaveSeconds?.Invoke(this, tickAnimator.TotalSeconds);
			Hide();
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			tickAnimator.Play();
		}

		private void btnPause_Click(object sender, EventArgs e)
		{
			tickAnimator.Pause();
		}

		private void btnCloseAndForget_Click(object sender, EventArgs e)
		{
			tickAnimator.Stop();
			Hide();
			tickAnimator.ResetSeconds();
			FinishedAndRejected?.Invoke(this, EventArgs.Empty);
		}

		public void StartWatching(int sec)
		{
			tickAnimator.Stop();
			tickAnimator.ResetSeconds();
			tickAnimator.TotalSeconds = sec;
			Show();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			//250; 211; 144
			ControlPaint.DrawBorder(e.Graphics, this.panel2.ClientRectangle, Color.FromArgb(250, 211, 144), ButtonBorderStyle.Solid);
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.FromArgb(250, 211, 144), ButtonBorderStyle.Solid);
		}
	}
}
