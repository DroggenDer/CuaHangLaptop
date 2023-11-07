using DevExpress.XtraBars.Ribbon.BackstageView.Accessible;
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
    public partial class Main : Form
    {
        public bool bDangNhap = false;
        public bool bQuanLy = false;
        public static TaiKhoan_DTO TaiKhoan;
        public Main(TaiKhoan_DTO tk)
        {
            InitializeComponent();
            TaiKhoan = tk;
            //MessageBox.Show(TaiKhoan.TenDangNhap);
        }
        public Main()
        {
            InitializeComponent();
            
        }


        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild!=null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;   
            childForm.Dock = DockStyle.Fill;
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_HeThong());
            lbl1.Text = btnHeThong.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_DanhMuc());
            lbl1.Text = btnDanhMuc.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_HoaDon());
            lbl1.Text = btnHoaDon.Text;
        }

        private void pic_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            lbl1.Text = "Home";
        }

        public void PhanQuyen()
        {
            btnHeThong.Enabled = !bDangNhap;
            btnHoaDon.Enabled = bDangNhap;
            btnDoiTac.Enabled = bDangNhap;
            btnQuanLy.Enabled = bDangNhap;
            btnDanhMuc.Enabled = bDangNhap;
            btnDuLieu.Enabled = bDangNhap;
        }

       

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void pic2_Click(object sender, EventArgs e)
        {

        }

        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btnDoiTac_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_DoiTac());
            lbl1.Text = btnDoiTac.Text;
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_QuanLy());
            lbl1.Text = btnQuanLy.Text;
        }

        private void btnHDSD_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDuLieu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_DuLieu());
            lbl1.Text = btnDuLieu.Text;
        }
    }
}
