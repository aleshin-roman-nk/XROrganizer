﻿using mvp_base;
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

			dateTimePickerPlanStart.Value = e.PlanStart;
			txtPlanHours.Text = e.PlanHours.ToString();
			txtPlanFinish.Text = e.PlanFinish.ToString("dd.MM.yyyy HH:mm");
			txtDescription.Text = e.Description;
		}

		private OSession _get()
		{
			_ent.PlanHours = get_plan_hours(txtPlanHours.Text);
			_ent.PlanStart = dateTimePickerPlanStart.Value;
			_ent.Description = txtDescription.Text;

			return _ent;
		}

		public ViewResult<OSession> Go(OSession e)
		{
			_set(e);
			bool ok = DialogResult.OK == this.ShowDialog();
			return new ViewResult<OSession> { Accept = ok, Data = _get() };
		}

		decimal get_plan_hours(string v)
		{
			return decimal.Parse(v);
		}

		private void txtPlanDuration_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				_ent.PlanHours = get_plan_hours(txtPlanHours.Text);
				txtPlanFinish.Text = _ent.PlanFinish.ToString("dd.MM.yyyy HH:mm");


				e.Handled = true;
			}
		}
	}
}
