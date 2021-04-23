using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBank.BL;
using TaskBank.BL.Entities;
using TaskBank.BL.Services;
using TaskBank.Dlg;
using TaskBank.Dlg.forms;
using TaskBank.ViewModules;

namespace TaskBank
{
	public partial class MainForm : Form, IMainView
	{
		TaskCollectionView taskCollectionView;

		List<RmDirectiry> directories = new List<RmDirectiry>();


		BindingSource bsDir = new BindingSource();
		BindingSource bsDirDest = new BindingSource();

		public event EventHandler<DateTime> CreateNoteCommand;
		public event EventHandler<RmTask> SaveTaskCommand;
		public event EventHandler<RmTask> DeleteNoteCommand;

		public MainForm()
		{
			InitializeComponent();

			taskCollectionView = new TaskCollectionView(dataGridView1, lblSaved, richTextBox1);
			taskCollectionView.SaveTaskNeeded += TaskCollectionView_SaveTaskNeeded;
			taskCollectionView.MoveTaskCollection += TaskCollectionView_MoveTaskCollection;

			directories.Add(new RmDirectiry {Name = "Программирование", Id = 1 });
			directories.Add(new RmDirectiry { Name = "Турецкий", Id = 2 });
			directories.Add(new RmDirectiry { Name = "Английский", Id = 3});
			directories.Add(new RmDirectiry { Name = "Организатор", Id = 4 });

			bsDir.DataSource = directories;
			bsDirDest.DataSource = directories;

			lblDir.DataBindings.Add("Text", bsDir, "Name");

			DataGridViewTextBoxColumn cDir = new DataGridViewTextBoxColumn
			{
				Width = 200,
				HeaderText = "Проекты",
				DataPropertyName = "Name"
			};
			dataGridView2.Columns.Add(cDir);
			dataGridView2.AutoGenerateColumns = false;
			dataGridView2.DataSource = bsDir;

			DataGridViewTextBoxColumn cDir1 = new DataGridViewTextBoxColumn
			{
				Width = 200,
				HeaderText = "Проекты",
				DataPropertyName = "Name"
			};
			dataGridView3.Columns.Add(cDir1);
			dataGridView3.AutoGenerateColumns = false;
			dataGridView3.DataSource = bsDirDest;
		}

		private void TaskCollectionView_MoveTaskCollection(object sender, IEnumerable<RmTask> e)
		{
			foreach (var item in e)
			{
				item.DirectoryId = (bsDirDest.Current as RmDirectiry).Id;
			}
		}

		private void TaskCollectionView_SaveTaskNeeded(object sender, RmTask e)
		{
			_userCommandSaveNote(e);
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			_userCommandCreateNote();
		}

		private void _userCommandSaveNote(RmTask rm)
		{
			SaveTaskCommand?.Invoke(this, rm);
		}

		private void _userCommandCreateNote()
		{
			CreateNoteCommand?.Invoke(this, DateTime.Now);
		}

		private void _userCommandDeleteNote(RmTask rm)
		{
			DeleteNoteCommand?.Invoke(this, rm);
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			_userCommandDeleteNote(taskCollectionView.CurrentTask);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			taskCollectionView.CommitAndSave();
		}

		public void DisplayTaskCollection(IEnumerable<RmTask> tlist)
		{
			taskCollectionView.DisplayTaskCollection(tlist);
		}
	}
}
