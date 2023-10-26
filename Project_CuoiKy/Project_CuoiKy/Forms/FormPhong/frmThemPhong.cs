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
    public partial class frmThemPhong : Form
    {
        private ApiService api = new ApiService();
        public frmThemPhong()
        {
            InitializeComponent();
            txtGiaPhong.Texts = "0";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string giaPhong = txtGiaPhong.Texts.Trim() == "" ? "0" : txtGiaPhong.Texts;
            string query = $"EXEC proc_ThemPhong '{txtTenPhong.Texts}', '{txtViTri.Texts}', {float.Parse(giaPhong)}";
            this.DialogResult = api.ExecQuery(query, "Thêm phòng thành công") ? DialogResult.OK : DialogResult.None;
        }
    }
}
