﻿namespace Project_CuoiKy.Forms.FormSanPham
{
    partial class frmSuaSanPham
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
            this.btnLuuThongTin = new CustomControls.RJControls.RJButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaNCC = new CustomControls.RJControls.RJComboBox();
            this.txtDonGia = new CustomControls.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new CustomControls.RJControls.RJTextBox();
            this.txtTenSanPham = new CustomControls.RJControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboLoaiSP = new CustomControls.RJControls.RJComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btnLuuThongTin.Location = new System.Drawing.Point(275, 581);
            this.btnLuuThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuuThongTin.Name = "btnLuuThongTin";
            this.btnLuuThongTin.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnLuuThongTin.Size = new System.Drawing.Size(187, 55);
            this.btnLuuThongTin.TabIndex = 66;
            this.btnLuuThongTin.Text = "Lưu thông tin";
            this.btnLuuThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuThongTin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnLuuThongTin.UseVisualStyleBackColor = false;
            this.btnLuuThongTin.Click += new System.EventHandler(this.btnLuuThongTin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(225, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 31);
            this.label4.TabIndex = 59;
            this.label4.Text = "Sửa thông sản phẩm";
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
            this.cboMaNCC.Location = new System.Drawing.Point(192, 318);
            this.cboMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaNCC.MinimumSize = new System.Drawing.Size(267, 37);
            this.cboMaNCC.Name = "cboMaNCC";
            this.cboMaNCC.Padding = new System.Windows.Forms.Padding(1);
            this.cboMaNCC.SelectedValue = null;
            this.cboMaNCC.Size = new System.Drawing.Size(357, 37);
            this.cboMaNCC.TabIndex = 74;
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
            this.txtDonGia.Location = new System.Drawing.Point(196, 482);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(5);
            this.txtDonGia.Multiline = false;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtDonGia.PasswordChar = false;
            this.txtDonGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.ReadOnly = false;
            this.txtDonGia.Size = new System.Drawing.Size(357, 39);
            this.txtDonGia.TabIndex = 73;
            this.txtDonGia.Texts = "";
            this.txtDonGia.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(196, 453);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 72;
            this.label5.Text = "Đơn giá";
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
            this.txtSoLuong.Location = new System.Drawing.Point(192, 404);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(5);
            this.txtSoLuong.Multiline = false;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtSoLuong.PasswordChar = false;
            this.txtSoLuong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.ReadOnly = false;
            this.txtSoLuong.Size = new System.Drawing.Size(357, 39);
            this.txtSoLuong.TabIndex = 71;
            this.txtSoLuong.Texts = "";
            this.txtSoLuong.UnderlinedStyle = false;
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
            this.txtTenSanPham.Location = new System.Drawing.Point(192, 151);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenSanPham.Multiline = false;
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtTenSanPham.PasswordChar = false;
            this.txtTenSanPham.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenSanPham.PlaceholderText = "";
            this.txtTenSanPham.ReadOnly = false;
            this.txtTenSanPham.Size = new System.Drawing.Size(357, 39);
            this.txtTenSanPham.TabIndex = 70;
            this.txtTenSanPham.Texts = "";
            this.txtTenSanPham.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(192, 374);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 69;
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
            this.label2.Location = new System.Drawing.Point(191, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 68;
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
            this.label1.Location = new System.Drawing.Point(192, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 67;
            this.label1.Text = "Tên sản phẩm";
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
            this.cboLoaiSP.Location = new System.Drawing.Point(192, 238);
            this.cboLoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiSP.MinimumSize = new System.Drawing.Size(267, 37);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Padding = new System.Windows.Forms.Padding(1);
            this.cboLoaiSP.SelectedValue = null;
            this.cboLoaiSP.Size = new System.Drawing.Size(357, 37);
            this.cboLoaiSP.TabIndex = 76;
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
            this.label6.Location = new System.Drawing.Point(191, 209);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 75;
            this.label6.Text = "Loại sản phẩm";
            // 
            // frmSuaSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(745, 719);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboMaNCC);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLuuThongTin);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSuaSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSuaSanPham";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton btnLuuThongTin;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJComboBox cboMaNCC;
        private CustomControls.RJControls.RJTextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private CustomControls.RJControls.RJTextBox txtSoLuong;
        private CustomControls.RJControls.RJTextBox txtTenSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJComboBox cboLoaiSP;
        private System.Windows.Forms.Label label6;
    }
}