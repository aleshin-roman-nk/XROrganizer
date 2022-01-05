using Domain.Entities;
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
	public partial class CurrentTaskBufferForm : Form, IBufferTaskView
	{
		private const int cGrip = 16;      // Grip size
		private const int cCaption = 32;   // Caption bar height;

		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();


		public CurrentTaskBufferForm()
		{
			InitializeComponent();

			this.DoubleBuffered = true;
			this.SetStyle(ControlStyles.ResizeRedraw, true);
			dataGridView1.AutoGenerateColumns = false;
		}

		public event EventHandler<INode> CreateSession;

		protected override void OnPaint(PaintEventArgs e)
		{
			Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
			ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);

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
				if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
				{
					m.Result = (IntPtr)17; // HTBOTTOMRIGHT
					return;
				}
			}
			base.WndProc(ref m);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		public void Display(IEnumerable<BufferTask> bufferTasks)
		{
			dataGridView1.DataSource = new BindingSource { DataSource = bufferTasks };
			ShowDialog();
		}

		private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				BufferTask n = (dataGridView1.DataSource as BindingSource).Current as BufferTask;

				CreateSession?.Invoke(this, n.Node);
				e.Handled = true;
			}
		}
	}
}
