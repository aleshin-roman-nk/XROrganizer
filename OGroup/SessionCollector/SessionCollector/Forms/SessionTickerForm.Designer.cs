
namespace SessionCollector.Forms
{
	partial class SessionTickerForm
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblTitle = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCloseAndForget = new System.Windows.Forms.Button();
			this.lblAnimation = new System.Windows.Forms.Label();
			this.btnPause = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			this.lblTime = new System.Windows.Forms.Label();
			this.btnStopAndSave = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
			this.panel1.Controls.Add(this.lblTitle);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(359, 45);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.lblTitle.Location = new System.Drawing.Point(3, 5);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(27, 25);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "...";
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Right;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(310, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(49, 45);
			this.button1.TabIndex = 0;
			this.button1.Text = "_";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(99)))), ((int)(((byte)(130)))));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.btnCloseAndForget);
			this.panel2.Controls.Add(this.lblAnimation);
			this.panel2.Controls.Add(this.btnPause);
			this.panel2.Controls.Add(this.btnPlay);
			this.panel2.Controls.Add(this.lblTime);
			this.panel2.Controls.Add(this.btnStopAndSave);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(361, 225);
			this.panel2.TabIndex = 1;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
			this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			// 
			// btnCloseAndForget
			// 
			this.btnCloseAndForget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(47)))), ((int)(((byte)(6)))));
			this.btnCloseAndForget.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(185)))), ((int)(((byte)(59)))));
			this.btnCloseAndForget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCloseAndForget.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCloseAndForget.Location = new System.Drawing.Point(293, 96);
			this.btnCloseAndForget.Name = "btnCloseAndForget";
			this.btnCloseAndForget.Size = new System.Drawing.Size(55, 57);
			this.btnCloseAndForget.TabIndex = 6;
			this.btnCloseAndForget.Text = "X";
			this.btnCloseAndForget.UseVisualStyleBackColor = false;
			this.btnCloseAndForget.Click += new System.EventHandler(this.btnCloseAndForget_Click);
			// 
			// lblAnimation
			// 
			this.lblAnimation.AutoSize = true;
			this.lblAnimation.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblAnimation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.lblAnimation.Location = new System.Drawing.Point(11, 96);
			this.lblAnimation.Name = "lblAnimation";
			this.lblAnimation.Size = new System.Drawing.Size(25, 29);
			this.lblAnimation.TabIndex = 5;
			this.lblAnimation.Text = ">";
			// 
			// btnPause
			// 
			this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(188)))));
			this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(185)))), ((int)(((byte)(59)))));
			this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPause.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPause.Location = new System.Drawing.Point(76, 155);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(55, 57);
			this.btnPause.TabIndex = 4;
			this.btnPause.Text = "[ ]";
			this.btnPause.UseVisualStyleBackColor = false;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// btnPlay
			// 
			this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(163)))), ((int)(((byte)(188)))));
			this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(185)))), ((int)(((byte)(59)))));
			this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPlay.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnPlay.Location = new System.Drawing.Point(15, 155);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(55, 57);
			this.btnPlay.TabIndex = 3;
			this.btnPlay.Text = ">>>";
			this.btnPlay.UseVisualStyleBackColor = false;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Font = new System.Drawing.Font("Roboto Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.lblTime.Location = new System.Drawing.Point(11, 60);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(105, 29);
			this.lblTime.TabIndex = 2;
			this.lblTime.Text = "00:00:00";
			// 
			// btnStopAndSave
			// 
			this.btnStopAndSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(224)))), ((int)(((byte)(143)))));
			this.btnStopAndSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(185)))), ((int)(((byte)(59)))));
			this.btnStopAndSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStopAndSave.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStopAndSave.Location = new System.Drawing.Point(293, 155);
			this.btnStopAndSave.Name = "btnStopAndSave";
			this.btnStopAndSave.Size = new System.Drawing.Size(55, 57);
			this.btnStopAndSave.TabIndex = 1;
			this.btnStopAndSave.Text = "S";
			this.btnStopAndSave.UseVisualStyleBackColor = false;
			this.btnStopAndSave.Click += new System.EventHandler(this.btnStopAndSave_Click);
			// 
			// SessionTickerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 225);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "SessionTickerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SessionTickerForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnStopAndSave;
		private System.Windows.Forms.Button btnPause;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label lblAnimation;
		private System.Windows.Forms.Button btnCloseAndForget;
		private System.Windows.Forms.Label lblTitle;
	}
}