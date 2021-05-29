
namespace WindowsFormsAppTest
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnCreatDir = new System.Windows.Forms.Button();
			this.btnHideIcons = new System.Windows.Forms.Button();
			this.btnShowIcons = new System.Windows.Forms.Button();
			this.component11 = new WindowsFormsAppTest.Component1(this.components);
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iNodeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.iNodeBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.iNodeBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(64, 59);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowTemplate.Height = 28;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(789, 404);
			this.dataGridView1.TabIndex = 0;
			// 
			// txtPath
			// 
			this.txtPath.Location = new System.Drawing.Point(64, 21);
			this.txtPath.Name = "txtPath";
			this.txtPath.ReadOnly = true;
			this.txtPath.Size = new System.Drawing.Size(789, 30);
			this.txtPath.TabIndex = 1;
			// 
			// btnCreatDir
			// 
			this.btnCreatDir.Location = new System.Drawing.Point(730, 471);
			this.btnCreatDir.Name = "btnCreatDir";
			this.btnCreatDir.Size = new System.Drawing.Size(123, 43);
			this.btnCreatDir.TabIndex = 2;
			this.btnCreatDir.Text = "create dir";
			this.btnCreatDir.UseVisualStyleBackColor = true;
			this.btnCreatDir.Click += new System.EventHandler(this.btnCreatDir_Click);
			// 
			// btnHideIcons
			// 
			this.btnHideIcons.Location = new System.Drawing.Point(896, 137);
			this.btnHideIcons.Name = "btnHideIcons";
			this.btnHideIcons.Size = new System.Drawing.Size(119, 43);
			this.btnHideIcons.TabIndex = 3;
			this.btnHideIcons.Text = "hide icons";
			this.btnHideIcons.UseVisualStyleBackColor = true;
			this.btnHideIcons.Click += new System.EventHandler(this.btnHideIcons_Click);
			// 
			// btnShowIcons
			// 
			this.btnShowIcons.Location = new System.Drawing.Point(896, 186);
			this.btnShowIcons.Name = "btnShowIcons";
			this.btnShowIcons.Size = new System.Drawing.Size(119, 43);
			this.btnShowIcons.TabIndex = 4;
			this.btnShowIcons.Text = "show icons";
			this.btnShowIcons.UseVisualStyleBackColor = true;
			this.btnShowIcons.Click += new System.EventHandler(this.btnShowIcons_Click);
			// 
			// component11
			// 
			this.component11.Grid = this.dataGridView1;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 200;
			// 
			// iNodeBindingSource
			// 
			this.iNodeBindingSource.DataSource = typeof(DirectoriesWolking.Models.DirNavigator.INode);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1053, 592);
			this.Controls.Add(this.btnShowIcons);
			this.Controls.Add(this.btnHideIcons);
			this.Controls.Add(this.btnCreatDir);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.dataGridView1);
			this.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.iNodeBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button btnCreatDir;
		private System.Windows.Forms.Button btnHideIcons;
		private System.Windows.Forms.Button btnShowIcons;
		private System.Windows.Forms.BindingSource iNodeBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private Component1 component11;
	}
}

