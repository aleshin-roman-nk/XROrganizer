
namespace TempWordCollector
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.txtWord = new System.Windows.Forms.TextBox();
			this.txtMeaning = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.meaningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.wordBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblTotalWords = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.txtExamples = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtWord
			// 
			this.txtWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtWord.Location = new System.Drawing.Point(0, 0);
			this.txtWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtWord.Name = "txtWord";
			this.txtWord.Size = new System.Drawing.Size(693, 30);
			this.txtWord.TabIndex = 0;
			// 
			// txtMeaning
			// 
			this.txtMeaning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMeaning.Location = new System.Drawing.Point(0, 38);
			this.txtMeaning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtMeaning.Multiline = true;
			this.txtMeaning.Name = "txtMeaning";
			this.txtMeaning.Size = new System.Drawing.Size(693, 146);
			this.txtMeaning.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.textDataGridViewTextBoxColumn,
            this.meaningDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.wordBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(534, 564);
			this.dataGridView1.TabIndex = 2;
			// 
			// textDataGridViewTextBoxColumn
			// 
			this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
			this.textDataGridViewTextBoxColumn.HeaderText = "Text";
			this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
			this.textDataGridViewTextBoxColumn.ReadOnly = true;
			this.textDataGridViewTextBoxColumn.Width = 150;
			// 
			// meaningDataGridViewTextBoxColumn
			// 
			this.meaningDataGridViewTextBoxColumn.DataPropertyName = "meaning";
			this.meaningDataGridViewTextBoxColumn.HeaderText = "meaning";
			this.meaningDataGridViewTextBoxColumn.Name = "meaningDataGridViewTextBoxColumn";
			this.meaningDataGridViewTextBoxColumn.ReadOnly = true;
			this.meaningDataGridViewTextBoxColumn.Width = 200;
			// 
			// wordBindingSource
			// 
			this.wordBindingSource.DataSource = typeof(TempWordCollector.Domain.Word);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(122, 12);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(106, 43);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(234, 12);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(106, 43);
			this.btnDel.TabIndex = 4;
			this.btnDel.Text = "Del";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 567);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Total";
			// 
			// lblTotalWords
			// 
			this.lblTotalWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblTotalWords.AutoSize = true;
			this.lblTotalWords.Location = new System.Drawing.Point(66, 567);
			this.lblTotalWords.Name = "lblTotalWords";
			this.lblTotalWords.Size = new System.Drawing.Size(19, 23);
			this.lblTotalWords.TabIndex = 6;
			this.lblTotalWords.Text = "0";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(12, 12);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(106, 43);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(12, 61);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.lblTotalWords);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(1240, 590);
			this.splitContainer1.SplitterDistance = 537;
			this.splitContainer1.TabIndex = 8;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer2.Location = new System.Drawing.Point(3, 3);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.txtMeaning);
			this.splitContainer2.Panel1.Controls.Add(this.txtWord);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.txtExamples);
			this.splitContainer2.Size = new System.Drawing.Size(693, 587);
			this.splitContainer2.SplitterDistance = 189;
			this.splitContainer2.TabIndex = 2;
			// 
			// txtExamples
			// 
			this.txtExamples.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtExamples.Location = new System.Drawing.Point(0, 3);
			this.txtExamples.Name = "txtExamples";
			this.txtExamples.Size = new System.Drawing.Size(693, 391);
			this.txtExamples.TabIndex = 0;
			this.txtExamples.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 663);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnAdd);
			this.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.wordBindingSource)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtWord;
		private System.Windows.Forms.TextBox txtMeaning;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.BindingSource wordBindingSource;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblTotalWords;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn meaningDataGridViewTextBoxColumn;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.RichTextBox txtExamples;
	}
}

