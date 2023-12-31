﻿using Project_CuoiKy.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKy.Forms.FormPhong
{
    public partial class frmSuaPhong : Form
    {
        ApiService api = new ApiService();
        private string maPhong;
        private string tenPhong;
        private string viTri;
        private string giaPhong;

        public frmSuaPhong()
        {
            InitializeComponent();

            btnLuuThongTin.Visible = ACCOUNT.Role == "ADMIN";
        }

        public frmSuaPhong(string maPhong, string tenPhong, string viTri, string giaPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
            this.viTri = txtViTri.Texts = viTri;
            this.tenPhong = txtTenPhong.Texts = tenPhong;
            this.giaPhong = txtGiaPhong.Texts = giaPhong;
        }   

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            string giaPhong = txtGiaPhong.Texts.Trim() == "" ? "0" : txtGiaPhong.Texts;
            string query = $"EXEC proc_SuaPhong {maPhong}, N'{txtTenPhong.Texts}', N'{txtViTri.Texts}', {float.Parse(giaPhong)}";
            this.DialogResult = api.ExecQuery(query, "Thêm phòng thành công") ? DialogResult.OK : DialogResult.None;
        }

        private void frmSuaPhong_Load(object sender, EventArgs e)
        {

        }

        private void txtGiaPhong_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự có phải là số hay không, hoặc có phải là ký tự chấp nhận được (ví dụ: backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải số, không cho phép ký tự được nhập vào TextBox
                e.Handled = true;
            }
        }
    }
}
