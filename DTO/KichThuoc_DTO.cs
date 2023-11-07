using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KichThuoc_DTO
    {
        private int _Id;
        private string _TenTinhTrang;

        public int Id { get => _Id; set => _Id = value; }
        public string TenKichThuoc { get => _TenTinhTrang; set => _TenTinhTrang = value; }
    }
}
