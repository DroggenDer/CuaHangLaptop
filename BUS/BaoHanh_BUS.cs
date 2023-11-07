using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BaoHanh_BUS
    {
        public static List<BaoHanh_DTO> LayDS()
        {
            return BaoHanh_DAO.LayDS();
        }

        public static bool KiemTra(string tenTT)
        {
            return BaoHanh_DAO.KiemTra(tenTT);
        }

        public static bool ThemTinhTrang(string tenTT)
        {
            return BaoHanh_DAO.Them(tenTT);
        }

        public static bool SuaTinhTrang(int id, string text)
        {
            return BaoHanh_DAO.Sua(id, text);
        }

        public static bool Xoa(int id)
        {
            return BaoHanh_DAO.Xoa(id);
        }
    }
}
