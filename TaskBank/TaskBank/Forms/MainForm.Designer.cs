namespace TaskBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtBufferState = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOpenedTaskCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btntsCreate = new System.Windows.Forms.ToolStripButton();
            this.btntsRename = new System.Windows.Forms.ToolStripButton();
            this.btntsDelete = new System.Windows.Forms.ToolStripButton();
            this.btntsTimeTag = new System.Windows.Forms.ToolStripButton();
            this.btntsTaskTag = new System.Windows.Forms.ToolStripButton();
            this.btntsCreateSession = new System.Windows.Forms.ToolStripButton();
            this.stbtnPutTaskToBuffer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnShowCompleted = new System.Windows.Forms.ToolStripButton();
            this.tsbtnShowBuffer = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSessionCollector = new System.Windows.Forms.ToolStripButton();
            this.stbtnViewEditDescription = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.nodesViewUC1 = new Shared.UI.UserControls.NodesViewUC();
            this.btnSessionState = new System.Windows.Forms.Button();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnShowStatistic = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBufferState
            // 
            this.txtBufferState.AutoSize = true;
            this.txtBufferState.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBufferState.Location = new System.Drawing.Point(79, 40);
            this.txtBufferState.Name = "txtBufferState";
            this.txtBufferState.Size = new System.Drawing.Size(17, 19);
            this.txtBufferState.TabIndex = 22;
            this.txtBufferState.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Буффер";
            // 
            // txtOpenedTaskCount
            // 
            this.txtOpenedTaskCount.AutoSize = true;
            this.txtOpenedTaskCount.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpenedTaskCount.Location = new System.Drawing.Point(184, 40);
            this.txtOpenedTaskCount.Name = "txtOpenedTaskCount";
            this.txtOpenedTaskCount.Size = new System.Drawing.Size(17, 19);
            this.txtOpenedTaskCount.TabIndex = 27;
            this.txtOpenedTaskCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "открыто";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btntsCreate,
            this.btntsRename,
            this.btntsDelete,
            this.btntsCreateSession,
            this.stbtnPutTaskToBuffer,
            this.toolStripSeparator1,
            this.tsbtnShowCompleted,
            this.tsbtnShowBuffer,
            this.tsbtnSessionCollector,
            this.stbtnViewEditDescription,
            this.tsbtnShowStatistic,
            this.toolStripSeparator2,
            this.btntsTimeTag,
            this.btntsTaskTag});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(776, 35);
            this.toolStrip1.TabIndex = 29;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btntsCreate
            // 
            this.btntsCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btntsCreate.Image = ((System.Drawing.Image)(resources.GetObject("btntsCreate.Image")));
            this.btntsCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntsCreate.Name = "btntsCreate";
            this.btntsCreate.Size = new System.Drawing.Size(32, 32);
            this.btntsCreate.Text = "toolStripButton1";
            this.btntsCreate.ToolTipText = "Create (F7)";
            this.btntsCreate.Click += new System.EventHandler(this.btntsCreate_Click);
            // 
            // btntsRename
            // 
            this.btntsRename.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btntsRename.Image = ((System.Drawing.Image)(resources.GetObject("btntsRename.Image")));
            this.btntsRename.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntsRename.Name = "btntsRename";
            this.btntsRename.Size = new System.Drawing.Size(32, 32);
            this.btntsRename.Text = "toolStripButton2";
            this.btntsRename.ToolTipText = "Rename (F2)";
            this.btntsRename.Click += new System.EventHandler(this.btntsRename_Click);
            // 
            // btntsDelete
            // 
            this.btntsDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btntsDelete.Image = ((System.Drawing.Image)(resources.GetObject("btntsDelete.Image")));
            this.btntsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntsDelete.Name = "btntsDelete";
            this.btntsDelete.Size = new System.Drawing.Size(32, 32);
            this.btntsDelete.Text = "Delete (Del)";
            this.btntsDelete.Click += new System.EventHandler(this.btntsDelete_Click);
            // 
            // btntsTimeTag
            // 
            this.btntsTimeTag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btntsTimeTag.Image = ((System.Drawing.Image)(resources.GetObject("btntsTimeTag.Image")));
            this.btntsTimeTag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntsTimeTag.Name = "btntsTimeTag";
            this.btntsTimeTag.Size = new System.Drawing.Size(32, 32);
            this.btntsTimeTag.Text = "toolStripButton1";
            this.btntsTimeTag.ToolTipText = "Time tag";
            this.btntsTimeTag.Click += new System.EventHandler(this.btntsTimeTag_Click);
            // 
            // btntsTaskTag
            // 
            this.btntsTaskTag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btntsTaskTag.Image = ((System.Drawing.Image)(resources.GetObject("btntsTaskTag.Image")));
            this.btntsTaskTag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntsTaskTag.Name = "btntsTaskTag";
            this.btntsTaskTag.Size = new System.Drawing.Size(32, 32);
            this.btntsTaskTag.Text = "toolStripButton1";
            this.btntsTaskTag.ToolTipText = "Task tag";
            this.btntsTaskTag.Click += new System.EventHandler(this.btntsTaskTag_Click);
            // 
            // btntsCreateSession
            // 
            this.btntsCreateSession.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btntsCreateSession.Image = ((System.Drawing.Image)(resources.GetObject("btntsCreateSession.Image")));
            this.btntsCreateSession.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntsCreateSession.Name = "btntsCreateSession";
            this.btntsCreateSession.Size = new System.Drawing.Size(32, 32);
            this.btntsCreateSession.Text = "toolStripButton1";
            this.btntsCreateSession.Click += new System.EventHandler(this.btntsCreateSession_Click);
            // 
            // stbtnPutTaskToBuffer
            // 
            this.stbtnPutTaskToBuffer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stbtnPutTaskToBuffer.Image = ((System.Drawing.Image)(resources.GetObject("stbtnPutTaskToBuffer.Image")));
            this.stbtnPutTaskToBuffer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbtnPutTaskToBuffer.Name = "stbtnPutTaskToBuffer";
            this.stbtnPutTaskToBuffer.Size = new System.Drawing.Size(32, 32);
            this.stbtnPutTaskToBuffer.Text = "Put to buffer";
            this.stbtnPutTaskToBuffer.Click += new System.EventHandler(this.stbtnPutTaskToBuffer_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // tsbtnShowCompleted
            // 
            this.tsbtnShowCompleted.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnShowCompleted.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShowCompleted.Image")));
            this.tsbtnShowCompleted.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShowCompleted.Name = "tsbtnShowCompleted";
            this.tsbtnShowCompleted.Size = new System.Drawing.Size(32, 32);
            this.tsbtnShowCompleted.Text = "View completed items";
            this.tsbtnShowCompleted.Click += new System.EventHandler(this.tsbtnShowCompleted_Click);
            // 
            // tsbtnShowBuffer
            // 
            this.tsbtnShowBuffer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnShowBuffer.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShowBuffer.Image")));
            this.tsbtnShowBuffer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShowBuffer.Name = "tsbtnShowBuffer";
            this.tsbtnShowBuffer.Size = new System.Drawing.Size(32, 32);
            this.tsbtnShowBuffer.Text = "Show buffer";
            this.tsbtnShowBuffer.Click += new System.EventHandler(this.tsbtnShowBuffer_Click);
            // 
            // tsbtnSessionCollector
            // 
            this.tsbtnSessionCollector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSessionCollector.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSessionCollector.Image")));
            this.tsbtnSessionCollector.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSessionCollector.Name = "tsbtnSessionCollector";
            this.tsbtnSessionCollector.Size = new System.Drawing.Size(32, 32);
            this.tsbtnSessionCollector.Text = "Session collector";
            this.tsbtnSessionCollector.Click += new System.EventHandler(this.tsbtnSessionCollector_Click);
            // 
            // stbtnViewEditDescription
            // 
            this.stbtnViewEditDescription.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stbtnViewEditDescription.Image = ((System.Drawing.Image)(resources.GetObject("stbtnViewEditDescription.Image")));
            this.stbtnViewEditDescription.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stbtnViewEditDescription.Name = "stbtnViewEditDescription";
            this.stbtnViewEditDescription.Size = new System.Drawing.Size(32, 32);
            this.stbtnViewEditDescription.Text = "Quick view and edit";
            this.stbtnViewEditDescription.Click += new System.EventHandler(this.stbtnViewEditDescription_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Сессия";
            // 
            // nodesViewUC1
            // 
            this.nodesViewUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nodesViewUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
            this.nodesViewUC1.Location = new System.Drawing.Point(0, 62);
            this.nodesViewUC1.Name = "nodesViewUC1";
            this.nodesViewUC1.Size = new System.Drawing.Size(775, 397);
            this.nodesViewUC1.TabIndex = 0;
            // 
            // btnSessionState
            // 
            this.btnSessionState.BackgroundImage = global::TaskBank.Properties.Resources.nosession;
            this.btnSessionState.FlatAppearance.BorderSize = 0;
            this.btnSessionState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSessionState.Location = new System.Drawing.Point(296, 38);
            this.btnSessionState.Name = "btnSessionState";
            this.btnSessionState.Size = new System.Drawing.Size(24, 24);
            this.btnSessionState.TabIndex = 31;
            this.btnSessionState.UseVisualStyleBackColor = true;
            this.btnSessionState.Click += new System.EventHandler(this.btnSessionState_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // tsbtnShowStatistic
            // 
            this.tsbtnShowStatistic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnShowStatistic.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnShowStatistic.Image")));
            this.tsbtnShowStatistic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShowStatistic.Name = "tsbtnShowStatistic";
            this.tsbtnShowStatistic.Size = new System.Drawing.Size(32, 32);
            this.tsbtnShowStatistic.Text = "Statistic";
            this.tsbtnShowStatistic.Click += new System.EventHandler(this.tsbtnShowStatistic_Click);
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(776, 459);
            this.Controls.Add(this.btnSessionState);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtOpenedTaskCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBufferState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nodesViewUC1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Shared.UI.UserControls.NodesViewUC nodesViewUC1;
		private System.Windows.Forms.Label txtBufferState;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label txtOpenedTaskCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btntsCreate;
		private System.Windows.Forms.ToolStripButton btntsRename;
		private System.Windows.Forms.ToolStripButton btntsDelete;
		private System.Windows.Forms.ToolStripButton btntsTimeTag;
		private System.Windows.Forms.ToolStripButton btntsTaskTag;
		private System.Windows.Forms.ToolStripButton btntsCreateSession;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnShowCompleted;
        private System.Windows.Forms.ToolStripButton tsbtnShowBuffer;
        private System.Windows.Forms.ToolStripButton tsbtnSessionCollector;
        private System.Windows.Forms.ToolStripButton stbtnViewEditDescription;
        private System.Windows.Forms.ToolStripButton stbtnPutTaskToBuffer;
        private System.Windows.Forms.Button btnSessionState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnShowStatistic;
    }
}

