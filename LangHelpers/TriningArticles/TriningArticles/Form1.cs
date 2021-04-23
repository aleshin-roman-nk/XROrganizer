using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TriningArticles.BL.Repo;
using TriningArticles.BL;
using TriningArticles.BL.tools;
using System.Text.RegularExpressions;

/*
 * Программка позволяет работать с объектами.
 * Например с фильмом, выписывая из него выражения.
 * Или набор выражений из какого то текста или статьи.
 * 
 * This program allows to work with objects.
 * For instance, these are films. I can write out the words I would like to remember from the article.
 * Or these are a set of interesting expressions out of (from) an article or a film.
 * 
 */

namespace TriningArticles
{
	public partial class MainForm : Form, IMainView
	{
		private const int cGrip = 16;      // Grip size
		private const int cCaption = 32;   // Caption bar height;
		private ArticleService articleService;

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImportAttribute("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImportAttribute("user32.dll")]
		public static extern bool ReleaseCapture();

		Repository repo;

		Article currentArticle => articleBindingSource.Current as Article;
		Article prevArticle { get; set; }

		public MainForm()
		{
			InitializeComponent();

			articleService = new ArticleService();

			string db_path;

#if DEBUG
			db_path = @"..\db\deb\articles";
#else 
			db_path = @"..\db\articles";
#endif

			(repo = new Repository()).SetSourceDir(db_path);

			displayArticles(repo.GetAllArticles());

			prevArticle = currentArticle;
		}

		private void displayArticles(IEnumerable<Article> arts)
		{
			articleBindingSource.DataSource = arts;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			repo.Close();
			Close();
		}
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 0x84)
			{  // Trap WM_NCHITTEST
				Point pos = new Point(m.LParam.ToInt32());
				pos = this.PointToClient(pos);
				if (pos.Y < cCaption)
				{
					m.Result = (IntPtr)2;  // HTCAPTION
					return;
				}
				if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
				{
					m.Result = (IntPtr)17; // HTBOTTOMRIGHT
					return;
				}
			}

			//switch (m.Msg)
			//{
			//	case 0x84:
			//		base.WndProc(ref m);
			//		if ((int)m.Result == 0x1)
			//			m.Result = (IntPtr)0x2;
			//		return;
			//}

			base.WndProc(ref m);
		}

		private void panelHead_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void btnMin_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}

		private void btnMax_Click(object sender, EventArgs e)
		{
			if(WindowState == FormWindowState.Normal)
				WindowState = FormWindowState.Maximized;
			else
				WindowState = FormWindowState.Normal;
		}

		private void btnAddArticle_Click(object sender, EventArgs e)
		{
			var a = repo.SaveArticle(repo.Create());

			// all of articles are reloaded now
			displayArticles(repo.GetAllArticles());

			putCursorOnArticle(a);

			putArticle(currentArticle);
		}

		private void putCursorOnArticle(Article art)
		{
			DataGridViewRow row = dgvArticles.Rows
				.Cast<DataGridViewRow>()
				.Where(r => (r.DataBoundItem as Article).Id == art.Id)
				.First();

			dgvArticles.Rows[row.Index].Selected = true;
			dgvArticles.CurrentCell = dgvArticles[0, row.Index];
		}

		private void putArticle(Article art)
		{
			if(art == null)
			{
				rtbHead.Clear();
				rtbPractice.Clear();

				label1.Text = $"#---";
				saved = true;

				articleService.Clear();
				return;
			}

			rtbHead.Rtf = art.Content;
			rtbPractice.Rtf = art.WorkText;
			label1.Text = $"#{art.Id}";
			articleService.SetObject(art);
			//txtTotalSentenses.Text = articleService.SentensesCount().ToString();
			txtTotalSentenses.Text = articleService.SentensesCount(rtbPractice.Text).ToString();
			//MessageBox.Show(articleService.maches());
			saved = true;
		}

		private string findNameTag(string input)
		{
			if (string.IsNullOrEmpty(input)) return "***";

			Regex r = new Regex(@"^###(.*?)$");
			var res = r.Match(input);

			if (res.Groups.Count == 2)
				return res.Groups[1].Value.TrimStart(' ');
			else return "---";
		}

		private void saveArticle(Article art)
		{
			art.WorkText = rtbPractice.Rtf;
			art.Content = rtbHead.Rtf;
			art.TxtContent = rtbHead.Text;

			if(rtbHead.Lines.Count() > 0)
				art.Name = findNameTag(rtbHead.Lines[0]);

			repo.SaveArticle(art);
			saved = true;
		}

		private void btnSaveArticle_Click(object sender, EventArgs e)
		{
			if (currentArticle != null) repo.SaveArticle(currentArticle);
		}

		private void btnDeleteArticle_Click(object sender, EventArgs e)
		{
			if (currentArticle == null) return;

			repo.DeleteArticle(currentArticle);

			putArticle(null);

			displayArticles(repo.GetAllArticles());
		}

		private void rtbHead_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.Control && e.KeyCode == Keys.S)
			{
				if (currentArticle != null)
				{
					saveArticle(currentArticle);
					articleBindingSource.ResetBindings(false);
				}
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(currentArticle != null)
			{
				saveArticle(currentArticle);
			}
		}


		public event Action<Article> SaveArticle;
		public event Action<Article> DeleteArticle;
		public event Action<string> ArticleSelected;

		bool _saved;
		private bool saved
		{
			get
			{
				return _saved;
			}
			set
			{
				_saved = value;
				if (_saved)
					label1.ForeColor = Color.Lime;
				else
					label1.ForeColor = Color.Red;
			}
		}

		private void rtbHead_TextChanged(object sender, EventArgs e)
		{
			saved = false;
			txtTotalSentenses.Text = articleService.SentensesCount(rtbPractice.Text).ToString();
		}

		public void PutArticleNameList(IEnumerable<Article> arts)
		{
			throw new NotImplementedException();
		}

		public void PutArticle(Article art)
		{
			throw new NotImplementedException();
		}

		private void articleBindingSource_CurrentItemChanged(object sender, EventArgs e)
		{
			if (!saved)
			{
				if (prevArticle != null)
					saveArticle(prevArticle);
			}

			putArticle(currentArticle);

			prevArticle = currentArticle;
		}
	}
}
