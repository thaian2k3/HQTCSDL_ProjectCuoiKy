namespace Project_CuoiKy.Forms.FormLichSuDungMay
{
    partial class frmLichSuDungMay
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblBoLoc = new System.Windows.Forms.Label();
            this.dgvLsdm = new System.Windows.Forms.DataGridView();
            this.MaLS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new CustomControls.RJControls.RJButton();
            this.cboMaKH = new CustomControls.RJControls.RJComboBox();
            this.cboMaMay = new CustomControls.RJControls.RJComboBox();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLsdm)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.btnRefresh);
            this.pnlHeader.Controls.Add(this.lblBoLoc);
            this.pnlHeader.Controls.Add(this.cboMaKH);
            this.pnlHeader.Controls.Add(this.cboMaMay);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1061, 63);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblBoLoc
            // 
            this.lblBoLoc.AutoSize = true;
            this.lblBoLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblBoLoc.Location = new System.Drawing.Point(36, 20);
            this.lblBoLoc.Name = "lblBoLoc";
            this.lblBoLoc.Size = new System.Drawing.Size(59, 20);
            this.lblBoLoc.TabIndex = 49;
            this.lblBoLoc.Text = "Bộ lọc";
            // 
            // dgvLsdm
            // 
            this.dgvLsdm.AllowUserToAddRows = false;
            this.dgvLsdm.AllowUserToDeleteRows = false;
            this.dgvLsdm.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvLsdm.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLsdm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLsdm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLsdm.ColumnHeadersHeight = 40;
            this.dgvLsdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLsdm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLS,
            this.MaMay,
            this.MaKH,
            this.TenKH,
            this.ThoiGianBatDau,
            this.ThoiGianKetThuc});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLsdm.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLsdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLsdm.EnableHeadersVisualStyles = false;
            this.dgvLsdm.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvLsdm.Location = new System.Drawing.Point(0, 63);
            this.dgvLsdm.Name = "dgvLsdm";
            this.dgvLsdm.ReadOnly = true;
            this.dgvLsdm.RowHeadersVisible = false;
            this.dgvLsdm.RowHeadersWidth = 51;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvLsdm.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLsdm.RowTemplate.DividerHeight = 1;
            this.dgvLsdm.RowTemplate.Height = 35;
            this.dgvLsdm.RowTemplate.ReadOnly = true;
            this.dgvLsdm.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLsdm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLsdm.Size = new System.Drawing.Size(1061, 516);
            this.dgvLsdm.TabIndex = 3;
            // 
            // MaLS
            // 
            this.MaLS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLS.DataPropertyName = "MaLS";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MaLS.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaLS.HeaderText = "Mã lịch sử";
            this.MaLS.MinimumWidth = 6;
            this.MaLS.Name = "MaLS";
            this.MaLS.ReadOnly = true;
            // 
            // MaMay
            // 
            this.MaMay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaMay.DataPropertyName = "MaMay";
            this.MaMay.HeaderText = "Mã máy";
            this.MaMay.MinimumWidth = 6;
            this.MaMay.Name = "MaMay";
            this.MaMay.ReadOnly = true;
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
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
            // ThoiGianBatDau
            // 
            this.ThoiGianBatDau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThoiGianBatDau.DataPropertyName = "ThoiGianBatDau";
            this.ThoiGianBatDau.HeaderText = "Thời gian bắt đầu";
            this.ThoiGianBatDau.MinimumWidth = 6;
            this.ThoiGianBatDau.Name = "ThoiGianBatDau";
            this.ThoiGianBatDau.ReadOnly = true;
            // 
            // ThoiGianKetThuc
            // 
            this.ThoiGianKetThuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThoiGianKetThuc.DataPropertyName = "ThoiGianKetThuc";
            this.ThoiGianKetThuc.HeaderText = "Thời gian kết thúc";
            this.ThoiGianKetThuc.MinimumWidth = 6;
            this.ThoiGianKetThuc.Name = "ThoiGianKetThuc";
            this.ThoiGianKetThuc.ReadOnly = true;
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
            this.btnRefresh.Location = new System.Drawing.Point(442, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Size = new System.Drawing.Size(97, 40);
            this.btnRefresh.TabIndex = 52;
            this.btnRefresh.Text = "Reset";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cboMaKH
            // 
            this.cboMaKH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboMaKH.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboMaKH.BorderSize = 1;
            this.cboMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaKH.ForeColor = System.Drawing.Color.DimGray;
            this.cboMaKH.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboMaKH.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboMaKH.ListTextColor = System.Drawing.Color.DimGray;
            this.cboMaKH.Location = new System.Drawing.Point(254, 13);
            this.cboMaKH.MinimumSize = new System.Drawing.Size(100, 30);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Padding = new System.Windows.Forms.Padding(1);
            this.cboMaKH.SelectedValue = null;
            this.cboMaKH.Size = new System.Drawing.Size(164, 35);
            this.cboMaKH.TabIndex = 48;
            this.cboMaKH.Texts = "";
            this.cboMaKH.OnSelectedIndexChanged += new System.EventHandler(this.cboMaKH_OnSelectedIndexChanged);
            // 
            // cboMaMay
            // 
            this.cboMaMay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboMaMay.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboMaMay.BorderSize = 1;
            this.cboMaMay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboMaMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaMay.ForeColor = System.Drawing.Color.DimGray;
            this.cboMaMay.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboMaMay.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboMaMay.ListTextColor = System.Drawing.Color.DimGray;
            this.cboMaMay.Location = new System.Drawing.Point(111, 13);
            this.cboMaMay.MinimumSize = new System.Drawing.Size(100, 30);
            this.cboMaMay.Name = "cboMaMay";
            this.cboMaMay.Padding = new System.Windows.Forms.Padding(1);
            this.cboMaMay.SelectedValue = null;
            this.cboMaMay.Size = new System.Drawing.Size(120, 35);
            this.cboMaMay.TabIndex = 47;
            this.cboMaMay.Texts = "";
            this.cboMaMay.OnSelectedIndexChanged += new System.EventHandler(this.cboMaMay_OnSelectedIndexChanged);
            // 
            // frmLichSuDungMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 579);
            this.Controls.Add(this.dgvLsdm);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmLichSuDungMay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLichSuDungMay";
            this.Load += new System.EventHandler(this.frmLichSuDungMay_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLsdm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private CustomControls.RJControls.RJButton btnRefresh;
        private System.Windows.Forms.Label lblBoLoc;
        private CustomControls.RJControls.RJComboBox cboMaKH;
        private CustomControls.RJControls.RJComboBox cboMaMay;
        private System.Windows.Forms.DataGridView dgvLsdm;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKetThuc;
    }
}