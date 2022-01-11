
namespace TaskBank.Forms
{
	partial class DescriptionForm
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
			this.descriptionUC1 = new Shared.UI.UserControls.DescriptionUC();
			this.lblPath = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// descriptionUC1
			// 
			this.descriptionUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(32)))));
			this.descriptionUC1.Location = new System.Drawing.Point(3, 31);
			this.descriptionUC1.Name = "descriptionUC1";
			this.descriptionUC1.Size = new System.Drawing.Size(450, 589);
			this.descriptionUC1.TabIndex = 0;
			// 
			// lblPath
			// 
			this.lblPath.AutoSize = true;
			this.lblPath.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPath.ForeColor = System.Drawing.Color.White;
			this.lblPath.Location = new System.Drawing.Point(7, 9);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(17, 19);
			this.lblPath.TabIndex = 1;
			this.lblPath.Text = "0";
			// 
			// DescriptionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(465, 632);
			this.Controls.Add(this.lblPath);
			this.Controls.Add(this.descriptionUC1);
			this.Name = "DescriptionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "DescriptionForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DescriptionForm_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Shared.UI.UserControls.DescriptionUC descriptionUC1;
		private System.Windows.Forms.Label lblPath;
	}
}