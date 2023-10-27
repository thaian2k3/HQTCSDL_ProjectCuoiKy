using Project_CuoiKy.Api;
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
    }
}
