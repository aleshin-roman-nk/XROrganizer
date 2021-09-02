using MultipleTypesInOneTable.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MultipleTypesInOneTable.Tools;
using MultipleTypesInOneTable.BL.Enities;

namespace MultipleTypesInOneTable
{
	public partial class Form1 : Form
	{
		IRepo _mainRepository;

		public Form1()
		{
			InitializeComponent();
		}

		private void btnCreateNote_Click(object sender, EventArgs e)
		{
			_mainRepository.Create(new NoteNode { description = "Notation", name = "Mama"});
			updateData();
		}

		private void btnCreateTask_Click(object sender, EventArgs e)
		{
			_mainRepository.Create(new TaskNode { AllotedTime = 120, name = "Papa" });
			updateData();
		}

		void updateData()
		{
			iNodeBindingSource.DataSource = null;
			var d = _mainRepository.GetAll();
			iNodeBindingSource.DataSource = d;

			//richTextBox1.Clear();
			//richTextBox1.Text = JTool.Ser(d);
		}

		private void _log(string msg)
		{
			richTextBox1.Text += msg;
		}

		INode current => iNodeBindingSource.Current as INode;

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			MessageBox.Show(current.GetType().Name);
		}

		private void btnKill_Click(object sender, EventArgs e)
		{
			_mainRepository.Kill(current);
			updateData();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			//current.name += "_ecited";
			//_mainRepository.Save(current);
			//iNodeBindingSource.ResetBindings(false);

			JTool.DisplayObjMessage(current);
		}

		private void btnCreateCommon_Click(object sender, EventArgs e)
		{
			_mainRepository.Create(new Node { name = "Common" });
			updateData();
		}

		private void btnAddCatLover_Click(object sender, EventArgs e)
		{
			CatLover cl = new CatLover
			{
				name = "Cotter",
				type = "clover"
			};

			cl.Cats.Add(new Cat { name = "Murzik"});

			_mainRepository.Create(cl);
			updateData();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//_mainRepository = new MainRepository(_log);
			_mainRepository = new MainPresenterDisconnected(_log);

			updateData();
		}
	}
}
