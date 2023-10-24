namespace Project_CuoiKy.Forms.FormKhachHang
{
    partial class frmSuaThongTinKH
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuuThongTin = new CustomControls.RJControls.RJButton();
            this.txtMatKhau = new CustomControls.RJControls.RJTextBox();
            this.txtTenKH = new CustomControls.RJControls.RJTextBox();
            this.txtMaKH = new CustomControls.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(138, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sửa thông tin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(95, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(95, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(95, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Số điện thoại";
            // 
            // btnLuuThongTin
            // 
            this.btnLuuThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnLuuThongTin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnLuuThongTin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(132)))), ((int)(((byte)(220)))));
            this.btnLuuThongTin.BorderRadius = 18;
            this.btnLuuThongTin.BorderSize = 2;
            this.btnLuuThongTin.FlatAppearance.BorderSize = 0;
            this.btnLuuThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnLuuThongTin.Image = global::Project_CuoiKy.Properties.Resources.icons8_edit_301;
            this.btnLuuThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuThongTin.Location = new System.Drawing.Point(143, 324);
            this.btnLuuThongTin.Name = "btnLuuThongTin";
            this.btnLuuThongTin.Padding = new System.Windows.Forms.Padding(5);
            this.btnLuuThongTin.Size = new System.Drawing.Size(140, 45);
            this.btnLuuThongTin.TabIndex = 27;
            this.btnLuuThongTin.Text = "Lưu thông tin";
            this.btnLuuThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuThongTin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnLuuThongTin.UseVisualStyleBackColor = false;
            this.btnLuuThongTin.Click += new System.EventHandler(this.btnLuuThongTin_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.txtMatKhau.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMatKhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMatKhau.BorderRadius = 15;
            this.txtMatKhau.BorderSize = 2;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMatKhau.Location = new System.Drawing.Point(95, 261);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMatKhau.PasswordChar = false;
            this.txtMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(250, 31);
            this.txtMatKhau.TabIndex = 26;
            this.txtMatKhau.Texts = "";
            this.txtMatKhau.UnderlinedStyle = false;
            // 
            // txtTenKH
            // 
            this.txtTenKH.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenKH.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenKH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenKH.BorderRadius = 15;
            this.txtTenKH.BorderSize = 2;
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenKH.Location = new System.Drawing.Point(95, 196);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Multiline = false;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTenKH.PasswordChar = false;
            this.txtTenKH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenKH.PlaceholderText = "";
            this.txtTenKH.Size = new System.Drawing.Size(250, 31);
            this.txtTenKH.TabIndex = 25;
            this.txtTenKH.Texts = "";
            this.txtTenKH.UnderlinedStyle = false;
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaKH.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaKH.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaKH.BorderRadius = 15;
            this.txtMaKH.BorderSize = 2;
            this.txtMaKH.CausesValidation = false;
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaKH.Location = new System.Drawing.Point(95, 131);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Multiline = false;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaKH.PasswordChar = false;
            this.txtMaKH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaKH.PlaceholderText = "";
            this.txtMaKH.Size = new System.Drawing.Size(250, 31);
            this.txtMaKH.TabIndex = 24;
            this.txtMaKH.Texts = "";
            this.txtMaKH.UnderlinedStyle = false;
            // 
            // frmSuaThongTinKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.btnLuuThongTin);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSuaThongTinKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSuaThongTinKH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtMaKH;
        private CustomControls.RJControls.RJTextBox txtTenKH;
        private CustomControls.RJControls.RJTextBox txtMatKhau;
        private CustomControls.RJControls.RJButton btnLuuThongTin;
    }
}