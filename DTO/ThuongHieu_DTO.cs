using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThuongHieu_DTO
    {
        private int _Id;
        private string _TenThuongHieu;

        public int Id { get => _Id; set => _Id = value; }
        public string TenThuongHieu { get => _TenThuongHieu; set => _TenThuongHieu = value; }
    }
}
