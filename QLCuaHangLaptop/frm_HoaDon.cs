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
    public partial class frm_HoaDon : Form
    {
        public frm_HoaDon()
        {
            InitializeComponent();
        }

        private void btnHDB_Click(object sender, EventArgs e)
        {
            frm_HoaDonBan f = new frm_HoaDonBan();
            f.ShowDialog();
        }

        private void btnHDN_Click(object sender, EventArgs e)
        {
            frm_HoaDonNhap f = new frm_HoaDonNhap();
            f.ShowDialog();
        }
    }
}
