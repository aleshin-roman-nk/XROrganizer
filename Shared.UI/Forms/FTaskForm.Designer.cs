
namespace Shared.UI.Forms
{
	partial class FTaskForm
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
			this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
			this.lblDate = new System.Windows.Forms.Label();
			this.btnComlete = new System.Windows.Forms.Button();
			this.button1save = new System.Windows.Forms.Button();
			this.lblFullPath = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1Name = new System.Windows.Forms.TextBox();
			this.btnUpdateTaskName = new System.Windows.Forms.Button();
			this.btnAllSessions = new System.Windows.Forms.Button();
			this.btnCreateSession = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBoxDescription
			// 
			this.richTextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.richTextBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(164)))), ((int)(((byte)(14)))));
			this.richTextBoxDescription.Location = new System.Drawing.Point(4, 4);
			this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(4);
			this.richTextBoxDescription.Name = "richTextBoxDescription";
			this.richTextBoxDescription.Size = new System.Drawing.Size(797, 446);
			this.richTextBoxDescription.TabIndex = 0;
			this.richTextBoxDescription.Text = "";
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Location = new System.Drawing.Point(16, 13);
			this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(17, 19);
			this.lblDate.TabIndex = 1;
			this.lblDate.Text = "0";
			// 
			// btnComlete
			// 
			this.btnComlete.BackgroundImage = global::Shared.UI.Properties.Resources.icons8_task_planning_48;
			this.btnComlete.FlatAppearance.BorderSize = 0;
			this.btnComlete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnComlete.Location = new System.Drawing.Point(745, 59);
			this.btnComlete.Name = "btnComlete";
			this.btnComlete.Size = new System.Drawing.Size(48, 48);
			this.btnComlete.TabIndex = 2;
			this.btnComlete.UseVisualStyleBackColor = true;
			this.btnComlete.Click += new System.EventHandler(this.btnComlete_Click);
			// 
			// button1save
			// 
			this.button1save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.button1save.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.button1save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1save.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.button1save.Location = new System.Drawing.Point(748, 12);
			this.button1save.Name = "button1save";
			this.button1save.Size = new System.Drawing.Size(45, 41);
			this.button1save.TabIndex = 3;
			this.button1save.Text = "S";
			this.button1save.UseVisualStyleBackColor = false;
			this.button1save.Click += new System.EventHandler(this.button1save_Click);
			// 
			// lblFullPath
			// 
			this.lblFullPath.AutoSize = true;
			this.lblFullPath.Location = new System.Drawing.Point(16, 34);
			this.lblFullPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFullPath.Name = "lblFullPath";
			this.lblFullPath.Size = new System.Drawing.Size(17, 19);
			this.lblFullPath.TabIndex = 4;
			this.lblFullPath.Tag = "node_full_path";
			this.lblFullPath.Text = "0";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 75);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 19);
			this.label1.TabIndex = 5;
			this.label1.Text = "Name";
			// 
			// textBox1Name
			// 
			this.textBox1Name.Location = new System.Drawing.Point(70, 72);
			this.textBox1Name.Name = "textBox1Name";
			this.textBox1Name.Size = new System.Drawing.Size(367, 27);
			this.textBox1Name.TabIndex = 6;
			// 
			// btnUpdateTaskName
			// 
			this.btnUpdateTaskName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdateTaskName.Location = new System.Drawing.Point(443, 72);
			this.btnUpdateTaskName.Name = "btnUpdateTaskName";
			this.btnUpdateTaskName.Size = new System.Drawing.Size(45, 27);
			this.btnUpdateTaskName.TabIndex = 7;
			this.btnUpdateTaskName.Text = "upd";
			this.btnUpdateTaskName.UseVisualStyleBackColor = true;
			this.btnUpdateTaskName.Click += new System.EventHandler(this.btnUpdateTaskName_Click);
			// 
			// btnAllSessions
			// 
			this.btnAllSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAllSessions.Location = new System.Drawing.Point(620, 13);
			this.btnAllSessions.Name = "btnAllSessions";
			this.btnAllSessions.Size = new System.Drawing.Size(119, 38);
			this.btnAllSessions.TabIndex = 8;
			this.btnAllSessions.Text = "all sessions";
			this.btnAllSessions.UseVisualStyleBackColor = true;
			// 
			// btnCreateSession
			// 
			this.btnCreateSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreateSession.Location = new System.Drawing.Point(620, 61);
			this.btnCreateSession.Name = "btnCreateSession";
			this.btnCreateSession.Size = new System.Drawing.Size(119, 38);
			this.btnCreateSession.TabIndex = 9;
			this.btnCreateSession.Text = "create session";
			this.btnCreateSession.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.richTextBoxDescription);
			this.panel1.Location = new System.Drawing.Point(3, 112);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(807, 456);
			this.panel1.TabIndex = 10;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// FTaskForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.ClientSize = new System.Drawing.Size(811, 572);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btnCreateSession);
			this.Controls.Add(this.btnAllSessions);
			this.Controls.Add(this.btnUpdateTaskName);
			this.Controls.Add(this.textBox1Name);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblFullPath);
			this.Controls.Add(this.button1save);
			this.Controls.Add(this.btnComlete);
			this.Controls.Add(this.lblDate);
			this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FTaskForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FTaskForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FTaskForm_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FTaskForm_FormClosed);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBoxDescription;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Button btnComlete;
		private System.Windows.Forms.Button button1save;
		private System.Windows.Forms.Label lblFullPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1Name;
		private System.Windows.Forms.Button btnUpdateTaskName;
		private System.Windows.Forms.Button btnAllSessions;
		private System.Windows.Forms.Button btnCreateSession;
		private System.Windows.Forms.Panel panel1;
	}
}