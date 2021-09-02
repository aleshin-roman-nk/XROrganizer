
namespace RoutingMessing
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
			this.lbA = new System.Windows.Forms.ListBox();
			this.lbB = new System.Windows.Forms.ListBox();
			this.lbMain = new System.Windows.Forms.ListBox();
			this.btnToMain = new System.Windows.Forms.Button();
			this.btnFromMain = new System.Windows.Forms.Button();
			this.btnShowClass = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbA
			// 
			this.lbA.FormattingEnabled = true;
			this.lbA.Location = new System.Drawing.Point(61, 44);
			this.lbA.Name = "lbA";
			this.lbA.Size = new System.Drawing.Size(252, 173);
			this.lbA.TabIndex = 0;
			this.lbA.SelectedIndexChanged += new System.EventHandler(this.lbA_SelectedIndexChanged);
			this.lbA.Enter += new System.EventHandler(this.lbA_Enter);
			// 
			// lbB
			// 
			this.lbB.FormattingEnabled = true;
			this.lbB.Location = new System.Drawing.Point(61, 233);
			this.lbB.Name = "lbB";
			this.lbB.Size = new System.Drawing.Size(252, 199);
			this.lbB.TabIndex = 1;
			this.lbB.SelectedIndexChanged += new System.EventHandler(this.lbA_SelectedIndexChanged);
			this.lbB.Enter += new System.EventHandler(this.lbA_Enter);
			// 
			// lbMain
			// 
			this.lbMain.FormattingEnabled = true;
			this.lbMain.Location = new System.Drawing.Point(416, 38);
			this.lbMain.Name = "lbMain";
			this.lbMain.Size = new System.Drawing.Size(249, 394);
			this.lbMain.TabIndex = 2;
			// 
			// btnToMain
			// 
			this.btnToMain.Location = new System.Drawing.Point(319, 194);
			this.btnToMain.Name = "btnToMain";
			this.btnToMain.Size = new System.Drawing.Size(75, 23);
			this.btnToMain.TabIndex = 3;
			this.btnToMain.Text = ">>>";
			this.btnToMain.UseVisualStyleBackColor = true;
			this.btnToMain.Click += new System.EventHandler(this.btnToMain_Click);
			// 
			// btnFromMain
			// 
			this.btnFromMain.Location = new System.Drawing.Point(319, 233);
			this.btnFromMain.Name = "btnFromMain";
			this.btnFromMain.Size = new System.Drawing.Size(75, 25);
			this.btnFromMain.TabIndex = 4;
			this.btnFromMain.Text = "<<<";
			this.btnFromMain.UseVisualStyleBackColor = true;
			this.btnFromMain.Click += new System.EventHandler(this.btnFromMain_Click);
			// 
			// btnShowClass
			// 
			this.btnShowClass.Location = new System.Drawing.Point(319, 324);
			this.btnShowClass.Name = "btnShowClass";
			this.btnShowClass.Size = new System.Drawing.Size(75, 23);
			this.btnShowClass.TabIndex = 5;
			this.btnShowClass.Text = "show";
			this.btnShowClass.UseVisualStyleBackColor = true;
			this.btnShowClass.Click += new System.EventHandler(this.btnShowClass_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnShowClass);
			this.Controls.Add(this.btnFromMain);
			this.Controls.Add(this.btnToMain);
			this.Controls.Add(this.lbMain);
			this.Controls.Add(this.lbB);
			this.Controls.Add(this.lbA);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lbA;
		private System.Windows.Forms.ListBox lbB;
		private System.Windows.Forms.ListBox lbMain;
		private System.Windows.Forms.Button btnToMain;
		private System.Windows.Forms.Button btnFromMain;
		private System.Windows.Forms.Button btnShowClass;
	}
}

