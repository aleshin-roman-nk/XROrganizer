﻿namespace TagGenerator
{
	partial class Form1
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
			this.btnStartTag = new System.Windows.Forms.Button();
			this.btnStopTag = new System.Windows.Forms.Button();
			this.btnMarkerTag = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnStartTag
			// 
			this.btnStartTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStartTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStartTag.Location = new System.Drawing.Point(12, 12);
			this.btnStartTag.Name = "btnStartTag";
			this.btnStartTag.Size = new System.Drawing.Size(191, 52);
			this.btnStartTag.TabIndex = 0;
			this.btnStartTag.Text = "Старт";
			this.btnStartTag.UseVisualStyleBackColor = true;
			this.btnStartTag.Click += new System.EventHandler(this.btnStartTag_Click);
			// 
			// btnStopTag
			// 
			this.btnStopTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStopTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStopTag.Location = new System.Drawing.Point(12, 70);
			this.btnStopTag.Name = "btnStopTag";
			this.btnStopTag.Size = new System.Drawing.Size(191, 52);
			this.btnStopTag.TabIndex = 1;
			this.btnStopTag.Text = "Стоп";
			this.btnStopTag.UseVisualStyleBackColor = true;
			this.btnStopTag.Click += new System.EventHandler(this.btnStopTag_Click);
			// 
			// btnMarkerTag
			// 
			this.btnMarkerTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMarkerTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnMarkerTag.Location = new System.Drawing.Point(12, 128);
			this.btnMarkerTag.Name = "btnMarkerTag";
			this.btnMarkerTag.Size = new System.Drawing.Size(191, 52);
			this.btnMarkerTag.TabIndex = 2;
			this.btnMarkerTag.Text = "ТекстМаркер";
			this.btnMarkerTag.UseVisualStyleBackColor = true;
			this.btnMarkerTag.Click += new System.EventHandler(this.btnMarkerTag_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Aquamarine;
			this.ClientSize = new System.Drawing.Size(219, 190);
			this.Controls.Add(this.btnMarkerTag);
			this.Controls.Add(this.btnStopTag);
			this.Controls.Add(this.btnStartTag);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.TopMost = true;
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnStartTag;
		private System.Windows.Forms.Button btnStopTag;
		private System.Windows.Forms.Button btnMarkerTag;
	}
}

