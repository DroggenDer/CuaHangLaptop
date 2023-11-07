using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangLaptop
{
    public partial class frm_QuanLy : Form
    {
        public frm_QuanLy()
        {
            InitializeComponent();
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            frm_QuanLy_ChucVu f = new frm_QuanLy_ChucVu();
            f.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frm_QuanLy_NhanVien f = new frm_QuanLy_NhanVien();
            f.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            frm_QuanLy_ThongKe f = new frm_QuanLy_ThongKe();
            f.ShowDialog();
        }
    }
}
