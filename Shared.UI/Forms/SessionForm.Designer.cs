
namespace Shared.UI.Forms
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
            this.txtNodeName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabTask = new System.Windows.Forms.TabPage();
            this.owningNodeDescription = new System.Windows.Forms.RichTextBox();
            this.btnEditLogList = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnOpenOwner = new System.Windows.Forms.Button();
            this.timeInputUserControl2Provided = new Shared.UI.UserControls.TimeInputUserControl();
            this.timeInputUserControl1Total = new Shared.UI.UserControls.TimeInputUserControl();
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
            this.label1.Location = new System.Drawing.Point(351, 144);
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
            this.dateTimePickerPlanStart.Location = new System.Drawing.Point(124, 138);
            this.dateTimePickerPlanStart.Name = "dateTimePickerPlanStart";
            this.dateTimePickerPlanStart.Size = new System.Drawing.Size(212, 30);
            this.dateTimePickerPlanStart.TabIndex = 2;
            this.dateTimePickerPlanStart.ValueChanged += new System.EventHandler(this.dateTimePickerPlanStart_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Начало";
            // 
            // txtPlanFinish
            // 
            this.txtPlanFinish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtPlanFinish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.txtPlanFinish.Location = new System.Drawing.Point(124, 181);
            this.txtPlanFinish.Name = "txtPlanFinish";
            this.txtPlanFinish.ReadOnly = true;
            this.txtPlanFinish.Size = new System.Drawing.Size(212, 30);
            this.txtPlanFinish.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.label3.Location = new System.Drawing.Point(12, 184);
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
            this.txtLogEnterConsole.Size = new System.Drawing.Size(938, 41);
            this.txtLogEnterConsole.TabIndex = 6;
            this.txtLogEnterConsole.Text = "";
            this.txtLogEnterConsole.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.label5.Location = new System.Drawing.Point(12, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Контекст";
            // 
            // txtNodeName
            // 
            this.txtNodeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtNodeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.txtNodeName.Location = new System.Drawing.Point(101, 101);
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.ReadOnly = true;
            this.txtNodeName.Size = new System.Drawing.Size(518, 30);
            this.txtNodeName.TabIndex = 9;
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
            this.panel1.Size = new System.Drawing.Size(939, 177);
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
            this.webBrowser1.Size = new System.Drawing.Size(939, 177);
            this.webBrowser1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.label6.Location = new System.Drawing.Point(651, 144);
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
            this.panel2.Size = new System.Drawing.Size(944, 47);
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
            this.splitContainer1.Size = new System.Drawing.Size(944, 234);
            this.splitContainer1.SplitterDistance = 183;
            this.splitContainer1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(655, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(58)))));
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Location = new System.Drawing.Point(101, 47);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(38, 38);
            this.btnOpen.TabIndex = 27;
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(686, 117);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(24, 24);
            this.btnPlay.TabIndex = 26;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(935, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 38);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(53, 47);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(38, 38);
            this.btnSave.TabIndex = 11;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(716, 117);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(24, 24);
            this.btnPause.TabIndex = 31;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabTask);
            this.tabControl1.Location = new System.Drawing.Point(2, 245);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(971, 334);
            this.tabControl1.TabIndex = 33;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tabPage1.Controls.Add(this.txtDescription);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(963, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Descr";
            this.tabPage1.ToolTipText = "Description in linear text";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(48)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.txtDescription.Location = new System.Drawing.Point(3, 6);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(957, 292);
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
            this.tabPage2.Size = new System.Drawing.Size(963, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Logs";
            // 
            // tabTask
            // 
            this.tabTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.tabTask.Controls.Add(this.owningNodeDescription);
            this.tabTask.Location = new System.Drawing.Point(4, 32);
            this.tabTask.Name = "tabTask";
            this.tabTask.Padding = new System.Windows.Forms.Padding(3);
            this.tabTask.Size = new System.Drawing.Size(963, 298);
            this.tabTask.TabIndex = 2;
            this.tabTask.Text = "Task";
            // 
            // owningNodeDescription
            // 
            this.owningNodeDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.owningNodeDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.owningNodeDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
            this.owningNodeDescription.Location = new System.Drawing.Point(3, 6);
            this.owningNodeDescription.Name = "owningNodeDescription";
            this.owningNodeDescription.Size = new System.Drawing.Size(954, 273);
            this.owningNodeDescription.TabIndex = 2;
            this.owningNodeDescription.Text = "Task description is here";
            // 
            // btnEditLogList
            // 
            this.btnEditLogList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditLogList.BackgroundImage")));
            this.btnEditLogList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditLogList.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditLogList.FlatAppearance.BorderSize = 0;
            this.btnEditLogList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditLogList.Location = new System.Drawing.Point(6, 210);
            this.btnEditLogList.Name = "btnEditLogList";
            this.btnEditLogList.Size = new System.Drawing.Size(24, 24);
            this.btnEditLogList.TabIndex = 34;
            this.btnEditLogList.UseVisualStyleBackColor = true;
            this.btnEditLogList.Click += new System.EventHandler(this.btnEditLogList_Click);
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHide.BackgroundImage")));
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Location = new System.Drawing.Point(891, 2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(38, 38);
            this.btnHide.TabIndex = 35;
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnOpenOwner
            // 
            this.btnOpenOwner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenOwner.BackgroundImage")));
            this.btnOpenOwner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnOpenOwner.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOpenOwner.FlatAppearance.BorderSize = 0;
            this.btnOpenOwner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenOwner.Location = new System.Drawing.Point(9, 47);
            this.btnOpenOwner.Name = "btnOpenOwner";
            this.btnOpenOwner.Size = new System.Drawing.Size(38, 38);
            this.btnOpenOwner.TabIndex = 36;
            this.btnOpenOwner.UseVisualStyleBackColor = true;
            this.btnOpenOwner.Click += new System.EventHandler(this.btnOpenOwner_Click);
            // 
            // timeInputUserControl2Provided
            // 
            this.timeInputUserControl2Provided.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeInputUserControl2Provided.Location = new System.Drawing.Point(355, 170);
            this.timeInputUserControl2Provided.Name = "timeInputUserControl2Provided";
            this.timeInputUserControl2Provided.Size = new System.Drawing.Size(294, 64);
            this.timeInputUserControl2Provided.TabIndex = 24;
            this.timeInputUserControl2Provided.TotalSeconds = 0;
            this.timeInputUserControl2Provided.ValueChanged += new System.EventHandler(this.timeInputUserControl2Provided_ValueChanged);
            // 
            // timeInputUserControl1Total
            // 
            this.timeInputUserControl1Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeInputUserControl1Total.Location = new System.Drawing.Point(655, 170);
            this.timeInputUserControl1Total.Name = "timeInputUserControl1Total";
            this.timeInputUserControl1Total.Size = new System.Drawing.Size(294, 64);
            this.timeInputUserControl1Total.TabIndex = 22;
            this.timeInputUserControl1Total.TotalSeconds = 0;
            this.timeInputUserControl1Total.ValueChanged += new System.EventHandler(this.timeInputUserControl1Total_ValueChanged);
            // 
            // SessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(977, 581);
            this.Controls.Add(this.btnOpenOwner);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnEditLogList);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timeInputUserControl2Provided);
            this.Controls.Add(this.timeInputUserControl1Total);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNodeName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPlanFinish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerPlanStart);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(977, 506);
            this.Name = "SessionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SessionForm";
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
		private System.Windows.Forms.TextBox txtNodeName;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Panel panel1;
		private Shared.UI.UserControls.TimeInputUserControl timeInputUserControl1Total;
		private Shared.UI.UserControls.TimeInputUserControl timeInputUserControl2Provided;
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
		private System.Windows.Forms.RichTextBox owningNodeDescription;
		private System.Windows.Forms.Button btnEditLogList;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnOpenOwner;
    }
}