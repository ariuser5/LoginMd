namespace LoginMd
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
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.btn_login = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.tb_username = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_password = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_login
			// 
			this.btn_login.Location = new System.Drawing.Point(45, 108);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(75, 23);
			this.btn_login.TabIndex = 0;
			this.btn_login.Text = "Login";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Location = new System.Drawing.Point(144, 108);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_cancel.TabIndex = 1;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// tb_username
			// 
			this.tb_username.Location = new System.Drawing.Point(74, 41);
			this.tb_username.Name = "tb_username";
			this.tb_username.Size = new System.Drawing.Size(162, 20);
			this.tb_username.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Username:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Password:";
			// 
			// tb_password
			// 
			this.tb_password.Location = new System.Drawing.Point(74, 70);
			this.tb_password.Name = "tb_password";
			this.tb_password.PasswordChar = '*';
			this.tb_password.Size = new System.Drawing.Size(162, 20);
			this.tb_password.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(116, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Login";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(259, 151);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tb_password);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb_username);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_login);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_login;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.TextBox tb_username;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_password;
		private System.Windows.Forms.Label label3;
	}
}

