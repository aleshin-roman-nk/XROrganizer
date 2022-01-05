using Domain.Entities;
using SessionCollector.Views;
using Shared.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using TimeTickerCounter;
using xorg.Tools;

namespace SessionCollector.Forms
{
	public partial class SessionForm : Form, ISingleSessionView
	{
		OSession _ent;

		ISessionLogItemCollectionEdit sessionLog;
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

		public SessionForm()
		{
			InitializeComponent();

			typeof(Control).GetProperty("ResizeRedraw", BindingFlags.NonPublic | BindingFlags.Instance)
			.SetValue(panel1, true, null);

			typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance)
			.SetValue(panel1, true, null);

			//tickCounterAnimator.DisplayTime = lblTotalTimeTicker;
			tickCounterAnimator.TotalSecondsChanged += TickCounterAnimator_TotalSecondsChanged;
			tickCounterAnimator.PictureBox = pictureBox1;
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

			owningNodeDescription.Text = e.Owner.definition;

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
			_isWorking = true;
			_set(e);
			//bool ok = DialogResult.OK == this.ShowDialog();
			this.Show();
		}

		public event EventHandler<ViewRequest<OSession, INode>> ChangeDirectory;
		public event EventHandler<ViewResponse<OSession>> WorkCompleted;
		public event EventHandler<OSession> SaveRequired;

		/*
		 * В принципе мы же копируем, заполняем поля из ввода пользователя в полы сущности.
		 * Нет ничего нелогичного чтобы и подчиненные объекты вешать (присваивать) в мордочке.
		 * 
		 * Я же собираю данные, например метод _get()
		 */
		private void btnChangeDirectory_Click(object sender, EventArgs e)
		{

			// >>> 28-11-2021 23:27
			//  Запросить директорию и забыть.
			//	Может не ChangeDirectory, а var obj = requestValue();
			// 

			ViewRequest<OSession, INode> req = new ViewRequest<OSession, INode> {Parameter = _ent };

			ChangeDirectory?.Invoke(this, req);

			if (req.Response.Ok)
			{
				_ent.NodeId = req.Response.Data.id;
				_ent.Owner = (Node)req.Response.Data;

				txtNodeName.Text = _ent.DirName;
			}
		}

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

		//public void SetOwner(INode o)
		//{
		//	_ent.NodeId = o.Id;
		//	_ent.Owner = (Node)o;

		//	txtDirName.Text = _ent.DirName;
		//}

		bool UserAnsweredYes(string msg)
		{
			return DialogResult.Yes == MessageBox.Show(msg, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			if (!UserAnsweredYes("This document will be closed without saving. Are you sure?")) return;

			WorkCompleted?.Invoke(this, new ViewResponse<OSession> { Ok = false, Data = null });
			_isWorking = false;
			tickCounterAnimator.Stop();
			Hide();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			WorkCompleted?.Invoke(this, new ViewResponse<OSession> { Ok = true, Data = _get() });
			_isWorking = false;
			tickCounterAnimator.Stop();
			Hide();
		}

		private void SessionForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;

			if (!UserAnsweredYes("This document will be closed without saving. Are you sure?")) return;

			_isWorking = false;
			tickCounterAnimator.Stop();
			Hide();
		}

		private void SessionForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.S && e.Control)
			{
				MessageBox.Show("Saved");

				SaveRequired?.Invoke(this, _get());
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

		private void SessionLog_WorkCompleted(object sender, ViewResponse<IEnumerable<NoteRec>> e)
		{
			if (e.Ok)
			{
				_ent.notes_source = JsonTool.Serialize(e.Data);
				webBrowser1.DocumentText = _ent.Html;
				sessionLog.WorkCompleted -= SessionLog_WorkCompleted;
			}
		}

		private void btnEditLogList_Click(object sender, EventArgs e)
		{
			sessionLog = new SessionLogItemCollectionEditForm();

			sessionLog.WorkCompleted += SessionLog_WorkCompleted;
			sessionLog.Go(_ent.Items);
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
