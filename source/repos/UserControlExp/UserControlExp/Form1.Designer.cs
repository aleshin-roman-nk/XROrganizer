
namespace UserControlExp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.gridControlUC1 = new UserControlExp.GridControlUC();
			this.entityBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.thing11 = new UserControlExp.Thing1(this.components);
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.ssbtnSave = new System.Windows.Forms.ToolStripButton();
			this.ssbtnDelete = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.entityBindingSource)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridControlUC1
			// 
			this.gridControlUC1.BtnClose = null;
			this.gridControlUC1.BtnSave = null;
			this.gridControlUC1.Location = new System.Drawing.Point(12, 42);
			this.gridControlUC1.Name = "gridControlUC1";
			this.gridControlUC1.Size = new System.Drawing.Size(639, 485);
			this.gridControlUC1.TabIndex = 0;
			// 
			// entityBindingSource
			// 
			this.entityBindingSource.DataSource = typeof(UserControlExp.Entity);
			// 
			// thing11
			// 
			this.thing11.DeleteButton = this.btnDelete;
			this.thing11.SaveButton = this.btnSave;
			// 
			// btnSave
			// 
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Location = new System.Drawing.Point(771, 57);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Location = new System.Drawing.Point(771, 86);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 2;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssbtnSave,
            this.ssbtnDelete});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(924, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// ssbtnSave
			// 
			this.ssbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ssbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("ssbtnSave.Image")));
			this.ssbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ssbtnSave.Name = "ssbtnSave";
			this.ssbtnSave.Size = new System.Drawing.Size(23, 22);
			this.ssbtnSave.Text = "toolStripButton1";
			// 
			// ssbtnDelete
			// 
			this.ssbtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ssbtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("ssbtnDelete.Image")));
			this.ssbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ssbtnDelete.Name = "ssbtnDelete";
			this.ssbtnDelete.Size = new System.Drawing.Size(23, 22);
			this.ssbtnDelete.Text = "toolStripButton2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(924, 597);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.gridControlUC1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.entityBindingSource)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource entityBindingSource;
		private GridControlUC gridControlUC1;
		private Thing1 thing11;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton ssbtnSave;
		private System.Windows.Forms.ToolStripButton ssbtnDelete;
	}
}

