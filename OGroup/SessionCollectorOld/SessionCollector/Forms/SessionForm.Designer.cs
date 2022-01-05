
namespace SessionCollector.Forms
{
	partial class SessionForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionForm));
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePickerPlanStart = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPlanFinish = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtLogEnterConsole = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDirName = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.label6 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnOpen = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnChangeDirectory = new System.Windows.Forms.Button();
			this.btnPause = new System.Windows.Forms.Button();
			this.timeInputUserControl2Provided = new SessionCollector.UC.TimeInputUserControl();
			this.timeInputUserControl1Total = new SessionCollector.UC.TimeInputUserControl();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.txtDescription = new System.Windows.Forms.RichTextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabTask = new System.Windows.Forms.TabPage();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnEditLogList = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabTask.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.label1.Location = new System.Drawing.Point(351, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(197, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Выделено времени, ч:м";
			// 
			// dateTimePickerPlanStart
			// 
			this.dateTimePickerPlanStart.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
			this.dateTimePickerPlanStart.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.dateTimePickerPlanStart.CustomFormat = "dd.MM.yyyy HH:mm";
			this.dateTimePickerPlanStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerPlanStart.Location = new System.Drawing.Point(124, 84);
			this.dateTimePickerPlanStart.Name = "dateTimePickerPlanStart";
			this.dateTimePickerPlanStart.Size = new System.Drawing.Size(212, 30);
			this.dateTimePickerPlanStart.TabIndex = 2;
			this.dateTimePickerPlanStart.ValueChanged += new System.EventHandler(this.dateTimePickerPlanStart_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.label2.Location = new System.Drawing.Point(12, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Начало";
			// 
			// txtPlanFinish
			// 
			this.txtPlanFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.txtPlanFinish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.txtPlanFinish.Location = new System.Drawing.Point(124, 127);
			this.txtPlanFinish.Name = "txtPlanFinish";
			this.txtPlanFinish.ReadOnly = true;
			this.txtPlanFinish.Size = new System.Drawing.Size(212, 30);
			this.txtPlanFinish.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.label3.Location = new System.Drawing.Point(12, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Окончание";
			// 
			// txtLogEnterConsole
			// 
			this.txtLogEnterConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLogEnterConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.txtLogEnterConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtLogEnterConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.txtLogEnterConsole.Location = new System.Drawing.Point(3, 3);
			this.txtLogEnterConsole.Name = "txtLogEnterConsole";
			this.txtLogEnterConsole.Size = new System.Drawing.Size(944, 66);
			this.txtLogEnterConsole.TabIndex = 6;
			this.txtLogEnterConsole.Text = "";
			this.txtLogEnterConsole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.label5.Location = new System.Drawing.Point(12, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Директория";
			// 
			// txtDirName
			// 
			this.txtDirName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.txtDirName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.txtDirName.Location = new System.Drawing.Point(124, 6);
			this.txtDirName.Name = "txtDirName";
			this.txtDirName.ReadOnly = true;
			this.txtDirName.Size = new System.Drawing.Size(351, 30);
			this.txtDirName.TabIndex = 9;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.webBrowser1);
			this.panel1.Location = new System.Drawing.Point(2, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(945, 271);
			this.panel1.TabIndex = 21;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// webBrowser1
			// 
			this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.webBrowser1.Location = new System.Drawing.Point(-1, -1);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(945, 271);
			this.webBrowser1.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.label6.Location = new System.Drawing.Point(651, 90);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(208, 23);
			this.label6.TabIndex = 25;
			this.label6.Text = "Отработанное время, ч:м";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtLogEnterConsole);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(950, 72);
			this.panel2.TabIndex = 28;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.panel2);
			this.splitContainer1.Size = new System.Drawing.Size(950, 353);
			this.splitContainer1.SplitterDistance = 277;
			this.splitContainer1.TabIndex = 29;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(655, 62);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(25, 25);
			this.pictureBox1.TabIndex = 30;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// btnOpen
			// 
			this.btnOpen.BackgroundImage = global::SessionCollector.Properties.Resources.open;
			this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnOpen.FlatAppearance.BorderSize = 0;
			this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpen.Location = new System.Drawing.Point(16, 35);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(38, 38);
			this.btnOpen.TabIndex = 27;
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
			// 
			// btnPlay
			// 
			this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
			this.btnPlay.FlatAppearance.BorderSize = 0;
			this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPlay.Location = new System.Drawing.Point(686, 63);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(24, 24);
			this.btnPlay.TabIndex = 26;
			this.btnPlay.UseVisualStyleBackColor = false;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Location = new System.Drawing.Point(917, 9);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(38, 38);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Location = new System.Drawing.Point(873, 9);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(38, 38);
			this.btnSave.TabIndex = 11;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnChangeDirectory
			// 
			this.btnChangeDirectory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangeDirectory.BackgroundImage")));
			this.btnChangeDirectory.FlatAppearance.BorderSize = 0;
			this.btnChangeDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChangeDirectory.Location = new System.Drawing.Point(481, 1);
			this.btnChangeDirectory.Name = "btnChangeDirectory";
			this.btnChangeDirectory.Size = new System.Drawing.Size(38, 38);
			this.btnChangeDirectory.TabIndex = 10;
			this.btnChangeDirectory.Text = "...";
			this.btnChangeDirectory.UseVisualStyleBackColor = true;
			this.btnChangeDirectory.Click += new System.EventHandler(this.btnChangeDirectory_Click);
			// 
			// btnPause
			// 
			this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
			this.btnPause.FlatAppearance.BorderSize = 0;
			this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPause.Location = new System.Drawing.Point(716, 63);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(24, 24);
			this.btnPause.TabIndex = 31;
			this.btnPause.UseVisualStyleBackColor = false;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// timeInputUserControl2Provided
			// 
			this.timeInputUserControl2Provided.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.timeInputUserControl2Provided.Location = new System.Drawing.Point(355, 116);
			this.timeInputUserControl2Provided.Name = "timeInputUserControl2Provided";
			this.timeInputUserControl2Provided.Size = new System.Drawing.Size(294, 64);
			this.timeInputUserControl2Provided.TabIndex = 24;
			this.timeInputUserControl2Provided.TotalSeconds = 0;
			this.timeInputUserControl2Provided.ValueChanged += new System.EventHandler(this.timeInputUserControl2Provided_ValueChanged);
			// 
			// timeInputUserControl1Total
			// 
			this.timeInputUserControl1Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.timeInputUserControl1Total.Location = new System.Drawing.Point(655, 116);
			this.timeInputUserControl1Total.Name = "timeInputUserControl1Total";
			this.timeInputUserControl1Total.Size = new System.Drawing.Size(294, 64);
			this.timeInputUserControl1Total.TabIndex = 22;
			this.timeInputUserControl1Total.TotalSeconds = 0;
			this.timeInputUserControl1Total.ValueChanged += new System.EventHandler(this.timeInputUserControl1Total_ValueChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabTask);
			this.tabControl1.Location = new System.Drawing.Point(2, 186);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(961, 398);
			this.tabControl1.TabIndex = 33;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.tabPage1.Controls.Add(this.txtDescription);
			this.tabPage1.Location = new System.Drawing.Point(4, 32);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(953, 362);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Descr";
			this.tabPage1.ToolTipText = "Description in linear text";
			// 
			// txtDescription
			// 
			this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.txtDescription.Location = new System.Drawing.Point(3, 6);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(947, 353);
			this.txtDescription.TabIndex = 7;
			this.txtDescription.Text = "";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
			this.tabPage2.Controls.Add(this.splitContainer1);
			this.tabPage2.Location = new System.Drawing.Point(4, 32);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(953, 362);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Logs";
			// 
			// tabTask
			// 
			this.tabTask.Controls.Add(this.richTextBox1);
			this.tabTask.Controls.Add(this.button1);
			this.tabTask.Controls.Add(this.label4);
			this.tabTask.Location = new System.Drawing.Point(4, 32);
			this.tabTask.Name = "tabTask";
			this.tabTask.Padding = new System.Windows.Forms.Padding(3);
			this.tabTask.Size = new System.Drawing.Size(953, 362);
			this.tabTask.TabIndex = 2;
			this.tabTask.Text = "Task";
			this.tabTask.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(25, 117);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(918, 239);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "Task description is here";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(25, 75);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(146, 36);
			this.button1.TabIndex = 1;
			this.button1.Text = "Open task";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(21, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(369, 23);
			this.label4.TabIndex = 0;
			this.label4.Text = "Task, referred to this session will be placed here";
			// 
			// btnEditLogList
			// 
			this.btnEditLogList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditLogList.BackgroundImage")));
			this.btnEditLogList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnEditLogList.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnEditLogList.FlatAppearance.BorderSize = 0;
			this.btnEditLogList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditLogList.Location = new System.Drawing.Point(6, 156);
			this.btnEditLogList.Name = "btnEditLogList";
			this.btnEditLogList.Size = new System.Drawing.Size(24, 24);
			this.btnEditLogList.TabIndex = 34;
			this.btnEditLogList.UseVisualStyleBackColor = true;
			this.btnEditLogList.Click += new System.EventHandler(this.btnEditLogList_Click);
			// 
			// SessionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.ClientSize = new System.Drawing.Size(967, 586);
			this.Controls.Add(this.btnEditLogList);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnOpen);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.timeInputUserControl2Provided);
			this.Controls.Add(this.timeInputUserControl1Total);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnChangeDirectory);
			this.Controls.Add(this.txtDirName);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPlanFinish);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateTimePickerPlanStart);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MinimumSize = new System.Drawing.Size(983, 625);
			this.Name = "SessionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SessionForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SessionForm_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SessionForm_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabTask.ResumeLayout(false);
			this.tabTask.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePickerPlanStart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPlanFinish;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox txtLogEnterConsole;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDirName;
		private System.Windows.Forms.Button btnChangeDirectory;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Panel panel1;
		private UC.TimeInputUserControl timeInputUserControl1Total;
		private UC.TimeInputUserControl timeInputUserControl2Provided;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnOpen;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.WebBrowser webBrowser1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnPause;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.RichTextBox txtDescription;
		private System.Windows.Forms.TabPage tabTask;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnEditLogList;
	}
}