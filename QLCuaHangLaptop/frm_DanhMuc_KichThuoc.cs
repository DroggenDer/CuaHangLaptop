using BUS;
using DevExpress.XtraExport;
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
    public partial class frm_DanhMuc_KichThuoc : Form
    {
        int rowIndex;
        BindingSource LstBindin = new BindingSource();

        public frm_DanhMuc_KichThuoc()
        {
            InitializeComponent();
            dvKichThuoc.DataSource = LstBindin;
            LoadDS();
            LoadBinding();
        }

        void LoadDS()
        {
            List<KichThuoc_DTO> listTinhTrang = KichThuoc_BUS.LayDS();
            LstBindin.DataSource = listTinhTrang;
        }

        void LoadBinding()
        {
            txtKichThuoc.DataBindings.Add(new Binding("Text", dvKichThuoc.DataSource, "TenKichThuoc", true, DataSourceUpdateMode.Never));
        }

        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string tenTT = txtKichThuoc.Text;

            if (String.IsNullOrEmpty(tenTT))
            {
                MessageBox.Show("Nhập tên vô đi nè");
                return;
            }

            if (KichThuoc_BUS.KiemTra(tenTT))
            {
                MessageBox.Show("Tên có rồi á");
                return;
            }

            if (KichThuoc_BUS.ThemTinhTrang(tenTT))
            {
                MessageBox.Show("Thêm được");
                LoadDS();
                return;
            }

            MessageBox.Show("Thêm hông được bà ơi");
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dvKichThuoc.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Chọn đi rồi sửa");
                return;
            }

            if (KichThuoc_BUS.KiemTra(txtKichThuoc.Text))
            {
                MessageBox.Show("Tên này có rồi mà");
                return;
            }

            int Id = Convert.ToInt32(row.Cells[0].Value);
            if (KichThuoc_BUS.SuaTinhTrang(Id, txtKichThuoc.Text))
            {
                MessageBox.Show("Sửa được rồi");
                LoadDS();
                return;
            }

            MessageBox.Show("Sửa không được luôn");
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = dvKichThuoc.Rows[rowIndex];

            if (row == null)
            {
                MessageBox.Show("Chọn trước đi rồi xóa");
                return;
            }

            int Id = Convert.ToInt32(row.Cells[0].Value);
            if (KichThuoc_BUS.Xoa(Id))
            {
                MessageBox.Show("Xóa được liền");
                LoadDS();
                return;
            }


            MessageBox.Show("Xóa thất bại hiu.. Do mục kích thước này này đã có Tivi!");
        }

        private void dvKichThuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void frm_DanhMuc_KichThuoc_Load(object sender, EventArgs e)
        {
            LoadDS();
        }
    }
}
