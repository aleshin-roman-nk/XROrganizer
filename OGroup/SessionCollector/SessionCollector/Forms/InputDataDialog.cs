using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionCollector.Forms
{
	public partial class InputDataDialog : Form
	{
		public string InputText { get => txtText.Text; set => txtText.Text = value; }

		string _valid_patter;

		public DialogResult ShowWithValidation(string regexpattern)
		{
			_valid_patter = regexpattern;

			return this.ShowDialog();
		}

		public InputDataDialog()
		{
			InitializeComponent();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			
		}

		private void txtText_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = true;

				if (!isValid(txtText.Text))
				{
					MessageBox.Show("Value is not correcnt according to the validation function");
				}
				else
					DialogResult = DialogResult.OK;
			}
		}

		private bool isValid(string src)
		{
			Regex rg = new Regex(_valid_patter);

			return rg.Match(src).Success;
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			if (!isValid(txtText.Text))
			{
				MessageBox.Show("Value is not correcnt according to the validation function");
			}
			else
				DialogResult = DialogResult.OK;
		}
	}
}
