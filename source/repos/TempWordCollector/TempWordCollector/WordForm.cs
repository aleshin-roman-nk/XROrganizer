using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TempWordCollector.Domain;

namespace TempWordCollector
{
	public partial class WordForm : Form, IWordView
	{
		public WordForm()
		{
			InitializeComponent();
		}

		private void _put(Word w)
		{
			txtWord.Text = w.Text;
			txtExplan.Text = w.meaning;
		}

		private void _accept(Word w)
		{
			w.Text = txtWord.Text;
			w.meaning = txtExplan.Text;
		}

		public bool ShowWord(Word w)
		{
			_put(w);

			if(this.ShowDialog() == DialogResult.OK)
			{
				_accept(w);
				return true;
			}

			return false;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
		}
	}
}
