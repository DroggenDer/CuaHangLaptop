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
    public partial class frm_DanhMuc : Form
    {
        public frm_DanhMuc()
        {
            InitializeComponent();
        }

        private void btnTinhTrang_Click(object sender, EventArgs e)
        {
            frm_DanhMuc_TinhTrang f = new frm_DanhMuc_TinhTrang();
            f.ShowDialog();
        }

        private void btnThuongHieu_Click(object sender, EventArgs e)
        {
            frm_DanhMuc_ThuongHieu f = new frm_DanhMuc_ThuongHieu();
            f.ShowDialog();
        }

        private void btnBaoHanh_Click(object sender, EventArgs e)
        {
            frm_DanhMuc_BaoHanh f = new frm_DanhMuc_BaoHanh();  
            f.ShowDialog();
        }

        private void btnKichThuoc_Click(object sender, EventArgs e)
        {
            frm_DanhMuc_KichThuoc f = new frm_DanhMuc_KichThuoc();
            f.ShowDialog();
        }

        private void btnLaptop_Click(object sender, EventArgs e)
        {
            frm_DanhMucLapTop f = new frm_DanhMucLapTop();
            f.ShowDialog();
        }
    }
}
