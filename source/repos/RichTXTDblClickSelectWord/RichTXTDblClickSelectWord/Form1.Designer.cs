
namespace RichTXTDblClickSelectWord
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
			this.richTxtEx1 = new RichTXTDblClickSelectWord.RichTxtEx();
			this.SuspendLayout();
			// 
			// richTxtEx1
			// 
			this.richTxtEx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.richTxtEx1.Location = new System.Drawing.Point(93, 24);
			this.richTxtEx1.Name = "richTxtEx1";
			this.richTxtEx1.Size = new System.Drawing.Size(439, 316);
			this.richTxtEx1.TabIndex = 0;
			this.richTxtEx1.Text = "roman nata vitaliy";
			this.richTxtEx1.DoubleClick += new System.EventHandler(this.richTxtEx1_DoubleClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.richTxtEx1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private RichTxtEx richTxtEx1;
	}
}

