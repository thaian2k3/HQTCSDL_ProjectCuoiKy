namespace Project_CuoiKy.Forms.FormKhachHang
{
    partial class frmThemKhachHang
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
            this.btnThem = new CustomControls.RJControls.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhau = new CustomControls.RJControls.RJTextBox();
            this.txtTenKH = new CustomControls.RJControls.RJTextBox();
            this.txtMaKH = new CustomControls.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(132)))), ((int)(((byte)(220)))));
            this.btnThem.BorderRadius = 18;
            this.btnThem.BorderSize = 2;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnThem.Image = global::Project_CuoiKy.Properties.Resources.icons8_add_user_male_30;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(160, 342);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(5);
            this.btnThem.Size = new System.Drawing.Size(96, 40);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(89, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(117, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Thêm khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(90, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Số điện thoại";
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
            this.txtMatKhau.Location = new System.Drawing.Point(90, 272);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMatKhau.PasswordChar = false;
            this.txtMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(250, 31);
            this.txtMatKhau.TabIndex = 33;
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
            this.txtTenKH.Location = new System.Drawing.Point(90, 203);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenKH.Multiline = false;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTenKH.PasswordChar = false;
            this.txtTenKH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenKH.PlaceholderText = "";
            this.txtTenKH.Size = new System.Drawing.Size(250, 31);
            this.txtTenKH.TabIndex = 32;
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
            this.txtMaKH.Location = new System.Drawing.Point(90, 129);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKH.Multiline = false;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaKH.PasswordChar = false;
            this.txtMaKH.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaKH.PlaceholderText = "";
            this.txtMaKH.Size = new System.Drawing.Size(250, 31);
            this.txtMaKH.TabIndex = 31;
            this.txtMaKH.Texts = "";
            this.txtMaKH.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(90, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Mật khẩu";
            // 
            // frmThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "frmThemKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmThemKhachHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJButton btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJTextBox txtMatKhau;
        private CustomControls.RJControls.RJTextBox txtTenKH;
        private CustomControls.RJControls.RJTextBox txtMaKH;
        private System.Windows.Forms.Label label3;
    }
}