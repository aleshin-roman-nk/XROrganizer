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

namespace Shared.UI.Forms
{
	public partial class ChooseDateForm : Form
	{
		private const int cGrip = 16;      // Grip size
		private const int cCaption = 32;   // Caption bar height;

		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		public ChooseDateForm()
		{
			InitializeComponent();

			this.DoubleBuffered = true;
			this.SetStyle(ControlStyles.ResizeRedraw, true);
		}

		protected override void OnPaint(PaintEventArgs e)
		{

			Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
			//Уголок изменения размера окна снизу справа.
			//ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);

			rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
			e.Graphics.FillRectangle(Brushes.CadetBlue, rc);

			Rectangle fullrec = new Rectangle(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);
			e.Graphics.DrawRectangle(Pens.Black, fullrec);
		}

		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 0x84)
			{  // Trap WM_NCHITTEST
				Point pos = new Point(m.LParam.ToInt32());
				pos = this.PointToClient(pos);
				// Перетаскивание
				if (pos.Y < cCaption)
				{
					m.Result = (IntPtr)2;  // HTCAPTION
					return;
				}
				// Изменение размера за правый нижний уголок
				//if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
				//{
				//	m.Result = (IntPtr)17; // HTBOTTOMRIGHT
				//	return;
				//}
			}
			base.WndProc(ref m);
		}

		private void ChooseDateForm_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				DialogResult = DialogResult.OK;
				e.Handled = true;
			}
			else if (e.KeyCode == Keys.Escape)
			{
				DialogResult = DialogResult.Cancel;
				e.Handled = true;
			}
		}

		public ViewResponse<DateTime> Choose()
		{
			if (DialogResult.OK == ShowDialog())
			{
				return new ViewResponse<DateTime> { Data = myCalendar1.CurrentDate, Ok = true };
			}
			else return new ViewResponse<DateTime> { Data = default, Ok = false };
		}
	}
}
