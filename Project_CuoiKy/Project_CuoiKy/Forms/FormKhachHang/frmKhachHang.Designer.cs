namespace Project_CuoiKy.Forms
{
    partial class frmKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTienNap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnInThongTin = new CustomControls.RJControls.RJButton();
            this.txtTimKiem = new CustomControls.RJControls.RJTextBox();
            this.btnThemKhachHang = new CustomControls.RJControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.txtTimKiem);
            this.pnlHeader.Controls.Add(this.btnThemKhachHang);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(874, 63);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.AutoScroll = true;
            this.pnlBody.Controls.Add(this.panel1);
            this.pnlBody.Controls.Add(this.dgvKhachHang);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 63);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(874, 588);
            this.pnlBody.TabIndex = 1;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvKhachHang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvKhachHang.ColumnHeadersHeight = 40;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.TongTienNap,
            this.MatKhau,
            this.dgvSua,
            this.dgvXoa});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.EnableHeadersVisualStyles = false;
            this.dgvKhachHang.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvKhachHang.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvKhachHang.RowTemplate.DividerHeight = 1;
            this.dgvKhachHang.RowTemplate.Height = 35;
            this.dgvKhachHang.RowTemplate.ReadOnly = true;
            this.dgvKhachHang.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(874, 588);
            this.dgvKhachHang.TabIndex = 0;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            this.dgvKhachHang.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellDoubleClick);
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKH.DataPropertyName = "MaKH";
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MaKH.DefaultCellStyle = dataGridViewCellStyle10;
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // TongTienNap
            // 
            this.TongTienNap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TongTienNap.DataPropertyName = "TongTienNap";
            this.TongTienNap.HeaderText = "Tiền tích lũy";
            this.TongTienNap.Name = "TongTienNap";
            this.TongTienNap.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "MatKhau";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            this.MatKhau.Visible = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle15.NullValue")));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Project_CuoiKy.Properties.Resources.icons8_edit_30;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 16;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle16.NullValue")));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White;
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Project_CuoiKy.Properties.Resources.icons8_delete_30;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 16;
            // 
            // dgvSua
            // 
            this.dgvSua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle11.NullValue")));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            this.dgvSua.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSua.HeaderText = "";
            this.dgvSua.Image = global::Project_CuoiKy.Properties.Resources.icons8_edit_30;
            this.dgvSua.Name = "dgvSua";
            this.dgvSua.ReadOnly = true;
            this.dgvSua.Width = 16;
            // 
            // dgvXoa
            // 
            this.dgvXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle12.NullValue")));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            this.dgvXoa.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvXoa.HeaderText = "";
            this.dgvXoa.Image = global::Project_CuoiKy.Properties.Resources.icons8_delete_30;
            this.dgvXoa.Name = "dgvXoa";
            this.dgvXoa.ReadOnly = true;
            this.dgvXoa.Width = 16;
            // 
            // btnInThongTin
            // 
            this.btnInThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnInThongTin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnInThongTin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(132)))), ((int)(((byte)(220)))));
            this.btnInThongTin.BorderRadius = 18;
            this.btnInThongTin.BorderSize = 2;
            this.btnInThongTin.FlatAppearance.BorderSize = 0;
            this.btnInThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnInThongTin.Image = global::Project_CuoiKy.Properties.Resources.icons8_print_30;
            this.btnInThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInThongTin.Location = new System.Drawing.Point(728, 19);
            this.btnInThongTin.Name = "btnInThongTin";
            this.btnInThongTin.Padding = new System.Windows.Forms.Padding(5);
            this.btnInThongTin.Size = new System.Drawing.Size(131, 45);
            this.btnInThongTin.TabIndex = 28;
            this.btnInThongTin.Text = "In thông tin";
            this.btnInThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInThongTin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnInThongTin.UseVisualStyleBackColor = false;
            this.btnInThongTin.Click += new System.EventHandler(this.btnInThongTin_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.txtTimKiem.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTimKiem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTimKiem.BorderRadius = 15;
            this.txtTimKiem.BorderSize = 2;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimKiem.Location = new System.Drawing.Point(609, 13);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "Tìm kiếm khách hàng";
            this.txtTimKiem.ReadOnly = false;
            this.txtTimKiem.Size = new System.Drawing.Size(250, 37);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = false;
            this.txtTimKiem._TextChanged += new System.EventHandler(this.txtTimKiem__TextChanged);
            // 
            // btnThemKhachHang
            // 
            this.btnThemKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnThemKhachHang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnThemKhachHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(132)))), ((int)(((byte)(220)))));
            this.btnThemKhachHang.BorderRadius = 18;
            this.btnThemKhachHang.BorderSize = 2;
            this.btnThemKhachHang.FlatAppearance.BorderSize = 0;
            this.btnThemKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKhachHang.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemKhachHang.Image = global::Project_CuoiKy.Properties.Resources.icons8_add_user_male_30;
            this.btnThemKhachHang.Location = new System.Drawing.Point(560, 13);
            this.btnThemKhachHang.Name = "btnThemKhachHang";
            this.btnThemKhachHang.Padding = new System.Windows.Forms.Padding(5);
            this.btnThemKhachHang.Size = new System.Drawing.Size(42, 37);
            this.btnThemKhachHang.TabIndex = 0;
            this.btnThemKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemKhachHang.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemKhachHang.UseVisualStyleBackColor = false;
            this.btnThemKhachHang.Click += new System.EventHandler(this.btnThemKhachHang_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnInThongTin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 104);
            this.panel1.TabIndex = 1;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 651);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlBody;
        private CustomControls.RJControls.RJButton btnThemKhachHang;
        private CustomControls.RJControls.RJTextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTienNap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewImageColumn dgvSua;
        private System.Windows.Forms.DataGridViewImageColumn dgvXoa;
        private CustomControls.RJControls.RJButton btnInThongTin;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel1;
    }
}