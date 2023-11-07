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
    public partial class frm_HoaDonBan : Form
    {
        public frm_HoaDonBan()
        {
            InitializeComponent();
        }

        private HoaDonBan_DTO hd;
        private CTHDBan_DTO cthd;

        private List<Laotop_DTO> ListLaptop;
        private List<CTHDBan_DTO> ListCTHD;
        BindingSource ListKho = new BindingSource();
        bool firstTimeBiding = true;

        int indexSelectedLaptop = -1;
        int indexCTHD = -1;

       

        void LoadCBB()
        {
            cbKhachHang.DataSource = KhachHang_BUS.LayDS();
            cbKhachHang.DisplayMember = "Ten";
            cbKhachHang.ValueMember = "Makh";
        }

        //action cho btn them
        void ThemHD(bool b)
        {
            cbKhachHang.Enabled = b;
            btnTaoHD.Enabled = b;
            btnLuuHD.Enabled = !b;
            btnXoaHD.Enabled = !b;
            btnTim.Enabled = !b;
            btnThem.Enabled = !b;
        }

        void LoadCTHD()
        {
            dgvCTHD.DataSource = ListCTHD = CTHDBan_BUS.LayDS(hd.Id);
            dgvCTHD.CellFormatting += dgvCTHD_CellFormatting_1;
        }


        //-------------kho
        void LoadKho()
        {
            ListKho.DataSource = ListLaptop = Laptop_BUS.LayDS(null);

            if (ListLaptop == null)
                return;

            dgvKho.Columns["ThuongHieu"].Visible = false;
            dgvKho.Columns["KichThuoc"].Visible = false;
            dgvKho.Columns["TinhTrang"].Visible = false;
            dgvKho.Columns["BaoHanh"].Visible = false;
            dgvKho.Columns["GiaBan"].Visible = false;

            if (firstTimeBiding)
            {
                AddBindingTextBox();
                firstTimeBiding = !firstTimeBiding;
            }
        }

        void AddBindingTextBox()
        {
            txtId.DataBindings.Add(new Binding("Text", dgvKho.DataSource, "Id", true, DataSourceUpdateMode.Never));
            txtTen.DataBindings.Add(new Binding("Text", dgvKho.DataSource, "TenLatop", true, DataSourceUpdateMode.Never));
            txtGiaBan.DataBindings.Add(new Binding("Text", dgvKho.DataSource, "GiaBan", true, DataSourceUpdateMode.Never));
        }


        void TinhThanhTien()
        {
            int soluong = (int)numSl.Value;
            int giaBan = 0;
            Int32.TryParse(txtGiaBan.Text, out giaBan);

            double khuyenmai = 0;
            Double.TryParse(txtKM.Text, out khuyenmai);
            if (khuyenmai >= 100)
            {
                khuyenmai = 0;
                txtKM.Text = "" + 0;
            }

            int thanhTien = giaBan * soluong - (int)(giaBan * soluong * khuyenmai / 100);

            txtTT.Text = thanhTien + "";
        }
        

        private void btnTaoHD_Click_1(object sender, EventArgs e)
        {
            hd = new HoaDonBan_DTO()
            {
                Id = 0,
                NgayBan = DateTime.Now,
                NhanVien = Main.TaiKhoan.NhanVien,
                KhachHang = cbKhachHang.SelectedItem as KhachHang_DTO
            };

            if (HoaDonBan_BUS.Them(hd))
            {
                MessageBox.Show("Thêm thành công rồi hi");
                hd = HoaDonBan_BUS.Lay(null);

                txtMahd.Text = hd.Id.ToString();
                txtNgayLap.Text = hd.NgayBan.ToString();
                txtNhanVien.Text = hd.NhanVien.Manv + " - " + hd.NhanVien.Holot + " " + hd.NhanVien.Ten;

                ThemHD(false);
                LoadKho();
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            CTHDBan_DTO ct = ListCTHD[indexCTHD];
            if (ct != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa '" + ct.Laptop.TenLaptop + "' khỏi hóa đơn '" + hd.Id + "' không ?", "Cảnh báo", MessageBoxButtons.OKCancel);

                if (result == DialogResult.Cancel)
                    return;

                //xoa chitiethd
                if (CTHDBan_BUS.Xoa(ct.Id))
                {
                    MessageBox.Show("Đã xóa rồi");
                    LoadCTHD();

                    //hoan tac sl kho
                    Laptop_BUS.CapNhatKho(ct.SoLuong, cthd.DonGiaBan, ct.Laptop.Id);
                    LoadKho();
                }
            }
        }


        private void dgvCTHD_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                Laotop_DTO th = e.Value as Laotop_DTO;
                if (th == null)
                {
                    return;
                }
                e.Value = th.TenLaptop;
            }
        }

        private void frm_HoaDonBan_Load(object sender, EventArgs e)
        {
            LoadCBB();
            dgvKho.DataSource = ListKho;
        }

        private void btnLuuHD_Click_1(object sender, EventArgs e)
        {
            ThemHD(true);
            txtMahd.Text = "";
            txtNgayLap.Text = "";
            txtNhanVien.Text = "";
            dgvCTHD.DataSource = null;
        }

        private void numSl_ValueChanged_2(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtKM_TextChanged_2(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtGiaBan_TextChanged_1(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtTim_Click_1(object sender, EventArgs e)
        {
            if (txtTim.Text == "Mã / Tên sản phẩm")
                txtTim.Text = "";
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            ListKho.DataSource = ListLaptop = Laptop_BUS.LayDS(txtTim.Text);

            dgvKho.Columns["ThuongHieu"].Visible = false;
            dgvKho.Columns["KichThuoc"].Visible = false;
            dgvKho.Columns["TinhTrang"].Visible = false;
            dgvKho.Columns["BaoHanh"].Visible = false;
            dgvKho.Columns["GiaNhap"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text) || indexSelectedLaptop == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
                return;
            }

            if (ListLaptop[indexSelectedLaptop].Slton < (int)numSl.Value)
            {
                MessageBox.Show("Cửa hàng không đủ số lượng Laptop này. Vui lòng chọn lại!");
                return;
            }

            cthd = new CTHDBan_DTO()
            {
                Id = 0,
                Laptop = ListLaptop[indexSelectedLaptop],
                SoLuong = (int)numSl.Value,
                DonGiaBan = Convert.ToInt32(txtGiaBan.Text),
                KhuyenMai = Convert.ToDouble(txtKM.Text),
                ThanhTien = Convert.ToInt32(txtTT.Text)
            };

            //them ne
            if (CTHDBan_BUS.Them(cthd, hd.Id))
            {
                MessageBox.Show("Thêm được rồi á");
                LoadCTHD();

                //caap nhat so luong trong kho va don gia Ban
                Laptop_BUS.CapNhatKho(-cthd.SoLuong, cthd.DonGiaBan, cthd.Laptop.Id);
                LoadKho();
            }
        }

        private void dgvKho_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexSelectedLaptop = e.RowIndex;
        }

        private void dgvCTHD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexCTHD = e.RowIndex;
        }

        private void btnXoaHD_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa hóa đơn này không ?", "Cảnh báo", MessageBoxButtons.OKCancel);

            if (result == DialogResult.Cancel)
                return;

            //xoa tat ca chitiethd
            if (!CTHDBan_BUS.XoaTatCa(hd.Id))
            {
                MessageBox.Show("Lỗi");
                return;
            }

            //hoan slton ve khoì
            foreach (CTHDBan_DTO ct in ListCTHD)
            {
                Laptop_BUS.CapNhatKho(ct.SoLuong, cthd.DonGiaBan, ct.Laptop.Id);
                LoadKho();
            }

            if (HoaDonBan_BUS.Xoa(hd.Id))
            {
                MessageBox.Show("Đã bị xóa");
                ThemHD(true);
                txtMahd.Text = "";
                txtNgayLap.Text = "";
                txtNhanVien.Text = "";
                dgvCTHD.DataSource = null;
            }
        }
    }
}
