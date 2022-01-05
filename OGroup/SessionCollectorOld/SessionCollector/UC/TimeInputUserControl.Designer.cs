
namespace SessionCollector.UC
{
	partial class TimeInputUserControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeInputUserControl));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnMinUp = new System.Windows.Forms.Button();
			this.btnMinDown = new System.Windows.Forms.Button();
			this.btnHrDown = new System.Windows.Forms.Button();
			this.btnHrUp = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.label1.Location = new System.Drawing.Point(111, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "мин";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.label2.Location = new System.Drawing.Point(198, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "часы";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.label7.Location = new System.Drawing.Point(14, 24);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 25);
			this.label7.TabIndex = 6;
			this.label7.Text = "00:00:00";
			// 
			// btnMinUp
			// 
			this.btnMinUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinUp.BackgroundImage")));
			this.btnMinUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnMinUp.FlatAppearance.BorderSize = 0;
			this.btnMinUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinUp.Location = new System.Drawing.Point(102, 25);
			this.btnMinUp.Name = "btnMinUp";
			this.btnMinUp.Size = new System.Drawing.Size(28, 28);
			this.btnMinUp.TabIndex = 7;
			this.btnMinUp.UseVisualStyleBackColor = true;
			this.btnMinUp.Click += new System.EventHandler(this.btnMinUp_Click);
			// 
			// btnMinDown
			// 
			this.btnMinDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinDown.BackgroundImage")));
			this.btnMinDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnMinDown.FlatAppearance.BorderSize = 0;
			this.btnMinDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMinDown.Location = new System.Drawing.Point(136, 25);
			this.btnMinDown.Name = "btnMinDown";
			this.btnMinDown.Size = new System.Drawing.Size(28, 28);
			this.btnMinDown.TabIndex = 8;
			this.btnMinDown.UseVisualStyleBackColor = true;
			this.btnMinDown.Click += new System.EventHandler(this.btnMinDown_Click);
			// 
			// btnHrDown
			// 
			this.btnHrDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHrDown.BackgroundImage")));
			this.btnHrDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnHrDown.FlatAppearance.BorderSize = 0;
			this.btnHrDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHrDown.Location = new System.Drawing.Point(223, 25);
			this.btnHrDown.Name = "btnHrDown";
			this.btnHrDown.Size = new System.Drawing.Size(28, 28);
			this.btnHrDown.TabIndex = 10;
			this.btnHrDown.UseVisualStyleBackColor = true;
			this.btnHrDown.Click += new System.EventHandler(this.btnHrDown_Click);
			// 
			// btnHrUp
			// 
			this.btnHrUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHrUp.BackgroundImage")));
			this.btnHrUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnHrUp.FlatAppearance.BorderSize = 0;
			this.btnHrUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHrUp.Location = new System.Drawing.Point(189, 25);
			this.btnHrUp.Name = "btnHrUp";
			this.btnHrUp.Size = new System.Drawing.Size(28, 28);
			this.btnHrUp.TabIndex = 9;
			this.btnHrUp.UseVisualStyleBackColor = true;
			this.btnHrUp.Click += new System.EventHandler(this.btnHrUp_Click);
			// 
			// TimeInputUserControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.btnHrDown);
			this.Controls.Add(this.btnHrUp);
			this.Controls.Add(this.btnMinDown);
			this.Controls.Add(this.btnMinUp);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "TimeInputUserControl";
			this.Size = new System.Drawing.Size(294, 69);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.TimeInputUserControl_Paint);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnMinUp;
		private System.Windows.Forms.Button btnMinDown;
		private System.Windows.Forms.Button btnHrDown;
		private System.Windows.Forms.Button btnHrUp;
	}
}
