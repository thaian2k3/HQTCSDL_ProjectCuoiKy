namespace Project_CuoiKy.Forms.FormLinhKien
{
    partial class frmThemLinhKien
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
            this.lblModel = new System.Windows.Forms.Label();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lblLoaiLK = new System.Windows.Forms.Label();
            this.lblMaMay = new System.Windows.Forms.Label();
            this.lblThemLinhKien = new System.Windows.Forms.Label();
            this.lblNhaCC = new System.Windows.Forms.Label();
            this.lblThongSo = new System.Windows.Forms.Label();
            this.cboLoaiLK = new CustomControls.RJControls.RJComboBox();
            this.txtThongSo = new CustomControls.RJControls.RJTextBox();
            this.cboNhaCC = new CustomControls.RJControls.RJComboBox();
            this.txtModel = new CustomControls.RJControls.RJTextBox();
            this.txtTenHang = new CustomControls.RJControls.RJTextBox();
            this.cboMaMay = new CustomControls.RJControls.RJComboBox();
            this.btnThem = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblModel.Location = new System.Drawing.Point(346, 503);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(66, 25);
            this.lblModel.TabIndex = 64;
            this.lblModel.Text = "Model";
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblTenHang.Location = new System.Drawing.Point(346, 408);
            this.lblTenHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(96, 25);
            this.lblTenHang.TabIndex = 63;
            this.lblTenHang.Text = "Tên hãng";
            // 
            // lblLoaiLK
            // 
            this.lblLoaiLK.AutoSize = true;
            this.lblLoaiLK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiLK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblLoaiLK.Location = new System.Drawing.Point(347, 317);
            this.lblLoaiLK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoaiLK.Name = "lblLoaiLK";
            this.lblLoaiLK.Size = new System.Drawing.Size(125, 25);
            this.lblLoaiLK.TabIndex = 62;
            this.lblLoaiLK.Text = "Loại linh kiện";
            // 
            // lblMaMay
            // 
            this.lblMaMay.AutoSize = true;
            this.lblMaMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblMaMay.Location = new System.Drawing.Point(347, 123);
            this.lblMaMay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaMay.Name = "lblMaMay";
            this.lblMaMay.Size = new System.Drawing.Size(358, 25);
            this.lblMaMay.TabIndex = 59;
            this.lblMaMay.Text = "Bạn muốn thêm linh kiện vào máy nào ?";
            // 
            // lblThemLinhKien
            // 
            this.lblThemLinhKien.AutoSize = true;
            this.lblThemLinhKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemLinhKien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblThemLinhKien.Location = new System.Drawing.Point(434, 62);
            this.lblThemLinhKien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThemLinhKien.Name = "lblThemLinhKien";
            this.lblThemLinhKien.Size = new System.Drawing.Size(203, 31);
            this.lblThemLinhKien.TabIndex = 58;
            this.lblThemLinhKien.Text = "Thêm linh kiện";
            // 
            // lblNhaCC
            // 
            this.lblNhaCC.AutoSize = true;
            this.lblNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblNhaCC.Location = new System.Drawing.Point(346, 224);
            this.lblNhaCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhaCC.Name = "lblNhaCC";
            this.lblNhaCC.Size = new System.Drawing.Size(133, 25);
            this.lblNhaCC.TabIndex = 69;
            this.lblNhaCC.Text = "Nhà cung cấp";
            // 
            // lblThongSo
            // 
            this.lblThongSo.AutoSize = true;
            this.lblThongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblThongSo.Location = new System.Drawing.Point(347, 597);
            this.lblThongSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongSo.Name = "lblThongSo";
            this.lblThongSo.Size = new System.Drawing.Size(95, 25);
            this.lblThongSo.TabIndex = 70;
            this.lblThongSo.Text = "Thông số";
            // 
            // cboLoaiLK
            // 
            this.cboLoaiLK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboLoaiLK.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLoaiLK.BorderSize = 1;
            this.cboLoaiLK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboLoaiLK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboLoaiLK.ForeColor = System.Drawing.Color.DimGray;
            this.cboLoaiLK.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLoaiLK.Items.AddRange(new object[] {
            "Bàn phím",
            "Tai nghe",
            "Màn hình",
            "Chuột"});
            this.cboLoaiLK.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboLoaiLK.ListTextColor = System.Drawing.Color.DimGray;
            this.cboLoaiLK.Location = new System.Drawing.Point(351, 356);
            this.cboLoaiLK.Margin = new System.Windows.Forms.Padding(4);
            this.cboLoaiLK.MinimumSize = new System.Drawing.Size(267, 37);
            this.cboLoaiLK.Name = "cboLoaiLK";
            this.cboLoaiLK.Padding = new System.Windows.Forms.Padding(1);
            this.cboLoaiLK.SelectedValue = null;
            this.cboLoaiLK.Size = new System.Drawing.Size(364, 37);
            this.cboLoaiLK.TabIndex = 72;
            this.cboLoaiLK.Texts = "Loại linh kiện";
            // 
            // txtThongSo
            // 
            this.txtThongSo.BackColor = System.Drawing.SystemColors.Window;
            this.txtThongSo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtThongSo.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtThongSo.BorderRadius = 15;
            this.txtThongSo.BorderSize = 2;
            this.txtThongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThongSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtThongSo.Location = new System.Drawing.Point(347, 626);
            this.txtThongSo.Margin = new System.Windows.Forms.Padding(5);
            this.txtThongSo.Multiline = false;
            this.txtThongSo.Name = "txtThongSo";
            this.txtThongSo.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtThongSo.PasswordChar = false;
            this.txtThongSo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtThongSo.PlaceholderText = "";
            this.txtThongSo.ReadOnly = false;
            this.txtThongSo.Size = new System.Drawing.Size(369, 39);
            this.txtThongSo.TabIndex = 71;
            this.txtThongSo.Texts = "";
            this.txtThongSo.UnderlinedStyle = false;
            // 
            // cboNhaCC
            // 
            this.cboNhaCC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboNhaCC.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboNhaCC.BorderSize = 1;
            this.cboNhaCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboNhaCC.ForeColor = System.Drawing.Color.DimGray;
            this.cboNhaCC.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboNhaCC.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboNhaCC.ListTextColor = System.Drawing.Color.DimGray;
            this.cboNhaCC.Location = new System.Drawing.Point(351, 262);
            this.cboNhaCC.Margin = new System.Windows.Forms.Padding(4);
            this.cboNhaCC.MinimumSize = new System.Drawing.Size(267, 37);
            this.cboNhaCC.Name = "cboNhaCC";
            this.cboNhaCC.Padding = new System.Windows.Forms.Padding(1);
            this.cboNhaCC.SelectedValue = null;
            this.cboNhaCC.Size = new System.Drawing.Size(364, 37);
            this.cboNhaCC.TabIndex = 68;
            this.cboNhaCC.Texts = "";
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.SystemColors.Window;
            this.txtModel.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtModel.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtModel.BorderRadius = 15;
            this.txtModel.BorderSize = 2;
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtModel.Location = new System.Drawing.Point(346, 532);
            this.txtModel.Margin = new System.Windows.Forms.Padding(5);
            this.txtModel.Multiline = false;
            this.txtModel.Name = "txtModel";
            this.txtModel.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtModel.PasswordChar = false;
            this.txtModel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtModel.PlaceholderText = "";
            this.txtModel.ReadOnly = false;
            this.txtModel.Size = new System.Drawing.Size(369, 39);
            this.txtModel.TabIndex = 67;
            this.txtModel.Texts = "";
            this.txtModel.UnderlinedStyle = false;
            // 
            // txtTenHang
            // 
            this.txtTenHang.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenHang.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenHang.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenHang.BorderRadius = 15;
            this.txtTenHang.BorderSize = 2;
            this.txtTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenHang.Location = new System.Drawing.Point(347, 437);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenHang.Multiline = false;
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Padding = new System.Windows.Forms.Padding(13, 9, 13, 9);
            this.txtTenHang.PasswordChar = false;
            this.txtTenHang.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenHang.PlaceholderText = "";
            this.txtTenHang.ReadOnly = false;
            this.txtTenHang.Size = new System.Drawing.Size(369, 39);
            this.txtTenHang.TabIndex = 66;
            this.txtTenHang.Texts = "";
            this.txtTenHang.UnderlinedStyle = false;
            // 
            // cboMaMay
            // 
            this.cboMaMay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboMaMay.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboMaMay.BorderSize = 1;
            this.cboMaMay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboMaMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboMaMay.ForeColor = System.Drawing.Color.DimGray;
            this.cboMaMay.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboMaMay.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboMaMay.ListTextColor = System.Drawing.Color.DimGray;
            this.cboMaMay.Location = new System.Drawing.Point(352, 173);
            this.cboMaMay.Margin = new System.Windows.Forms.Padding(4);
            this.cboMaMay.MinimumSize = new System.Drawing.Size(267, 37);
            this.cboMaMay.Name = "cboMaMay";
            this.cboMaMay.Padding = new System.Windows.Forms.Padding(1);
            this.cboMaMay.SelectedValue = null;
            this.cboMaMay.Size = new System.Drawing.Size(364, 37);
            this.cboMaMay.TabIndex = 61;
            this.cboMaMay.Texts = "";
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
            this.btnThem.Image = global::Project_CuoiKy.Properties.Resources.icons8_edit_30;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(440, 691);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnThem.Size = new System.Drawing.Size(182, 49);
            this.btnThem.TabIndex = 60;
            this.btnThem.Text = "Lưu thông tin";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmThemLinhKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1067, 774);
            this.Controls.Add(this.cboLoaiLK);
            this.Controls.Add(this.txtThongSo);
            this.Controls.Add(this.lblThongSo);
            this.Controls.Add(this.lblNhaCC);
            this.Controls.Add(this.cboNhaCC);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblTenHang);
            this.Controls.Add(this.lblLoaiLK);
            this.Controls.Add(this.cboMaMay);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblMaMay);
            this.Controls.Add(this.lblThemLinhKien);
            this.Name = "frmThemLinhKien";
            this.Text = "frmThemLinhKien";
            this.Load += new System.EventHandler(this.frmThemLinhKien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJTextBox txtModel;
        private CustomControls.RJControls.RJTextBox txtTenHang;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblLoaiLK;
        private CustomControls.RJControls.RJComboBox cboMaMay;
        private CustomControls.RJControls.RJButton btnThem;
        private System.Windows.Forms.Label lblMaMay;
        private System.Windows.Forms.Label lblThemLinhKien;
        private CustomControls.RJControls.RJComboBox cboNhaCC;
        private System.Windows.Forms.Label lblNhaCC;
        private CustomControls.RJControls.RJTextBox txtThongSo;
        private System.Windows.Forms.Label lblThongSo;
        private CustomControls.RJControls.RJComboBox cboLoaiLK;
    }
}