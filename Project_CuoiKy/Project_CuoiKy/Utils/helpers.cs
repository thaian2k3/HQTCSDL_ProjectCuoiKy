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
        // Lấy dữ liệu từ 1 cột trong 1 hàng
        public String DataInRow(DataGridView dgv ,string col)
        {
            return dgv.CurrentRow.Cells[col].Value.ToString();
        }
    }
}
