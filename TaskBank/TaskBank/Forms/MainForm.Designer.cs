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
			this.btnShowDescr = new System.Windows.Forms.Button();
			this.txtBufferState = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnHideCompleted = new System.Windows.Forms.Button();
			this.btnShowCurentBuffer = new System.Windows.Forms.Button();
			this.txtOpenedTaskCount = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnStartSessionCollector = new System.Windows.Forms.Button();
			this.nodesViewUC1 = new Shared.UI.UserControls.NodesViewUC();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btntsCreate = new System.Windows.Forms.ToolStripButton();
			this.btntsRename = new System.Windows.Forms.ToolStripButton();
			this.btntsDelete = new System.Windows.Forms.ToolStripButton();
			this.btntsTimeTag = new System.Windows.Forms.ToolStripButton();
			this.btntsTaskTag = new System.Windows.Forms.ToolStripButton();
			this.btntsCreateSession = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnShowDescr
			// 
			this.btnShowDescr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnShowDescr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShowDescr.Location = new System.Drawing.Point(405, 40);
			this.btnShowDescr.Name = "btnShowDescr";
			this.btnShowDescr.Size = new System.Drawing.Size(52, 23);
			this.btnShowDescr.TabIndex = 1;
			this.btnShowDescr.Text = "Dscr";
			this.btnShowDescr.UseVisualStyleBackColor = true;
			this.btnShowDescr.Click += new System.EventHandler(this.btnShowDescr_Click);
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
			// btnHideCompleted
			// 
			this.btnHideCompleted.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHideCompleted.Location = new System.Drawing.Point(292, 38);
			this.btnHideCompleted.Name = "btnHideCompleted";
			this.btnHideCompleted.Size = new System.Drawing.Size(25, 25);
			this.btnHideCompleted.TabIndex = 24;
			this.btnHideCompleted.Text = "H";
			this.btnHideCompleted.UseVisualStyleBackColor = true;
			this.btnHideCompleted.Click += new System.EventHandler(this.btnHideCompleted_Click);
			// 
			// btnShowCurentBuffer
			// 
			this.btnShowCurentBuffer.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowCurentBuffer.Location = new System.Drawing.Point(323, 38);
			this.btnShowCurentBuffer.Name = "btnShowCurentBuffer";
			this.btnShowCurentBuffer.Size = new System.Drawing.Size(25, 25);
			this.btnShowCurentBuffer.TabIndex = 25;
			this.btnShowCurentBuffer.Text = "B";
			this.btnShowCurentBuffer.UseVisualStyleBackColor = true;
			this.btnShowCurentBuffer.Click += new System.EventHandler(this.btnShowCurentBuffer_Click);
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
			// btnStartSessionCollector
			// 
			this.btnStartSessionCollector.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartSessionCollector.Location = new System.Drawing.Point(354, 38);
			this.btnStartSessionCollector.Name = "btnStartSessionCollector";
			this.btnStartSessionCollector.Size = new System.Drawing.Size(33, 25);
			this.btnStartSessionCollector.TabIndex = 28;
			this.btnStartSessionCollector.Text = "Sc";
			this.btnStartSessionCollector.UseVisualStyleBackColor = true;
			this.btnStartSessionCollector.Click += new System.EventHandler(this.btnStartSessionCollector_Click);
			// 
			// nodesViewUC1
			// 
			this.nodesViewUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nodesViewUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
			this.nodesViewUC1.Location = new System.Drawing.Point(0, 128);
			this.nodesViewUC1.Name = "nodesViewUC1";
			this.nodesViewUC1.Size = new System.Drawing.Size(775, 579);
			this.nodesViewUC1.TabIndex = 0;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btntsCreate,
            this.btntsRename,
            this.btntsDelete,
            this.btntsTimeTag,
            this.btntsTaskTag,
            this.btntsCreateSession});
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
			// MainForm
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(776, 707);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.btnStartSessionCollector);
			this.Controls.Add(this.txtOpenedTaskCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnShowCurentBuffer);
			this.Controls.Add(this.btnHideCompleted);
			this.Controls.Add(this.txtBufferState);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnShowDescr);
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
		private System.Windows.Forms.Button btnShowDescr;
		private System.Windows.Forms.Label txtBufferState;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnHideCompleted;
		private System.Windows.Forms.Button btnShowCurentBuffer;
		private System.Windows.Forms.Label txtOpenedTaskCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnStartSessionCollector;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btntsCreate;
		private System.Windows.Forms.ToolStripButton btntsRename;
		private System.Windows.Forms.ToolStripButton btntsDelete;
		private System.Windows.Forms.ToolStripButton btntsTimeTag;
		private System.Windows.Forms.ToolStripButton btntsTaskTag;
		private System.Windows.Forms.ToolStripButton btntsCreateSession;
	}
}

