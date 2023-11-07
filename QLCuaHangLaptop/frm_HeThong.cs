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
    public partial class frm_HeThong : Form
    {
        public bool bDangNhap = false;
        public bool bQuanLy = false;
        public static TaiKhoan_DTO TaiKhoan;
        frm_HeThong_Dangnhap fDN;
        frm_HeThong_DoiMK fDMK;
       
        public frm_HeThong()
        {
            InitializeComponent();
        }

        public void PhanQuyenDN()
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string sTen;
            fDN = new frm_HeThong_Dangnhap();
            if (fDN.ShowDialog() == DialogResult.OK)
            {
                sTen = fDN.txtTenDangNhap.Text;
                string sMatKhau = fDN.txtMatKhau.Text;

                TaiKhoan = new TaiKhoan_DTO();
                TaiKhoan = TaiKhoan_BUS.layTaiKhoan(sTen, sMatKhau);
                if (TaiKhoan != null)
                {
                    bDangNhap = true;
                    bQuanLy = TaiKhoan.NhanVien.ChucVu.TenChucVu == "Quản lý" ? true : false;
                    MessageBox.Show("Đăng nhập thành công!");
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mặt khẩu không đúng!");
                    button1_Click(sender, e);
                }
            }
            Main m = new Main(TaiKhoan);
            m.PhanQuyen();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (!f.IsDisposed)
                    f.Close();
            }
            //Đăng xuất và thiết lập lại menu
            bDangNhap = false;
            bQuanLy = false;
            MessageBox.Show("Đăng xuất thành công!");
            Main m = new Main();
            m.PhanQuyen();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            fDMK = new frm_HeThong_DoiMK();
            fDMK.txtTendangnhap.Text = TaiKhoan.TenDangNhap;

            if (fDMK.ShowDialog() == DialogResult.OK)
            {
                string sTen = fDMK.txtTendangnhap.Text;
                string sMatKhau = fDMK.txtMKCu.Text;
                string mkMoi = fDMK.txtMKMoi.Text;
                string nhapLaiMKMoi = fDMK.txtNhapLai.Text;


                TaiKhoan_DTO nd = new TaiKhoan_DTO();
                nd = TaiKhoan_BUS.layTaiKhoan(sTen, sMatKhau);

                if (sTen == "" || sMatKhau == "" || mkMoi == "" || nhapLaiMKMoi == "")
                {
                    MessageBox.Show("Vui lòng nhập dủ thông tin!");
                    btnDoiMK_Click(sender, e);
                }
                else
                {
                    if (nd == null)
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                        btnDoiMK_Click(sender, e);
                    }
                    else
                    {
                        if (mkMoi != nhapLaiMKMoi)
                        {
                            MessageBox.Show("Nhập lại mật khẩu chưa đúng!");
                            btnDoiMK_Click(sender, e);
                        }
                        else
                        {
                            //đổi mật khẩu
                            if (TaiKhoan_BUS.DoiMatKhau(nd, mkMoi))
                            {
                                MessageBox.Show("Đổi mật khẩu thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Không đổi được!");
                            }
                        }
                    }
                }
            }
        }
    }
}
