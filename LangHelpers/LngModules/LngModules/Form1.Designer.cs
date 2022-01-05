
namespace LngModules
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
			this.dataGridViewSentences = new System.Windows.Forms.DataGridView();
			this.dataGridViewLexemsOfSentence = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSelectParagraph = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSentences)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLexemsOfSentence)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewSentences
			// 
			this.dataGridViewSentences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSentences.Location = new System.Drawing.Point(12, 66);
			this.dataGridViewSentences.Name = "dataGridViewSentences";
			this.dataGridViewSentences.Size = new System.Drawing.Size(542, 197);
			this.dataGridViewSentences.TabIndex = 0;
			// 
			// dataGridViewLexemsOfSentence
			// 
			this.dataGridViewLexemsOfSentence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewLexemsOfSentence.Location = new System.Drawing.Point(560, 66);
			this.dataGridViewLexemsOfSentence.Name = "dataGridViewLexemsOfSentence";
			this.dataGridViewLexemsOfSentence.Size = new System.Drawing.Size(496, 197);
			this.dataGridViewLexemsOfSentence.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "предложения";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(556, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(190, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "слова предложения";
			// 
			// btnSelectParagraph
			// 
			this.btnSelectParagraph.Location = new System.Drawing.Point(16, 12);
			this.btnSelectParagraph.Name = "btnSelectParagraph";
			this.btnSelectParagraph.Size = new System.Drawing.Size(133, 23);
			this.btnSelectParagraph.TabIndex = 6;
			this.btnSelectParagraph.Text = "select paragraph";
			this.btnSelectParagraph.UseVisualStyleBackColor = true;
			this.btnSelectParagraph.Click += new System.EventHandler(this.btnSelectParagraph_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 269);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(542, 410);
			this.richTextBox1.TabIndex = 7;
			this.richTextBox1.Text = "";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(560, 269);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(496, 410);
			this.richTextBox2.TabIndex = 8;
			this.richTextBox2.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1068, 692);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.btnSelectParagraph);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewLexemsOfSentence);
			this.Controls.Add(this.dataGridViewSentences);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSentences)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLexemsOfSentence)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewSentences;
		private System.Windows.Forms.DataGridView dataGridViewLexemsOfSentence;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSelectParagraph;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox2;
	}
}

