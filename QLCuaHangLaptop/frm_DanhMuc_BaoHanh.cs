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
    public partial class frm_DanhMuc_BaoHanh : Form
    {
        int rowIndex;
        BindingSource LstBindin = new BindingSource();

        public frm_DanhMuc_BaoHanh()
        {
            InitializeComponent();
            dvTinhTrang.DataSource = LstBindin;
            LoadDS();
            LoadBinding();
        }

        void LoadDS()
        {
            List<BaoHanh_DTO> listTinhTrang = BaoHanh_BUS.LayDS();
            LstBindin.DataSource = listTinhTrang;
        }

        void LoadBinding()
        {
            txtTenTinhTrang.DataBindings.Add(new Binding("Text", dvTinhTrang.DataSource, "TenBaoHanh", true, DataSourceUpdateMode.Never));
        }

        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string tenTT = txtTenTinhTrang.Text;

            if (String.IsNullOrEmpty(tenTT))
            {
                MessageBox.Show("Nhập thời hạn bảo hành cho sản phẩm trước!");
                return;
            }

            if (BaoHanh_BUS.KiemTra(tenTT))
            {
                MessageBox.Show("Bảo hành đã tồn tại");
                return;
            }

            if (BaoHanh_BUS.ThemTinhTrang(tenTT))
            {
                MessageBox.Show("Thêm được rồi");
                LoadDS();
                return;
            }

            MessageBox.Show("Thêm hông được!");
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dvTinhTrang.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Chọn đi rồi mới sửa được");
                return;
            }

            if (BaoHanh_BUS.KiemTra(txtTenTinhTrang.Text))
            {
                MessageBox.Show("Trạng thái bảo hành của sản phẩm đã tồn tại rồi");
                return;
            }

            int Id = Convert.ToInt32(row.Cells[0].Value);
            if (BaoHanh_BUS.SuaTinhTrang(Id, txtTenTinhTrang.Text))
            {
                MessageBox.Show("Sửa được rồi");
                LoadDS();
                return;
            }

            MessageBox.Show("Sửa không được");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dvTinhTrang.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Chọn trước khi xóa ");
                return;
            }

            int Id = Convert.ToInt32(row.Cells[0].Value);
            if (BaoHanh_BUS.Xoa(Id))
            {
                MessageBox.Show("Xóa thành công rồi nè");
                LoadDS();
                return;
            }


            MessageBox.Show("Xóa thất bại ! Do mục bảo hành này này đã có Laptop!");
        }

        private void dvTinhTrang_CellClick_2(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void frm_DanhMuc_BaoHanh_Load(object sender, EventArgs e)
        {
            LoadDS();
        }
    }
}
