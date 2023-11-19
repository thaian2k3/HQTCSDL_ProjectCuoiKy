namespace Project_CuoiKy.Forms.FormMay
{
    partial class frmThemMay
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaPhong = new CustomControls.RJControls.RJTextBox();
            this.txtViTri = new CustomControls.RJControls.RJTextBox();
            this.txtTenPhong = new CustomControls.RJControls.RJTextBox();
            this.cboMaPhong = new CustomControls.RJControls.RJComboBox();
            this.btnThem = new CustomControls.RJControls.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(276, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Bạn muốn thêm máy vào phòng nào ?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(341, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Thêm máy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(276, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Giá phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(275, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Vị trí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label5.Location = new System.Drawing.Point(276, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Tên phòng";
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.BackColor = System.Drawing.SystemColors.Window;
            this.txtGiaPhong.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtGiaPhong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGiaPhong.BorderRadius = 15;
            this.txtGiaPhong.BorderSize = 2;
            this.txtGiaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGiaPhong.Location = new System.Drawing.Point(276, 395);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaPhong.Multiline = false;
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGiaPhong.PasswordChar = false;
            this.txtGiaPhong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGiaPhong.PlaceholderText = "";
            this.txtGiaPhong.ReadOnly = true;
            this.txtGiaPhong.Size = new System.Drawing.Size(277, 31);
            this.txtGiaPhong.TabIndex = 57;
            this.txtGiaPhong.Texts = "";
            this.txtGiaPhong.UnderlinedStyle = false;
            this.txtGiaPhong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaPhong_KeyPress);
            // 
            // txtViTri
            // 
            this.txtViTri.BackColor = System.Drawing.SystemColors.Window;
            this.txtViTri.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtViTri.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtViTri.BorderRadius = 15;
            this.txtViTri.BorderSize = 2;
            this.txtViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViTri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtViTri.Location = new System.Drawing.Point(276, 313);
            this.txtViTri.Margin = new System.Windows.Forms.Padding(4);
            this.txtViTri.Multiline = false;
            this.txtViTri.Name = "txtViTri";
            this.txtViTri.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtViTri.PasswordChar = false;
            this.txtViTri.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtViTri.PlaceholderText = "";
            this.txtViTri.ReadOnly = true;
            this.txtViTri.Size = new System.Drawing.Size(277, 31);
            this.txtViTri.TabIndex = 56;
            this.txtViTri.Texts = "";
            this.txtViTri.UnderlinedStyle = false;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenPhong.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenPhong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenPhong.BorderRadius = 15;
            this.txtTenPhong.BorderSize = 2;
            this.txtTenPhong.CausesValidation = false;
            this.txtTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenPhong.Location = new System.Drawing.Point(276, 239);
            this.txtTenPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenPhong.Multiline = false;
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTenPhong.PasswordChar = false;
            this.txtTenPhong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenPhong.PlaceholderText = "";
            this.txtTenPhong.ReadOnly = true;
            this.txtTenPhong.Size = new System.Drawing.Size(277, 31);
            this.txtTenPhong.TabIndex = 55;
            this.txtTenPhong.Texts = "";
            this.txtTenPhong.UnderlinedStyle = false;
            // 
            // cboMaPhong
            // 
            this.cboMaPhong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboMaPhong.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cboMaPhong.BorderSize = 1;
            this.cboMaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboMaPhong.ForeColor = System.Drawing.Color.DimGray;
            this.cboMaPhong.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboMaPhong.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboMaPhong.ListTextColor = System.Drawing.Color.DimGray;
            this.cboMaPhong.Location = new System.Drawing.Point(280, 152);
            this.cboMaPhong.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboMaPhong.Name = "cboMaPhong";
            this.cboMaPhong.Padding = new System.Windows.Forms.Padding(1);
            this.cboMaPhong.SelectedValue = null;
            this.cboMaPhong.Size = new System.Drawing.Size(273, 30);
            this.cboMaPhong.TabIndex = 51;
            this.cboMaPhong.Texts = "";
            this.cboMaPhong.OnSelectedIndexChanged += new System.EventHandler(this.cboMaPhong_OnSelectedIndexChanged);
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
            this.btnThem.Image = global::Project_CuoiKy.Properties.Resources.icons8_add_301;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(365, 467);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(5);
            this.btnThem.Size = new System.Drawing.Size(96, 40);
            this.btnThem.TabIndex = 50;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(102)))), ((int)(((byte)(157)))));
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmThemMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(800, 629);
            this.Controls.Add(this.txtGiaPhong);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboMaPhong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Name = "frmThemMay";
            this.Text = "frmThemMay";
            this.Load += new System.EventHandler(this.frmThemMay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.RJControls.RJButton btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJControls.RJComboBox cboMaPhong;
        private CustomControls.RJControls.RJTextBox txtGiaPhong;
        private CustomControls.RJControls.RJTextBox txtViTri;
        private CustomControls.RJControls.RJTextBox txtTenPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}