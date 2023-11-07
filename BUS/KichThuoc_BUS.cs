using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KichThuoc_BUS
    {
        public static List<KichThuoc_DTO> LayDS()
        {
            return KichThuoc_DAO.LayDS();
        }

        public static bool KiemTra(string tenTT)
        {
            return KichThuoc_DAO.KiemTra(tenTT);
        }

        public static bool ThemTinhTrang(string tenTT)
        {
            return KichThuoc_DAO.Them(tenTT);
        }

        public static bool SuaTinhTrang(int id, string text)
        {
            return KichThuoc_DAO.Sua(id, text);
        }

        public static bool Xoa(int id)
        {
            return KichThuoc_DAO.Xoa(id);
        }
    }
}
