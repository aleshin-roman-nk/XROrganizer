using Domain.dto;
using Domain.Entities;
using Shared.UI.Interfaces;
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

		IInputBox _inputBox;

		public CurrentTaskBufferForm(IInputBox inputBox)
		{
			InitializeComponent();

			_inputBox = inputBox;

			bs = new BindingSource();
			dataGridView1.DataSource = bs;
			bs.CurrentItemChanged += Bs_CurrentItemChanged;

			this.DoubleBuffered = true;
			this.SetStyle(ControlStyles.ResizeRedraw, true);
			dataGridView1.AutoGenerateColumns = false;
		}

		public event EventHandler<NodeDTO> CreateSession;
        public event EventHandler Completed;
        public event EventHandler<BufferTask> Delete;

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


		BindingSource bs;
		public void Go(IEnumerable<BufferTask> bufferTasks)
		{
			bs.DataSource = bufferTasks;
			Show();
		}

		private void Bs_CurrentItemChanged(object sender, EventArgs e)
		{
			var i = bs.Current as BufferTask;

			if(i != null)
				richTextBox1.Text = i.descr;
		}

		private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
		{
			BufferTask n = (dataGridView1.DataSource as BindingSource).Current as BufferTask;
			if (n == null) return;

			if (e.KeyCode == Keys.Enter)
			{
				CreateSession?.Invoke(this, new NodeDTO { id = n.Node.id });
				e.Handled = true;
			}
			else if(e.KeyCode == Keys.Delete)
            {
				if(_inputBox.UserAnsweredYes($"Confirm deleting {n.path}"))
					Delete?.Invoke(this, n);
            }
		}

        private void CurrentTaskBufferForm_FormClosed(object sender, FormClosedEventArgs e)
        {
			Completed?.Invoke(this, EventArgs.Empty);
        }

        public void Update(IEnumerable<BufferTask> bufferTasks)
        {
			bs.DataSource = null;
			bs.DataSource = bufferTasks;
		}

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
			if (e.RowIndex < 0) return;

			var i = dataGridView1.Rows[e.RowIndex].DataBoundItem as BufferTask;

			CreateSession?.Invoke(this, new NodeDTO { id = i.Node.id });
		}
    }
}
