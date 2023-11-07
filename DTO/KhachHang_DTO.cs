using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        private int _Makh;
        private string _HoLot;
        private string _Ten;
        private string _GioiTinh;
        private DateTime _NamSinh;
        private string _DiaChi;
        private string _Sdt;

        public int Makh { get => _Makh; set => _Makh = value; }
        public string HoLot { get => _HoLot; set => _HoLot = value; }
        public string Ten { get => _Ten; set => _Ten = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public DateTime NamSinh { get => _NamSinh; set => _NamSinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string Sdt { get => _Sdt; set => _Sdt = value; }
    }
}
