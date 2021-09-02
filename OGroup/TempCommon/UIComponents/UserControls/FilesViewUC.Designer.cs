
namespace CommonUIComponents.UserControls
{
	partial class FilesViewUC
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.currentFileText = new System.Windows.Forms.RichTextBox();
			this.itemsGrid = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NTypeString = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iNodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.lblSaved = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBufferState = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iNodeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// currentFileText
			// 
			this.currentFileText.AcceptsTab = true;
			this.currentFileText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.currentFileText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(32)))));
			this.currentFileText.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.currentFileText.EnableAutoDragDrop = true;
			this.currentFileText.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.currentFileText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(164)))), ((int)(((byte)(14)))));
			this.currentFileText.Location = new System.Drawing.Point(3, 19);
			this.currentFileText.Name = "currentFileText";
			this.currentFileText.Size = new System.Drawing.Size(372, 525);
			this.currentFileText.TabIndex = 12;
			this.currentFileText.Text = "";
			// 
			// itemsGrid
			// 
			this.itemsGrid.AllowUserToAddRows = false;
			this.itemsGrid.AllowUserToDeleteRows = false;
			this.itemsGrid.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
			this.itemsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.itemsGrid.AutoGenerateColumns = false;
			this.itemsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
			this.itemsGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.itemsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			this.itemsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.itemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.itemsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.NTypeString,
            this.description,
            this.dateDataGridViewTextBoxColumn});
			this.itemsGrid.DataSource = this.iNodeBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.itemsGrid.DefaultCellStyle = dataGridViewCellStyle3;
			this.itemsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemsGrid.EnableHeadersVisualStyles = false;
			this.itemsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(198)))), ((int)(((byte)(144)))));
			this.itemsGrid.Location = new System.Drawing.Point(0, 0);
			this.itemsGrid.Name = "itemsGrid";
			this.itemsGrid.ReadOnly = true;
			this.itemsGrid.RowHeadersVisible = false;
			this.itemsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.itemsGrid.Size = new System.Drawing.Size(566, 547);
			this.itemsGrid.TabIndex = 13;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 80;
			// 
			// NTypeString
			// 
			this.NTypeString.DataPropertyName = "NTypeString";
			this.NTypeString.HeaderText = "type";
			this.NTypeString.Name = "NTypeString";
			this.NTypeString.ReadOnly = true;
			this.NTypeString.Width = 50;
			// 
			// description
			// 
			this.description.DataPropertyName = "description";
			this.description.HeaderText = "description";
			this.description.Name = "description";
			this.description.ReadOnly = true;
			this.description.Width = 300;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			this.dateDataGridViewTextBoxColumn.Width = 150;
			// 
			// iNodeBindingSource
			// 
			this.iNodeBindingSource.DataSource = typeof(Domain.Entities.INode);
			// 
			// lblSaved
			// 
			this.lblSaved.AutoSize = true;
			this.lblSaved.Location = new System.Drawing.Point(47, 3);
			this.lblSaved.Name = "lblSaved";
			this.lblSaved.Size = new System.Drawing.Size(13, 13);
			this.lblSaved.TabIndex = 17;
			this.lblSaved.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "saved:";
			// 
			// btnDel
			// 
			this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDel.Location = new System.Drawing.Point(77, 3);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(68, 23);
			this.btnDel.TabIndex = 15;
			this.btnDel.Text = "delete";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreate.Location = new System.Drawing.Point(3, 3);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(68, 23);
			this.btnCreate.TabIndex = 14;
			this.btnCreate.Text = "create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(3, 32);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.itemsGrid);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.currentFileText);
			this.splitContainer1.Panel2.Controls.Add(this.lblSaved);
			this.splitContainer1.Panel2.Controls.Add(this.label1);
			this.splitContainer1.Size = new System.Drawing.Size(948, 547);
			this.splitContainer1.SplitterDistance = 566;
			this.splitContainer1.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(197, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 19;
			this.label2.Text = "Буффер";
			// 
			// txtBufferState
			// 
			this.txtBufferState.AutoSize = true;
			this.txtBufferState.Location = new System.Drawing.Point(250, 8);
			this.txtBufferState.Name = "txtBufferState";
			this.txtBufferState.Size = new System.Drawing.Size(13, 13);
			this.txtBufferState.TabIndex = 20;
			this.txtBufferState.Text = "0";
			// 
			// FilesViewUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtBufferState);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnCreate);
			this.Name = "FilesViewUC";
			this.Size = new System.Drawing.Size(951, 579);
			((System.ComponentModel.ISupportInitialize)(this.itemsGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iNodeBindingSource)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox currentFileText;
		private System.Windows.Forms.DataGridView itemsGrid;
		private System.Windows.Forms.Label lblSaved;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.BindingSource iNodeBindingSource;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label txtBufferState;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn NTypeString;
		private System.Windows.Forms.DataGridViewTextBoxColumn description;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
	}
}
