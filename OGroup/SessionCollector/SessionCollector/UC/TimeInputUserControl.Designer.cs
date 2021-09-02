
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
			this.label2.Location = new System.Drawing.Point(185, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "часы";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(110, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 27);
			this.label3.TabIndex = 2;
			this.label3.Text = "+";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			this.label3.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
			this.label3.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(138, 30);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(19, 27);
			this.label4.TabIndex = 3;
			this.label4.Text = "-";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			this.label4.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
			this.label4.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(212, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(19, 27);
			this.label5.TabIndex = 5;
			this.label5.Text = "-";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			this.label5.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
			this.label5.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(184, 30);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(24, 27);
			this.label6.TabIndex = 4;
			this.label6.Text = "+";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			this.label6.MouseEnter += new System.EventHandler(this.label5_MouseEnter);
			this.label6.MouseLeave += new System.EventHandler(this.label5_MouseLeave);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(14, 17);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 25);
			this.label7.TabIndex = 6;
			this.label7.Text = "00:00:00";
			// 
			// TimeInputUserControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "TimeInputUserControl";
			this.Size = new System.Drawing.Size(294, 69);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
	}
}
