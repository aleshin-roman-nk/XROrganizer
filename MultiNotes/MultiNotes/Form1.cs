using MultiNotes.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aleshin_rv.UIHelpers;

namespace MultiNotes
{
	public partial class Form1 : Form
	{
		BindingSource bs;
		repository repo;
		BindingSource bsNoteView;

		Dictionary<int, Color> colors;

		public Form1()
		{
			InitializeComponent();

			repo = new repository(@"..\notes");
			repo.LoadContent();
			bs = new BindingSource();
			bsNoteView = new BindingSource();
			bs.CurrentItemChanged += Bs_CurrentItemChanged;
			bsNoteView.CurrentItemChanged += BsNoteView_CurrentItemChanged;
			initColors();

			dataGridView2.DataSource = bsNoteView;
			dataGridView1.DataSource = bs;

			dataGridView1.AutoGenerateColumns = false;
			dataGridView2.AutoGenerateColumns = false;

			dataGridView1.AddCol(150, "Date", "Date", "Date");
			dataGridView1.AddCol(200, "Name", "title", "title");

			dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
			dataGridView2.AddCol(40, "!", null, "Imp");
			dataGridView2.AddCol(150, "Date", "_Date", "Date");
			dataGridView2.AddCol(800, "Text", "notetxt", "notetxt");

			bindTextViewer(bsNoteView);

			displayBoards(repo.Boards);
		}

		private void BsNoteView_CurrentItemChanged(object sender, EventArgs e)
		{
			//var col_code = currentNote.color;
			//richTextBox1.BackColor = colors[col_code];
		}

		void initColors()
		{
			colors = new Dictionary<int, Color>();
			colors[0] = Color.Yellow;
			colors[1] = Color.LightPink;
			colors[2] = Color.Green;
			colors[4] = Color.White;
			colors[5] = Color.Blue;
			colors[6] = Color.Gold;
		}

		MBoard currentBoard => bs.Current as MBoard;
		MNote currentNote => bsNoteView.Current as MNote;

		private void Bs_CurrentItemChanged(object sender, EventArgs e)
		{
			displayNotes(repo.GetNotesOf(currentBoard));
		}

		private void bindTextViewer(BindingSource src)
		{
			richTextBox1.DataBindings.Clear();
			richTextBox1.DataBindings.Add("Text", src, "notetxt");
		}

		private void displayNotes(IEnumerable<MNote> notes)
		{
			bsNoteView.DataSource = notes;
		}

		private void displayBoards(IEnumerable<MBoard> brds)
		{
			bs.DataSource = brds;
		}

		private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			var row = dataGridView2.Rows[e.RowIndex];

			var col_code = (row.DataBoundItem as MNote).color;

			if (colors.ContainsKey(col_code))
			{
				row.Cells["Imp"].Style.BackColor = colors[col_code];
				row.Cells["Imp"].Style.SelectionBackColor = colors[col_code];
			}
		}
	}
}
