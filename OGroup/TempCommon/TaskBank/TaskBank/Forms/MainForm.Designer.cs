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
			this.btnShowDescr = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnRename = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnTimeTag = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.txtBufferState = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnHideCompleted = new System.Windows.Forms.Button();
			this.btnShowCurentBuffer = new System.Windows.Forms.Button();
			this.txtOpenedTaskCount = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.nodesViewUC1 = new Shared.UI.UserControls.NodesViewUC();
			this.btnStartSessionCollector = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnShowDescr
			// 
			this.btnShowDescr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnShowDescr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShowDescr.Location = new System.Drawing.Point(723, 1);
			this.btnShowDescr.Name = "btnShowDescr";
			this.btnShowDescr.Size = new System.Drawing.Size(52, 23);
			this.btnShowDescr.TabIndex = 1;
			this.btnShowDescr.Text = "Dscr";
			this.btnShowDescr.UseVisualStyleBackColor = true;
			this.btnShowDescr.Click += new System.EventHandler(this.btnShowDescr_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreate.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreate.Location = new System.Drawing.Point(12, 12);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(68, 36);
			this.btnCreate.TabIndex = 15;
			this.btnCreate.Text = "create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnRename
			// 
			this.btnRename.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRename.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRename.Location = new System.Drawing.Point(86, 12);
			this.btnRename.Name = "btnRename";
			this.btnRename.Size = new System.Drawing.Size(68, 36);
			this.btnRename.TabIndex = 16;
			this.btnRename.Text = "rename";
			this.btnRename.UseVisualStyleBackColor = true;
			this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(160, 12);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(68, 36);
			this.btnDelete.TabIndex = 17;
			this.btnDelete.Text = "delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnTimeTag
			// 
			this.btnTimeTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.btnTimeTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTimeTag.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTimeTag.Location = new System.Drawing.Point(271, 12);
			this.btnTimeTag.Name = "btnTimeTag";
			this.btnTimeTag.Size = new System.Drawing.Size(84, 36);
			this.btnTimeTag.TabIndex = 18;
			this.btnTimeTag.Text = "time_tag";
			this.btnTimeTag.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(361, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(51, 36);
			this.button1.TabIndex = 19;
			this.button1.Text = "tag";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// txtBufferState
			// 
			this.txtBufferState.AutoSize = true;
			this.txtBufferState.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBufferState.Location = new System.Drawing.Point(495, 12);
			this.txtBufferState.Name = "txtBufferState";
			this.txtBufferState.Size = new System.Drawing.Size(17, 19);
			this.txtBufferState.TabIndex = 22;
			this.txtBufferState.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(428, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 19);
			this.label2.TabIndex = 21;
			this.label2.Text = "Буффер";
			// 
			// btnHideCompleted
			// 
			this.btnHideCompleted.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHideCompleted.Location = new System.Drawing.Point(577, 12);
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
			this.btnShowCurentBuffer.Location = new System.Drawing.Point(608, 12);
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
			this.txtOpenedTaskCount.Location = new System.Drawing.Point(495, 32);
			this.txtOpenedTaskCount.Name = "txtOpenedTaskCount";
			this.txtOpenedTaskCount.Size = new System.Drawing.Size(17, 19);
			this.txtOpenedTaskCount.TabIndex = 27;
			this.txtOpenedTaskCount.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(428, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 19);
			this.label3.TabIndex = 26;
			this.label3.Text = "открыто";
			// 
			// nodesViewUC1
			// 
			this.nodesViewUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nodesViewUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
			this.nodesViewUC1.Location = new System.Drawing.Point(0, 54);
			this.nodesViewUC1.Name = "nodesViewUC1";
			this.nodesViewUC1.Size = new System.Drawing.Size(775, 517);
			this.nodesViewUC1.TabIndex = 0;
			// 
			// btnStartSessionCollector
			// 
			this.btnStartSessionCollector.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStartSessionCollector.Location = new System.Drawing.Point(639, 12);
			this.btnStartSessionCollector.Name = "btnStartSessionCollector";
			this.btnStartSessionCollector.Size = new System.Drawing.Size(33, 25);
			this.btnStartSessionCollector.TabIndex = 28;
			this.btnStartSessionCollector.Text = "Sc";
			this.btnStartSessionCollector.UseVisualStyleBackColor = true;
			this.btnStartSessionCollector.Click += new System.EventHandler(this.btnStartSessionCollector_Click);
			// 
			// MainForm
			// 
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(776, 571);
			this.Controls.Add(this.btnStartSessionCollector);
			this.Controls.Add(this.txtOpenedTaskCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnShowCurentBuffer);
			this.Controls.Add(this.btnHideCompleted);
			this.Controls.Add(this.txtBufferState);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnTimeTag);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnRename);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.btnShowDescr);
			this.Controls.Add(this.nodesViewUC1);
			this.DoubleBuffered = true;
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Shared.UI.UserControls.NodesViewUC nodesViewUC1;
		private System.Windows.Forms.Button btnShowDescr;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnRename;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnTimeTag;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label txtBufferState;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnHideCompleted;
		private System.Windows.Forms.Button btnShowCurentBuffer;
		private System.Windows.Forms.Label txtOpenedTaskCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnStartSessionCollector;
	}
}

