using DTO;
using Microsoft.Reporting.WinForms;
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
    public partial class ReportNhap : Form
    {
        public List<HDNhapHang> lstHDNH;
        public ReportNhap(List<HDNhapHang> lstHDNhaHang)
        {
            InitializeComponent();
            this.lstHDNH = lstHDNhaHang;
        }

        private void ReportNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyCuaHangLaptopDataSet.ChiTietHDN' table. You can move, or remove it, as needed.
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            var source = new ReportDataSource("DataSetInCTHDNhap", lstHDNH);
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
