using mvp_base;
using SessionCollector.BL.Entities;
using mvp_base;
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
using SessionCollector.Tools;

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
			//txtPlanHours.Text = e.ReservedHours.ToString();

			mtxtPlanHrs.Text = TimeSpan.FromHours(Convert.ToDouble(e.ReservedHours)).ToString(@"hh\:mm");

			txtPlanFinish.Text = e.Finish.ToString("dd.MM.yyyy HH:mm");
			txtDescription.Text = e.Description;
			//lblSessionTotalTimeString.Text = e.TotalWorkTime;

			timeInputUserControl1.TotalSeconds = _ent.TotalSeconds;

			txtDirName.Text = e.DirName;
		}

		private OSession _get()
		{
			//_ent.ReservedHours = get_plan_hours(txtPlanHours.Text);
			_ent.ReservedHours = get_plan_hours(mtxtPlanHrs.Text);
			_ent.Start = dateTimePickerPlanStart.Value;
			_ent.Description = txtDescription.Text;
			_ent.TotalSeconds = timeInputUserControl1.TotalSeconds;

			return _ent;
		}

		public ViewResult<OSession> Go(OSession e)
		{
			_set(e);
			bool ok = DialogResult.OK == this.ShowDialog();

			return new ViewResult<OSession> { Ok = ok, Result = ok ? _get() : null };
		}

		decimal get_plan_hours(string v)
		{
			return Convert.ToDecimal(TimeSpan.Parse(v).TotalHours);
		}

		private void txtPlanDuration_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				_ent.ReservedHours = get_plan_hours(mtxtPlanHrs.Text);
				txtPlanFinish.Text = _ent.Finish.ToString("dd.MM.yyyy HH:mm");

				e.Handled = true;
			}
		}

		private void label6_Click(object sender, EventArgs e)
		{
			//InputDataDialog dlg = new InputDataDialog();

			//if(dlg.ShowWithValidation(@"^(?:(?:([01]?\d|2[0-3]):)?([0-5]?\d):)?([0-5]?\d)$") == DialogResult.OK)
			//{
			//	_ent.TotalSeconds = Convert.ToInt32(TimeSpan.Parse(dlg.InputText).TotalSeconds);
			//	blSessionTotalTimeString.Text = _ent.TotalWorkTime;
			//}
		}

		Color label6Backgfround;

		public event EventHandler<ViewResultParams<OSession, INode>> ChangeDirectory;

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


		/*
		 * В принципе мы же копируем, заполняем поля из ввода пользователя в полы сущности.
		 * Нет ничего нелогичного чтобы и подчиненные объекты вешать (присваивать) в мордочке.
		 * 
		 * Я же собираю данные, например метод _get()
		 */
		private void btnChangeDirectory_Click(object sender, EventArgs e)
		{
			// просто спросить директорию.
			// здесь сами присвоим, а если надо валидация, в бизнес логике сделаем.

			ViewResultParams<OSession, INode> req = new ViewResultParams<OSession, INode>();

			req.Param = _ent;

			ChangeDirectory?.Invoke(this, req);

			if (req.Ok)
			{
				_ent.NodeId = req.Result.Id;
				_ent.Node = (Node)req.Result;

				txtDirName.Text = _ent.DirName;

			}

			// И теперь, после выхода, если нажата сохранить, а не отмена, в презентере выпоняем сохранение.
			// и нет подводных операций сохранения.
		}
	}
}
