
namespace LngModules
{
	partial class ParagraphsForm
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
			this.btnSelectAndClose = new System.Windows.Forms.Button();
			this.btnNewParagraph = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 75);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(488, 374);
			this.dataGridView1.TabIndex = 0;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(506, 75);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(506, 374);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// btnSelectAndClose
			// 
			this.btnSelectAndClose.Location = new System.Drawing.Point(809, 12);
			this.btnSelectAndClose.Name = "btnSelectAndClose";
			this.btnSelectAndClose.Size = new System.Drawing.Size(203, 23);
			this.btnSelectAndClose.TabIndex = 2;
			this.btnSelectAndClose.Text = "Select and close";
			this.btnSelectAndClose.UseVisualStyleBackColor = true;
			// 
			// btnNewParagraph
			// 
			this.btnNewParagraph.Location = new System.Drawing.Point(12, 12);
			this.btnNewParagraph.Name = "btnNewParagraph";
			this.btnNewParagraph.Size = new System.Drawing.Size(145, 23);
			this.btnNewParagraph.TabIndex = 3;
			this.btnNewParagraph.Text = "create paragaph";
			this.btnNewParagraph.UseVisualStyleBackColor = true;
			// 
			// ParagraphsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1024, 460);
			this.Controls.Add(this.btnNewParagraph);
			this.Controls.Add(this.btnSelectAndClose);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "ParagraphsForm";
			this.Text = "ParagraphsForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnSelectAndClose;
		private System.Windows.Forms.Button btnNewParagraph;
	}
}