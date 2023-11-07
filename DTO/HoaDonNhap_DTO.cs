using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonNhap_DTO
    {
        private int _Id;
        private DateTime _NgayNhap;
        private NhanVien_DTO _NhanVien;
        private NhaCungCap_DTO _NhaCungCap;
        private List<CTHDNhap_DTO> _ChiTiet;

        public int Id { get => _Id; set => _Id = value; }
        public DateTime NgayNhap { get => _NgayNhap; set => _NgayNhap = value; }
        public NhanVien_DTO NhanVien { get => _NhanVien; set => _NhanVien = value; }
        public NhaCungCap_DTO NhaCungCap { get => _NhaCungCap; set => _NhaCungCap = value; }
        public List<CTHDNhap_DTO> ChiTiet { get => _ChiTiet; set => _ChiTiet = value; }
    }
}
