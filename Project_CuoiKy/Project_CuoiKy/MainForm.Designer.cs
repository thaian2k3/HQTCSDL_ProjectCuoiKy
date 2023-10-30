namespace Project_CuoiKy
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlSubmenuPhong = new System.Windows.Forms.Panel();
            this.btnDanhSachMay = new CustomControls.RJControls.RJButton();
            this.btnThongTinPhong = new CustomControls.RJControls.RJButton();
            this.btnPhong = new CustomControls.RJControls.RJButton();
            this.btnHoaDon = new CustomControls.RJControls.RJButton();

            this.pnlSubmenuKhachHang = new System.Windows.Forms.Panel();
            this.btnXemChiTietKH = new CustomControls.RJControls.RJButton();
            this.btnTaiKhoan = new CustomControls.RJControls.RJButton();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.btnHome = new CustomControls.RJControls.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rjCircularPictureBox1 = new CustomControls.RJControls.RJCircularPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new CustomControls.RJControls.RJButton();
            this.rjButton5 = new CustomControls.RJControls.RJButton();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlSidebar.SuspendLayout();
            this.pnlSubmenuPhong.SuspendLayout();
            this.pnlSubmenuKhachHang.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.pnlSidebar.Controls.Add(this.btnHoaDon);
            this.pnlSidebar.Controls.Add(this.pnlSubmenuPhong);
            this.pnlSidebar.Controls.Add(this.btnPhong);
            this.pnlSidebar.Controls.Add(this.pnlSubmenuKhachHang);
            this.pnlSidebar.Controls.Add(this.btnTaiKhoan);
            this.pnlSidebar.Controls.Add(this.rjButton2);
            this.pnlSidebar.Controls.Add(this.btnHome);
            this.pnlSidebar.Controls.Add(this.panel3);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(293, 795);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnHoaDon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHoaDon.BorderRadius = 0;
            this.btnHoaDon.BorderSize = 0;
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatAppearance.BorderSize = 0;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnHoaDon.Image = global::Project_CuoiKy.Properties.Resources.icons8_room_45__1_;
            this.btnHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 581);
            this.btnHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(293, 98);
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Text = "Hóa Đơn";
            this.btnHoaDon.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnHoaDon.UseVisualStyleBackColor = false;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // rjButton4
            // pnlSubmenuPhong
            // 
            this.pnlSubmenuPhong.AutoSize = true;
            this.pnlSubmenuPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.pnlSubmenuPhong.Controls.Add(this.btnDanhSachMay);
            this.pnlSubmenuPhong.Controls.Add(this.btnThongTinPhong);
            this.pnlSubmenuPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuPhong.Location = new System.Drawing.Point(0, 473);
            this.pnlSubmenuPhong.Name = "pnlSubmenuPhong";
            this.pnlSubmenuPhong.Size = new System.Drawing.Size(220, 100);
            this.pnlSubmenuPhong.TabIndex = 0;
            this.pnlSubmenuPhong.Visible = false;
            // 
            // btnDanhSachMay
            // 
            this.btnDanhSachMay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.btnDanhSachMay.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.btnDanhSachMay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDanhSachMay.BorderRadius = 0;
            this.btnDanhSachMay.BorderSize = 0;
            this.btnDanhSachMay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhSachMay.FlatAppearance.BorderSize = 0;
            this.btnDanhSachMay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachMay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnDanhSachMay.Image = global::Project_CuoiKy.Properties.Resources.icons8_computer_30;
            this.btnDanhSachMay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachMay.Location = new System.Drawing.Point(0, 50);
            this.btnDanhSachMay.Name = "btnDanhSachMay";
            this.btnDanhSachMay.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDanhSachMay.Size = new System.Drawing.Size(220, 50);
            this.btnDanhSachMay.TabIndex = 6;
            this.btnDanhSachMay.Text = "Danh sách máy";
            this.btnDanhSachMay.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnDanhSachMay.UseVisualStyleBackColor = false;
            this.btnDanhSachMay.Click += new System.EventHandler(this.btnDanhSachMay_Click);
            // 
            // btnThongTinPhong
            // 
            this.btnThongTinPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.btnThongTinPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.btnThongTinPhong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThongTinPhong.BorderRadius = 0;
            this.btnThongTinPhong.BorderSize = 0;
            this.btnThongTinPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongTinPhong.FlatAppearance.BorderSize = 0;
            this.btnThongTinPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongTinPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnThongTinPhong.Image = global::Project_CuoiKy.Properties.Resources.icons8_detail_30;
            this.btnThongTinPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTinPhong.Location = new System.Drawing.Point(0, 0);
            this.btnThongTinPhong.Name = "btnThongTinPhong";
            this.btnThongTinPhong.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnThongTinPhong.Size = new System.Drawing.Size(220, 50);
            this.btnThongTinPhong.TabIndex = 5;
            this.btnThongTinPhong.Text = "Thông tin phòng";
            this.btnThongTinPhong.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnThongTinPhong.UseVisualStyleBackColor = false;
            this.btnThongTinPhong.Click += new System.EventHandler(this.btnThongTinPhong_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnPhong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnPhong.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPhong.BorderRadius = 0;
            this.btnPhong.BorderSize = 0;
            this.btnPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhong.FlatAppearance.BorderSize = 0;
            this.btnPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnPhong.Image = global::Project_CuoiKy.Properties.Resources.icons8_room_45__1_;
            this.btnPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhong.Location = new System.Drawing.Point(0, 393);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(220, 80);
            this.btnPhong.TabIndex = 4;
            this.btnPhong.Text = "Phòng";
            this.btnPhong.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnPhong.UseVisualStyleBackColor = false;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // pnlSubmenuKhachHang
            // 
            this.pnlSubmenuKhachHang.AutoSize = true;
            this.pnlSubmenuKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(79)))));
            this.pnlSubmenuKhachHang.Controls.Add(this.btnXemChiTietKH);
            this.pnlSubmenuKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubmenuKhachHang.Location = new System.Drawing.Point(0, 421);
            this.pnlSubmenuKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSubmenuKhachHang.Name = "pnlSubmenuKhachHang";
            this.pnlSubmenuKhachHang.Size = new System.Drawing.Size(293, 62);
            this.pnlSubmenuKhachHang.TabIndex = 0;
            this.pnlSubmenuKhachHang.Visible = false;
            // 
            // btnXemChiTietKH
            // 
            this.btnXemChiTietKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.btnXemChiTietKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(75)))), ((int)(((byte)(84)))));
            this.btnXemChiTietKH.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXemChiTietKH.BorderRadius = 0;
            this.btnXemChiTietKH.BorderSize = 0;
            this.btnXemChiTietKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXemChiTietKH.FlatAppearance.BorderSize = 0;
            this.btnXemChiTietKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTietKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTietKH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnXemChiTietKH.Image = global::Project_CuoiKy.Properties.Resources.icons8_detail_30;
            this.btnXemChiTietKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXemChiTietKH.Location = new System.Drawing.Point(0, 0);
            this.btnXemChiTietKH.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemChiTietKH.Name = "btnXemChiTietKH";
            this.btnXemChiTietKH.Padding = new System.Windows.Forms.Padding(33, 0, 0, 0);
            this.btnXemChiTietKH.Size = new System.Drawing.Size(293, 62);
            this.btnXemChiTietKH.TabIndex = 4;
            this.btnXemChiTietKH.Text = "Thông tin chi tiết";
            this.btnXemChiTietKH.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnXemChiTietKH.UseVisualStyleBackColor = false;
            this.btnXemChiTietKH.Click += new System.EventHandler(this.btnXemChiTietKH_Click);
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnTaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnTaiKhoan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTaiKhoan.BorderRadius = 0;
            this.btnTaiKhoan.BorderSize = 0;
            this.btnTaiKhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiKhoan.FlatAppearance.BorderSize = 0;
            this.btnTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnTaiKhoan.Image = global::Project_CuoiKy.Properties.Resources.icons8_user_account_45;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(0, 323);
            this.btnTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(293, 98);
            this.btnTaiKhoan.TabIndex = 3;
            this.btnTaiKhoan.Text = "   Khách hàng        ";
            this.btnTaiKhoan.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton2.BorderRadius = 0;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.rjButton2.Image = global::Project_CuoiKy.Properties.Resources.icons8_menu_45;
            this.rjButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton2.Location = new System.Drawing.Point(0, 225);
            this.rjButton2.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(293, 98);
            this.rjButton2.TabIndex = 2;
            this.rjButton2.Text = "Menu";
            this.rjButton2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnHome.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHome.BorderRadius = 0;
            this.btnHome.BorderSize = 0;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 127);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(293, 98);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rjCircularPictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 127);
            this.panel3.TabIndex = 0;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = global::Project_CuoiKy.Properties.Resources.icons8_networking_manager_50;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(4, 15);
            this.rjCircularPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(97, 97);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 1;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(109, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CCORE HADP";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.rjButton5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(293, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 97);
            this.panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLogout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnLogout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(174)))), ((int)(((byte)(214)))));
            this.btnLogout.BorderRadius = 25;
            this.btnLogout.BorderSize = 1;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnLogout.Image = global::Project_CuoiKy.Properties.Resources.icons8_logout_45;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(996, 15);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(127, 68);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Thoát";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // rjButton5
            // 
            this.rjButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rjButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.rjButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.rjButton5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(174)))), ((int)(((byte)(214)))));
            this.rjButton5.BorderRadius = 25;
            this.rjButton5.BorderSize = 1;
            this.rjButton5.FlatAppearance.BorderSize = 0;
            this.rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.rjButton5.Image = global::Project_CuoiKy.Properties.Resources.icons8_user_45;
            this.rjButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rjButton5.Location = new System.Drawing.Point(800, 15);
            this.rjButton5.Margin = new System.Windows.Forms.Padding(4);
            this.rjButton5.Name = "rjButton5";
            this.rjButton5.Size = new System.Drawing.Size(169, 68);
            this.rjButton5.TabIndex = 0;
            this.rjButton5.Text = "Tài khoản";
            this.rjButton5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rjButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.rjButton5.UseVisualStyleBackColor = false;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(293, 97);
            this.pnlChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1155, 698);
            this.pnlChildForm.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1448, 795);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlSubmenuPhong.ResumeLayout(false);
            this.pnlSubmenuKhachHang.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private CustomControls.RJControls.RJButton btnHome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJControls.RJButton btnPhong;
        private CustomControls.RJControls.RJButton btnTaiKhoan;
        private CustomControls.RJControls.RJButton rjButton2;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btnLogout;
        private CustomControls.RJControls.RJButton rjButton5;
        private CustomControls.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Panel pnlSubmenuKhachHang;
        private CustomControls.RJControls.RJButton btnXemChiTietKH;
        private CustomControls.RJControls.RJButton btnHoaDon;
        private System.Windows.Forms.Panel pnlSubmenuPhong;
        private CustomControls.RJControls.RJButton btnThongTinPhong;
        private CustomControls.RJControls.RJButton btnDanhSachMay;
    }
}

