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
    public partial class frm_QuanLy_ThongKe : Form
    {

        List<HoaDonNhap_DTO> lstNhap;
        List<HoaDonBan_DTO> lstBan;
        DateTime d1, d2;

        private void frm_QuanLy_ThongKe_Load(object sender, EventArgs e)
        {
            dp2.Value = DateTime.Today;
            dp1.Value = DateTime.Today.AddDays(-DateTime.Today.Day + 1);
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            d1 = dp1.Value;
            d2 = dp2.Value.AddDays(1);
            dgvNhap.DataSource = lstNhap = HoaDonNhap_BUS.LayDS(d1, d2);
            dgvXuat.DataSource = lstBan = HoaDonBan_BUS.LayDS(d1, d2);

            dgvNhap.CellFormatting += dgvNhap_CellFormatting;
            dgvXuat.CellFormatting += dgvXuat_CellFormatting;
        }

        private void dgvXuat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                NhanVien_DTO th = e.Value as NhanVien_DTO;
                if (th == null)
                {
                    return;
                }
                e.Value = th.Holot + " " + th.Ten;
            }

            if (e.ColumnIndex == 3)
            {
                KhachHang_DTO th = e.Value as KhachHang_DTO;
                if (th == null)
                {
                    return;
                }
                e.Value = th.HoLot + " " + th.Ten;
            }

        }

        private void dgvNhap_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                NhanVien_DTO th = e.Value as NhanVien_DTO;
                if (th == null)
                {
                    return;
                }
                e.Value = th.Holot + " " + th.Ten;
            }

            if (e.ColumnIndex == 3)
            {
                NhaCungCap_DTO th = e.Value as NhaCungCap_DTO;
                if (th == null)
                {
                    return;
                }
                e.Value = th.Ten;
            }
        }

        public frm_QuanLy_ThongKe()
        {
            InitializeComponent();
        }

        
    }
}
