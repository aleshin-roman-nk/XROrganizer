using SessionCollector.BL.Entities;
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

		//public event EventHandler NotifyShown;

		public void DisplaySessions(IEnumerable<OSession> list, decimal hours)
		{
			bs.DataSource = list;
			dgvSessions.DataSource = bs;

			txtDescription.DataBindings.Clear();
			txtDescription.DataBindings.Add("Text", bs, "Description");

			lblAllocatedTime.Text = hours.ToString();
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

			if(e.KeyCode == Keys.Enter)
			{
				CommandWorkSession?.Invoke(this, _current_session);
				e.Handled = true;
			}
		}

		private void btnSortAndAlign_Click(object sender, EventArgs e)
		{
			CommandOrderAndAlign?.Invoke(this, monthCalendar1.SelectionStart);
		}

		private void dgvSessions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			//var row = dgvSessions.Rows[e.RowIndex];
			//if ((row.DataBoundItem as OSession).Closed)
			//	row.Cells["closedDataGridViewCheckBoxColumn"].Style.Font.Style = FontStyle.Strikeout;
			//else
			//	row.Cells["closedDataGridViewCheckBoxColumn"].Style.BackColor = Color;
		}
	}
}
