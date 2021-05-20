using SessionCollector.BL.Entities;
using SessionCollector.Forms;
using SessionCollector.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionCollector
{
	public partial class MainForm : Form, IMainView
	{
		BindingSource bs = new BindingSource();

		private OSession _current_session => bs.Current as OSession;

		public DateTime CurrentDateTime => monthCalendar1.SelectionStart;

		public MainForm()
		{
			InitializeComponent();

			txtCurrentDate.Text = monthCalendar1.SelectionStart.ToString("dd MMMM yyyy");
		}

		public event EventHandler<DateTime> CommandCreateSession;
		public event EventHandler CommandSaveDayImage;
		public event EventHandler<DateTime> CommandDateChanged;
		public event EventHandler<DateTime> CommandOrderAndAlign;
		public event EventHandler<OSession> CommandWorkSession;
		public event EventHandler<OSession> CommandDeleteSession;
		public event EventHandler<OSession> CommandStartSessionTick;



		//public event EventHandler NotifyShown;

		public void DisplaySessions(IEnumerable<OSession> list, decimal hours, DateTime? eod)
		{
			bs.DataSource = list;
			dgvSessions.DataSource = bs;

			txtDescription.DataBindings.Clear();
			txtDescription.DataBindings.Add("Text", bs, "Description");

			lblAllocatedTime.Text = hours.ToString();

			lblEndOfDay.Text = !eod.HasValue ? "нет сессий" : eod.Value.ToString("HH:mm '/' dd.MM.yy");
		}

		private void btnNewSession_Click(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			DateTime sel = monthCalendar1.SelectionStart;

			DateTime dt = new DateTime(sel.Year, sel.Month, sel.Day, now.Hour, now.Minute, now.Second);

			CommandCreateSession?.Invoke(this, dt);
		}

		private void btnSaveDayImage_Click(object sender, EventArgs e)
		{
			CommandSaveDayImage?.Invoke(this, EventArgs.Empty);
		}

		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{
			CommandDateChanged?.Invoke(this, e.Start);
			txtCurrentDate.Text = e.Start.ToString("dd MMMM yyyy");
		}

		private void MainForm_Shown(object sender, EventArgs e)
		{
			CommandDateChanged?.Invoke(this, monthCalendar1.SelectionStart);
		}

		private void dgvSessions_KeyDown(object sender, KeyEventArgs e)
		{
			if (_current_session == null) return;

			if (e.Control && e.KeyCode == Keys.Enter)
			{
				CommandStartSessionTick?.Invoke(this, _current_session);
				e.Handled = true;
			}
			else if (e.KeyCode == Keys.Enter)// Если комплексная сессия - вход в нее - нормально. Если надо редактировать, ентер+контрол.
			{
				CommandWorkSession?.Invoke(this, _current_session);
				e.Handled = true;
			}
			else if (e.KeyCode == Keys.Delete)
			{
				CommandDeleteSession?.Invoke(this, _current_session);
				e.Handled = true;
			}
		}

		private void btnSortAndAlign_Click(object sender, EventArgs e)
		{
			CommandOrderAndAlign?.Invoke(this, monthCalendar1.SelectionStart);
		}

		private void dgvSessions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			var data = dgvSessions.Rows[e.RowIndex].DataBoundItem as OSession;
			if (data.Closed)
			{
				e.CellStyle.ForeColor = ColorTranslator.FromHtml("#78e08f");
			}
		}

		public bool UserAnsweredYes(string qstr)
		{
			return MessageBox.Show(qstr, "WARNUNG", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
		}

		public void ShowMessage(string msg)
		{
			MessageBox.Show(msg, "WARNUNG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
			var p = sender as Panel;
			//MessageBox.Show(p.Name);
			ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color.Yellow, ButtonBorderStyle.Solid);
		}

		private void dgvSessions_Paint(object sender, PaintEventArgs e)
		{
			var p = sender as DataGridView;
			//MessageBox.Show(p.Name);
			ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color.Yellow, ButtonBorderStyle.Solid);
		}
	}
}
