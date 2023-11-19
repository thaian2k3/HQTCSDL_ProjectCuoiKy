namespace Project_CuoiKy.Forms.FormSanPham
{
    partial class frmThemSanPham
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMaNCC = new CustomControls.RJControls.RJComboBox();
            this.txtDonGia = new CustomControls.RJControls.RJTextBox();
            this.btnThem = new CustomControls.RJControls.RJButton();
            this.txtSoLuong = new CustomControls.RJControls.RJTextBox();
            this.txtTenSanPham = new CustomControls.RJControls.RJTextBox();
            this.cboLoaiSP = new CustomControls.RJControls.RJComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(156, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Số lượng";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(155, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Mã nhà cung cấp";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(156, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tên sản phẩm";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(203, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Thêm sản phẩm";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(159, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Đơn giá";
            // 
            // cboMaNCC
            // 
            this.cboMaNCC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboMaNCC.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboMaNCC.BorderSize = 1;
            this.cboMaNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboMaNCC.ForeColor = System.Drawing.Color.DimGray;
            this.cboMaNCC.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboMaNCC.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboMaNCC.ListTextColor = System.Drawing.Color.DimGray;
            this.cboMaNCC.Location = new System.Drawing.Point(156, 270);
            this.cboMaNCC.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Padding = new System.Windows.Forms.Padding(1);
            this.cboMaNCC.SelectedValue = null;
            this.cboMaNCC.Size = new System.Drawing.Size(268, 30);
            this.cboMaNCC.TabIndex = 53;
            this.cboMaNCC.Texts = "";
            this.cboMaNCC.OnSelectedIndexChanged += new System.EventHandler(this.cboMaNCC_OnSelectedIndexChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.BackColor = System.Drawing.SystemColors.Window;
            this.txtDonGia.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDonGia.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDonGia.BorderRadius = 15;
            this.txtDonGia.BorderSize = 2;
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDonGia.Location = new System.Drawing.Point(159, 404);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonGia.Multiline = false;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDonGia.PasswordChar = false;
            this.txtDonGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.ReadOnly = false;
            this.txtDonGia.Size = new System.Drawing.Size(268, 31);
            this.txtDonGia.TabIndex = 52;
            this.txtDonGia.Texts = "";
            this.txtDonGia.UnderlinedStyle = false;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
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
            this.btnThem.Location = new System.Drawing.Point(236, 456);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnThem.Size = new System.Drawing.Size(96, 40);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoLuong.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoLuong.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSoLuong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoLuong.BorderRadius = 15;
            this.txtSoLuong.BorderSize = 2;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoLuong.Location = new System.Drawing.Point(156, 340);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoLuong.Multiline = false;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSoLuong.PasswordChar = false;
            this.txtSoLuong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.ReadOnly = false;
            this.txtSoLuong.Size = new System.Drawing.Size(268, 31);
            this.txtSoLuong.TabIndex = 49;
            this.txtSoLuong.Texts = "";
            this.txtSoLuong.UnderlinedStyle = false;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenSanPham.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenSanPham.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenSanPham.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenSanPham.BorderRadius = 15;
            this.txtTenSanPham.BorderSize = 2;
            this.txtTenSanPham.CausesValidation = false;
            this.txtTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenSanPham.Location = new System.Drawing.Point(156, 139);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenSanPham.Multiline = false;
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTenSanPham.PasswordChar = false;
            this.txtTenSanPham.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenSanPham.PlaceholderText = "";
            this.txtTenSanPham.ReadOnly = false;
            this.txtTenSanPham.Size = new System.Drawing.Size(268, 31);
            this.txtTenSanPham.TabIndex = 47;
            this.txtTenSanPham.Texts = "";
            this.txtTenSanPham.UnderlinedStyle = false;
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboLoaiSP.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLoaiSP.BorderSize = 1;
            this.cboLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboLoaiSP.ForeColor = System.Drawing.Color.DimGray;
            this.cboLoaiSP.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLoaiSP.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboLoaiSP.ListTextColor = System.Drawing.Color.DimGray;
            this.cboLoaiSP.Location = new System.Drawing.Point(156, 205);
            this.cboLoaiSP.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Padding = new System.Windows.Forms.Padding(1);
            this.cboLoaiSP.SelectedValue = null;
            this.cboLoaiSP.Size = new System.Drawing.Size(268, 30);
            this.cboLoaiSP.TabIndex = 55;
            this.cboLoaiSP.Texts = "";
            this.cboLoaiSP.OnSelectedIndexChanged += new System.EventHandler(this.cboLoaiSP_OnSelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label6.Location = new System.Drawing.Point(155, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Loại sản phẩm";
            // 
            // frmThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(581, 581);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboMaNCC);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "frmThemSanPham";
            this.Text = "frmThemSanPham";
            this.Load += new System.EventHandler(this.frmThemSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton btnThem;
        private CustomControls.RJControls.RJTextBox txtSoLuong;
        private CustomControls.RJControls.RJTextBox txtTenSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJTextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJComboBox cboMaNCC;
        private CustomControls.RJControls.RJComboBox cboLoaiSP;
        private System.Windows.Forms.Label label6;
    }
}