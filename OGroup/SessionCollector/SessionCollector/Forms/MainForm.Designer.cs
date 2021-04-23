
namespace SessionCollector
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvSessions = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.planStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.planHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.planFinishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.actualHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.closedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.oSessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.btnNewSession = new System.Windows.Forms.Button();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.btnSaveDayImage = new System.Windows.Forms.Button();
			this.dgvDirectories = new System.Windows.Forms.DataGridView();
			this.txtCurrentDate = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.RichTextBox();
			this.btnSortAndAlign = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblAllocatedTime = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.oSessionBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDirectories)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvSessions
			// 
			this.dgvSessions.AllowUserToAddRows = false;
			this.dgvSessions.AllowUserToDeleteRows = false;
			this.dgvSessions.AllowUserToResizeRows = false;
			this.dgvSessions.AutoGenerateColumns = false;
			this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.planStartDataGridViewTextBoxColumn,
            this.planHoursDataGridViewTextBoxColumn,
            this.planFinishDataGridViewTextBoxColumn,
            this.actualHoursDataGridViewTextBoxColumn,
            this.closedDataGridViewCheckBoxColumn});
			this.dgvSessions.DataSource = this.oSessionBindingSource;
			this.dgvSessions.Location = new System.Drawing.Point(240, 46);
			this.dgvSessions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvSessions.Name = "dgvSessions";
			this.dgvSessions.RowTemplate.Height = 28;
			this.dgvSessions.Size = new System.Drawing.Size(1149, 287);
			this.dgvSessions.TabIndex = 0;
			this.dgvSessions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSessions_CellFormatting);
			this.dgvSessions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSessions_KeyDown);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
			this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
			this.descriptionDataGridViewTextBoxColumn.Width = 300;
			// 
			// planStartDataGridViewTextBoxColumn
			// 
			this.planStartDataGridViewTextBoxColumn.DataPropertyName = "PlanStart";
			dataGridViewCellStyle7.Format = "dd.MM.yyyy \\ HH:mm";
			this.planStartDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
			this.planStartDataGridViewTextBoxColumn.HeaderText = "PlanStart";
			this.planStartDataGridViewTextBoxColumn.Name = "planStartDataGridViewTextBoxColumn";
			this.planStartDataGridViewTextBoxColumn.Width = 200;
			// 
			// planHoursDataGridViewTextBoxColumn
			// 
			this.planHoursDataGridViewTextBoxColumn.DataPropertyName = "PlanHours";
			this.planHoursDataGridViewTextBoxColumn.HeaderText = "PlanHours";
			this.planHoursDataGridViewTextBoxColumn.Name = "planHoursDataGridViewTextBoxColumn";
			// 
			// planFinishDataGridViewTextBoxColumn
			// 
			this.planFinishDataGridViewTextBoxColumn.DataPropertyName = "PlanFinish";
			dataGridViewCellStyle8.Format = "HH:mm";
			this.planFinishDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
			this.planFinishDataGridViewTextBoxColumn.HeaderText = "PlanFinish";
			this.planFinishDataGridViewTextBoxColumn.Name = "planFinishDataGridViewTextBoxColumn";
			this.planFinishDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// actualHoursDataGridViewTextBoxColumn
			// 
			this.actualHoursDataGridViewTextBoxColumn.DataPropertyName = "ActualHours";
			this.actualHoursDataGridViewTextBoxColumn.HeaderText = "ActualHours";
			this.actualHoursDataGridViewTextBoxColumn.Name = "actualHoursDataGridViewTextBoxColumn";
			// 
			// closedDataGridViewCheckBoxColumn
			// 
			this.closedDataGridViewCheckBoxColumn.DataPropertyName = "Closed";
			this.closedDataGridViewCheckBoxColumn.HeaderText = "Closed";
			this.closedDataGridViewCheckBoxColumn.Name = "closedDataGridViewCheckBoxColumn";
			// 
			// oSessionBindingSource
			// 
			this.oSessionBindingSource.DataSource = typeof(SessionCollector.BL.Entities.OSession);
			// 
			// btnNewSession
			// 
			this.btnNewSession.Location = new System.Drawing.Point(18, 677);
			this.btnNewSession.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnNewSession.Name = "btnNewSession";
			this.btnNewSession.Size = new System.Drawing.Size(183, 41);
			this.btnNewSession.TabIndex = 1;
			this.btnNewSession.Text = "New Session";
			this.btnNewSession.UseVisualStyleBackColor = true;
			this.btnNewSession.Click += new System.EventHandler(this.btnNewSession_Click);
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(6, 18);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 2;
			this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
			// 
			// btnSaveDayImage
			// 
			this.btnSaveDayImage.Location = new System.Drawing.Point(1206, 677);
			this.btnSaveDayImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSaveDayImage.Name = "btnSaveDayImage";
			this.btnSaveDayImage.Size = new System.Drawing.Size(183, 41);
			this.btnSaveDayImage.TabIndex = 3;
			this.btnSaveDayImage.Text = "Save image";
			this.btnSaveDayImage.UseVisualStyleBackColor = true;
			this.btnSaveDayImage.Click += new System.EventHandler(this.btnSaveDayImage_Click);
			// 
			// dgvDirectories
			// 
			this.dgvDirectories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDirectories.Location = new System.Drawing.Point(6, 183);
			this.dgvDirectories.Name = "dgvDirectories";
			this.dgvDirectories.Size = new System.Drawing.Size(230, 484);
			this.dgvDirectories.TabIndex = 4;
			// 
			// txtCurrentDate
			// 
			this.txtCurrentDate.AutoSize = true;
			this.txtCurrentDate.Location = new System.Drawing.Point(236, 18);
			this.txtCurrentDate.Name = "txtCurrentDate";
			this.txtCurrentDate.Size = new System.Drawing.Size(54, 23);
			this.txtCurrentDate.TabIndex = 5;
			this.txtCurrentDate.Text = "label1";
			// 
			// txtDescription
			// 
			this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDescription.Location = new System.Drawing.Point(0, 0);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(1147, 324);
			this.txtDescription.TabIndex = 6;
			this.txtDescription.Text = "";
			// 
			// btnSortAndAlign
			// 
			this.btnSortAndAlign.Location = new System.Drawing.Point(686, 675);
			this.btnSortAndAlign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSortAndAlign.Name = "btnSortAndAlign";
			this.btnSortAndAlign.Size = new System.Drawing.Size(183, 41);
			this.btnSortAndAlign.TabIndex = 7;
			this.btnSortAndAlign.Text = "Sort and align";
			this.btnSortAndAlign.UseVisualStyleBackColor = true;
			this.btnSortAndAlign.Click += new System.EventHandler(this.btnSortAndAlign_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(665, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Распределено часов";
			// 
			// lblAllocatedTime
			// 
			this.lblAllocatedTime.AutoSize = true;
			this.lblAllocatedTime.Location = new System.Drawing.Point(847, 18);
			this.lblAllocatedTime.Name = "lblAllocatedTime";
			this.lblAllocatedTime.Size = new System.Drawing.Size(19, 23);
			this.lblAllocatedTime.TabIndex = 9;
			this.lblAllocatedTime.Text = "0";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtDescription);
			this.panel1.Location = new System.Drawing.Point(240, 341);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1149, 326);
			this.panel1.TabIndex = 10;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1449, 740);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblAllocatedTime);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSortAndAlign);
			this.Controls.Add(this.txtCurrentDate);
			this.Controls.Add(this.dgvDirectories);
			this.Controls.Add(this.btnSaveDayImage);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.btnNewSession);
			this.Controls.Add(this.dgvSessions);
			this.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.oSessionBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDirectories)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvSessions;
		private System.Windows.Forms.Button btnNewSession;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Button btnSaveDayImage;
		private System.Windows.Forms.DataGridView dgvDirectories;
		private System.Windows.Forms.BindingSource oSessionBindingSource;
		private System.Windows.Forms.Label txtCurrentDate;
		private System.Windows.Forms.RichTextBox txtDescription;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn planStartDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn planHoursDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn planFinishDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn actualHoursDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn closedDataGridViewCheckBoxColumn;
		private System.Windows.Forms.Button btnSortAndAlign;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblAllocatedTime;
		private System.Windows.Forms.Panel panel1;
	}
}

