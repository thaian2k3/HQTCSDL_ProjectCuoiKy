﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKy.Forms.FormKhachHang
{
    public partial class frmThemKhachHang : Form
    {
        Api.ApiService api = new Api.ApiService();
        public frmThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = $"EXEC dbo.ThemKhachHang '{txtMaKH.Texts}', '{txtTenKH.Texts}', '{txtMatKhau.Texts}'";
            bool result = api.ExecQuery(query, "Thêm khách hàng thành công");
            this.DialogResult = result ? DialogResult.OK : DialogResult.None;
        }
    }
}
