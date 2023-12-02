namespace Project_CuoiKy.Forms.FormHoaDon
{
    partial class frmDoanhThu
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.dtpNgayCuoi = new CustomControls.RJControls.RJDatePicker();
            this.dtpNgayDau = new CustomControls.RJControls.RJDatePicker();
            this.lblGach = new System.Windows.Forms.Label();
            this.lblBoLoc = new System.Windows.Forms.Label();
            this.crysDoanhThu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.btnMonth = new CustomControls.RJControls.RJButton();
            this.btnWeek = new CustomControls.RJControls.RJButton();
            this.btnTim = new CustomControls.RJControls.RJButton();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.rjButton2);
            this.pnlHeader.Controls.Add(this.btnMonth);
            this.pnlHeader.Controls.Add(this.btnWeek);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.dtpNgayCuoi);
            this.pnlHeader.Controls.Add(this.dtpNgayDau);
            this.pnlHeader.Controls.Add(this.lblGach);
            this.pnlHeader.Controls.Add(this.btnTim);
            this.pnlHeader.Controls.Add(this.lblBoLoc);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(986, 77);
            this.pnlHeader.TabIndex = 3;
            // 
            // dtpNgayCuoi
            // 
            this.dtpNgayCuoi.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpNgayCuoi.BorderSize = 0;
            this.dtpNgayCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpNgayCuoi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCuoi.Location = new System.Drawing.Point(249, 17);
            this.dtpNgayCuoi.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpNgayCuoi.Name = "dtpNgayCuoi";
            this.dtpNgayCuoi.Size = new System.Drawing.Size(115, 35);
            this.dtpNgayCuoi.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpNgayCuoi.TabIndex = 61;
            this.dtpNgayCuoi.TextColor = System.Drawing.Color.White;
            // 
            // dtpNgayDau
            // 
            this.dtpNgayDau.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpNgayDau.BorderSize = 0;
            this.dtpNgayDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dtpNgayDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDau.Location = new System.Drawing.Point(91, 17);
            this.dtpNgayDau.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpNgayDau.Name = "dtpNgayDau";
            this.dtpNgayDau.Size = new System.Drawing.Size(111, 35);
            this.dtpNgayDau.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.dtpNgayDau.TabIndex = 60;
            this.dtpNgayDau.TextColor = System.Drawing.Color.White;
            // 
            // lblGach
            // 
            this.lblGach.AutoSize = true;
            this.lblGach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGach.Location = new System.Drawing.Point(217, 21);
            this.lblGach.Name = "lblGach";
            this.lblGach.Size = new System.Drawing.Size(17, 24);
            this.lblGach.TabIndex = 59;
            this.lblGach.Text = "-";
            // 
            // lblBoLoc
            // 
            this.lblBoLoc.AutoSize = true;
            this.lblBoLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.lblBoLoc.Location = new System.Drawing.Point(12, 23);
            this.lblBoLoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoLoc.Name = "lblBoLoc";
            this.lblBoLoc.Size = new System.Drawing.Size(59, 20);
            this.lblBoLoc.TabIndex = 47;
            this.lblBoLoc.Text = "Bộ lọc";
            // 
            // crysDoanhThu
            // 
            this.crysDoanhThu.ActiveViewIndex = -1;
            this.crysDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crysDoanhThu.Cursor = System.Windows.Forms.Cursors.Default;
            this.crysDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crysDoanhThu.Location = new System.Drawing.Point(0, 77);
            this.crysDoanhThu.Name = "crysDoanhThu";
            this.crysDoanhThu.Size = new System.Drawing.Size(986, 538);
            this.crysDoanhThu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(458, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Doanh thu trong";
            // 
            // rjButton2
            // 
            this.rjButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.rjButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(132)))), ((int)(((byte)(220)))));
            this.rjButton2.BorderRadius = 18;
            this.rjButton2.BorderSize = 2;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.rjButton2.Image = global::Project_CuoiKy.Properties.Resources.icons8_money_box_30;
            this.rjButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton2.Location = new System.Drawing.Point(855, 16);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Padding = new System.Windows.Forms.Padding(5);
            this.rjButton2.Size = new System.Drawing.Size(94, 40);
            this.rjButton2.TabIndex = 66;
            this.rjButton2.Text = "Năm";
            this.rjButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnMonth.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnMonth.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(132)))), ((int)(((byte)(220)))));
            this.btnMonth.BorderRadius = 18;
            this.btnMonth.BorderSize = 2;
            this.btnMonth.FlatAppearance.BorderSize = 0;
            this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnMonth.Image = global::Project_CuoiKy.Properties.Resources.icons8_money_box_30;
            this.btnMonth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonth.Location = new System.Drawing.Point(730, 17);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Padding = new System.Windows.Forms.Padding(5);
            this.btnMonth.Size = new System.Drawing.Size(98, 40);
            this.btnMonth.TabIndex = 65;
            this.btnMonth.Text = "Tháng";
            this.btnMonth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMonth.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnMonth.UseVisualStyleBackColor = false;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnWeek
            // 
            this.btnWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnWeek.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnWeek.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(132)))), ((int)(((byte)(220)))));
            this.btnWeek.BorderRadius = 18;
            this.btnWeek.BorderSize = 2;
            this.btnWeek.FlatAppearance.BorderSize = 0;
            this.btnWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnWeek.Image = global::Project_CuoiKy.Properties.Resources.icons8_money_box_30;
            this.btnWeek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeek.Location = new System.Drawing.Point(609, 17);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Padding = new System.Windows.Forms.Padding(5);
            this.btnWeek.Size = new System.Drawing.Size(89, 40);
            this.btnWeek.TabIndex = 64;
            this.btnWeek.Text = "Tuần";
            this.btnWeek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWeek.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnWeek.UseVisualStyleBackColor = false;
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnTim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.btnTim.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(132)))), ((int)(((byte)(220)))));
            this.btnTim.BorderRadius = 22;
            this.btnTim.BorderSize = 1;
            this.btnTim.FlatAppearance.BorderSize = 0;
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnTim.Image = global::Project_CuoiKy.Properties.Resources.icons8_search_30;
            this.btnTim.Location = new System.Drawing.Point(383, 16);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4);
            this.btnTim.Name = "btnTim";
            this.btnTim.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnTim.Size = new System.Drawing.Size(45, 41);
            this.btnTim.TabIndex = 58;
            this.btnTim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 615);
            this.Controls.Add(this.crysDoanhThu);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmDoanhThu";
            this.Text = "frmDoanhThu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private CustomControls.RJControls.RJDatePicker dtpNgayCuoi;
        private CustomControls.RJControls.RJDatePicker dtpNgayDau;
        private System.Windows.Forms.Label lblGach;
        private CustomControls.RJControls.RJButton btnTim;
        private System.Windows.Forms.Label lblBoLoc;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crysDoanhThu;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton btnMonth;
        private CustomControls.RJControls.RJButton btnWeek;
    }
}