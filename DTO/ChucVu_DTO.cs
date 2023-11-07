using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChucVu_DTO
    {
        private int _Id;
        private string _TenChucVu;

        public int Id { get => _Id; set => _Id = value; }
        public string TenChucVu { get => _TenChucVu; set => _TenChucVu = value; }
    }
}
