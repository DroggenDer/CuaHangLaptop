﻿using System;
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
    public partial class frm_DoiTac : Form
    {
        public frm_DoiTac()
        {
            InitializeComponent();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frm_DoiTac_KhachHang f = new frm_DoiTac_KhachHang();
            f.ShowDialog();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            frm_DoiTac_NhaCungCap f = new frm_DoiTac_NhaCungCap();
            f.ShowDialog();
        }

        private void frm_DoiTac_Load(object sender, EventArgs e)
        {

        }
    }
}
