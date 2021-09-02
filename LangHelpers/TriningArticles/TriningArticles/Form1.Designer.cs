
namespace TriningArticles
{
	partial class MainForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panelHead = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btnMin = new System.Windows.Forms.Button();
			this.btnMax = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvArticles = new System.Windows.Forms.DataGridView();
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnDeleteArticle = new System.Windows.Forms.Button();
			this.btnSaveArticle = new System.Windows.Forms.Button();
			this.btnAddArticle = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panel3 = new System.Windows.Forms.Panel();
			this.rtbHead = new System.Windows.Forms.RichTextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.txtTotalSentenses = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.rtbPractice = new System.Windows.Forms.RichTextBox();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.btnGetArtLink = new System.Windows.Forms.Button();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panelHead.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panelHead
			// 
			this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panelHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelHead.Controls.Add(this.panel5);
			this.panelHead.Controls.Add(this.btnMin);
			this.panelHead.Controls.Add(this.btnMax);
			this.panelHead.Controls.Add(this.btnClose);
			this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHead.Location = new System.Drawing.Point(0, 0);
			this.panelHead.Name = "panelHead";
			this.panelHead.Size = new System.Drawing.Size(931, 35);
			this.panelHead.TabIndex = 0;
			this.panelHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseMove);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Gray;
			this.panel5.Controls.Add(this.label1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(149, 33);
			this.panel5.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.Lime;
			this.label1.Location = new System.Drawing.Point(11, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// btnMin
			// 
			this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnMin.FlatAppearance.BorderSize = 0;
			this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnMin.Location = new System.Drawing.Point(806, 2);
			this.btnMin.Name = "btnMin";
			this.btnMin.Size = new System.Drawing.Size(36, 30);
			this.btnMin.TabIndex = 2;
			this.btnMin.Text = "_";
			this.btnMin.UseVisualStyleBackColor = false;
			this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
			// 
			// btnMax
			// 
			this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnMax.FlatAppearance.BorderSize = 0;
			this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMax.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnMax.Location = new System.Drawing.Point(848, 2);
			this.btnMax.Name = "btnMax";
			this.btnMax.Size = new System.Drawing.Size(36, 30);
			this.btnMax.TabIndex = 1;
			this.btnMax.Text = "[ ]";
			this.btnMax.UseVisualStyleBackColor = false;
			this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnClose.Location = new System.Drawing.Point(890, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(36, 30);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gray;
			this.panel1.Controls.Add(this.btnGetArtLink);
			this.panel1.Controls.Add(this.dgvArticles);
			this.panel1.Controls.Add(this.btnDeleteArticle);
			this.panel1.Controls.Add(this.btnSaveArticle);
			this.panel1.Controls.Add(this.btnAddArticle);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(298, 688);
			this.panel1.TabIndex = 1;
			// 
			// dgvArticles
			// 
			this.dgvArticles.AllowUserToAddRows = false;
			this.dgvArticles.AllowUserToDeleteRows = false;
			this.dgvArticles.AllowUserToResizeRows = false;
			this.dgvArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvArticles.AutoGenerateColumns = false;
			this.dgvArticles.BackgroundColor = System.Drawing.Color.Gray;
			this.dgvArticles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Yellow;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Yellow;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvArticles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvArticles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ColumnName});
			this.dgvArticles.DataSource = this.articleBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGreen;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvArticles.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvArticles.EnableHeadersVisualStyles = false;
			this.dgvArticles.GridColor = System.Drawing.Color.Lime;
			this.dgvArticles.Location = new System.Drawing.Point(0, 40);
			this.dgvArticles.MultiSelect = false;
			this.dgvArticles.Name = "dgvArticles";
			this.dgvArticles.ReadOnly = true;
			this.dgvArticles.RowHeadersVisible = false;
			this.dgvArticles.RowTemplate.Height = 26;
			this.dgvArticles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvArticles.Size = new System.Drawing.Size(298, 648);
			this.dgvArticles.TabIndex = 4;
			// 
			// ColumnName
			// 
			this.ColumnName.DataPropertyName = "Name";
			this.ColumnName.HeaderText = "Name";
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			this.ColumnName.Width = 200;
			// 
			// btnDeleteArticle
			// 
			this.btnDeleteArticle.BackColor = System.Drawing.Color.SaddleBrown;
			this.btnDeleteArticle.FlatAppearance.BorderSize = 0;
			this.btnDeleteArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDeleteArticle.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteArticle.Image")));
			this.btnDeleteArticle.Location = new System.Drawing.Point(96, 4);
			this.btnDeleteArticle.Name = "btnDeleteArticle";
			this.btnDeleteArticle.Size = new System.Drawing.Size(40, 30);
			this.btnDeleteArticle.TabIndex = 3;
			this.btnDeleteArticle.UseVisualStyleBackColor = false;
			this.btnDeleteArticle.Click += new System.EventHandler(this.btnDeleteArticle_Click);
			// 
			// btnSaveArticle
			// 
			this.btnSaveArticle.BackColor = System.Drawing.Color.DarkGreen;
			this.btnSaveArticle.FlatAppearance.BorderSize = 0;
			this.btnSaveArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSaveArticle.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveArticle.Image")));
			this.btnSaveArticle.Location = new System.Drawing.Point(50, 4);
			this.btnSaveArticle.Name = "btnSaveArticle";
			this.btnSaveArticle.Size = new System.Drawing.Size(40, 30);
			this.btnSaveArticle.TabIndex = 2;
			this.btnSaveArticle.UseVisualStyleBackColor = false;
			this.btnSaveArticle.Click += new System.EventHandler(this.btnSaveArticle_Click);
			// 
			// btnAddArticle
			// 
			this.btnAddArticle.BackColor = System.Drawing.Color.Lime;
			this.btnAddArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAddArticle.Location = new System.Drawing.Point(4, 4);
			this.btnAddArticle.Name = "btnAddArticle";
			this.btnAddArticle.Size = new System.Drawing.Size(40, 30);
			this.btnAddArticle.TabIndex = 1;
			this.btnAddArticle.Text = "+";
			this.btnAddArticle.UseVisualStyleBackColor = false;
			this.btnAddArticle.Click += new System.EventHandler(this.btnAddArticle_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Controls.Add(this.splitContainer1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(621, 688);
			this.panel2.TabIndex = 2;
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.Gray;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.panel3);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panel4);
			this.splitContainer1.Size = new System.Drawing.Size(621, 688);
			this.splitContainer1.SplitterDistance = 321;
			this.splitContainer1.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.rtbHead);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(621, 321);
			this.panel3.TabIndex = 1;
			// 
			// rtbHead
			// 
			this.rtbHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.rtbHead.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbHead.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbHead.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbHead.ForeColor = System.Drawing.Color.Yellow;
			this.rtbHead.Location = new System.Drawing.Point(0, 0);
			this.rtbHead.Name = "rtbHead";
			this.rtbHead.Size = new System.Drawing.Size(619, 319);
			this.rtbHead.TabIndex = 0;
			this.rtbHead.Text = "";
			this.rtbHead.TextChanged += new System.EventHandler(this.rtbHead_TextChanged);
			this.rtbHead.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbHead_KeyDown);
			// 
			// panel4
			// 
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel4.Controls.Add(this.txtTotalSentenses);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.rtbPractice);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(621, 363);
			this.panel4.TabIndex = 1;
			// 
			// txtTotalSentenses
			// 
			this.txtTotalSentenses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtTotalSentenses.AutoSize = true;
			this.txtTotalSentenses.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtTotalSentenses.ForeColor = System.Drawing.Color.Yellow;
			this.txtTotalSentenses.Location = new System.Drawing.Point(147, 320);
			this.txtTotalSentenses.Name = "txtTotalSentenses";
			this.txtTotalSentenses.Size = new System.Drawing.Size(19, 23);
			this.txtTotalSentenses.TabIndex = 2;
			this.txtTotalSentenses.Text = "0";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.Yellow;
			this.label2.Location = new System.Drawing.Point(3, 320);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(138, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Total sentenses :";
			// 
			// rtbPractice
			// 
			this.rtbPractice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbPractice.BackColor = System.Drawing.Color.DarkSlateGray;
			this.rtbPractice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbPractice.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbPractice.ForeColor = System.Drawing.Color.LawnGreen;
			this.rtbPractice.Location = new System.Drawing.Point(0, 0);
			this.rtbPractice.Name = "rtbPractice";
			this.rtbPractice.Size = new System.Drawing.Size(619, 317);
			this.rtbPractice.TabIndex = 0;
			this.rtbPractice.Text = "";
			this.rtbPractice.TextChanged += new System.EventHandler(this.rtbHead_TextChanged);
			this.rtbPractice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtbHead_KeyDown);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer2.Location = new System.Drawing.Point(4, 41);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.panel1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.panel2);
			this.splitContainer2.Size = new System.Drawing.Size(923, 688);
			this.splitContainer2.SplitterDistance = 298;
			this.splitContainer2.TabIndex = 3;
			// 
			// btnGetArtLink
			// 
			this.btnGetArtLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGetArtLink.BackColor = System.Drawing.Color.SaddleBrown;
			this.btnGetArtLink.FlatAppearance.BorderSize = 0;
			this.btnGetArtLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGetArtLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnGetArtLink.Image = ((System.Drawing.Image)(resources.GetObject("btnGetArtLink.Image")));
			this.btnGetArtLink.Location = new System.Drawing.Point(255, 4);
			this.btnGetArtLink.Name = "btnGetArtLink";
			this.btnGetArtLink.Size = new System.Drawing.Size(40, 30);
			this.btnGetArtLink.TabIndex = 5;
			this.btnGetArtLink.UseVisualStyleBackColor = false;
			this.btnGetArtLink.Click += new System.EventHandler(this.btnGetArtLink_Click);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 70;
			// 
			// articleBindingSource
			// 
			this.articleBindingSource.DataSource = typeof(TriningArticles.BL.Article);
			this.articleBindingSource.CurrentItemChanged += new System.EventHandler(this.articleBindingSource_CurrentItemChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(931, 752);
			this.Controls.Add(this.splitContainer2);
			this.Controls.Add(this.panelHead);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(931, 752);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Training English";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.panelHead.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
			this.panel2.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelHead;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnMin;
		private System.Windows.Forms.Button btnMax;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.RichTextBox rtbHead;
		private System.Windows.Forms.RichTextBox rtbPractice;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btnAddArticle;
		private System.Windows.Forms.Button btnSaveArticle;
		private System.Windows.Forms.Button btnDeleteArticle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label txtTotalSentenses;
		private System.Windows.Forms.DataGridView dgvArticles;
		private System.Windows.Forms.BindingSource articleBindingSource;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btnGetArtLink;
	}
}

