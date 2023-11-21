namespace Project_CuoiKy.Forms.FormKhachHang
{
    partial class frmInBaoCaoKhachHang
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
            this.crysBaoCaoKhachHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crysBaoCaoKhachHang
            // 
            this.crysBaoCaoKhachHang.ActiveViewIndex = -1;
            this.crysBaoCaoKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crysBaoCaoKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crysBaoCaoKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crysBaoCaoKhachHang.Location = new System.Drawing.Point(0, 0);
            this.crysBaoCaoKhachHang.Name = "crysBaoCaoKhachHang";
            this.crysBaoCaoKhachHang.Size = new System.Drawing.Size(800, 450);
            this.crysBaoCaoKhachHang.TabIndex = 0;
            // 
            // frmInBaoCaoKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crysBaoCaoKhachHang);
            this.Name = "frmInBaoCaoKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInBaoCaoKhachHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crysBaoCaoKhachHang;
    }
}