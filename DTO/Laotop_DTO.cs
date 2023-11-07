using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Laotop_DTO
    {
        private int _Id;
        private string _TenLaptop;
        private ThuongHieu_DTO _ThuongHieu;
        private KichThuoc_DTO _KichThuoc;
        private BaoHanh_DTO _BaoHanh;
        private TinhTrang_DTO _TinhTrang;
        private int _GiaNhap = 0;
        private int _GiaBan = 0;
        private int _Slton = 0;

        public int Id { get => _Id; set => _Id = value; }
        public string TenLaptop { get => _TenLaptop; set => _TenLaptop = value; }
        public ThuongHieu_DTO ThuongHieu { get => _ThuongHieu; set => _ThuongHieu = value; }
        public KichThuoc_DTO KichThuoc { get => _KichThuoc; set => _KichThuoc = value; }
        public BaoHanh_DTO BaoHanh { get => _BaoHanh; set => _BaoHanh = value; }
        public TinhTrang_DTO TinhTrang { get => _TinhTrang; set => _TinhTrang = value; }
        public int GiaNhap { get => _GiaNhap; set => _GiaNhap = value; }
        public int GiaBan { get => _GiaBan; set => _GiaBan = value; }
        public int Slton { get => _Slton; set => _Slton = value; }
       
    }
}
