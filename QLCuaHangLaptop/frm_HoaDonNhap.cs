﻿using BUS;
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

    public partial class frm_HoaDonNhap : Form
    {
        private HoaDonNhap_DTO hd;
        private CTHDNhap_DTO cthd;

        private List<Laotop_DTO> ListLaptop;
        private List<CTHDNhap_DTO> ListCTHD;
        BindingSource ListKho = new BindingSource();
        bool firstTimeBiding = true;

        int indexSelectedLaptop = -1;
        int indexCTHD = -1;

        public frm_HoaDonNhap()
        {
            InitializeComponent();
        }

        void LoadCBB()
        {
            cbNCC.DataSource = NhaCungCap_BUS.LayDS();
            cbNCC.DisplayMember = "Ten";
            cbNCC.ValueMember = "Id";
        }

       

        void LoadCTHD()
        {
            dgvCTHD.DataSource = ListCTHD = CTHDNhap_BUS.LayDS(hd.Id);
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
            txtTen.DataBindings.Add(new Binding("Text", dgvKho.DataSource, "TenLaptop", true, DataSourceUpdateMode.Never));
            txtGiaNhap.DataBindings.Add(new Binding("Text", dgvKho.DataSource, "GiaNhap", true, DataSourceUpdateMode.Never));
        }


        void TinhThanhTien()
        {
            int soluong = (int)numSl.Value;
            int gianhap = 0;
            Int32.TryParse(txtGiaNhap.Text, out gianhap);

            double khuyenmai = 0;
            Double.TryParse(txtKM.Text, out khuyenmai);
            if (khuyenmai >= 100)
            {
                khuyenmai = 0;
                txtKM.Text = "" + 0;
            }

            int thanhTien = gianhap * soluong - (int)(gianhap * soluong * khuyenmai / 100);

            txtTT.Text = thanhTien + "";
        }
        
       



        private void btnTaoHD_Click_1(object sender, EventArgs e)
        {
            hd = new HoaDonNhap_DTO();

            hd.Id = 0;
            hd.NgayNhap = DateTime.Now;
            hd.NhanVien = Main.TaiKhoan.NhanVien;
            hd.NhaCungCap = cbNCC.SelectedItem as NhaCungCap_DTO;
            

            if (HoaDonNhap_BUS.Them(hd))
            {
                MessageBox.Show("Thêm thành công luôn");
                hd = HoaDonNhap_BUS.Lay(null);

                txtMahd.Text = hd.Id.ToString();
                txtNgayLap.Text = hd.NgayNhap.ToString();
                txtNhanVien.Text = hd.NhanVien.Manv + " - " + hd.NhanVien.Holot + " " + hd.NhanVien.Ten;

                ThemHD(false);
                LoadKho();
            }
        }

        //action cho btn them
        void ThemHD(bool b)
        {
            cbNCC.Enabled = b;
            btnTaoHD.Enabled = b;
            btnLuuHD.Enabled = !b;
            btnXoaHD.Enabled = !b;
            btnTim.Enabled = !b;
            btnThem.Enabled = !b;
        }

        private void btnLuuHD_Click_1(object sender, EventArgs e)
        {
            ThemHD(true);

            List<HDNhapHang> lstHDNhapHang = InCTHDNhap_BUS.LayDSCTHD(int.Parse(txtMahd.Text));
            new ReportNhap(lstHDNhapHang).ShowDialog();

            txtMahd.Text = "";
            txtNgayLap.Text = "";
            txtNhanVien.Text = "";
            dgvCTHD.DataSource = null;

            
        }

        private void frm_HoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadCBB();
            dgvKho.DataSource = ListKho;
        }

        private void btnXoaHD_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa hóa đơn này không ?", "Cảnh báo", MessageBoxButtons.OKCancel);

            if (result == DialogResult.Cancel)
                return;

            //xoa tat ca chitiethd
            if (!CTHDNhap_BUS.XoaTatCa(hd.Id))
            {
                MessageBox.Show("Lỗi");
                return;
            }

            //hoan slton ve kho
            foreach (CTHDNhap_DTO ct in ListCTHD)
            {
                Laptop_BUS.CapNhatKho(-ct.SoLuong, cthd.DonGiaNhap, ct.Laptop.Id);
                LoadKho();
            }

            if (HoaDonNhap_BUS.Xoa(hd.Id))
            {
                MessageBox.Show("Đã xóa rồi á");
                ThemHD(true);
                txtMahd.Text = "";
                txtNgayLap.Text = "";
                txtNhanVien.Text = "";
                dgvCTHD.DataSource = null;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CTHDNhap_DTO ct = ListCTHD[indexCTHD];
            if (ct != null)
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa '" + ct.Laptop.TenLaptop + "' khỏi hóa đơn '" + hd.Id + "' không ?", "Cảnh báo", MessageBoxButtons.OKCancel);

                if (result == DialogResult.Cancel)
                    return;

                //xoa chitiethd
                if (CTHDNhap_BUS.Xoa(ct.Id))
                {
                    MessageBox.Show("Đã bị xóa rồi");
                    LoadCTHD();

                    //hoan tac sl kho
                    Laptop_BUS.CapNhatKho(-ct.SoLuong, cthd.DonGiaNhap, ct.Laptop.Id);
                    LoadKho();
                }
            }
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            ListKho.DataSource = ListLaptop = Laptop_BUS.LayDS(txtTim.Text);

            dgvKho.Columns["ThuongHieu"].Visible = false;
            dgvKho.Columns["KichThuoc"].Visible = false;
            dgvKho.Columns["TinhTrang"].Visible = false;
            dgvKho.Columns["BaoHanh"].Visible = false;
            dgvKho.Columns["GiaBan"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtId.Text) || indexSelectedLaptop == -1)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
                return;
            }

            cthd = new CTHDNhap_DTO()
            {
                Id = 0,
                Laptop = ListLaptop[indexSelectedLaptop],
                SoLuong = (int)numSl.Value,
                DonGiaNhap = Convert.ToInt32(txtGiaNhap.Text),
                KhuyenMai = Convert.ToDouble(txtKM.Text),
                ThanhTien = Convert.ToInt32(txtTT.Text)
            };

            //them ne
            if (CTHDNhap_BUS.Them(cthd, hd.Id))
            {
                MessageBox.Show("Thêm thành công rồi á");
                LoadCTHD();

                //caap nhat so luong trong kho va don gia nhap
                Laptop_BUS.CapNhatKho(cthd.SoLuong, cthd.DonGiaNhap, cthd.Laptop.Id);
                LoadKho();
            }
        }

        private void dgvKho_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexSelectedLaptop = e.RowIndex;
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

        private void numSl_ValueChanged_1(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtGiaNhap_TextChanged_1(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtKM_TextChanged_1(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtTim_Click_1(object sender, EventArgs e)
        {
            if (txtTim.Text == "Mã / Tên sản phẩm")
                txtTim.Text = "";
        }

        private void dgvCTHD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexCTHD = e.RowIndex;
        }
    }
}
