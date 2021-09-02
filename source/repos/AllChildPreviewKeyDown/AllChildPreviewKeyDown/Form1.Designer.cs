
namespace AllChildPreviewKeyDown
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
			this.components = new System.ComponentModel.Container();
			this.listView1 = new System.Windows.Forms.ListView();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(12, 147);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(214, 291);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(447, 12);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(209, 160);
			this.listBox1.TabIndex = 1;
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(447, 178);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(230, 218);
			this.treeView1.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(13, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(428, 133);
			this.panel1.TabIndex = 3;
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(756, 8);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(236, 394);
			this.listBox2.TabIndex = 4;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem1.Text = "toolStripMenuItem1";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem2.Text = "toolStripMenuItem2";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem3.Text = "toolStripMenuItem3";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1004, 450);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.listView1);
			this.KeyPreview = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
	}
}

