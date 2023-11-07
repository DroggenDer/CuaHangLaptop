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
    public partial class frm_QuanLy_ChucVu : Form
    {
        int rowIndex;
        BindingSource LstBindingChucVu = new BindingSource();
        public frm_QuanLy_ChucVu()
        {
            InitializeComponent();

            dvTinhTrang.DataSource = LstBindingChucVu;
            LoadDSChucVu();
            LoadBinding();

        }

        void LoadDSChucVu()
        {
            List<ChucVu_DTO> listChucVu = ChucVu_BUS.LayDS();
            LstBindingChucVu.DataSource = listChucVu;
        }

        void LoadBinding()
        {
            txtTenTinhTrang.DataBindings.Add(new Binding("Text", dvTinhTrang.DataSource, "TenChucVu", true, DataSourceUpdateMode.Never));
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            LoadDSChucVu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenTT = txtTenTinhTrang.Text;

            if (String.IsNullOrEmpty(tenTT))
            {
                MessageBox.Show("Vui lòng nhập tên!");
                return;
            }

            if (ChucVu_BUS.KiemTra(tenTT))
            {
                MessageBox.Show("Tên chức vụ đã tồn tại!");
                return;
            }

            if (ChucVu_BUS.Them(tenTT))
            {
                MessageBox.Show("Thêm thành công!");
                LoadDSChucVu();
                return;
            }

            MessageBox.Show("Thêm hông được!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dvTinhTrang.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Vui lòng chọn trước khi sửa!");
                return;
            }

            if (ChucVu_BUS.KiemTra(txtTenTinhTrang.Text))
            {
                MessageBox.Show("Tên chức vụ đã tồn tại!");
                return;
            }

            int Id = Convert.ToInt32(row.Cells[0].Value);
            if (ChucVu_BUS.Sua(Id, txtTenTinhTrang.Text))
            {
                MessageBox.Show("Sửa thành công!");
                LoadDSChucVu();
                return;
            }

            MessageBox.Show("Sửa thất bại!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dvTinhTrang.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Vui lòng chọn trước khi xóa!");
                return;
            }

            int Id = Convert.ToInt32(row.Cells[0].Value);
            if (ChucVu_BUS.Xoa(Id))
            {
                MessageBox.Show("Xóa thành công!");
                LoadDSChucVu();
                return;
            }


            MessageBox.Show("Xóa thất bại! Do chức vụ này đã có nhân viên!");
        }

        private void dvTinhTrang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }
    }
}
