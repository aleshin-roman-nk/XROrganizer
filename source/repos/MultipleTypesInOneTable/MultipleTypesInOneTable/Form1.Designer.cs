
namespace MultipleTypesInOneTable
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iNodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnCreateNote = new System.Windows.Forms.Button();
			this.btnCreateTask = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnKill = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnCreateCommon = new System.Windows.Forms.Button();
			this.btnAddCatLover = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iNodeBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.iNodeBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(532, 368);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "type";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			this.typeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// iNodeBindingSource
			// 
			this.iNodeBindingSource.DataSource = typeof(MultipleTypesInOneTable.BL.Enities.INode);
			// 
			// btnCreateNote
			// 
			this.btnCreateNote.Location = new System.Drawing.Point(703, 52);
			this.btnCreateNote.Name = "btnCreateNote";
			this.btnCreateNote.Size = new System.Drawing.Size(75, 23);
			this.btnCreateNote.TabIndex = 1;
			this.btnCreateNote.Text = "add note";
			this.btnCreateNote.UseVisualStyleBackColor = true;
			this.btnCreateNote.Click += new System.EventHandler(this.btnCreateNote_Click);
			// 
			// btnCreateTask
			// 
			this.btnCreateTask.Location = new System.Drawing.Point(822, 52);
			this.btnCreateTask.Name = "btnCreateTask";
			this.btnCreateTask.Size = new System.Drawing.Size(75, 23);
			this.btnCreateTask.TabIndex = 2;
			this.btnCreateTask.Text = "add task";
			this.btnCreateTask.UseVisualStyleBackColor = true;
			this.btnCreateTask.Click += new System.EventHandler(this.btnCreateTask_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.Location = new System.Drawing.Point(550, 89);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(514, 349);
			this.richTextBox1.TabIndex = 4;
			this.richTextBox1.Text = "";
			// 
			// btnKill
			// 
			this.btnKill.BackColor = System.Drawing.Color.Red;
			this.btnKill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKill.ForeColor = System.Drawing.Color.Yellow;
			this.btnKill.Location = new System.Drawing.Point(12, 386);
			this.btnKill.Name = "btnKill";
			this.btnKill.Size = new System.Drawing.Size(75, 23);
			this.btnKill.TabIndex = 5;
			this.btnKill.Text = "kill";
			this.btnKill.UseVisualStyleBackColor = false;
			this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Location = new System.Drawing.Point(550, 12);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(75, 23);
			this.btnEdit.TabIndex = 6;
			this.btnEdit.Text = "edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnCreateCommon
			// 
			this.btnCreateCommon.Location = new System.Drawing.Point(564, 52);
			this.btnCreateCommon.Name = "btnCreateCommon";
			this.btnCreateCommon.Size = new System.Drawing.Size(75, 23);
			this.btnCreateCommon.TabIndex = 7;
			this.btnCreateCommon.Text = "common";
			this.btnCreateCommon.UseVisualStyleBackColor = true;
			this.btnCreateCommon.Click += new System.EventHandler(this.btnCreateCommon_Click);
			// 
			// btnAddCatLover
			// 
			this.btnAddCatLover.Location = new System.Drawing.Point(962, 52);
			this.btnAddCatLover.Name = "btnAddCatLover";
			this.btnAddCatLover.Size = new System.Drawing.Size(75, 23);
			this.btnAddCatLover.TabIndex = 8;
			this.btnAddCatLover.Text = "add catlover";
			this.btnAddCatLover.UseVisualStyleBackColor = true;
			this.btnAddCatLover.Click += new System.EventHandler(this.btnAddCatLover_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1076, 450);
			this.Controls.Add(this.btnAddCatLover);
			this.Controls.Add(this.btnCreateCommon);
			this.Controls.Add(this.btnEdit);
			this.Controls.Add(this.btnKill);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btnCreateTask);
			this.Controls.Add(this.btnCreateNote);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iNodeBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnCreateNote;
		private System.Windows.Forms.Button btnCreateTask;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource iNodeBindingSource;
		private System.Windows.Forms.Button btnKill;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnCreateCommon;
		private System.Windows.Forms.Button btnAddCatLover;
	}
}

