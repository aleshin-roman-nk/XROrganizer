using Domain.Entities;
using InputBoxes;
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
using UIComponents.NodesNavigator;

namespace TaskBank
{
	public partial class MainForm : Form, IMainView
	{
		TaskCollectionView taskCollectionView;

		INodeNavigatorView _DirNavigator;

		INodeNavigatorView _targetDirs;

		public INodeNavigatorView DirNavigator => _DirNavigator;

		public INodeNavigatorView TargetDirs => _targetDirs;

		public event EventHandler NewTask;
		public event EventHandler<Note> SaveTask;
		public event EventHandler<Note> DeleteTask;
		// Все что связанно с работой одного модуля должно быть упаковынным в свой usercontrol или component
		public event EventHandler<string> CreateDir;
		public event EventHandler<Dir> DeleteDir;

		public MainForm()
		{
			InitializeComponent();

			taskCollectionView = new TaskCollectionView(dataGridView1, lblSaved, richTextBox1);
			taskCollectionView.SaveTaskNeeded += TaskCollectionView_SaveTaskNeeded;
			taskCollectionView.MoveTaskCollection += TaskCollectionView_MoveTaskCollection;

			_DirNavigator = new NodeNavigatorView(dgvDirectories, txtDirName);

			_targetDirs = new NodeNavigatorView(dataGridView3, null);
		}

		private void TaskCollectionView_MoveTaskCollection(object sender, IEnumerable<Note> e)
		{

		}

		private void TaskCollectionView_SaveTaskNeeded(object sender, Note e)
		{
			OnSaveNote(e);
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			OnCreateNote();
		}

		private void OnSaveNote(Note rm)
		{
			SaveTask?.Invoke(this, rm);
		}

		private void OnCreateNote()
		{
			NewTask?.Invoke(this, EventArgs.Empty);
		}

		private void OnDeleteNote(Note rm)
		{
			DeleteTask?.Invoke(this, rm);
		}

		private void OnNewDir(string dir)
		{
			CreateDir?.Invoke(this, dir);
		}

		private void OnDelDir(Dir d)
		{
			DeleteDir?.Invoke(this, d);
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			OnDeleteNote(taskCollectionView.CurrentTask);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			taskCollectionView.CommitAndSave();
		}

		public void DisplayTaskCollection(IEnumerable<Note> tlist)
		{
			taskCollectionView.DisplayTaskCollection(tlist);
		}

		private void btnNewDir_Click(object sender, EventArgs e)
		{
			var str = InputBox.Show("Enter new directory name");
			if (!string.IsNullOrEmpty(str))
				OnNewDir(str);

			dgvDirectories.Focus();
		}

		private void btnDeleteDir_Click(object sender, EventArgs e)
		{
			OnDelDir(_DirNavigator.CurrentNode as Dir);
		}
	}
}