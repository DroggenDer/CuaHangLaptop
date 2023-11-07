using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoHanh_DTO
    {
        private int _Id;
        private string _TenTinhTrang;

        public int Id { get => _Id; set => _Id = value; }
        public string TenBaoHanh { get => _TenTinhTrang; set => _TenTinhTrang = value; }
    }
}
