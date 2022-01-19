using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared.UI.UserControls
{
	public partial class TimeInputUserControl : UserControl
	{
		TimeSpan _allTime;

		TimeSpan _mins = new TimeSpan(0, 5, 0);
		TimeSpan _hrs = new TimeSpan(1, 0, 0);

		public event EventHandler ValueChanged;


		private void OnValueChanged()
		{
			ValueChanged?.Invoke(this, EventArgs.Empty);
		}

		public int TotalSeconds
		{
			get
			{
				return (int)_allTime.TotalSeconds;
			}
			set
			{
				_allTime = TimeSpan.FromSeconds(value);
				//update();
				label7.Text = _allTime.ToString();
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

		private void update()
		{
			label7.Text = _allTime.ToString();
			OnValueChanged();
		}

		private void TimeInputUserControl_Paint(object sender, PaintEventArgs e)
		{
			var p = sender as UserControl;
			ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color.Yellow, ButtonBorderStyle.Solid);
		}

		private void label3_Paint(object sender, PaintEventArgs e)
		{
			var p = sender as Label;
			ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color.Yellow, ButtonBorderStyle.Solid);
		}

		private void btnMinUp_Click(object sender, EventArgs e)
		{
			_allTime += _mins;
			update();
		}

		private void btnMinDown_Click(object sender, EventArgs e)
		{
			_allTime -= _mins;
			update();
		}

		private void btnHrUp_Click(object sender, EventArgs e)
		{
			_allTime += _hrs;
			update();
		}

		private void btnHrDown_Click(object sender, EventArgs e)
		{
			_allTime -= _hrs;
			update();
		}
	}
}
