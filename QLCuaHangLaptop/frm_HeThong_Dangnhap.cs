using BUS;
using DTO;
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
    public partial class frm_HeThong_Dangnhap : Form
    {
        public bool bDangNhap = false;
        public bool bQuanLy = false;
        public static TaiKhoan_DTO TaiKhoan;
        frm_HeThong_Dangnhap fDN;
        frm_HeThong_DoiMK fDMK;
        public frm_HeThong_Dangnhap()
        {
            InitializeComponent();
        }

        private void frm_HeThong_Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
        }
    }
}
