
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTaskForm));
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSaved = new System.Windows.Forms.Label();
            this.checkBox1Pinned = new System.Windows.Forms.CheckBox();
            this.btnCreateSession = new System.Windows.Forms.Button();
            this.btnAllSessions = new System.Windows.Forms.Button();
            this.button1save = new System.Windows.Forms.Button();
            this.btnComlete = new System.Windows.Forms.Button();
            this.btnTimeTag = new System.Windows.Forms.Button();
            this.txtFullPath = new System.Windows.Forms.TextBox();
            this.nodeTextPagesUC1 = new Shared.UI.UserControls.NodeTextPagesUC();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(269, 13);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(17, 19);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nodeTextPagesUC1);
            this.panel1.Location = new System.Drawing.Point(3, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 494);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblSaved
            // 
            this.lblSaved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaved.AutoSize = true;
            this.lblSaved.Location = new System.Drawing.Point(737, 13);
            this.lblSaved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(17, 19);
            this.lblSaved.TabIndex = 12;
            this.lblSaved.Text = "0";
            // 
            // checkBox1Pinned
            // 
            this.checkBox1Pinned.AutoSize = true;
            this.checkBox1Pinned.Location = new System.Drawing.Point(179, 12);
            this.checkBox1Pinned.Name = "checkBox1Pinned";
            this.checkBox1Pinned.Size = new System.Drawing.Size(72, 23);
            this.checkBox1Pinned.TabIndex = 13;
            this.checkBox1Pinned.Text = "pinned";
            this.checkBox1Pinned.UseVisualStyleBackColor = true;
            // 
            // btnCreateSession
            // 
            this.btnCreateSession.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateSession.BackgroundImage")));
            this.btnCreateSession.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreateSession.FlatAppearance.BorderSize = 0;
            this.btnCreateSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateSession.Location = new System.Drawing.Point(8, 5);
            this.btnCreateSession.Name = "btnCreateSession";
            this.btnCreateSession.Size = new System.Drawing.Size(34, 34);
            this.btnCreateSession.TabIndex = 9;
            this.btnCreateSession.Text = "create session";
            this.btnCreateSession.UseVisualStyleBackColor = true;
            this.btnCreateSession.Click += new System.EventHandler(this.btnCreateSession_Click);
            // 
            // btnAllSessions
            // 
            this.btnAllSessions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAllSessions.BackgroundImage")));
            this.btnAllSessions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAllSessions.FlatAppearance.BorderSize = 0;
            this.btnAllSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllSessions.Location = new System.Drawing.Point(48, 5);
            this.btnAllSessions.Name = "btnAllSessions";
            this.btnAllSessions.Size = new System.Drawing.Size(34, 34);
            this.btnAllSessions.TabIndex = 8;
            this.btnAllSessions.UseVisualStyleBackColor = true;
            this.btnAllSessions.Click += new System.EventHandler(this.btnAllSessions_Click);
            // 
            // button1save
            // 
            this.button1save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1save.BackgroundImage")));
            this.button1save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1save.FlatAppearance.BorderSize = 0;
            this.button1save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1save.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1save.Location = new System.Drawing.Point(771, 5);
            this.button1save.Name = "button1save";
            this.button1save.Size = new System.Drawing.Size(34, 34);
            this.button1save.TabIndex = 3;
            this.button1save.UseVisualStyleBackColor = false;
            this.button1save.Click += new System.EventHandler(this.button1save_Click);
            // 
            // btnComlete
            // 
            this.btnComlete.BackgroundImage = global::Shared.UI.Properties.Resources.icons8_task_planning_48;
            this.btnComlete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComlete.FlatAppearance.BorderSize = 0;
            this.btnComlete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComlete.Location = new System.Drawing.Point(88, 5);
            this.btnComlete.Name = "btnComlete";
            this.btnComlete.Size = new System.Drawing.Size(34, 34);
            this.btnComlete.TabIndex = 2;
            this.btnComlete.UseVisualStyleBackColor = true;
            this.btnComlete.Click += new System.EventHandler(this.btnComlete_Click);
            // 
            // btnTimeTag
            // 
            this.btnTimeTag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(164)))));
            this.btnTimeTag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimeTag.BackgroundImage")));
            this.btnTimeTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTimeTag.FlatAppearance.BorderSize = 0;
            this.btnTimeTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeTag.Location = new System.Drawing.Point(128, 5);
            this.btnTimeTag.Name = "btnTimeTag";
            this.btnTimeTag.Size = new System.Drawing.Size(34, 34);
            this.btnTimeTag.TabIndex = 15;
            this.btnTimeTag.UseVisualStyleBackColor = false;
            this.btnTimeTag.Click += new System.EventHandler(this.btnTimeTag_Click);
            // 
            // txtFullPath
            // 
            this.txtFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.txtFullPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullPath.Font = new System.Drawing.Font("Roboto Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullPath.ForeColor = System.Drawing.Color.White;
            this.txtFullPath.Location = new System.Drawing.Point(8, 45);
            this.txtFullPath.Name = "txtFullPath";
            this.txtFullPath.ReadOnly = true;
            this.txtFullPath.Size = new System.Drawing.Size(802, 23);
            this.txtFullPath.TabIndex = 14;
            this.txtFullPath.Tag = "node_full_path";
            // 
            // nodeTextPagesUC1
            // 
            this.nodeTextPagesUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nodeTextPagesUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.nodeTextPagesUC1.Location = new System.Drawing.Point(4, 4);
            this.nodeTextPagesUC1.Margin = new System.Windows.Forms.Padding(4);
            this.nodeTextPagesUC1.Name = "nodeTextPagesUC1";
            this.nodeTextPagesUC1.SelectedText = "";
            this.nodeTextPagesUC1.Size = new System.Drawing.Size(797, 484);
            this.nodeTextPagesUC1.TabIndex = 1;
            this.nodeTextPagesUC1.ObjectChanged += new System.EventHandler(this.nodeTextPagesUC1_ObjectChanged);
            this.nodeTextPagesUC1.AddPageRequired += new System.EventHandler(this.nodeTextPagesUC1_AddPageRequired);
            this.nodeTextPagesUC1.RemovePageRequired += new System.EventHandler<Domain.Entities.NodeTextPage>(this.nodeTextPagesUC1_RemovePageRequired);
            this.nodeTextPagesUC1.OpenNodeById += new System.EventHandler<string>(this.nodeTextPagesUC1_OpenNodeById);
            // 
            // FTaskForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(811, 572);
            this.Controls.Add(this.btnTimeTag);
            this.Controls.Add(this.txtFullPath);
            this.Controls.Add(this.checkBox1Pinned);
            this.Controls.Add(this.lblSaved);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCreateSession);
            this.Controls.Add(this.btnAllSessions);
            this.Controls.Add(this.button1save);
            this.Controls.Add(this.btnComlete);
            this.Controls.Add(this.lblDate);
            this.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FTaskForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FTaskForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FTaskForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FTaskForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Button btnComlete;
		private System.Windows.Forms.Button button1save;
		private System.Windows.Forms.Button btnAllSessions;
		private System.Windows.Forms.Button btnCreateSession;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblSaved;
        private System.Windows.Forms.CheckBox checkBox1Pinned;
        private System.Windows.Forms.Button btnTimeTag;
        private System.Windows.Forms.TextBox txtFullPath;
        private UserControls.NodeTextPagesUC nodeTextPagesUC1;
    }
}