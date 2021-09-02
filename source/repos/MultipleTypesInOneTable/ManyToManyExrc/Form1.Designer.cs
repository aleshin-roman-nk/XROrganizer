
namespace ManyToManyExrc
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(35, 58);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(560, 318);
			this.dataGridView1.TabIndex = 0;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(35, 382);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(560, 199);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(601, 58);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(497, 318);
			this.dataGridView2.TabIndex = 2;
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(601, 382);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(497, 199);
			this.richTextBox2.TabIndex = 3;
			this.richTextBox2.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "предложения параграфа";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(598, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(108, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "слова предложения";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1400, 637);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

