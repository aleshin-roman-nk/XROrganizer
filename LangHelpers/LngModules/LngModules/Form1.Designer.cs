
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
			this.dataGridViewAllLexem = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSelectParagraph = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSentences)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLexemsOfSentence)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllLexem)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewSentences
			// 
			this.dataGridViewSentences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSentences.Location = new System.Drawing.Point(12, 93);
			this.dataGridViewSentences.Name = "dataGridViewSentences";
			this.dataGridViewSentences.Size = new System.Drawing.Size(542, 526);
			this.dataGridViewSentences.TabIndex = 0;
			// 
			// dataGridViewLexemsOfSentence
			// 
			this.dataGridViewLexemsOfSentence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewLexemsOfSentence.Location = new System.Drawing.Point(560, 93);
			this.dataGridViewLexemsOfSentence.Name = "dataGridViewLexemsOfSentence";
			this.dataGridViewLexemsOfSentence.Size = new System.Drawing.Size(241, 526);
			this.dataGridViewLexemsOfSentence.TabIndex = 1;
			// 
			// dataGridViewAllLexem
			// 
			this.dataGridViewAllLexem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAllLexem.Location = new System.Drawing.Point(807, 93);
			this.dataGridViewAllLexem.Name = "dataGridViewAllLexem";
			this.dataGridViewAllLexem.Size = new System.Drawing.Size(249, 526);
			this.dataGridViewAllLexem.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(12, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "предложения";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(557, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(190, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "слова предложения";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(804, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 24);
			this.label3.TabIndex = 5;
			this.label3.Text = "все слова";
			// 
			// btnSelectParagraph
			// 
			this.btnSelectParagraph.Location = new System.Drawing.Point(12, 12);
			this.btnSelectParagraph.Name = "btnSelectParagraph";
			this.btnSelectParagraph.Size = new System.Drawing.Size(133, 23);
			this.btnSelectParagraph.TabIndex = 6;
			this.btnSelectParagraph.Text = "select paragraph";
			this.btnSelectParagraph.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1068, 664);
			this.Controls.Add(this.btnSelectParagraph);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewAllLexem);
			this.Controls.Add(this.dataGridViewLexemsOfSentence);
			this.Controls.Add(this.dataGridViewSentences);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSentences)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLexemsOfSentence)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllLexem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewSentences;
		private System.Windows.Forms.DataGridView dataGridViewLexemsOfSentence;
		private System.Windows.Forms.DataGridView dataGridViewAllLexem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSelectParagraph;
	}
}

