
namespace SessionCollector.Forms
{
	partial class SessionForm
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
			this.txtPlanHours = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePickerPlanStart = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPlanFinish = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnChangeDirectory = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btn = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.lblSessionTotalTimeString = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtPlanHours
			// 
			this.txtPlanHours.Location = new System.Drawing.Point(215, 143);
			this.txtPlanHours.Name = "txtPlanHours";
			this.txtPlanHours.Size = new System.Drawing.Size(96, 30);
			this.txtPlanHours.TabIndex = 0;
			this.txtPlanHours.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlanDuration_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 146);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(197, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Выделено времени, ч:м";
			// 
			// dateTimePickerPlanStart
			// 
			this.dateTimePickerPlanStart.CustomFormat = "dd.MM.yyyy HH:mm";
			this.dateTimePickerPlanStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerPlanStart.Location = new System.Drawing.Point(215, 85);
			this.dateTimePickerPlanStart.Name = "dateTimePickerPlanStart";
			this.dateTimePickerPlanStart.Size = new System.Drawing.Size(212, 30);
			this.dateTimePickerPlanStart.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Начало";
			// 
			// txtPlanFinish
			// 
			this.txtPlanFinish.Location = new System.Drawing.Point(215, 194);
			this.txtPlanFinish.Name = "txtPlanFinish";
			this.txtPlanFinish.ReadOnly = true;
			this.txtPlanFinish.Size = new System.Drawing.Size(212, 30);
			this.txtPlanFinish.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 201);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(97, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Окончание";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(490, 71);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(465, 444);
			this.txtDescription.TabIndex = 6;
			this.txtDescription.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(486, 45);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Описание";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(106, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Директория";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(124, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(351, 30);
			this.textBox1.TabIndex = 9;
			// 
			// btnChangeDirectory
			// 
			this.btnChangeDirectory.Location = new System.Drawing.Point(481, 6);
			this.btnChangeDirectory.Name = "btnChangeDirectory";
			this.btnChangeDirectory.Size = new System.Drawing.Size(44, 30);
			this.btnChangeDirectory.TabIndex = 10;
			this.btnChangeDirectory.Text = "...";
			this.btnChangeDirectory.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Location = new System.Drawing.Point(88, 482);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(121, 33);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			// 
			// btn
			// 
			this.btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn.Location = new System.Drawing.Point(227, 482);
			this.btn.Name = "btn";
			this.btn.Size = new System.Drawing.Size(121, 33);
			this.btn.TabIndex = 12;
			this.btn.Text = "Отмена";
			this.btn.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label6.Location = new System.Drawing.Point(12, 266);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(177, 25);
			this.label6.TabIndex = 18;
			this.label6.Text = "Общее время сессии";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			this.label6.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
			this.label6.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
			// 
			// lblSessionTotalTimeString
			// 
			this.lblSessionTotalTimeString.AutoSize = true;
			this.lblSessionTotalTimeString.Location = new System.Drawing.Point(200, 266);
			this.lblSessionTotalTimeString.Name = "lblSessionTotalTimeString";
			this.lblSessionTotalTimeString.Size = new System.Drawing.Size(19, 23);
			this.lblSessionTotalTimeString.TabIndex = 19;
			this.lblSessionTotalTimeString.Text = "0";
			// 
			// SessionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(967, 536);
			this.Controls.Add(this.lblSessionTotalTimeString);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btn);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnChangeDirectory);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtPlanFinish);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateTimePickerPlanStart);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPlanHours);
			this.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "SessionForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SessionForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPlanHours;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePickerPlanStart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPlanFinish;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox txtDescription;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btnChangeDirectory;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblSessionTotalTimeString;
	}
}