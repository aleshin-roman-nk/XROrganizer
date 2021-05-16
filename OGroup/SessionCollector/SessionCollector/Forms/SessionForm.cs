using mvp_base;
using SessionCollector.BL.Entities;
using SessionCollector.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTickerCounter;

namespace SessionCollector.Forms
{
	public partial class SessionForm : Form, ISessionView
	{
		OSession _ent;

		public SessionForm()
		{
			InitializeComponent();
		}

		private void _set(OSession e)
		{
			_ent = e;

			dateTimePickerPlanStart.Value = e.Start;
			txtPlanHours.Text = e.ReservedHours.ToString();
			txtPlanFinish.Text = e.Finish.ToString("dd.MM.yyyy HH:mm");
			txtDescription.Text = e.Description;
			lblSessionTotalTimeString.Text = e.TotalWorkTime;
		}

		private OSession _get()
		{
			_ent.ReservedHours = get_plan_hours(txtPlanHours.Text);
			_ent.Start = dateTimePickerPlanStart.Value;
			_ent.Description = txtDescription.Text;

			return _ent;
		}

		public ViewResult<OSession> Go(OSession e)
		{
			_set(e);
			bool ok = DialogResult.OK == this.ShowDialog();
			if(ok)
				return new ViewResult<OSession> { Accept = ok, Data = _get() };
			else
				return new ViewResult<OSession> { Accept = ok, Data = null };
		}

		decimal get_plan_hours(string v)
		{
			return decimal.Parse(v);
		}

		private void txtPlanDuration_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				_ent.ReservedHours = get_plan_hours(txtPlanHours.Text);
				txtPlanFinish.Text = _ent.Finish.ToString("dd.MM.yyyy HH:mm");

				e.Handled = true;
			}
		}

		private void label6_Click(object sender, EventArgs e)
		{
			InputDataDialog dlg = new InputDataDialog();

			if(dlg.ShowWithValidation(@"^(?:(?:([01]?\d|2[0-3]):)?([0-5]?\d):)?([0-5]?\d)$") == DialogResult.OK)
			{
				_ent.TotalSeconds = Convert.ToInt32(TimeSpan.Parse(dlg.InputText).TotalSeconds);
				lblSessionTotalTimeString.Text = _ent.TotalWorkTime;
			}
		}

		Color label6Backgfround;

		private void label6_MouseEnter(object sender, EventArgs e)
		{
			var lbl = sender as Label;

			label6Backgfround = lbl.BackColor;
			lbl.BackColor = ColorTranslator.FromHtml("#b8e994");
		}

		private void label6_MouseLeave(object sender, EventArgs e)
		{
			var lbl = sender as Label;
			lbl.BackColor = label6Backgfround;
		}
	}
}
