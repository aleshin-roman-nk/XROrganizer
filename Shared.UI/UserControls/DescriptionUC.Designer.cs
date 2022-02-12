
namespace Shared.UI.UserControls
{
	partial class DescriptionUC
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.lblSaved = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxNodeDescription = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSaved
            // 
            this.lblSaved.AutoSize = true;
            this.lblSaved.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaved.ForeColor = System.Drawing.Color.White;
            this.lblSaved.Location = new System.Drawing.Point(55, 6);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(17, 19);
            this.lblSaved.TabIndex = 19;
            this.lblSaved.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "saved:";
            // 
            // rtxNodeDescription
            // 
            this.rtxNodeDescription.AcceptsTab = true;
            this.rtxNodeDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(32)))));
            this.rtxNodeDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxNodeDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxNodeDescription.EnableAutoDragDrop = true;
            this.rtxNodeDescription.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtxNodeDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(164)))), ((int)(((byte)(14)))));
            this.rtxNodeDescription.Location = new System.Drawing.Point(0, 0);
            this.rtxNodeDescription.Name = "rtxNodeDescription";
            this.rtxNodeDescription.Size = new System.Drawing.Size(374, 552);
            this.rtxNodeDescription.TabIndex = 20;
            this.rtxNodeDescription.Text = "Hello world";
            this.rtxNodeDescription.TextChanged += new System.EventHandler(this.rtxNodeDescription_TextChanged);
            this.rtxNodeDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxNodeDescription_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rtxNodeDescription);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 554);
            this.panel1.TabIndex = 21;
            // 
            // DescriptionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(90)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSaved);
            this.Controls.Add(this.label1);
            this.Name = "DescriptionUC";
            this.Size = new System.Drawing.Size(376, 581);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSaved;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox rtxNodeDescription;
		private System.Windows.Forms.Panel panel1;
	}
}
