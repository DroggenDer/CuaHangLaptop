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
    public partial class frm_DanhMuc_ThuongHieu : Form
    {
        int rowIndex;
        BindingSource LstBindin = new BindingSource();

        public frm_DanhMuc_ThuongHieu()
        {
            InitializeComponent();
            dvThuongHieu.DataSource = LstBindin;
            LoadDS();
            LoadBinding();
        }

        void LoadDS()
        {
            List<ThuongHieu_DTO> listTinhTrang = ThuongHieu_BUS.LayDSTH();
            LstBindin.DataSource = listTinhTrang;
        }

        void LoadBinding()
        {
            txtThuongHieu.DataBindings.Add(new Binding("Text", dvThuongHieu.DataSource, "TenThuongHieu", true, DataSourceUpdateMode.Never));
        }


        private void dvThuongHieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string tenTT = txtThuongHieu.Text;

            if (String.IsNullOrEmpty(tenTT))
            {
                MessageBox.Show("Nhập tên vô đi");
                return;
            }

            if (ThuongHieu_BUS.KiemTra(tenTT))
            {
                MessageBox.Show("Tên đã có rồi");
                return;
            }

            if (ThuongHieu_BUS.ThemTinhTrang(tenTT))
            {
                MessageBox.Show("Thêm được rồi nè");
                LoadDS();
                return;
            }

            MessageBox.Show("Thêm hông được");
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dvThuongHieu.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Chọn rồi mới sửa được");
                return;
            }

            if (ThuongHieu_BUS.KiemTra(txtThuongHieu.Text))
            {
                MessageBox.Show("Tên tồn tại rồi");
                return;
            }

            int Id = Convert.ToInt32(row.Cells[0].Value);
            if (ThuongHieu_BUS.SuaTinhTrang(Id, txtThuongHieu.Text))
            {
                MessageBox.Show("Sửa được rồi á");
                LoadDS();
                return;
            }

            MessageBox.Show("Sửa không được luôn");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dvThuongHieu.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Chọn đi rồi xóa");
                return;
            }

            int Id = Convert.ToInt32(row.Cells[0].Value);
            if (ThuongHieu_BUS.Xoa(Id))
            {
                MessageBox.Show("Xóa được rồi");
                LoadDS();
                return;
            }
            MessageBox.Show("Xóa thất bại rồi hu.. Do thương hiệu này này đã có Tivi!");
        }

        private void frm_DanhMuc_ThuongHieu_Load(object sender, EventArgs e)
        {
            LoadDS();
        }
    }
}
