
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvSessions = new System.Windows.Forms.DataGridView();
			this.ShorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ReservedHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalWorkTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnNewSession = new System.Windows.Forms.Button();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.btnSaveDayImage = new System.Windows.Forms.Button();
			this.txtCurrentDate = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.RichTextBox();
			this.btnSortAndAlign = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblAllocatedTime = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.lblEndOfDay = new System.Windows.Forms.Label();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.closedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.oSessionBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.oSessionBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSessions
			// 
			this.dgvSessions.AllowUserToAddRows = false;
			this.dgvSessions.AllowUserToDeleteRows = false;
			this.dgvSessions.AllowUserToResizeRows = false;
			this.dgvSessions.AutoGenerateColumns = false;
			this.dgvSessions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
			this.dgvSessions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ShorName,
            this.Start,
            this.ReservedHours,
            this.TotalWorkTime,
            this.closedDataGridViewCheckBoxColumn});
			this.dgvSessions.DataSource = this.oSessionBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSessions.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvSessions.EnableHeadersVisualStyles = false;
			this.dgvSessions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.dgvSessions.Location = new System.Drawing.Point(183, 46);
			this.dgvSessions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvSessions.Name = "dgvSessions";
			this.dgvSessions.RowHeadersVisible = false;
			this.dgvSessions.RowTemplate.Height = 28;
			this.dgvSessions.Size = new System.Drawing.Size(1116, 287);
			this.dgvSessions.TabIndex = 0;
			this.dgvSessions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSessions_CellFormatting);
			this.dgvSessions.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvSessions_Paint);
			this.dgvSessions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSessions_KeyDown);
			// 
			// ShorName
			// 
			this.ShorName.DataPropertyName = "ShorName";
			this.ShorName.HeaderText = "Name";
			this.ShorName.Name = "ShorName";
			this.ShorName.ReadOnly = true;
			this.ShorName.Width = 300;
			// 
			// Start
			// 
			this.Start.DataPropertyName = "Start";
			dataGridViewCellStyle2.Format = "HH:mm  dd.MM.yy";
			this.Start.DefaultCellStyle = dataGridViewCellStyle2;
			this.Start.HeaderText = "Start";
			this.Start.Name = "Start";
			this.Start.Width = 150;
			// 
			// ReservedHours
			// 
			this.ReservedHours.DataPropertyName = "ReservedHours";
			this.ReservedHours.HeaderText = "Hrs";
			this.ReservedHours.Name = "ReservedHours";
			this.ReservedHours.Width = 50;
			// 
			// TotalWorkTime
			// 
			this.TotalWorkTime.DataPropertyName = "TotalWorkTime";
			this.TotalWorkTime.HeaderText = "Total";
			this.TotalWorkTime.Name = "TotalWorkTime";
			this.TotalWorkTime.ReadOnly = true;
			// 
			// btnNewSession
			// 
			this.btnNewSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
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
			this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
			this.monthCalendar1.Location = new System.Drawing.Point(6, 18);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 2;
			this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
			// 
			// btnSaveDayImage
			// 
			this.btnSaveDayImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveDayImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.btnSaveDayImage.Location = new System.Drawing.Point(934, 677);
			this.btnSaveDayImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSaveDayImage.Name = "btnSaveDayImage";
			this.btnSaveDayImage.Size = new System.Drawing.Size(183, 41);
			this.btnSaveDayImage.TabIndex = 3;
			this.btnSaveDayImage.Text = "Save image";
			this.btnSaveDayImage.UseVisualStyleBackColor = true;
			this.btnSaveDayImage.Click += new System.EventHandler(this.btnSaveDayImage_Click);
			// 
			// txtCurrentDate
			// 
			this.txtCurrentDate.AutoSize = true;
			this.txtCurrentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.txtCurrentDate.Location = new System.Drawing.Point(236, 18);
			this.txtCurrentDate.Name = "txtCurrentDate";
			this.txtCurrentDate.Size = new System.Drawing.Size(54, 23);
			this.txtCurrentDate.TabIndex = 5;
			this.txtCurrentDate.Text = "label1";
			// 
			// txtDescription
			// 
			this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
			this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.txtDescription.Location = new System.Drawing.Point(3, 3);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(1110, 320);
			this.txtDescription.TabIndex = 6;
			this.txtDescription.Text = "";
			// 
			// btnSortAndAlign
			// 
			this.btnSortAndAlign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSortAndAlign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
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
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.label1.Location = new System.Drawing.Point(461, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Распределено часов";
			// 
			// lblAllocatedTime
			// 
			this.lblAllocatedTime.AutoSize = true;
			this.lblAllocatedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.lblAllocatedTime.Location = new System.Drawing.Point(643, 18);
			this.lblAllocatedTime.Name = "lblAllocatedTime";
			this.lblAllocatedTime.Size = new System.Drawing.Size(19, 23);
			this.lblAllocatedTime.TabIndex = 9;
			this.lblAllocatedTime.Text = "0";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtDescription);
			this.panel1.Location = new System.Drawing.Point(183, 341);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1116, 326);
			this.panel1.TabIndex = 10;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.label2.Location = new System.Drawing.Point(720, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Завершение смены";
			// 
			// lblEndOfDay
			// 
			this.lblEndOfDay.AutoSize = true;
			this.lblEndOfDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.lblEndOfDay.Location = new System.Drawing.Point(891, 18);
			this.lblEndOfDay.Name = "lblEndOfDay";
			this.lblEndOfDay.Size = new System.Drawing.Size(19, 23);
			this.lblEndOfDay.TabIndex = 12;
			this.lblEndOfDay.Text = "0";
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Dir";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
			this.ClientSize = new System.Drawing.Size(1332, 740);
			this.Controls.Add(this.lblEndOfDay);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblAllocatedTime);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSortAndAlign);
			this.Controls.Add(this.txtCurrentDate);
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
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.oSessionBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvSessions;
		private System.Windows.Forms.Button btnNewSession;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Button btnSaveDayImage;
		private System.Windows.Forms.BindingSource oSessionBindingSource;
		private System.Windows.Forms.Label txtCurrentDate;
		private System.Windows.Forms.RichTextBox txtDescription;
		private System.Windows.Forms.Button btnSortAndAlign;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblAllocatedTime;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn planStartDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn planHoursDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn planFinishDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ShorName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Start;
		private System.Windows.Forms.DataGridViewTextBoxColumn ReservedHours;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalWorkTime;
		private System.Windows.Forms.DataGridViewCheckBoxColumn closedDataGridViewCheckBoxColumn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblEndOfDay;
	}
}

