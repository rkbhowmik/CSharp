namespace PracticeApp1
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
			this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.btnsave = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btnChooseFileName = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// dtpBirthday
			// 
			this.dtpBirthday.Location = new System.Drawing.Point(24, 3);
			this.dtpBirthday.Name = "dtpBirthday";
			this.dtpBirthday.Size = new System.Drawing.Size(200, 20);
			this.dtpBirthday.TabIndex = 0;
			this.dtpBirthday.ValueChanged += new System.EventHandler(this.dtpBirthday_ValueChanged);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(248, 3);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 20);
			this.txtName.TabIndex = 1;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(381, 3);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(100, 20);
			this.txtPhone.TabIndex = 2;
			// 
			// btnsave
			// 
			this.btnsave.Location = new System.Drawing.Point(24, 40);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(75, 23);
			this.btnsave.TabIndex = 3;
			this.btnsave.Text = "Save";
			this.btnsave.UseVisualStyleBackColor = true;
			this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// btnChooseFileName
			// 
			this.btnChooseFileName.Location = new System.Drawing.Point(118, 40);
			this.btnChooseFileName.Name = "btnChooseFileName";
			this.btnChooseFileName.Size = new System.Drawing.Size(75, 23);
			this.btnChooseFileName.TabIndex = 4;
			this.btnChooseFileName.Text = "Convert";
			this.btnChooseFileName.UseVisualStyleBackColor = true;
			this.btnChooseFileName.Click += new System.EventHandler(this.btnChooseFileName_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 261);
			this.Controls.Add(this.btnChooseFileName);
			this.Controls.Add(this.btnsave);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.dtpBirthday);
			this.Name = "Form1";
			this.Text = "Practice App";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpBirthday;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.Button btnsave;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btnChooseFileName;
	}
}

