namespace Project_CuoiKy.Forms.FormDangNhap
{
    partial class frmLogin
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
            this.tabControlLogin = new System.Windows.Forms.TabControl();
            this.tabDangNhap = new System.Windows.Forms.TabPage();
            this.btnDangNhap = new CustomControls.RJControls.RJButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtPassword = new CustomControls.RJControls.RJTextBox();
            this.txtUsername = new CustomControls.RJControls.RJTextBox();
            this.tabDangKy = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPasswordRegister = new CustomControls.RJControls.RJTextBox();
            this.btnDangKy = new CustomControls.RJControls.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordRegister = new CustomControls.RJControls.RJTextBox();
            this.txtUsernameRegister = new CustomControls.RJControls.RJTextBox();
            this.tabControlLogin.SuspendLayout();
            this.tabDangNhap.SuspendLayout();
            this.tabDangKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlLogin
            // 
            this.tabControlLogin.Controls.Add(this.tabDangNhap);
            this.tabControlLogin.Controls.Add(this.tabDangKy);
            this.tabControlLogin.Location = new System.Drawing.Point(12, 12);
            this.tabControlLogin.Name = "tabControlLogin";
            this.tabControlLogin.SelectedIndex = 0;
            this.tabControlLogin.Size = new System.Drawing.Size(567, 398);
            this.tabControlLogin.TabIndex = 5;
            // 
            // tabDangNhap
            // 
            this.tabDangNhap.Controls.Add(this.btnDangNhap);
            this.tabDangNhap.Controls.Add(this.lblPassword);
            this.tabDangNhap.Controls.Add(this.lblUsername);
            this.tabDangNhap.Controls.Add(this.txtPassword);
            this.tabDangNhap.Controls.Add(this.txtUsername);
            this.tabDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDangNhap.Location = new System.Drawing.Point(4, 22);
            this.tabDangNhap.Name = "tabDangNhap";
            this.tabDangNhap.Padding = new System.Windows.Forms.Padding(3);
            this.tabDangNhap.Size = new System.Drawing.Size(559, 372);
            this.tabDangNhap.TabIndex = 0;
            this.tabDangNhap.Text = "Đăng nhập";
            this.tabDangNhap.ToolTipText = "Đăng nhập";
            this.tabDangNhap.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDangNhap.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDangNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDangNhap.BorderRadius = 20;
            this.btnDangNhap.BorderSize = 0;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(202, 244);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(150, 40);
            this.btnDangNhap.TabIndex = 9;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextColor = System.Drawing.Color.White;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(151, 156);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 16);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(151, 81);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 16);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "Username";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtPassword.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(154, 176);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = true;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Mật khẩu";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.Size = new System.Drawing.Size(250, 31);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsername.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUsername.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUsername.BorderRadius = 15;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.Location = new System.Drawing.Point(154, 101);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "Tài khoản";
            this.txtUsername.ReadOnly = false;
            this.txtUsername.Size = new System.Drawing.Size(250, 31);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Texts = "";
            this.txtUsername.UnderlinedStyle = false;
            // 
            // tabDangKy
            // 
            this.tabDangKy.Controls.Add(this.label3);
            this.tabDangKy.Controls.Add(this.txtConfirmPasswordRegister);
            this.tabDangKy.Controls.Add(this.btnDangKy);
            this.tabDangKy.Controls.Add(this.label1);
            this.tabDangKy.Controls.Add(this.label2);
            this.tabDangKy.Controls.Add(this.txtPasswordRegister);
            this.tabDangKy.Controls.Add(this.txtUsernameRegister);
            this.tabDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDangKy.Location = new System.Drawing.Point(4, 22);
            this.tabDangKy.Name = "tabDangKy";
            this.tabDangKy.Padding = new System.Windows.Forms.Padding(3);
            this.tabDangKy.Size = new System.Drawing.Size(559, 372);
            this.tabDangKy.TabIndex = 1;
            this.tabDangKy.Text = "Đăng ký";
            this.tabDangKy.ToolTipText = "Đăng ký";
            this.tabDangKy.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Confirm Password";
            // 
            // txtConfirmPasswordRegister
            // 
            this.txtConfirmPasswordRegister.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmPasswordRegister.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtConfirmPasswordRegister.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtConfirmPasswordRegister.BorderRadius = 15;
            this.txtConfirmPasswordRegister.BorderSize = 2;
            this.txtConfirmPasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPasswordRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConfirmPasswordRegister.Location = new System.Drawing.Point(162, 221);
            this.txtConfirmPasswordRegister.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPasswordRegister.Multiline = false;
            this.txtConfirmPasswordRegister.Name = "txtConfirmPasswordRegister";
            this.txtConfirmPasswordRegister.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtConfirmPasswordRegister.PasswordChar = true;
            this.txtConfirmPasswordRegister.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtConfirmPasswordRegister.PlaceholderText = "Nhập lại mật khẩu";
            this.txtConfirmPasswordRegister.ReadOnly = false;
            this.txtConfirmPasswordRegister.Size = new System.Drawing.Size(250, 31);
            this.txtConfirmPasswordRegister.TabIndex = 15;
            this.txtConfirmPasswordRegister.Texts = "";
            this.txtConfirmPasswordRegister.UnderlinedStyle = false;
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDangKy.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDangKy.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDangKy.BorderRadius = 20;
            this.btnDangKy.BorderSize = 0;
            this.btnDangKy.FlatAppearance.BorderSize = 0;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(205, 277);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(150, 40);
            this.btnDangKy.TabIndex = 14;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.TextColor = System.Drawing.Color.White;
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Username";
            // 
            // txtPasswordRegister
            // 
            this.txtPasswordRegister.BackColor = System.Drawing.SystemColors.Window;
            this.txtPasswordRegister.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPasswordRegister.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPasswordRegister.BorderRadius = 15;
            this.txtPasswordRegister.BorderSize = 2;
            this.txtPasswordRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPasswordRegister.Location = new System.Drawing.Point(162, 134);
            this.txtPasswordRegister.Margin = new System.Windows.Forms.Padding(4);
            this.txtPasswordRegister.Multiline = false;
            this.txtPasswordRegister.Name = "txtPasswordRegister";
            this.txtPasswordRegister.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPasswordRegister.PasswordChar = true;
            this.txtPasswordRegister.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPasswordRegister.PlaceholderText = "Mật khẩu";
            this.txtPasswordRegister.ReadOnly = false;
            this.txtPasswordRegister.Size = new System.Drawing.Size(250, 31);
            this.txtPasswordRegister.TabIndex = 11;
            this.txtPasswordRegister.Texts = "";
            this.txtPasswordRegister.UnderlinedStyle = false;
            // 
            // txtUsernameRegister
            // 
            this.txtUsernameRegister.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsernameRegister.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtUsernameRegister.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtUsernameRegister.BorderRadius = 15;
            this.txtUsernameRegister.BorderSize = 2;
            this.txtUsernameRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsernameRegister.Location = new System.Drawing.Point(162, 54);
            this.txtUsernameRegister.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsernameRegister.Multiline = false;
            this.txtUsernameRegister.Name = "txtUsernameRegister";
            this.txtUsernameRegister.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsernameRegister.PasswordChar = false;
            this.txtUsernameRegister.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUsernameRegister.PlaceholderText = "Tài khoản";
            this.txtUsernameRegister.ReadOnly = false;
            this.txtUsernameRegister.Size = new System.Drawing.Size(250, 31);
            this.txtUsernameRegister.TabIndex = 10;
            this.txtUsernameRegister.Texts = "";
            this.txtUsernameRegister.UnderlinedStyle = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 420);
            this.Controls.Add(this.tabControlLogin);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLogin_KeyDown);
            this.tabControlLogin.ResumeLayout(false);
            this.tabDangNhap.ResumeLayout(false);
            this.tabDangNhap.PerformLayout();
            this.tabDangKy.ResumeLayout(false);
            this.tabDangKy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControlLogin;
        private System.Windows.Forms.TabPage tabDangNhap;
        private System.Windows.Forms.TabPage tabDangKy;
        private CustomControls.RJControls.RJButton btnDangNhap;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private CustomControls.RJControls.RJTextBox txtPassword;
        private CustomControls.RJControls.RJTextBox txtUsername;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJControls.RJTextBox txtConfirmPasswordRegister;
        private CustomControls.RJControls.RJButton btnDangKy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJTextBox txtPasswordRegister;
        private CustomControls.RJControls.RJTextBox txtUsernameRegister;
    }
}