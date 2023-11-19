namespace Project_CuoiKy.Forms.FormHoaDon
{
    partial class frmChiTietHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThanhToan = new CustomControls.RJControls.RJButton();
            this.dgvChiTietBaoTri = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvXoaHoaDon = new System.Windows.Forms.DataGridViewImageColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnSua = new CustomControls.RJControls.RJButton();
            this.txtSoLuong = new CustomControls.RJControls.RJTextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.pnlBody.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBaoTri)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.panel1);
            this.pnlBody.Controls.Add(this.dgvChiTietBaoTri);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 63);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(889, 561);
            this.pnlBody.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 472);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 89);
            this.panel1.TabIndex = 1;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnThanhToan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnThanhToan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(132)))), ((int)(((byte)(220)))));
            this.btnThanhToan.BorderRadius = 18;
            this.btnThanhToan.BorderSize = 2;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnThanhToan.Image = global::Project_CuoiKy.Properties.Resources.icons8_receipt_approved_30;
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(731, 24);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnThanhToan.Size = new System.Drawing.Size(130, 40);
            this.btnThanhToan.TabIndex = 55;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // dgvChiTietBaoTri
            // 
            this.dgvChiTietBaoTri.AllowUserToAddRows = false;
            this.dgvChiTietBaoTri.AllowUserToDeleteRows = false;
            this.dgvChiTietBaoTri.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvChiTietBaoTri.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChiTietBaoTri.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChiTietBaoTri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChiTietBaoTri.ColumnHeadersHeight = 40;
            this.dgvChiTietBaoTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvChiTietBaoTri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.DonGia,
            this.SoLuong,
            this.TongTien,
            this.dgvXoaHoaDon,
            this.MaKH,
            this.MaHoaDon,
            this.NgayTao,
            this.TinhTrang,
            this.TongGiaTri});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietBaoTri.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiTietBaoTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietBaoTri.EnableHeadersVisualStyles = false;
            this.dgvChiTietBaoTri.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvChiTietBaoTri.Location = new System.Drawing.Point(0, 0);
            this.dgvChiTietBaoTri.Name = "dgvChiTietBaoTri";
            this.dgvChiTietBaoTri.ReadOnly = true;
            this.dgvChiTietBaoTri.RowHeadersVisible = false;
            this.dgvChiTietBaoTri.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvChiTietBaoTri.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvChiTietBaoTri.RowTemplate.DividerHeight = 1;
            this.dgvChiTietBaoTri.RowTemplate.Height = 35;
            this.dgvChiTietBaoTri.RowTemplate.ReadOnly = true;
            this.dgvChiTietBaoTri.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietBaoTri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietBaoTri.Size = new System.Drawing.Size(889, 561);
            this.dgvChiTietBaoTri.TabIndex = 0;
            this.dgvChiTietBaoTri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_CellClick);
            this.dgvChiTietBaoTri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_CellContentClick);
            // 
            // MaSP
            // 
            this.MaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // TongTien
            // 
            this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.MinimumWidth = 6;
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            // 
            // dgvXoaHoaDon
            // 
            this.dgvXoaHoaDon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            this.dgvXoaHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvXoaHoaDon.HeaderText = "";
            this.dgvXoaHoaDon.Image = global::Project_CuoiKy.Properties.Resources.icons8_delete_30;
            this.dgvXoaHoaDon.MinimumWidth = 6;
            this.dgvXoaHoaDon.Name = "dgvXoaHoaDon";
            this.dgvXoaHoaDon.ReadOnly = true;
            this.dgvXoaHoaDon.Width = 16;
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            this.MaKH.Visible = false;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.DataPropertyName = "MaHD";
            this.MaHoaDon.HeaderText = "Column1";
            this.MaHoaDon.MinimumWidth = 6;
            this.MaHoaDon.Name = "MaHoaDon";
            this.MaHoaDon.ReadOnly = true;
            this.MaHoaDon.Visible = false;
            this.MaHoaDon.Width = 125;
            // 
            // NgayTao
            // 
            this.NgayTao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayTao.DataPropertyName = "NgayTao";
            this.NgayTao.HeaderText = "Ngày tạo";
            this.NgayTao.MinimumWidth = 6;
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.ReadOnly = true;
            this.NgayTao.Visible = false;
            // 
            // TinhTrang
            // 
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            this.TinhTrang.Visible = false;
            this.TinhTrang.Width = 125;
            // 
            // TongGiaTri
            // 
            this.TongGiaTri.DataPropertyName = "TongGiaTri";
            this.TongGiaTri.HeaderText = "Tổng giá trị";
            this.TongGiaTri.MinimumWidth = 6;
            this.TongGiaTri.Name = "TongGiaTri";
            this.TongGiaTri.ReadOnly = true;
            this.TongGiaTri.Visible = false;
            this.TongGiaTri.Width = 125;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.btnSua);
            this.pnlHeader.Controls.Add(this.txtSoLuong);
            this.pnlHeader.Controls.Add(this.lblSoLuong);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(889, 63);
            this.pnlHeader.TabIndex = 4;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnSua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(132)))), ((int)(((byte)(220)))));
            this.btnSua.BorderRadius = 18;
            this.btnSua.BorderSize = 2;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnSua.Image = global::Project_CuoiKy.Properties.Resources.icons8_reset_30;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(289, 10);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSua.Size = new System.Drawing.Size(84, 40);
            this.btnSua.TabIndex = 53;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.SystemColors.Window;
            this.txtSoLuong.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSoLuong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoLuong.BorderRadius = 0;
            this.txtSoLuong.BorderSize = 2;
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSoLuong.Location = new System.Drawing.Point(95, 15);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoLuong.Multiline = false;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.txtSoLuong.PasswordChar = false;
            this.txtSoLuong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoLuong.PlaceholderText = "Số lượng sản phẩm";
            this.txtSoLuong.ReadOnly = false;
            this.txtSoLuong.Size = new System.Drawing.Size(188, 29);
            this.txtSoLuong.TabIndex = 1;
            this.txtSoLuong.Texts = "";
            this.txtSoLuong.UnderlinedStyle = false;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblSoLuong.Location = new System.Drawing.Point(9, 19);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(80, 20);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // frmChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(889, 624);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmChiTietHoaDon";
            this.Text = "frmChiTietHoaDon";
            this.Load += new System.EventHandler(this.frmChiTietHoaDon_Load);
            this.pnlBody.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBaoTri)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.DataGridView dgvChiTietBaoTri;
        private System.Windows.Forms.Panel pnlHeader;
        private CustomControls.RJControls.RJTextBox txtSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private CustomControls.RJControls.RJButton btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewImageColumn dgvXoaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongGiaTri;
        private System.Windows.Forms.Panel panel1;
        private CustomControls.RJControls.RJButton btnThanhToan;
    }
}