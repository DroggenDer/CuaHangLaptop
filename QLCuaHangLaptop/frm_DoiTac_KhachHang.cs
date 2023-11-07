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
    public partial class frm_DoiTac_KhachHang : Form
    {
        int rowIndex;
        BindingSource LstBindin = new BindingSource();

        public frm_DoiTac_KhachHang()
        {
            InitializeComponent();
            dvKhachHang.DataSource = LstBindin;
            LoadDS();
            LoadBinding();
        }

        void LoadDS()
        {
            List<KhachHang_DTO> listTinhTrang = KhachHang_BUS.LayDS();
            LstBindin.DataSource = listTinhTrang;
        }

        void LoadBinding()
        {
            txtHo.DataBindings.Add(new Binding("Text", dvKhachHang.DataSource, "HoLot", true, DataSourceUpdateMode.Never));
            txtTen.DataBindings.Add(new Binding("Text", dvKhachHang.DataSource, "Ten", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dvKhachHang.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtSdt.DataBindings.Add(new Binding("Text", dvKhachHang.DataSource, "Sdt", true, DataSourceUpdateMode.Never));
            dpNamSinh.DataBindings.Add(new Binding("Value", dvKhachHang.DataSource, "NamSinh", true, DataSourceUpdateMode.Never));
        }



        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frm_DoiTac_KhachHang_Load(object sender, EventArgs e)
        {
            LoadDS();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string dc = txtDiaChi.Text;
            string sdt = txtSdt.Text;

            if (String.IsNullOrEmpty(ho) || String.IsNullOrEmpty(ten) || String.IsNullOrEmpty(dc) || String.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Nhập thông tin");
                return;
            }

            KhachHang_DTO kh = new KhachHang_DTO()
            {
                Makh = 0,
                HoLot = ho,
                Ten = ten,
                GioiTinh = rdnNam.Checked ? "Nam" : "Nữ",
                NamSinh = dpNamSinh.Value,
                DiaChi = dc,
                Sdt = sdt
            };
            if (KhachHang_BUS.Them(kh))
            {
                MessageBox.Show("Thêm được rồi");
                LoadDS();
                return;
            }

            MessageBox.Show("Thêm không được rồi");
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dvKhachHang.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Chọn rồi mới sửa á");
                return;
            }
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string dc = txtDiaChi.Text;
            string sdt = txtSdt.Text;

            if (String.IsNullOrEmpty(ho) || String.IsNullOrEmpty(ten) || String.IsNullOrEmpty(dc) || String.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Nhập đầy đủ vô");
                return;
            }
            int Id = Convert.ToInt32(row.Cells[0].Value);
            KhachHang_DTO ncc = new KhachHang_DTO()
            {
                Makh = 0,
                HoLot = ho,
                Ten = ten,
                GioiTinh = rdnNam.Checked ? "Nam" : "Nữ",
                NamSinh = dpNamSinh.Value,
                DiaChi = dc,
                Sdt = sdt
            };
            if (KhachHang_BUS.Sua(Id, ncc))
            {
                MessageBox.Show("Sửa được rồi");
                LoadDS();
                return;
            }

            MessageBox.Show("Sửa thất bại");
        }

        private void dvKhachHang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;  
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            txtHo.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";

            dvKhachHang.ClearSelection();
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dvKhachHang.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Chọn rồi mới xóa");
                return;
            }

            int Id = Convert.ToInt32(row.Cells[0].Value);

            if (KhachHang_BUS.Xoa(Id))
            {
                MessageBox.Show("Xóa được rồi ");
                LoadDS();
                return;
            }

            MessageBox.Show("Xóa không được rồi");
        }
    }
}
