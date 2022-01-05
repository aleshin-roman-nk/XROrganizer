
namespace Shared.UI.Forms
{
	partial class ChooseDateForm
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
			this.myCalendar1 = new DrRomic.UI.MyCalendar();
			this.SuspendLayout();
			// 
			// myCalendar1
			// 
			this.myCalendar1.BackColorCalendar = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.myCalendar1.ControlsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.myCalendar1.CurrentDateBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.myCalendar1.CurrentDateForeColor = System.Drawing.Color.Aqua;
			this.myCalendar1.ForeColorCalendar = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(211)))), ((int)(((byte)(144)))));
			this.myCalendar1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.myCalendar1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.myCalendar1.Location = new System.Drawing.Point(12, 47);
			this.myCalendar1.Name = "myCalendar1";
			this.myCalendar1.OutDaysBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
			this.myCalendar1.OutDaysForeColor = System.Drawing.Color.Gray;
			this.myCalendar1.Size = new System.Drawing.Size(385, 324);
			this.myCalendar1.TabIndex = 18;
			// 
			// ChooseDateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
			this.ClientSize = new System.Drawing.Size(409, 414);
			this.Controls.Add(this.myCalendar1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.KeyPreview = true;
			this.Name = "ChooseDateForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChooseDateForm";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChooseDateForm_KeyDown);
			this.ResumeLayout(false);

		}

		#endregion

		private DrRomic.UI.MyCalendar myCalendar1;
	}
}