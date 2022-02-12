using Domain.Entities;
using Shared.UI;
using Shared.UI.Interfaces;
using Shared.UI.tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using xorg.Tools;

namespace Shared.UI.Forms
{
	public partial class SessionForm : Form, ISingleSessionView
	{
		private const int cGrip = 16;      // Grip size
		//private const int cCaption = 32;   // Caption bar height;
		private const int cCaption = 42;   // Caption bar height;

		private const int WM_NCLBUTTONDOWN = 0xA1;
		private const int HT_CAPTION = 0x2;
		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		private static extern bool ReleaseCapture();


		OSession _ent;

//		ISessionLogItemCollectionEdit sessionLog;
		TickCounterAnimator tickCounterAnimator = new TickCounterAnimator();

		bool _closed;
		bool closed
		{
			get
			{
				return _closed;
			}
			set
			{
				_closed = value;

				if (_closed)
				{
					btnOpen.BackgroundImage = Properties.Resources.closed;
				}
				else
				{
					btnOpen.BackgroundImage = Properties.Resources.open;
				}
			}
		}

		private bool _isWorking = false;
		public bool IsWorking => _isWorking;

        public int ObjId => _ent.Id;

        public SessionForm()
		{
			InitializeComponent();

			typeof(Control).GetProperty("ResizeRedraw", BindingFlags.NonPublic | BindingFlags.Instance)
			.SetValue(panel1, true, null);

			typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance)
			.SetValue(panel1, true, null);

			this.DoubleBuffered = true;
			this.SetStyle(ControlStyles.ResizeRedraw, true);

			//tickCounterAnimator.DisplayTime = lblTotalTimeTicker;
			tickCounterAnimator.TotalSecondsChanged += TickCounterAnimator_TotalSecondsChanged;
			tickCounterAnimator.PictureBox = pictureBox1;
		}

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

		private void TickCounterAnimator_TotalSecondsChanged(object sender, int e)
		{
			timeInputUserControl1Total.TotalSeconds = e;
		}

		private void _set(OSession e)
		{
			_ent = e;

			dateTimePickerPlanStart.Value = e.Start;

			txtPlanFinish.Text = e.Finish.ToString("dd.MM.yyyy HH:mm");

			txtDescription.Clear();
			txtDescription.Text = e.Description;

			txtLogEnterConsole.Clear();

			timeInputUserControl1Total.TotalSeconds = _ent.TotalSeconds;
			timeInputUserControl2Provided.TotalSeconds = _ent.ProvidedSeconds;

			tickCounterAnimator.TotalSeconds = timeInputUserControl1Total.TotalSeconds;

			webBrowser1.DocumentText = e.Html;

			txtNodeName.Text = e.Name;

			owningNodeDescription.Text = e.Owner.text;

			closed = e.Closed;
		}

		private OSession _get()
		{
			_ent.ProvidedSeconds = timeInputUserControl2Provided.TotalSeconds;
			//_ent.TotalSeconds = tickCounterAnimator.TotalSeconds > timeInputUserControl1Total.TotalSeconds ? tickCounterAnimator.TotalSeconds : timeInputUserControl1Total.TotalSeconds;
			_ent.TotalSeconds = timeInputUserControl1Total.TotalSeconds;
			_ent.Start = dateTimePickerPlanStart.Value;
			_ent.Description = txtDescription.Text;
			_ent.Closed = closed;

			return _ent;
		}

		public void Go(OSession e)
		{
			_set(e);
			this.Show();
		}

        public event EventHandler Completed;
        public event EventHandler<OSession> Save;
        public event EventHandler<Node> OpenOwner;

		private void timeInputUserControl2Provided_ValueChanged(object sender, EventArgs e)
		{
			_ent.ProvidedSeconds = timeInputUserControl2Provided.TotalSeconds;
			txtPlanFinish.Text = _ent.Finish.ToString("dd.MM.yyyy HH:mm");
		}

		private void dateTimePickerPlanStart_ValueChanged(object sender, EventArgs e)
		{
			_ent.Start = dateTimePickerPlanStart.Value;
			txtPlanFinish.Text = _ent.Finish.ToString("dd.MM.yyyy HH:mm");
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			var p = sender as Panel;
			ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color.Yellow, ButtonBorderStyle.Solid);
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			closed = !closed;
		}

		private void txtDescription_KeyDown(object sender, KeyEventArgs e)
		{
			var txt = sender as RichTextBox;

			if(e.KeyCode == Keys.Enter && e.Shift)
			{
				_ent.AddNote(DateTime.Now, txt.Text);

				webBrowser1.DocumentText = _ent.Html;

				txt.Clear();

				e.Handled = true;
			}
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{
			var p = sender as Panel;
			ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color.Yellow, ButtonBorderStyle.Solid);
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			if (tickCounterAnimator.IsRunning) return;

			tickCounterAnimator.TotalSeconds = timeInputUserControl1Total.TotalSeconds;
			tickCounterAnimator.Play();
		}

		bool UserAnsweredYes(string msg)
		{
			return DialogResult.Yes == MessageBox.Show(msg, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			tickCounterAnimator.Stop();
			Completed?.Invoke(this, EventArgs.Empty);
			Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			//tickCounterAnimator.Stop();
			Save?.Invoke(this, _get());
		}

		private void SessionForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.S && e.Control)
			{
				Save?.Invoke(this, _get());
				MessageBox.Show("Saved");
				e.Handled = true;
			}
		}

		private void btnPause_Click(object sender, EventArgs e)
		{
			tickCounterAnimator.Stop();
			timeInputUserControl1Total.TotalSeconds = tickCounterAnimator.TotalSeconds;
		}

		private void timeInputUserControl1Total_ValueChanged(object sender, EventArgs e)
		{
			if (tickCounterAnimator.IsRunning)
			{
				tickCounterAnimator.Stop();
				timeInputUserControl1Total.TotalSeconds = tickCounterAnimator.TotalSeconds;
			}
		}

//		private void SessionLog_WorkCompleted(object sender, ViewResponse<IEnumerable<NoteRec>> e)
//		{
//			if (e.Ok)
//			{
//				_ent.notes_source = JsonTool.Serialize(e.Data);
//				webBrowser1.DocumentText = _ent.Html;
////				sessionLog.WorkCompleted -= SessionLog_WorkCompleted;
//			}
//		}

		private void btnEditLogList_Click(object sender, EventArgs e)
		{
//			sessionLog = new SessionLogItemCollectionEditForm();

//			sessionLog.WorkCompleted += SessionLog_WorkCompleted;
//			sessionLog.Go(_ent.Items);
		}

        public void Restore()
        {
			this.Show();
			this.WindowState = FormWindowState.Normal;
			this.Focus();
		}

        private void btnHide_Click(object sender, EventArgs e)
        {
			this.Hide();
        }

        private void btnOpenOwner_Click(object sender, EventArgs e)
        {
			OpenOwner?.Invoke(this, _ent.Owner);
        }
    }
}
