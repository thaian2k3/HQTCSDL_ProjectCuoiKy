namespace Project_CuoiKy.Forms.FormBaoTri
{
    partial class frmViewChiTietBaotri
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvChiTietBaoTri = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBoLoc = new System.Windows.Forms.Label();
            this.btnRefresh = new CustomControls.RJControls.RJButton();
            this.btnThem = new CustomControls.RJControls.RJButton();
            this.MaLK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuBT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiLK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienBaoTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBaoTri)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgvChiTietBaoTri);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 77);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1426, 373);
            this.pnlBody.TabIndex = 7;
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
            this.MaLK,
            this.MaPhieuBT,
            this.SoTien,
            this.TinhTrang,
            this.GhiChu,
            this.LoaiLK,
            this.Model,
            this.NgayTao,
            this.TongTienBaoTri,
            this.delete});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietBaoTri.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChiTietBaoTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietBaoTri.EnableHeadersVisualStyles = false;
            this.dgvChiTietBaoTri.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvChiTietBaoTri.Location = new System.Drawing.Point(0, 0);
            this.dgvChiTietBaoTri.Margin = new System.Windows.Forms.Padding(4);
            this.dgvChiTietBaoTri.Name = "dgvChiTietBaoTri";
            this.dgvChiTietBaoTri.ReadOnly = true;
            this.dgvChiTietBaoTri.RowHeadersVisible = false;
            this.dgvChiTietBaoTri.RowHeadersWidth = 51;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvChiTietBaoTri.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChiTietBaoTri.RowTemplate.DividerHeight = 1;
            this.dgvChiTietBaoTri.RowTemplate.Height = 35;
            this.dgvChiTietBaoTri.RowTemplate.ReadOnly = true;
            this.dgvChiTietBaoTri.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChiTietBaoTri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietBaoTri.Size = new System.Drawing.Size(1426, 373);
            this.dgvChiTietBaoTri.TabIndex = 0;
            this.dgvChiTietBaoTri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietBaoTri_CellClick);
            this.dgvChiTietBaoTri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietBaoTri_CellContentClick);
            this.dgvChiTietBaoTri.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietBaoTri_CellContentDoubleClick);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.btnThem);
            this.pnlHeader.Controls.Add(this.lblBoLoc);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1426, 77);
            this.pnlHeader.TabIndex = 6;
            // 
            // lblBoLoc
            // 
            this.lblBoLoc.AutoSize = true;
            this.lblBoLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblBoLoc.Location = new System.Drawing.Point(109, 23);
            this.lblBoLoc.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBoLoc.Name = "lblBoLoc";
            this.lblBoLoc.Size = new System.Drawing.Size(400, 38);
            this.lblBoLoc.TabIndex = 48;
            this.lblBoLoc.Text = "Xem chi tiết phiếu bảo trì";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(132)))), ((int)(((byte)(220)))));
            this.btnRefresh.BorderRadius = 18;
            this.btnRefresh.BorderSize = 2;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnRefresh.Image = global::Project_CuoiKy.Properties.Resources.icons8_reset_30;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(1088, 12);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnRefresh.Size = new System.Drawing.Size(129, 49);
            this.btnRefresh.TabIndex = 63;
            this.btnRefresh.Text = "Reset";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnThem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnThem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(132)))), ((int)(((byte)(220)))));
            this.btnThem.BorderRadius = 18;
            this.btnThem.BorderSize = 2;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Image = global::Project_CuoiKy.Properties.Resources.icons8_add_30;
            this.btnThem.Location = new System.Drawing.Point(1275, 12);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnThem.Size = new System.Drawing.Size(124, 49);
            this.btnThem.TabIndex = 64;
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // MaLK
            // 
            this.MaLK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLK.DataPropertyName = "MaLK";
            this.MaLK.HeaderText = "Mã LK";
            this.MaLK.MinimumWidth = 6;
            this.MaLK.Name = "MaLK";
            this.MaLK.ReadOnly = true;
            // 
            // MaPhieuBT
            // 
            this.MaPhieuBT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaPhieuBT.DataPropertyName = "MaPhieu";
            this.MaPhieuBT.HeaderText = "Mã Phiếu";
            this.MaPhieuBT.MinimumWidth = 6;
            this.MaPhieuBT.Name = "MaPhieuBT";
            this.MaPhieuBT.ReadOnly = true;
            // 
            // SoTien
            // 
            this.SoTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTien.DataPropertyName = "SoTien";
            this.SoTien.HeaderText = "Số tiền";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            this.SoTien.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrang.DataPropertyName = "TinhTrang";
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.MinimumWidth = 6;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // LoaiLK
            // 
            this.LoaiLK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LoaiLK.DataPropertyName = "LoaiLK";
            this.LoaiLK.HeaderText = "Loại linh kiện";
            this.LoaiLK.MinimumWidth = 6;
            this.LoaiLK.Name = "LoaiLK";
            this.LoaiLK.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // NgayTao
            // 
            this.NgayTao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayTao.DataPropertyName = "NgayTao";
            this.NgayTao.HeaderText = "Ngày tạo";
            this.NgayTao.MinimumWidth = 6;
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.ReadOnly = true;
            // 
            // TongTienBaoTri
            // 
            this.TongTienBaoTri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTienBaoTri.DataPropertyName = "TongTienBaoTri";
            this.TongTienBaoTri.HeaderText = "Tổng tiền bảo trì";
            this.TongTienBaoTri.MinimumWidth = 6;
            this.TongTienBaoTri.Name = "TongTienBaoTri";
            this.TongTienBaoTri.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.DataPropertyName = "delete";
            this.delete.HeaderText = "Xóa";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "Xóa";
            this.delete.Width = 60;
            // 
            // frmViewChiTietBaotri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 450);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmViewChiTietBaotri";
            this.Text = "frmBaotri";
            this.Load += new System.EventHandler(this.frmChiTietBaotri_Load);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietBaoTri)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.DataGridView dgvChiTietBaoTri;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblBoLoc;
        private CustomControls.RJControls.RJButton btnThem;
        private CustomControls.RJControls.RJButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiLK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienBaoTri;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}