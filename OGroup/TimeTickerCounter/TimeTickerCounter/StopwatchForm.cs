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
		TickCounterController tickCtrl;

		public StopwatchForm()
		{
			InitializeComponent();

			tickCtrl = new TickCounterController();
			tickCtrl.IsRunningShow = label1;
			tickCtrl.TimeShow = lblOut;
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			tickCtrl.Play();
		}

		private void btnPause_Click(object sender, EventArgs e)
		{
			tickCtrl.Pause();
		}

		bool resetHasConfirmed()
		{
			return UserAnswerYesBox.ShowDialog("The timer is going to be reset. Are you sure you want it to be this way?");
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			if (!resetHasConfirmed()) return;

			tickCtrl.Stop();
		}

		private void btnClipboard_Click(object sender, EventArgs e)
		{
			Clipboard.Clear();
			Clipboard.SetText(tickCtrl.TimeAsString);
		}
	}
}
