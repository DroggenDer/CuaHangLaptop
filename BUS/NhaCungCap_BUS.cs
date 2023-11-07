using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCap_BUS
    {
        public static List<NhaCungCap_DTO> LayDS()
        {
            return NhaCungCap_DAO.LayDS();
        }

        public static bool KiemTra(string tenTT)
        {
            return NhaCungCap_DAO.KiemTra(tenTT);
        }

        public static bool Them(NhaCungCap_DTO tenTT)
        {
            return NhaCungCap_DAO.Them(tenTT);
        }

        public static bool Sua(int id, NhaCungCap_DTO ncc)
        {
            return NhaCungCap_DAO.Sua(id, ncc);
        }

        public static bool Xoa(int id)
        {
            return NhaCungCap_DAO.Xoa(id);
        }
    }
}
