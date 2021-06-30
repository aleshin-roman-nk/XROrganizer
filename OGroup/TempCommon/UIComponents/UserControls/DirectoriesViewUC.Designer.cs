
namespace UIComponents.UserControls
{
	partial class DirectoriesViewUC
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
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgvDirectories = new System.Windows.Forms.DataGridView();
			this.btnDeleteDir = new System.Windows.Forms.Button();
			this.btnNewDir = new System.Windows.Forms.Button();
			this.txtDirectoryFullName = new System.Windows.Forms.TextBox();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iNodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDirectories)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iNodeBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.dgvDirectories);
			this.panel3.Location = new System.Drawing.Point(0, 68);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(309, 415);
			this.panel3.TabIndex = 10;
			// 
			// dgvDirectories
			// 
			this.dgvDirectories.AllowUserToAddRows = false;
			this.dgvDirectories.AllowUserToDeleteRows = false;
			this.dgvDirectories.AllowUserToResizeRows = false;
			this.dgvDirectories.AutoGenerateColumns = false;
			this.dgvDirectories.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
			this.dgvDirectories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDirectories.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvDirectories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDirectories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
			this.dgvDirectories.DataSource = this.iNodeBindingSource;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(142)))), ((int)(((byte)(135)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(226)))), ((int)(((byte)(199)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvDirectories.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvDirectories.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDirectories.EnableHeadersVisualStyles = false;
			this.dgvDirectories.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
			this.dgvDirectories.Location = new System.Drawing.Point(0, 0);
			this.dgvDirectories.Name = "dgvDirectories";
			this.dgvDirectories.ReadOnly = true;
			this.dgvDirectories.RowHeadersVisible = false;
			this.dgvDirectories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDirectories.Size = new System.Drawing.Size(307, 413);
			this.dgvDirectories.TabIndex = 0;
			// 
			// btnDeleteDir
			// 
			this.btnDeleteDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnDeleteDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteDir.Location = new System.Drawing.Point(84, 3);
			this.btnDeleteDir.Name = "btnDeleteDir";
			this.btnDeleteDir.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteDir.TabIndex = 16;
			this.btnDeleteDir.Text = "del dir";
			this.btnDeleteDir.UseVisualStyleBackColor = true;
			this.btnDeleteDir.Click += new System.EventHandler(this.btnDeleteDir_Click);
			// 
			// btnNewDir
			// 
			this.btnNewDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnNewDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewDir.Location = new System.Drawing.Point(3, 3);
			this.btnNewDir.Name = "btnNewDir";
			this.btnNewDir.Size = new System.Drawing.Size(75, 23);
			this.btnNewDir.TabIndex = 15;
			this.btnNewDir.Text = "create dir";
			this.btnNewDir.UseVisualStyleBackColor = true;
			this.btnNewDir.Click += new System.EventHandler(this.btnNewDir_Click);
			// 
			// txtDirectoryFullName
			// 
			this.txtDirectoryFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDirectoryFullName.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtDirectoryFullName.Location = new System.Drawing.Point(3, 36);
			this.txtDirectoryFullName.Name = "txtDirectoryFullName";
			this.txtDirectoryFullName.ReadOnly = true;
			this.txtDirectoryFullName.Size = new System.Drawing.Size(303, 27);
			this.txtDirectoryFullName.TabIndex = 17;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 200;
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "type";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			this.typeDataGridViewTextBoxColumn.ReadOnly = true;
			this.typeDataGridViewTextBoxColumn.Width = 70;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// iNodeBindingSource
			// 
			this.iNodeBindingSource.DataSource = typeof(Domain.Entities.INode);
			// 
			// DirectoriesViewUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtDirectoryFullName);
			this.Controls.Add(this.btnDeleteDir);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.btnNewDir);
			this.Name = "DirectoriesViewUC";
			this.Size = new System.Drawing.Size(309, 483);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDirectories)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iNodeBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dgvDirectories;
		private System.Windows.Forms.Button btnDeleteDir;
		private System.Windows.Forms.Button btnNewDir;
		private System.Windows.Forms.TextBox txtDirectoryFullName;
		private System.Windows.Forms.BindingSource iNodeBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
	}
}
