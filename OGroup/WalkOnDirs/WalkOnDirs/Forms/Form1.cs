using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalkOnDirs.BL;

namespace WalkOnDirs
{
	public partial class Form1 : Form
	{
		BindingSource bs;
		BindingSource bsPItems;
		DirectoryCollection directoryCollection;
		SessionCollection sessionCollection;
		BindingSource bsSessions;
		Directory currentDir;

		public Form1()
		{
			InitializeComponent();

			directoryCollection = new DirectoryCollection();
			bs = new BindingSource();
			bsPItems = new BindingSource();

			sessionCollection = new SessionCollection();
			bsSessions = new BindingSource();
			dataGridView2.DataSource = bsSessions;

			bsPItems.DataMember = "PItems";
			bs.CurrentItemChanged += Bs_CurrentItemChanged;
			currentDir = directoryCollection.GetRoot();// root
			_enterDir(currentDir);
			listBox1.DataSource = bs;
			listBox1.DisplayMember = "Name";

			reloadSessions(monthCalendar1.SelectionStart);
		}

		private void Bs_CurrentItemChanged(object sender, EventArgs e)
		{
			//if (_currentDirInUI == null) return;
			//lblProgectThings.Text = directoryCollection.GetFullPathOf(_currentDirInUI);
		}

		Directory _currentDirInUI => bs.Current as Directory;

		private void update_currentDir_view()
		{
			var children = directoryCollection.GetChildrenOf(currentDir);

			//if (children.Count() == 0) return;

			bs.DataSource = children;
			bs.ResetBindings(false);

			label1.Text = directoryCollection.GetFullPathOf(currentDir);
		}

		private void _show_prtasks(Directory dir)
		{
			bsPItems.DataSource = dir.PItems;
			dataGridView1.DataSource = bsPItems;
			dataGridView1.Columns[2].Width = 400;
		}

		private void _enterDir(Directory dir)
		{
			currentDir = dir;

			update_currentDir_view();
			_show_prtasks(currentDir);
		}

		private void _exitDir()
		{
			currentDir = directoryCollection.GetParentOf(currentDir);
			bs.DataSource = directoryCollection.GetChildrenOf(currentDir);
			bs.ResetBindings(false);

			label1.Text = directoryCollection.GetFullPathOf(currentDir);

			_show_prtasks(currentDir);
		}

		private void listBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				if (_currentDirInUI == null) return;
				_enterDir(_currentDirInUI);
			}
			else if (e.KeyCode == Keys.Back)
			{
				_exitDir();
			}
		}

		private void btnCreateSession_Click(object sender, EventArgs e)
		{
			DateTime dt = DateTime.Now;
			DateTime dt1 = new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
			DateTime dt2 = dt1.AddDays(1);

			//DateTime date_from_db = new DateTime(2021, 02, 13, 0, 0, 0, 0);
			DateTime date_from_db = new DateTime(dt.Year, dt.Month, dt.Day + 1, 0, 0, 0, 0);
			bool is_in = date_from_db >= dt1 && date_from_db < dt2 ? true : false;
			string str_is_out = is_in ? "в пределах" : "за пределами";

			MessageBox.Show($"{dt1.ToString("yyyy.MM.dd HH:mm:ss")} <= {date_from_db.ToString("yyyy.MM.dd HH:mm:ss")} < {dt2.ToString("yyyy.MM.dd HH:mm:ss")}\n" +
				$"{str_is_out}");
		}

		private void btnAddPrj_Click(object sender, EventArgs e)
		{
			Directory d = new Directory();
			string str = "";
			var s = InputBoxLibrary.WinForms.InputBox.InputBoxUtility.Instance.InputBox(ref str, "", "");

			if (string.IsNullOrEmpty(s)) return;

			d.Name = s;
			d.ParentId = currentDir.Id;
			directoryCollection.AddProject(d);
			update_currentDir_view();
		}

		private void button1_Click(object sender, EventArgs e)
		{


			
		}

		void reloadSessions(DateTime dt)
		{
			bsSessions.DataSource = sessionCollection.GetSessionsOnDate(dt);
		}

		private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
		{
			if(Keys.Enter == e.KeyCode)
			{
				var i = bsPItems.Current as PrjItem;

				if(i != null)
				{
					sessionCollection.Sessions.Add(sessionCollection.FromPrjItem(i, monthCalendar1.SelectionStart));
					reloadSessions(monthCalendar1.SelectionStart);
				}

				e.Handled = true;
			}
		}

		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{
			reloadSessions(monthCalendar1.SelectionStart);
		}
	}
}
