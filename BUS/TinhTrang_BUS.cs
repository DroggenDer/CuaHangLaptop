using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TinhTrang_BUS
    {
        public static List<TinhTrang_DTO> LayDSTinhTrang()
        {
            return TinhTrang_DAO.LayDSTinhTrang();
        }

        public static bool ThemTinhTrang(string tenTT)
        {
            return TinhTrang_DAO.ThemTinhTrang(tenTT);
        }

        public static bool SuaTinhTrang(int Id, string tenmoi)
        {
            return TinhTrang_DAO.Sua(Id, tenmoi);
        }

        public static bool KiemTra(string tenTT)
        {
            return TinhTrang_DAO.KiemTraTinhTrang(tenTT);
        }

        public static bool Xoa(int id)
        {
            return TinhTrang_DAO.Xoa(id);
        }
    }
}
