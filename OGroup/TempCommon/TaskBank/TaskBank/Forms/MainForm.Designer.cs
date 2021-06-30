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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.directoriesViewUC1 = new UIComponents.UserControls.DirectoriesViewUC();
			this.directoryFilesViewUC1 = new UIComponents.UserControls.DirectoryFilesViewUC();
			this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dirBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.dirBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dirBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dirBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Location = new System.Drawing.Point(1, 28);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.directoriesViewUC1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.directoryFilesViewUC1);
			this.splitContainer1.Size = new System.Drawing.Size(1667, 661);
			this.splitContainer1.SplitterDistance = 637;
			this.splitContainer1.TabIndex = 15;
			// 
			// directoriesViewUC1
			// 
			this.directoriesViewUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.directoriesViewUC1.Location = new System.Drawing.Point(0, 3);
			this.directoriesViewUC1.Name = "directoriesViewUC1";
			this.directoriesViewUC1.Size = new System.Drawing.Size(632, 653);
			this.directoriesViewUC1.TabIndex = 0;
			// 
			// directoryFilesViewUC1
			// 
			this.directoryFilesViewUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.directoryFilesViewUC1.Location = new System.Drawing.Point(3, 3);
			this.directoryFilesViewUC1.Name = "directoryFilesViewUC1";
			this.directoryFilesViewUC1.Size = new System.Drawing.Size(1018, 653);
			this.directoryFilesViewUC1.TabIndex = 0;
			// 
			// noteBindingSource
			// 
			this.noteBindingSource.DataSource = typeof(Domain.Entities.Note);
			// 
			// dirBindingSource1
			// 
			this.dirBindingSource1.DataSource = typeof(Domain.Entities.Dir);
			// 
			// dirBindingSource
			// 
			this.dirBindingSource.DataSource = typeof(Domain.Entities.Dir);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(1670, 691);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Task bank";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dirBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dirBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.BindingSource dirBindingSource;
		private System.Windows.Forms.BindingSource noteBindingSource;
		private System.Windows.Forms.BindingSource dirBindingSource1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private UIComponents.UserControls.DirectoriesViewUC directoriesViewUC1;
		private UIComponents.UserControls.DirectoryFilesViewUC directoryFilesViewUC1;
	}
}

