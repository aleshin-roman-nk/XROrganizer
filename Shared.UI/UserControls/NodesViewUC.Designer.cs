
namespace Shared.UI.UserControls
{
	partial class NodesViewUC
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.nodeGrid = new System.Windows.Forms.DataGridView();
			this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NTypeString = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cldate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtDirectoryFullName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.nodeGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// nodeGrid
			// 
			this.nodeGrid.AllowUserToAddRows = false;
			this.nodeGrid.AllowUserToDeleteRows = false;
			this.nodeGrid.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
			this.nodeGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.nodeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nodeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
			this.nodeGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.nodeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			this.nodeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.nodeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.nodeGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.name,
            this.NTypeString,
            this.cldate,
            this.description});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(212)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(93)))), ((int)(((byte)(160)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.nodeGrid.DefaultCellStyle = dataGridViewCellStyle3;
			this.nodeGrid.EnableHeadersVisualStyles = false;
			this.nodeGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(198)))), ((int)(((byte)(144)))));
			this.nodeGrid.Location = new System.Drawing.Point(3, 36);
			this.nodeGrid.Name = "nodeGrid";
			this.nodeGrid.ReadOnly = true;
			this.nodeGrid.RowHeadersVisible = false;
			this.nodeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.nodeGrid.Size = new System.Drawing.Size(999, 540);
			this.nodeGrid.TabIndex = 13;
			this.nodeGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.nodeGrid_CellMouseDoubleClick);
			this.nodeGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemsGrid_KeyDown);
			// 
			// colId
			// 
			this.colId.DataPropertyName = "id";
			this.colId.HeaderText = "#";
			this.colId.Name = "colId";
			this.colId.ReadOnly = true;
			this.colId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.colId.Width = 70;
			// 
			// name
			// 
			this.name.DataPropertyName = "name";
			this.name.HeaderText = "name";
			this.name.Name = "name";
			this.name.ReadOnly = true;
			this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.name.Width = 200;
			// 
			// NTypeString
			// 
			this.NTypeString.DataPropertyName = "NTypeString";
			this.NTypeString.HeaderText = "type";
			this.NTypeString.Name = "NTypeString";
			this.NTypeString.ReadOnly = true;
			this.NTypeString.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.NTypeString.Width = 50;
			// 
			// cldate
			// 
			this.cldate.DataPropertyName = "date";
			this.cldate.HeaderText = "date";
			this.cldate.Name = "cldate";
			this.cldate.ReadOnly = true;
			this.cldate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.cldate.Width = 150;
			// 
			// description
			// 
			this.description.DataPropertyName = "definition";
			this.description.HeaderText = "definition";
			this.description.Name = "description";
			this.description.ReadOnly = true;
			this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.description.Width = 300;
			// 
			// txtDirectoryFullName
			// 
			this.txtDirectoryFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDirectoryFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
			this.txtDirectoryFullName.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtDirectoryFullName.Location = new System.Drawing.Point(3, 3);
			this.txtDirectoryFullName.Name = "txtDirectoryFullName";
			this.txtDirectoryFullName.ReadOnly = true;
			this.txtDirectoryFullName.Size = new System.Drawing.Size(999, 27);
			this.txtDirectoryFullName.TabIndex = 24;
			// 
			// NodesViewUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
			this.Controls.Add(this.txtDirectoryFullName);
			this.Controls.Add(this.nodeGrid);
			this.Name = "NodesViewUC";
			this.Size = new System.Drawing.Size(1005, 576);
			this.Load += new System.EventHandler(this.NodesViewUC_Load);
			((System.ComponentModel.ISupportInitialize)(this.nodeGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridView nodeGrid;
		private System.Windows.Forms.TextBox txtDirectoryFullName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colId;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn NTypeString;
		private System.Windows.Forms.DataGridViewTextBoxColumn cldate;
		private System.Windows.Forms.DataGridViewTextBoxColumn description;
	}
}
