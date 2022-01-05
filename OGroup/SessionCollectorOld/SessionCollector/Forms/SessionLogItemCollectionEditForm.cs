using mvp_base;
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
	public partial class SessionLogItemCollectionEditForm : Form, ISessionLogItemCollectionEdit
	{
		BindingSource bs = new BindingSource();
		List<NoteRec> _items = new List<NoteRec>();

		public event EventHandler<ViewResponse<IEnumerable<NoteRec>>> WorkCompleted;

		public SessionLogItemCollectionEditForm()
		{
			InitializeComponent();

			dataGridView1.AutoGenerateColumns = false;

			bs.CurrentItemChanged += Bs_CurrentItemChanged;
			dataGridView1.DataSource = bs;
		}

		NoteRec _current => bs.Current as NoteRec;

		public void Go(IEnumerable<NoteRec> recs)
		{
			bs.DataSource = recs;
			_items.Clear();
			_items.AddRange(recs);

			this.ShowDialog();
		}

		private void Bs_CurrentItemChanged(object sender, EventArgs e)
		{
			if (_current != null) richTextBox1.Text = _current.Text;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (_current != null) _current.Text = richTextBox1.Text;
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if(_current != null)
			{
				_items.Remove(_current);
				bs.DataSource = null;
				bs.DataSource = _items;
				//bs.ResetBindings(false);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnSaveAndClose_Click(object sender, EventArgs e)
		{
			if (_current != null) _current.Text = richTextBox1.Text;

			WorkCompleted?.Invoke(this, new ViewResponse<IEnumerable<NoteRec>> { Data = _items, Ok = true });
			this.Close();
		}
	}
}
