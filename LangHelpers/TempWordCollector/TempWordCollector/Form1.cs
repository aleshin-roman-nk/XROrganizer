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
	public partial class Form1 : Form
	{

		WordCollection _words;
		IWordView _wordView;

		public Form1()
		{
			InitializeComponent();

			_words = new WordCollection("words.json");

			wordBindingSource.DataSource = _words.Items;
			wordBindingSource.CurrentItemChanged += WordBindingSource_CurrentItemChanged;

			lblTotalWords.Text = _words.TotalWords.ToString();

			wordBindingSource.ResetBindings(false);

			_wordView = new WordForm();
		}

		void redisplayItems(IEnumerable<Word> c)
		{
			wordBindingSource.DataSource = c;
		}

		private void WordBindingSource_CurrentItemChanged(object sender, EventArgs e)
		{
			if (Current == null) return;

			txtWord.Text = Current.Text;
			txtMeaning.Text = Current.meaning;
			txtExamples.Text = Current.examples;
		}

		private Word Current => wordBindingSource.Current as Word;

		private void btnAdd_Click(object sender, EventArgs e)
		{
			var w = new Word();

			if (!_wordView.ShowWord(w)) return;

			try
			{
				_words.AddWord(w);
				_words.Save("words.json");
				redisplayItems(_words.Items);
				//wordBindingSource.ResetBindings(false);
				lblTotalWords.Text = _words.TotalWords.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			_words.Delete(Current);
			_words.Save("words.json");
			redisplayItems(_words.Items);
			lblTotalWords.Text = _words.TotalWords.ToString();
			txtWord.Clear();
			txtMeaning.Clear();
		}

		bool validInput()
		{
			return !string.IsNullOrEmpty(txtMeaning.Text) && !string.IsNullOrEmpty(txtWord.Text);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (validInput())
			{
				Current.meaning = txtMeaning.Text;
				Current.Text = txtWord.Text;
				Current.examples = txtExamples.Text;
				_words.Save("words.json");
				wordBindingSource.ResetBindings(false);
			}
		}
	}
}
