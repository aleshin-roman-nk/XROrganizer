
namespace TimeTickerCounter
{
	partial class StopwatchForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopwatchForm));
			this.btnPlay = new System.Windows.Forms.Button();
			this.btnPause = new System.Windows.Forms.Button();
			this.lblOut = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnClipboard = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnPlay
			// 
			this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
			this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnPlay.FlatAppearance.BorderSize = 0;
			this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPlay.Location = new System.Drawing.Point(12, 82);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(64, 64);
			this.btnPlay.TabIndex = 0;
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// btnPause
			// 
			this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
			this.btnPause.FlatAppearance.BorderSize = 0;
			this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPause.Location = new System.Drawing.Point(82, 82);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(64, 64);
			this.btnPause.TabIndex = 1;
			this.btnPause.UseVisualStyleBackColor = true;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// lblOut
			// 
			this.lblOut.AutoSize = true;
			this.lblOut.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblOut.Location = new System.Drawing.Point(12, 9);
			this.lblOut.Name = "lblOut";
			this.lblOut.Size = new System.Drawing.Size(125, 33);
			this.lblOut.TabIndex = 2;
			this.lblOut.Text = "00:00:00";
			// 
			// btnReset
			// 
			this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
			this.btnReset.FlatAppearance.BorderSize = 0;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.Location = new System.Drawing.Point(152, 82);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(64, 64);
			this.btnReset.TabIndex = 3;
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnClipboard
			// 
			this.btnClipboard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClipboard.BackgroundImage")));
			this.btnClipboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnClipboard.FlatAppearance.BorderSize = 0;
			this.btnClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClipboard.Location = new System.Drawing.Point(143, 14);
			this.btnClipboard.Name = "btnClipboard";
			this.btnClipboard.Size = new System.Drawing.Size(29, 28);
			this.btnClipboard.TabIndex = 4;
			this.btnClipboard.UseVisualStyleBackColor = true;
			this.btnClipboard.Click += new System.EventHandler(this.btnClipboard_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(15, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(20, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = ">";
			// 
			// StopwatchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(241, 160);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnClipboard);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.lblOut);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.btnPlay);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "StopwatchForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Stopwatch";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnPause;
		private System.Windows.Forms.Label lblOut;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnClipboard;
		private System.Windows.Forms.Label label1;
	}
}

