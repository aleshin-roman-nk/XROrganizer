namespace Shared.UI.Forms
{
    partial class NodeDefaultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NodeDefaultForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.checkBoxPinned = new System.Windows.Forms.CheckBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.btnCloseAndSave = new System.Windows.Forms.Button();
            this.lblSaved = new System.Windows.Forms.Label();
            this.nodeTextPagesUC1 = new Shared.UI.UserControls.NodeTextPagesUC();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(204)))));
            this.label2.Location = new System.Drawing.Point(-2, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(204)))));
            this.label5.Location = new System.Drawing.Point(345, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(204)))));
            this.label6.Location = new System.Drawing.Point(345, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Type";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(204)))));
            this.textBoxID.Location = new System.Drawing.Point(60, 11);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(170, 23);
            this.textBoxID.TabIndex = 7;
            this.textBoxID.TabStop = false;
            this.textBoxID.Text = "1234";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(204)))));
            this.textBoxName.Location = new System.Drawing.Point(60, 47);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(273, 23);
            this.textBoxName.TabIndex = 8;
            this.textBoxName.Text = "Name1";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.textBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPath.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(204)))));
            this.textBoxPath.Location = new System.Drawing.Point(3, 80);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(845, 19);
            this.textBoxPath.TabIndex = 9;
            this.textBoxPath.TabStop = false;
            this.textBoxPath.Text = "xorg \\ shared \\ #1234";
            // 
            // checkBoxPinned
            // 
            this.checkBoxPinned.AutoSize = true;
            this.checkBoxPinned.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPinned.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(204)))));
            this.checkBoxPinned.Location = new System.Drawing.Point(242, 7);
            this.checkBoxPinned.Name = "checkBoxPinned";
            this.checkBoxPinned.Size = new System.Drawing.Size(97, 29);
            this.checkBoxPinned.TabIndex = 10;
            this.checkBoxPinned.Text = "Pinned";
            this.checkBoxPinned.UseVisualStyleBackColor = true;
            // 
            // textBoxDate
            // 
            this.textBoxDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.textBoxDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDate.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(204)))));
            this.textBoxDate.Location = new System.Drawing.Point(407, 11);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(219, 23);
            this.textBoxDate.TabIndex = 11;
            this.textBoxDate.TabStop = false;
            this.textBoxDate.Text = "12.02.2022";
            // 
            // textBoxType
            // 
            this.textBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(58)))));
            this.textBoxType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxType.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(204)))));
            this.textBoxType.Location = new System.Drawing.Point(407, 47);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.ReadOnly = true;
            this.textBoxType.Size = new System.Drawing.Size(219, 23);
            this.textBoxType.TabIndex = 12;
            this.textBoxType.TabStop = false;
            this.textBoxType.Text = "Note";
            // 
            // btnCloseAndSave
            // 
            this.btnCloseAndSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseAndSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseAndSave.BackgroundImage")));
            this.btnCloseAndSave.FlatAppearance.BorderSize = 0;
            this.btnCloseAndSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseAndSave.Location = new System.Drawing.Point(800, 1);
            this.btnCloseAndSave.Name = "btnCloseAndSave";
            this.btnCloseAndSave.Size = new System.Drawing.Size(48, 48);
            this.btnCloseAndSave.TabIndex = 13;
            this.btnCloseAndSave.UseVisualStyleBackColor = true;
            this.btnCloseAndSave.Click += new System.EventHandler(this.btnCloseAndSave_Click);
            // 
            // lblSaved
            // 
            this.lblSaved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaved.AutoSize = true;
            this.lblSaved.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(204)))));
            this.lblSaved.Location = new System.Drawing.Point(799, 51);
            this.lblSaved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaved.Name = "lblSaved";
            this.lblSaved.Size = new System.Drawing.Size(19, 21);
            this.lblSaved.TabIndex = 15;
            this.lblSaved.Text = "0";
            // 
            // nodeTextPagesUC1
            // 
            this.nodeTextPagesUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nodeTextPagesUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.nodeTextPagesUC1.Location = new System.Drawing.Point(3, 105);
            this.nodeTextPagesUC1.Name = "nodeTextPagesUC1";
            this.nodeTextPagesUC1.SelectedText = "";
            this.nodeTextPagesUC1.Size = new System.Drawing.Size(845, 591);
            this.nodeTextPagesUC1.TabIndex = 1;
            this.nodeTextPagesUC1.ObjectChanged += new System.EventHandler(this.nodeTextPagesUC1_ObjectChanged);
            this.nodeTextPagesUC1.AddPageRequired += new System.EventHandler(this.nodeTextPagesUC1_AddPageRequired);
            this.nodeTextPagesUC1.RemovePageRequired += new System.EventHandler<Domain.Entities.NodeTextPage>(this.nodeTextPagesUC1_RemovePageRequired);
            this.nodeTextPagesUC1.OpenNodeById += new System.EventHandler<string>(this.nodeTextPagesUC1_OpenNodeById);
            // 
            // NodeDefaultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(850, 697);
            this.Controls.Add(this.nodeTextPagesUC1);
            this.Controls.Add(this.lblSaved);
            this.Controls.Add(this.btnCloseAndSave);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.checkBoxPinned);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "NodeDefaultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Node";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NodeDefaultForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NodeDefaultForm_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NodeDefaultForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.CheckBox checkBoxPinned;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Button btnCloseAndSave;
        private UserControls.NodeTextPagesUC nodeTextPaginator;
        private System.Windows.Forms.Label lblSaved;
        private UserControls.NodeTextPagesUC nodeTextPagesUC1;
    }
}