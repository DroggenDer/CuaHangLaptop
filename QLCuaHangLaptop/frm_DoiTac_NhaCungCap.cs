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
    public partial class frm_DoiTac_NhaCungCap : Form
    {
        int rowIndex;
        BindingSource LstBindin = new BindingSource();

        public frm_DoiTac_NhaCungCap()
        {
            InitializeComponent();
            dvKhachHang.DataSource = LstBindin;
            LoadDS();
            LoadBinding();
        }

        void LoadDS()
        {
            List<NhaCungCap_DTO> listTinhTrang = NhaCungCap_BUS.LayDS();
            LstBindin.DataSource = listTinhTrang;
        }

        void LoadBinding()
        {
            txtHoTen.DataBindings.Add(new Binding("Text", dvKhachHang.DataSource, "Ten", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dvKhachHang.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtSdt.DataBindings.Add(new Binding("Text", dvKhachHang.DataSource, "Sdt", true, DataSourceUpdateMode.Never));
            txtEmail.DataBindings.Add(new Binding("Text", dvKhachHang.DataSource, "Email", true, DataSourceUpdateMode.Never));
        }

        private void frm_DoiTac_NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDS();
        }

        private void dvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtHoTen.Text;
            string dc = txtDiaChi.Text;
            string sdt = txtSdt.Text;
            string email = txtEmail.Text;

            if (String.IsNullOrEmpty(ten) || String.IsNullOrEmpty(dc) || String.IsNullOrEmpty(sdt) || String.IsNullOrEmpty(email))
            {
                MessageBox.Show("Nhập đủ thông tin");
                return;
            }

            if (NhaCungCap_BUS.KiemTra(ten))
            {
                MessageBox.Show("Tên này có rồi");
                return;
            }

            NhaCungCap_DTO ncc = new NhaCungCap_DTO()
            {
                Id = 0,
                Ten = ten,
                DiaChi = dc,
                Sdt = sdt,
                Email = email
            };
            if (NhaCungCap_BUS.Them(ncc))
            {
                MessageBox.Show("Thêm được rồi");
                LoadDS();
                return;
            }

            MessageBox.Show("Thêm hông được");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dvKhachHang.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Chọn rồi mới sửa");
                return;
            }

            if (NhaCungCap_BUS.KiemTra(txtHoTen.Text))
            {
                MessageBox.Show("Tên này có rồi á");
                return;
            }

            int Id = Convert.ToInt32(row.Cells[0].Value);
            NhaCungCap_DTO ncc = new NhaCungCap_DTO()
            {
                Id = 0,
                Ten = txtHoTen.Text,
                DiaChi = txtDiaChi.Text,
                Sdt = txtSdt.Text,
                Email = txtEmail.Text
            };
            if (NhaCungCap_BUS.Sua(Id, ncc))
            {
                MessageBox.Show("Sửa được luôn");
                LoadDS();
                return;
            }

            MessageBox.Show("Sửa không được rồi");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";

            dvKhachHang.ClearSelection();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dvKhachHang.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Chọn rồi hả xóa ");
                return;
            }

            int Id = Convert.ToInt32(row.Cells[0].Value);

            if (NhaCungCap_BUS.Xoa(Id))
            {
                MessageBox.Show("Xóa được rồi á");
                LoadDS();
                return;
            }

            MessageBox.Show("Xóa thất bại rồi");
        }
    }
}
