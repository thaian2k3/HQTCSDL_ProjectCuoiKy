namespace Project_CuoiKy.Forms.FormLinhKien
{
    partial class frmSuaThongTinLinhKien
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
            this.lblThongSo = new System.Windows.Forms.Label();
            this.lblMaMay = new System.Windows.Forms.Label();
            this.lblThemLinhKien = new System.Windows.Forms.Label();
            this.lblLoaiLK = new System.Windows.Forms.Label();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblNhaCC = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.txtTinhTrang = new CustomControls.RJControls.RJTextBox();
            this.cboLoaiLK = new CustomControls.RJControls.RJComboBox();
            this.txtThongSo = new CustomControls.RJControls.RJTextBox();
            this.cboNhaCC = new CustomControls.RJControls.RJComboBox();
            this.txtModel = new CustomControls.RJControls.RJTextBox();
            this.txtTenHang = new CustomControls.RJControls.RJTextBox();
            this.cboMaMay = new CustomControls.RJControls.RJComboBox();
            this.btnSua = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // lblThongSo
            // 
            this.lblThongSo.AutoSize = true;
            this.lblThongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblThongSo.Location = new System.Drawing.Point(260, 427);
            this.lblThongSo.Name = "lblThongSo";
            this.lblThongSo.Size = new System.Drawing.Size(75, 20);
            this.lblThongSo.TabIndex = 84;
            this.lblThongSo.Text = "Thông số";
            // 
            // lblMaMay
            // 
            this.lblMaMay.AutoSize = true;
            this.lblMaMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblMaMay.Location = new System.Drawing.Point(260, 66);
            this.lblMaMay.Name = "lblMaMay";
            this.lblMaMay.Size = new System.Drawing.Size(274, 20);
            this.lblMaMay.TabIndex = 74;
            this.lblMaMay.Text = "Bạn muốn đổi linh kiện vào máy nào ?";
            // 
            // lblThemLinhKien
            // 
            this.lblThemLinhKien.AutoSize = true;
            this.lblThemLinhKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemLinhKien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblThemLinhKien.Location = new System.Drawing.Point(326, 16);
            this.lblThemLinhKien.Name = "lblThemLinhKien";
            this.lblThemLinhKien.Size = new System.Drawing.Size(149, 25);
            this.lblThemLinhKien.TabIndex = 73;
            this.lblThemLinhKien.Text = "Sửa linh kiện";
            // 
            // lblLoaiLK
            // 
            this.lblLoaiLK.AutoSize = true;
            this.lblLoaiLK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiLK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblLoaiLK.Location = new System.Drawing.Point(260, 223);
            this.lblLoaiLK.Name = "lblLoaiLK";
            this.lblLoaiLK.Size = new System.Drawing.Size(100, 20);
            this.lblLoaiLK.TabIndex = 77;
            this.lblLoaiLK.Text = "Loại linh kiện";
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblTenHang.Location = new System.Drawing.Point(260, 297);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(76, 20);
            this.lblTenHang.TabIndex = 78;
            this.lblTenHang.Text = "Tên hãng";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblModel.Location = new System.Drawing.Point(260, 362);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(52, 20);
            this.lblModel.TabIndex = 79;
            this.lblModel.Text = "Model";
            // 
            // lblNhaCC
            // 
            this.lblNhaCC.AutoSize = true;
            this.lblNhaCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblNhaCC.Location = new System.Drawing.Point(260, 148);
            this.lblNhaCC.Name = "lblNhaCC";
            this.lblNhaCC.Size = new System.Drawing.Size(107, 20);
            this.lblNhaCC.TabIndex = 83;
            this.lblNhaCC.Text = "Nhà cung cấp";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.AutoSize = true;
            this.lblTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblTinhTrang.Location = new System.Drawing.Point(260, 488);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(84, 20);
            this.lblTinhTrang.TabIndex = 87;
            this.lblTinhTrang.Text = "Tình  trạng";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BackColor = System.Drawing.SystemColors.Window;
            this.txtTinhTrang.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTinhTrang.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTinhTrang.BorderRadius = 15;
            this.txtTinhTrang.BorderSize = 2;
            this.txtTinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTinhTrang.Location = new System.Drawing.Point(260, 512);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTinhTrang.Multiline = false;
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTinhTrang.PasswordChar = false;
            this.txtTinhTrang.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTinhTrang.PlaceholderText = "";
            this.txtTinhTrang.ReadOnly = false;
            this.txtTinhTrang.Size = new System.Drawing.Size(277, 31);
            this.txtTinhTrang.TabIndex = 88;
            this.txtTinhTrang.Texts = "";
            this.txtTinhTrang.UnderlinedStyle = false;
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
            "Chuột",
            "Bàn phím",
            "Tai nghe",
            "Màn hình"});
            this.cboLoaiLK.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboLoaiLK.ListTextColor = System.Drawing.Color.DimGray;
            this.cboLoaiLK.Location = new System.Drawing.Point(263, 255);
            this.cboLoaiLK.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboLoaiLK.Name = "cboLoaiLK";
            this.cboLoaiLK.Padding = new System.Windows.Forms.Padding(1);
            this.cboLoaiLK.SelectedValue = null;
            this.cboLoaiLK.Size = new System.Drawing.Size(273, 30);
            this.cboLoaiLK.TabIndex = 86;
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
            this.txtThongSo.Location = new System.Drawing.Point(260, 451);
            this.txtThongSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtThongSo.Multiline = false;
            this.txtThongSo.Name = "txtThongSo";
            this.txtThongSo.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtThongSo.PasswordChar = false;
            this.txtThongSo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtThongSo.PlaceholderText = "";
            this.txtThongSo.ReadOnly = false;
            this.txtThongSo.Size = new System.Drawing.Size(277, 31);
            this.txtThongSo.TabIndex = 85;
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
            this.cboNhaCC.Location = new System.Drawing.Point(263, 179);
            this.cboNhaCC.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboNhaCC.Name = "cboNhaCC";
            this.cboNhaCC.Padding = new System.Windows.Forms.Padding(1);
            this.cboNhaCC.SelectedValue = null;
            this.cboNhaCC.Size = new System.Drawing.Size(273, 30);
            this.cboNhaCC.TabIndex = 82;
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
            this.txtModel.Location = new System.Drawing.Point(260, 385);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModel.Multiline = false;
            this.txtModel.Name = "txtModel";
            this.txtModel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtModel.PasswordChar = false;
            this.txtModel.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtModel.PlaceholderText = "";
            this.txtModel.ReadOnly = false;
            this.txtModel.Size = new System.Drawing.Size(277, 31);
            this.txtModel.TabIndex = 81;
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
            this.txtTenHang.Location = new System.Drawing.Point(260, 321);
            this.txtTenHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenHang.Multiline = false;
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTenHang.PasswordChar = false;
            this.txtTenHang.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenHang.PlaceholderText = "";
            this.txtTenHang.ReadOnly = false;
            this.txtTenHang.Size = new System.Drawing.Size(277, 31);
            this.txtTenHang.TabIndex = 80;
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
            this.cboMaMay.Location = new System.Drawing.Point(264, 106);
            this.cboMaMay.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboMaMay.Name = "cboMaMay";
            this.cboMaMay.Padding = new System.Windows.Forms.Padding(1);
            this.cboMaMay.SelectedValue = null;
            this.cboMaMay.Size = new System.Drawing.Size(273, 30);
            this.cboMaMay.TabIndex = 76;
            this.cboMaMay.Texts = "";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnSua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(132)))), ((int)(((byte)(220)))));
            this.btnSua.BorderRadius = 18;
            this.btnSua.BorderSize = 2;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnSua.Image = global::Project_CuoiKy.Properties.Resources.icons8_edit_30;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(343, 551);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSua.Size = new System.Drawing.Size(137, 40);
            this.btnSua.TabIndex = 75;
            this.btnSua.Text = "Lưu thông tin";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmSuaThongTinLinhKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 629);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.lblTinhTrang);
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
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.lblMaMay);
            this.Controls.Add(this.lblThemLinhKien);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSuaThongTinLinhKien";
            this.Text = "frmSuaThongTinLinhKien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomControls.RJControls.RJTextBox txtThongSo;
        private System.Windows.Forms.Label lblThongSo;
        private CustomControls.RJControls.RJComboBox cboMaMay;
        private CustomControls.RJControls.RJButton btnSua;
        private System.Windows.Forms.Label lblMaMay;
        private System.Windows.Forms.Label lblThemLinhKien;
        private System.Windows.Forms.Label lblLoaiLK;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblModel;
        private CustomControls.RJControls.RJTextBox txtTenHang;
        private CustomControls.RJControls.RJTextBox txtModel;
        private CustomControls.RJControls.RJComboBox cboNhaCC;
        private System.Windows.Forms.Label lblNhaCC;
        private CustomControls.RJControls.RJComboBox cboLoaiLK;
        private CustomControls.RJControls.RJTextBox txtTinhTrang;
        private System.Windows.Forms.Label lblTinhTrang;
    }
}