using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap_DTO
    {
        private int _Id;
        private string _Ten;
        private string _DiaChi;
        private string _Sdt;
        private string _Email;

        public int Id { get => _Id; set => _Id = value; }
        public string Ten { get => _Ten; set => _Ten = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string Sdt { get => _Sdt; set => _Sdt = value; }
        public string Email { get => _Email; set => _Email = value; }
        
    }
}
