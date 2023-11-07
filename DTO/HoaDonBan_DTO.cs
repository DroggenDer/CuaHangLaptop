
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonBan_DTO
    {
        private int _Id;
        private DateTime _NgayBan;
        private NhanVien_DTO _NhanVien;
        private KhachHang_DTO _KhachHang;
        private List<CTHDBan_DTO> _ChiTiet;

        public int Id { get => _Id; set => _Id = value; }
        public DateTime NgayBan { get => _NgayBan; set => _NgayBan = value; }
        public NhanVien_DTO NhanVien { get => _NhanVien; set => _NhanVien = value; }
        public KhachHang_DTO KhachHang { get => _KhachHang; set => _KhachHang = value; }
        public List<CTHDBan_DTO> ChiTiet { get => _ChiTiet; set => _ChiTiet = value; }
    }
}
