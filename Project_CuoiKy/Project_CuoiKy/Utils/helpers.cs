using CustomControls.RJControls;
using Project_CuoiKy.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CuoiKy.Utils
{
    internal class Helpers
    {
        private ApiService api = new ApiService();
        // Lấy dữ liệu từ 1 cột trong 1 hàng
        public String DataInCol(DataGridView dgv ,string col)
        {
            return dgv.CurrentRow.Cells[col].Value.ToString();
        }

        // Đổ dữ liệu vào Combobox
        public RJComboBox CboData(string query, RJComboBox cbo, string nameMember)
        {
            cbo.DataSource = api.CreateTable(query);
            cbo.DisplayMember = nameMember;
            cbo.ValueMember = nameMember;
            cbo.SelectedItem = null;
            return cbo;
        }
    }
}
