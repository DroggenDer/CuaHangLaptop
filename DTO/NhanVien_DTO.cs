using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private int _Manv;
        private string _Holot;
        private string _Ten;
        private string _Diachi;
        private string _GioiTinh;
        private DateTime _NamSinh;
        private string _Sdt;

        public int Manv { get => _Manv; set => _Manv = value; }
        public string Holot { get => _Holot; set => _Holot = value; }
        public string Ten { get => _Ten; set => _Ten = value; }
        public string Diachi { get => _Diachi; set => _Diachi = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public DateTime NamSinh { get => _NamSinh; set => _NamSinh = value; }
        public string Sdt { get => _Sdt; set => _Sdt = value; }

        public ChucVu_DTO ChucVu { get; set; }
    }
}
