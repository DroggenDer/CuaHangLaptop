using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHDNhap_DTO
    {
        private int _Id;
        private Laotop_DTO _Laptop;
        private int _SoLuong;
        private int _DonGiaNhap;
        private double _KhuyenMai;
        private int _ThanhTien;

        public int Id { get => _Id; set => _Id = value; }
        public Laotop_DTO Laptop { get => _Laptop; set => _Laptop = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public int DonGiaNhap { get => _DonGiaNhap; set => _DonGiaNhap = value; }
        public double KhuyenMai { get => _KhuyenMai; set => _KhuyenMai = value; }
        public int ThanhTien { get => _ThanhTien; set => _ThanhTien = value; }
    }
}
