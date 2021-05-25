using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBank.Dlg;
using TaskBank.Dlg.forms;
using TaskBank.ViewComponents;

namespace TaskBank
{
	public partial class MainForm : Form, IMainView
	{
		TaskCollectionView taskCollectionView;

		public event EventHandler<DateTime> CreateNoteCommand;
		public event EventHandler<OTask> SaveNoteCommand;
		public event EventHandler<OTask> DeleteNoteCommand;
		public event EventHandler<string> CreateDir;

		public MainForm()
		{
			InitializeComponent();

			taskCollectionView = new TaskCollectionView(dataGridView1, lblSaved, richTextBox1);
			taskCollectionView.SaveTaskNeeded += TaskCollectionView_SaveTaskNeeded;
			taskCollectionView.MoveTaskCollection += TaskCollectionView_MoveTaskCollection;
		}

		private void TaskCollectionView_MoveTaskCollection(object sender, IEnumerable<OTask> e)
		{

		}

		private void TaskCollectionView_SaveTaskNeeded(object sender, OTask e)
		{
			OnSaveNote(e);
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			OnCreateNote();
		}

		private void OnSaveNote(OTask rm)
		{
			SaveNoteCommand?.Invoke(this, rm);
		}

		private void OnCreateNote()
		{
			CreateNoteCommand?.Invoke(this, DateTime.Now);
		}

		private void OnDeleteNote(OTask rm)
		{
			DeleteNoteCommand?.Invoke(this, rm);
		}

		private void OnNewDir(string dir)
		{
			CreateDir?.Invoke(this, dir);
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			OnDeleteNote(taskCollectionView.CurrentTask);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			taskCollectionView.CommitAndSave();
		}

		public void DisplayTaskCollection(IEnumerable<OTask> tlist)
		{
			taskCollectionView.DisplayTaskCollection(tlist);
		}

		private void btnNewDir_Click(object sender, EventArgs e)
		{
			var str = InputBoxes.InputBox.Show("Enter new directory name");
			if (!string.IsNullOrEmpty(str))
				OnNewDir(str);
		}
	}
}