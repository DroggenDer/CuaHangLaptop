using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HDNhapHang
    {
        private string tenLapTop;
        private int _SoLuong;
        private int _DonGiaNhap;
        private double _KhuyenMai;
        private int _ThanhTien;
        private string tenNCC;
        private int sdtNCC;
        private string diaChiNCC;

        public string TenLapTop { get => tenLapTop; set => tenLapTop = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public int DonGiaNhap { get => _DonGiaNhap; set => _DonGiaNhap = value; }
        public double KhuyenMai { get => _KhuyenMai; set => _KhuyenMai = value; }
        public int ThanhTien { get => _ThanhTien; set => _ThanhTien = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public int SdtNCC { get => sdtNCC; set => sdtNCC = value; }
        public string DiaChiNCC { get => diaChiNCC; set => diaChiNCC = value; }
    }
}
