namespace Project_CuoiKy.Forms.FormHoaDon
{
    partial class frmBaoCaoHoaDon
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
            this.crysBaoCaoHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crysBaoCaoHoaDon
            // 
            this.crysBaoCaoHoaDon.ActiveViewIndex = -1;
            this.crysBaoCaoHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crysBaoCaoHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crysBaoCaoHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crysBaoCaoHoaDon.Location = new System.Drawing.Point(0, 0);
            this.crysBaoCaoHoaDon.Name = "crysBaoCaoHoaDon";
            this.crysBaoCaoHoaDon.Size = new System.Drawing.Size(800, 450);
            this.crysBaoCaoHoaDon.TabIndex = 0;
            // 
            // frmBaoCaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crysBaoCaoHoaDon);
            this.Name = "frmBaoCaoHoaDon";
            this.Text = "frmBaoCaoHoaDon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer crysBaoCaoHoaDon;
    }
}