using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using xorg.Tools;

namespace SessionCollector
{
	public partial class SCMainForm : Form, ISCMainView
	{
		BindingSource bs = new BindingSource();

		private OSession _current_session => bs.Current as OSession;

		public DateTime CurrentDateTime => myCalendar1.CurrentDate;

		public SCMainForm()
		{
			InitializeComponent();

			//this.DoubleBuffered = true;
			//this.SetStyle(ControlStyles.ResizeRedraw, true);

			typeof(Control).GetProperty("ResizeRedraw", BindingFlags.NonPublic | BindingFlags.Instance)
			   .SetValue(panel1, true, null);

			typeof(Panel).GetProperty("DoubleBuffered",
						  BindingFlags.NonPublic | BindingFlags.Instance)
			 .SetValue(panel1, true, null);

			//txtCurrentDate.Text = monthCalendar1.SelectionStart.ToString("dd MMMM yyyy");

			dgvSessions.AutoGenerateColumns = false;
		}

		public event EventHandler<DateTime> DateChanged;
		public event EventHandler<OSession> StartSession;
		public event EventHandler<OSession> DeleteSession;
		public event EventHandler<DateTime> ShowStata;
		public event EventHandler<OSession> KickNextDay;
		public event EventHandler<OSession> KickPrevDay;
		public event EventHandler WindowClosed;

		//public event EventHandler NotifyShown;
		bool _hideComplSessions = true;
		private bool hideComplSessions
		{
			get
			{
				return _hideComplSessions;
			}
			set
			{
				_hideComplSessions = value;
				if (_hideComplSessions)
					btnHideCompletedSessions.BackgroundImage = Properties.Resources.hide_completed_sess;
				else
					btnHideCompletedSessions.BackgroundImage = Properties.Resources.unhide_completed_sess;
			}
		}
		IEnumerable<OSession> _originalCollectio;
		private IEnumerable<OSession> hideCompletedIfNeeded()
		{
			if (_hideComplSessions)
				return _originalCollectio.Where(x => !x.Closed).ToList();
			//else return _originalCollectio.Where(x => x.Closed).ToList(); 
			else return _originalCollectio;
		}

		public void DisplaySessions(IEnumerable<OSession> list, decimal hours, decimal doneSecnds, DateTime? eod)
		{
			_originalCollectio = list;

			//var j = Tools.JsonTool.Serialize(_originalCollectio.FirstOrDefault());
			//MessageBox.Show(j);

			bs.DataSource = hideCompletedIfNeeded();
			dgvSessions.DataSource = bs;

			txtDescription.DataBindings.Clear();
			//txtDescription.DataBindings.Add("Text", bs, "Description");
			txtDescription.DataBindings.Add("Text", bs, "OwnerDefinition");

			lblAllocatedTime.Text = TimeSpan.FromHours(Convert.ToDouble(hours)).ToString(@"hh\:mm");

			lblEndOfDay.Text = !eod.HasValue ? "нет сессий" : eod.Value.ToString("HH:mm '/' dd.MM.yy");

			txtActualDoneWord.Text = TimeSpan.FromSeconds(Convert.ToDouble(doneSecnds)).ToString(@"hh\:mm");
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
			DateChanged?.Invoke(this, myCalendar1.CurrentDate);
		}

		private void dgvSessions_KeyDown(object sender, KeyEventArgs e)
		{
			if (_current_session == null) return;

			if (e.KeyCode == Keys.Enter)// Если комплексная сессия - вход в нее - нормально. Если надо редактировать, ентер+контрол.
			{
				StartSession?.Invoke(this, _current_session);
				e.Handled = true;
			}
			else if (e.KeyCode == Keys.Delete)
			{
				DeleteSession?.Invoke(this, _current_session);
				e.Handled = true;
			}
		}

		private void dgvSessions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			var data = dgvSessions.Rows[e.RowIndex].DataBoundItem as OSession;

			if (data.Closed)
			{
				e.CellStyle.ForeColor = ColorTranslator.FromHtml("#78e08f");
			}
			else
				e.CellStyle.ForeColor = ColorTranslator.FromHtml("#ff7675");
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			var p = sender as Panel;
			ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color.Yellow, ButtonBorderStyle.Solid);			
		}

		private void dgvSessions_Paint(object sender, PaintEventArgs e)
		{
			var p = sender as DataGridView;
			ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color.Yellow, ButtonBorderStyle.Solid);
		}

		private void btnStata_Click(object sender, EventArgs e)
		{
			ShowStata?.Invoke(this, myCalendar1.CurrentDate);
		}

		private void myCalendar1_DateChanged(DateTime obj)
		{
			DateChanged?.Invoke(this, obj);
		}

		private void btnKickPrevDay_Click(object sender, EventArgs e)
		{
			KickPrevDay?.Invoke(this, _current_session);
		}

		private void btnKickNextDay_Click(object sender, EventArgs e)
		{
			KickNextDay?.Invoke(this, _current_session);
		}

		private void btnHideCompletedSessions_Click(object sender, EventArgs e)
		{
			hideComplSessions = !hideComplSessions;
			bs.DataSource = hideCompletedIfNeeded();
		}

		private void SCMainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			WindowClosed?.Invoke(this, EventArgs.Empty);
		}

		public void ShowWindow()
		{
			this.Show();
			this.WindowState = FormWindowState.Normal;
			this.Focus();
		}

        private void dgvSessions_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
			if (e.RowIndex < 0) return;

			var i = dgvSessions.Rows[e.RowIndex].DataBoundItem as OSession;

			StartSession?.Invoke(this, i);
		}
    }
}
