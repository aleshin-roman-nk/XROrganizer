
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.dgvSessions = new System.Windows.Forms.DataGridView();
			this.DirName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalMins = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Finish = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnNewSession = new System.Windows.Forms.Button();
			this.txtDescription = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblAllocatedTime = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.lblEndOfDay = new System.Windows.Forms.Label();
			this.btnStata = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtActualDoneWord = new System.Windows.Forms.Label();
			this.myCalendar1 = new DrRomic.UI.MyCalendar();
			this.btnKickNextDay = new System.Windows.Forms.Button();
			this.btnKickPrevDay = new System.Windows.Forms.Button();
			this.btnHideCompletedSessions = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvSessions
			// 
			this.dgvSessions.AllowUserToAddRows = false;
			this.dgvSessions.AllowUserToDeleteRows = false;
			this.dgvSessions.AllowUserToResizeRows = false;
			this.dgvSessions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvSessions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.dgvSessions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSessions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSessions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DirName,
            this.cName,
            this.TotalMins,
            this.Start,
            this.Finish});
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(80)))), ((int)(((byte)(50)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvSessions.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgvSessions.EnableHeadersVisualStyles = false;
			this.dgvSessions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.dgvSessions.Location = new System.Drawing.Point(404, 69);
			this.dgvSessions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvSessions.Name = "dgvSessions";
			this.dgvSessions.ReadOnly = true;
			this.dgvSessions.RowHeadersVisible = false;
			this.dgvSessions.RowTemplate.Height = 28;
			this.dgvSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSessions.Size = new System.Drawing.Size(921, 287);
			this.dgvSessions.TabIndex = 0;
			this.dgvSessions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSessions_CellFormatting);
			this.dgvSessions.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvSessions_Paint);
			this.dgvSessions.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSessions_KeyDown);
			// 
			// DirName
			// 
			this.DirName.DataPropertyName = "DirName";
			this.DirName.HeaderText = "DirName";
			this.DirName.Name = "DirName";
			this.DirName.ReadOnly = true;
			// 
			// cName
			// 
			this.cName.DataPropertyName = "Name";
			this.cName.HeaderText = "Name";
			this.cName.Name = "cName";
			this.cName.ReadOnly = true;
			this.cName.Width = 500;
			// 
			// TotalMins
			// 
			this.TotalMins.DataPropertyName = "WorkedMinutes";
			this.TotalMins.HeaderText = "TotalMins";
			this.TotalMins.Name = "TotalMins";
			this.TotalMins.ReadOnly = true;
			// 
			// Start
			// 
			this.Start.DataPropertyName = "Start";
			dataGridViewCellStyle6.Format = "HH:mm";
			this.Start.DefaultCellStyle = dataGridViewCellStyle6;
			this.Start.HeaderText = "Start";
			this.Start.Name = "Start";
			this.Start.ReadOnly = true;
			// 
			// Finish
			// 
			this.Finish.DataPropertyName = "Finish";
			dataGridViewCellStyle7.Format = "HH:mm";
			this.Finish.DefaultCellStyle = dataGridViewCellStyle7;
			this.Finish.HeaderText = "Finish";
			this.Finish.Name = "Finish";
			this.Finish.ReadOnly = true;
			// 
			// btnNewSession
			// 
			this.btnNewSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.btnNewSession.Location = new System.Drawing.Point(13, 392);
			this.btnNewSession.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnNewSession.Name = "btnNewSession";
			this.btnNewSession.Size = new System.Drawing.Size(164, 41);
			this.btnNewSession.TabIndex = 1;
			this.btnNewSession.Text = "New Session";
			this.btnNewSession.UseVisualStyleBackColor = true;
			this.btnNewSession.Click += new System.EventHandler(this.btnNewSession_Click);
			// 
			// txtDescription
			// 
			this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.txtDescription.Location = new System.Drawing.Point(3, 3);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.ReadOnly = true;
			this.txtDescription.Size = new System.Drawing.Size(913, 295);
			this.txtDescription.TabIndex = 6;
			this.txtDescription.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.label1.Location = new System.Drawing.Point(403, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Распределено часов";
			// 
			// lblAllocatedTime
			// 
			this.lblAllocatedTime.AutoSize = true;
			this.lblAllocatedTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.lblAllocatedTime.Location = new System.Drawing.Point(651, 9);
			this.lblAllocatedTime.Name = "lblAllocatedTime";
			this.lblAllocatedTime.Size = new System.Drawing.Size(19, 23);
			this.lblAllocatedTime.TabIndex = 9;
			this.lblAllocatedTime.Text = "0";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.txtDescription);
			this.panel1.Location = new System.Drawing.Point(404, 364);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(921, 303);
			this.panel1.TabIndex = 10;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.label2.Location = new System.Drawing.Point(818, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Завершение смены";
			// 
			// lblEndOfDay
			// 
			this.lblEndOfDay.AutoSize = true;
			this.lblEndOfDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.lblEndOfDay.Location = new System.Drawing.Point(989, 41);
			this.lblEndOfDay.Name = "lblEndOfDay";
			this.lblEndOfDay.Size = new System.Drawing.Size(19, 23);
			this.lblEndOfDay.TabIndex = 12;
			this.lblEndOfDay.Text = "0";
			// 
			// btnStata
			// 
			this.btnStata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.btnStata.Location = new System.Drawing.Point(13, 341);
			this.btnStata.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnStata.Name = "btnStata";
			this.btnStata.Size = new System.Drawing.Size(164, 41);
			this.btnStata.TabIndex = 14;
			this.btnStata.Text = "Statistic";
			this.btnStata.UseVisualStyleBackColor = true;
			this.btnStata.Click += new System.EventHandler(this.btnStata_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.label3.Location = new System.Drawing.Point(403, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 23);
			this.label3.TabIndex = 15;
			this.label3.Text = "Полезная работа";
			// 
			// txtActualDoneWord
			// 
			this.txtActualDoneWord.AutoSize = true;
			this.txtActualDoneWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.txtActualDoneWord.Location = new System.Drawing.Point(651, 41);
			this.txtActualDoneWord.Name = "txtActualDoneWord";
			this.txtActualDoneWord.Size = new System.Drawing.Size(19, 23);
			this.txtActualDoneWord.TabIndex = 16;
			this.txtActualDoneWord.Text = "0";
			// 
			// myCalendar1
			// 
			this.myCalendar1.BackColorCalendar = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.myCalendar1.ControlsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.myCalendar1.CurrentDateBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.myCalendar1.CurrentDateForeColor = System.Drawing.Color.Aqua;
			this.myCalendar1.ForeColorCalendar = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.myCalendar1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.myCalendar1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.myCalendar1.Location = new System.Drawing.Point(12, 9);
			this.myCalendar1.Name = "myCalendar1";
			this.myCalendar1.OutDaysBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
			this.myCalendar1.OutDaysForeColor = System.Drawing.Color.Gray;
			this.myCalendar1.Size = new System.Drawing.Size(385, 324);
			this.myCalendar1.TabIndex = 17;
			this.myCalendar1.DateChanged += new System.Action<System.DateTime>(this.myCalendar1_DateChanged);
			// 
			// btnKickNextDay
			// 
			this.btnKickNextDay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKickNextDay.BackgroundImage")));
			this.btnKickNextDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnKickNextDay.FlatAppearance.BorderSize = 0;
			this.btnKickNextDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKickNextDay.Location = new System.Drawing.Point(1267, 12);
			this.btnKickNextDay.Name = "btnKickNextDay";
			this.btnKickNextDay.Size = new System.Drawing.Size(28, 28);
			this.btnKickNextDay.TabIndex = 18;
			this.btnKickNextDay.UseVisualStyleBackColor = true;
			this.btnKickNextDay.Click += new System.EventHandler(this.btnKickNextDay_Click);
			// 
			// btnKickPrevDay
			// 
			this.btnKickPrevDay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKickPrevDay.BackgroundImage")));
			this.btnKickPrevDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnKickPrevDay.FlatAppearance.BorderSize = 0;
			this.btnKickPrevDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnKickPrevDay.Location = new System.Drawing.Point(1233, 12);
			this.btnKickPrevDay.Name = "btnKickPrevDay";
			this.btnKickPrevDay.Size = new System.Drawing.Size(28, 28);
			this.btnKickPrevDay.TabIndex = 19;
			this.btnKickPrevDay.UseVisualStyleBackColor = true;
			this.btnKickPrevDay.Click += new System.EventHandler(this.btnKickPrevDay_Click);
			// 
			// btnHideCompletedSessions
			// 
			this.btnHideCompletedSessions.BackgroundImage = global::SessionCollector.Properties.Resources.hide_completed_sess;
			this.btnHideCompletedSessions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnHideCompletedSessions.FlatAppearance.BorderSize = 0;
			this.btnHideCompletedSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHideCompletedSessions.Location = new System.Drawing.Point(1199, 12);
			this.btnHideCompletedSessions.Name = "btnHideCompletedSessions";
			this.btnHideCompletedSessions.Size = new System.Drawing.Size(28, 28);
			this.btnHideCompletedSessions.TabIndex = 20;
			this.btnHideCompletedSessions.UseVisualStyleBackColor = true;
			this.btnHideCompletedSessions.Click += new System.EventHandler(this.btnHideCompletedSessions_Click);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.ClientSize = new System.Drawing.Size(1333, 674);
			this.Controls.Add(this.btnHideCompletedSessions);
			this.Controls.Add(this.btnKickPrevDay);
			this.Controls.Add(this.btnKickNextDay);
			this.Controls.Add(this.myCalendar1);
			this.Controls.Add(this.txtActualDoneWord);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnStata);
			this.Controls.Add(this.lblEndOfDay);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblAllocatedTime);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnNewSession);
			this.Controls.Add(this.dgvSessions);
			this.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Session Collector";
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.dgvSessions)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvSessions;
		private System.Windows.Forms.Button btnNewSession;
		private System.Windows.Forms.RichTextBox txtDescription;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblAllocatedTime;
		private System.Windows.Forms.Panel panel1;
//		private System.Windows.Forms.DataGridViewTextBoxColumn planStartDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewTextBoxColumn planHoursDataGridViewTextBoxColumn;
//		private System.Windows.Forms.DataGridViewTextBoxColumn planFinishDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblEndOfDay;
		private System.Windows.Forms.Button btnStata;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label txtActualDoneWord;
		private DrRomic.UI.MyCalendar myCalendar1;
		private System.Windows.Forms.Button btnKickNextDay;
		private System.Windows.Forms.Button btnKickPrevDay;
		private System.Windows.Forms.DataGridViewTextBoxColumn DirName;
		private System.Windows.Forms.DataGridViewTextBoxColumn cName;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalMins;
		private System.Windows.Forms.DataGridViewTextBoxColumn Start;
		private System.Windows.Forms.DataGridViewTextBoxColumn Finish;
		private System.Windows.Forms.Button btnHideCompletedSessions;
	}
}

