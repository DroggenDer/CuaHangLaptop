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
    public partial class frm_DanhMuc_TinhTrang : Form
    {
        int rowIndex;
        BindingSource LstBindingTinhTrang = new BindingSource();
        public frm_DanhMuc_TinhTrang()
        {
            InitializeComponent();

            dvTinhTrang.DataSource = LstBindingTinhTrang;
            LoadDSTinhTrang();
            LoadBinding();

        }

        void LoadDSTinhTrang()
        {
            List<TinhTrang_DTO> listTinhTrang = TinhTrang_BUS.LayDSTinhTrang();
            LstBindingTinhTrang.DataSource = listTinhTrang;
        }

        void LoadBinding()
        {
            txtTenTinhTrang.DataBindings.Add(new Binding("Text", dvTinhTrang.DataSource, "TenTinhTrang", true, DataSourceUpdateMode.Never));
        }

        private void frm_DanhMuc_TinhTrang_Load(object sender, EventArgs e)
        {
            LoadDSTinhTrang();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string tenTT = txtTenTinhTrang.Text;

            if (String.IsNullOrEmpty(tenTT))
            {
                MessageBox.Show("Nhập tên mới được á");
                return;
            }

            if (TinhTrang_BUS.KiemTra(tenTT))
            {
                MessageBox.Show("Tên đã có rồi");
                return;
            }

            if (TinhTrang_BUS.ThemTinhTrang(tenTT))
            {
                MessageBox.Show("Thêm được rồi nè");
                LoadDSTinhTrang();
                return;
            }

            MessageBox.Show("Thêm hông được!");
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dvTinhTrang.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Chọn rồi mới sửa được");
                return;
            }

            if (TinhTrang_BUS.KiemTra(txtTenTinhTrang.Text))
            {
                MessageBox.Show("Tên có rồi á ");
                return;
            }

            int Id = Convert.ToInt32(row.Cells[0].Value);
            if (TinhTrang_BUS.SuaTinhTrang(Id, txtTenTinhTrang.Text))
            {
                MessageBox.Show("Sửa được rồi nè");
                LoadDSTinhTrang();
                return;
            }

            MessageBox.Show("Sửa thất bại");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dvTinhTrang.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Chọn rồi mới xóa được");
                return;
            }

            int Id = Convert.ToInt32(row.Cells[0].Value);
            if (TinhTrang_BUS.Xoa(Id))
            {
                MessageBox.Show("Xóa được rồi");
                LoadDSTinhTrang();
                return;
            }
            MessageBox.Show("Xóa thất bại, do mục tình trạng này đã có laptop!");
        }

        private void dvTinhTrang_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }
    }
}
