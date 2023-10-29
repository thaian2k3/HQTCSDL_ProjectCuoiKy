using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKy.Forms.FormHoaDon
{
    public partial class frmChiTietHoaDon : Form
    {
        private Api.ApiService api = new Api.ApiService();
        private string maHD;
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }
        public frmChiTietHoaDon(string maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
            LoadData();

        }
        public void LoadData()
        {
            string query = $"SELECT * FROM func_InChiTietHoaDon({maHD})";
            dgvHoaDon.DataSource = api.CreateTable(query);
        }
    }
}
