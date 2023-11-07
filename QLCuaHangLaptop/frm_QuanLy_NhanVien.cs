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
    public partial class frm_QuanLy_NhanVien : Form
    {
        int rowIndex;
        BindingSource LstBindin = new BindingSource();

        public frm_QuanLy_NhanVien()
        {
            InitializeComponent();
            dgvNhanVien.DataSource = LstBindin;
            LoadDS();
            LoadBinding();
            LoadCbbChucVu();
        }

        void LoadCbbChucVu()
        {
            List<ChucVu_DTO> listcv = ChucVu_BUS.LayDS();
            cbChucVu.DataSource = listcv;
            cbChucVu.DisplayMember = "TenChucVu";
            cbChucVu.ValueMember = "id";
        }

        void LoadDS()
        {
            List<NhanVien_DTO> listTinhTrang = NhanVien_BUS.LayDS();
            LstBindin.DataSource = listTinhTrang;

        }

        void LoadBinding()
        {
            txtHo.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "HoLot", true, DataSourceUpdateMode.Never));
            txtTen.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "Ten", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txtSdt.DataBindings.Add(new Binding("Text", dgvNhanVien.DataSource, "Sdt", true, DataSourceUpdateMode.Never));
            dpNamSinh.DataBindings.Add(new Binding("Value", dgvNhanVien.DataSource, "NamSinh", true, DataSourceUpdateMode.Never));
            //cbChucVu.DataBindings.Add(new Binding("Value", dgvNhanVien.DataSource, "TenChucVu", true, DataSourceUpdateMode.Never));
        }

        private void frm_QuanLy_NhanVien_Load(object sender, EventArgs e)
        {
            LoadDS();
            dgvNhanVien.CellFormatting += dgvNhanVien_CellFormatting;
        }

        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                ChucVu_DTO x = e.Value as ChucVu_DTO;
                if (x == null)
                {
                    return;
                }
                e.Value = x.TenChucVu;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string dc = txtDiaChi.Text;
            string sdt = txtSdt.Text;

            if (String.IsNullOrEmpty(ho) || String.IsNullOrEmpty(ten) || String.IsNullOrEmpty(dc) || String.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Nhập thông tin vô đi");
                return;
            }

            NhanVien_DTO kh = new NhanVien_DTO()
            {
                Manv = 0,
                Holot = ho,
                Ten = ten,
                Diachi = dc,
                GioiTinh = rdnNam.Checked ? "Nam" : "Nữ",
                NamSinh = dpNamSinh.Value,
                Sdt = sdt,
                ChucVu = (cbChucVu.SelectedItem as ChucVu_DTO)
            };
            if (NhanVien_BUS.Them(kh))
            {
                //them taikhoan
                MessageBox.Show("Thêm được rồi");
                LoadDS();
                return;
            }

            MessageBox.Show("Thêm hông được");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNhanVien.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Chọn đi rồi sửa sau");
                return;
            }
            string ho = txtHo.Text;
            string ten = txtTen.Text;
            string dc = txtDiaChi.Text;
            string sdt = txtSdt.Text;

            if (String.IsNullOrEmpty(ho) || String.IsNullOrEmpty(ten) || String.IsNullOrEmpty(dc) || String.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Nhập thông tin vô");
                return;
            }
            int Id = Convert.ToInt32(row.Cells[0].Value);
            NhanVien_DTO ncc = new NhanVien_DTO()
            {
                Manv = 0,
                Holot = ho,
                Ten = ten,
                Diachi = dc,
                GioiTinh = rdnNam.Checked ? "Nam" : "Nữ",
                NamSinh = dpNamSinh.Value,
                Sdt = sdt,
                ChucVu = (cbChucVu.SelectedItem as ChucVu_DTO)
            };
            if (NhanVien_BUS.Sua(Id, ncc))
            {
                MessageBox.Show("Sửa được rồi");
                LoadDS();
                return;
            }

            MessageBox.Show("Sửa không được");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtHo.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSdt.Text = "";

            dgvNhanVien.ClearSelection();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNhanVien.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Chọn đi rồi xóa nhe");
                return;
            }

            int Id = Convert.ToInt32(row.Cells[0].Value);

            if (NhanVien_BUS.Xoa(Id))
            {
                MessageBox.Show("Xóa được rồi nè");
                LoadDS();
                return;
            }

            MessageBox.Show("Xóa không được hu");
        }
    }
}
