namespace Shared.UI.Forms
{
	partial class CompletedTasksForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDateCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDefinition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clDate,
            this.clDateCompleted,
            this.clDefinition,
            this.clPath});
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 375);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // clId
            // 
            this.clId.DataPropertyName = "id";
            this.clId.HeaderText = "#";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Width = 50;
            // 
            // clDate
            // 
            this.clDate.DataPropertyName = "date";
            this.clDate.HeaderText = "date";
            this.clDate.Name = "clDate";
            this.clDate.ReadOnly = true;
            // 
            // clDateCompleted
            // 
            this.clDateCompleted.DataPropertyName = "completed_date";
            this.clDateCompleted.HeaderText = "completed";
            this.clDateCompleted.Name = "clDateCompleted";
            this.clDateCompleted.ReadOnly = true;
            // 
            // clDefinition
            // 
            this.clDefinition.DataPropertyName = "definition";
            this.clDefinition.HeaderText = "def";
            this.clDefinition.Name = "clDefinition";
            this.clDefinition.ReadOnly = true;
            // 
            // clPath
            // 
            this.clPath.DataPropertyName = "path";
            this.clPath.HeaderText = "path";
            this.clPath.Name = "clPath";
            this.clPath.ReadOnly = true;
            this.clPath.Width = 300;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 33);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CompletedTasksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CompletedTasksForm";
            this.Text = "CompletedTasksForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CompletedTasksForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn clId;
		private System.Windows.Forms.DataGridViewTextBoxColumn clDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn clDateCompleted;
		private System.Windows.Forms.DataGridViewTextBoxColumn clDefinition;
		private System.Windows.Forms.DataGridViewTextBoxColumn clPath;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}