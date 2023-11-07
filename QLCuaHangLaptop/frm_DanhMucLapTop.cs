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
    public partial class frm_DanhMucLapTop : Form
    {

        int rowIndex;
        BindingSource LstBinding = new BindingSource();
        List<Laotop_DTO> ListLaptop;
        public frm_DanhMucLapTop()
        {
            InitializeComponent();

            dgLaptop.DataSource = LstBinding;
            LoadDSChucVu();
            LoadBinding();

        }

        void LoadAllCombobox()
        {
            cbThuongHieu.DataSource = ThuongHieu_BUS.LayDSTH();
            cbBaoHanh.DataSource = BaoHanh_BUS.LayDS();
            cbKichThuoc.DataSource = KichThuoc_BUS.LayDS();
            cbTinhTrang.DataSource = TinhTrang_BUS.LayDSTinhTrang();

            cbTinhTrang.DisplayMember = "TenTinhTrang";
            cbBaoHanh.DisplayMember = "TenBaoHanh";
            cbKichThuoc.DisplayMember = "TenKichThuoc";
            cbThuongHieu.DisplayMember = "TenThuongHieu";

            cbThuongHieu.ValueMember = "Id";
            cbBaoHanh.ValueMember = "Id";
            cbKichThuoc.ValueMember = "Id";
            cbTinhTrang.ValueMember = "Id";
        }

        void LoadDSChucVu()
        {
            ListLaptop = Laptop_BUS.LayDS(null);

            LstBinding.DataSource = ListLaptop;

            dgLaptop.CellFormatting += dgLaptop_CellFormatting;
        }

        

        void LoadBinding()
        {
            txtTen.DataBindings.Add(new Binding("Text", dgLaptop.DataSource, "TenLaptop", true, DataSourceUpdateMode.Never));
            txtGiaNhap.DataBindings.Add(new Binding("Text", dgLaptop.DataSource, "GiaNhap", true, DataSourceUpdateMode.Never));
            txtGiaBan.DataBindings.Add(new Binding("Text", dgLaptop.DataSource, "GiaBan", true, DataSourceUpdateMode.Never));
            txtTonKho.DataBindings.Add(new Binding("Text", dgLaptop.DataSource, "Slton", true, DataSourceUpdateMode.Never));
        }

        

        

        

        

        

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDSChucVu();
            LoadAllCombobox();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string tenTT = txtTen.Text;

            if (String.IsNullOrEmpty(tenTT))
            {
                MessageBox.Show("Vui lòng nhập tên!");
                return;
            }

            Laotop_DTO laptop = new Laotop_DTO()
            {
                Id = 0,
                TenLaptop = tenTT,
                ThuongHieu = cbThuongHieu.SelectedItem as ThuongHieu_DTO,
                KichThuoc = cbKichThuoc.SelectedItem as KichThuoc_DTO,
                BaoHanh = cbBaoHanh.SelectedItem as BaoHanh_DTO,
                TinhTrang = cbTinhTrang.SelectedItem as TinhTrang_DTO,
                GiaNhap = Convert.ToInt32(txtGiaNhap.Text),
                GiaBan = Convert.ToInt32(txtGiaBan.Text)
            };

            if (Laptop_BUS.Them(laptop))
            {
                MessageBox.Show("Thêm thành công!");
                LoadDSChucVu();
                return;
            }

            MessageBox.Show("Thêm hông được!");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (Laptop_BUS.Xoa(ListLaptop[rowIndex].Id))
            {
                MessageBox.Show("Xóa được luôn");
                LoadDSChucVu();
                return;
            }

            MessageBox.Show("Xóa không được ");
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string tenTT = txtTen.Text;

            if (String.IsNullOrEmpty(tenTT))
            {
                MessageBox.Show("Vui lòng nhập tên!");
                return;
            }

            Laotop_DTO tivi = new Laotop_DTO()
            {
                Id = 0,
                TenLaptop = tenTT,
                ThuongHieu = cbThuongHieu.SelectedItem as ThuongHieu_DTO,
                KichThuoc = cbKichThuoc.SelectedItem as KichThuoc_DTO,
                BaoHanh = cbBaoHanh.SelectedItem as BaoHanh_DTO,
                TinhTrang = cbTinhTrang.SelectedItem as TinhTrang_DTO,

                GiaBan = Convert.ToInt32(txtGiaBan.Text),
            };


            if (Laptop_BUS.Sua(ListLaptop[rowIndex].Id, tivi))
            {
                MessageBox.Show("Sửa được rồi");
                LoadDSChucVu();
                return;
            }

            MessageBox.Show("Sửa thất bại!");
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            txtTen.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";

            dgLaptop.ClearSelection();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadDSChucVu();
            LoadAllCombobox();
        }

        private void frm_DanhMucLapTop_Load(object sender, EventArgs e)
        {
            LoadDSChucVu();
            LoadAllCombobox();
        }

        private void dgLaptop_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                ThuongHieu_DTO th = e.Value as ThuongHieu_DTO;
                if (th == null)
                {
                    return;
                }
                e.Value = th.TenThuongHieu;
            }

            if (e.ColumnIndex == 3)
            {
                KichThuoc_DTO th = e.Value as KichThuoc_DTO;
                if (th == null)
                {
                    return;
                }
                e.Value = th.TenKichThuoc;
            }

            if (e.ColumnIndex == 4)
            {
                BaoHanh_DTO th = e.Value as BaoHanh_DTO;
                if (th == null)
                {
                    return;
                }
                e.Value = th.TenBaoHanh;
            }

            if (e.ColumnIndex == 5)
            {
                TinhTrang_DTO th = e.Value as TinhTrang_DTO;
                if (th == null)
                {
                    return;
                }
                e.Value = th.TenTinhTrang;
            }
        }

        private void dgLaptop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            
        }
    }
}
