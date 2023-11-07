using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ThuongHieu_BUS
    {
        public static List<ThuongHieu_DTO> LayDSTH()
        {
            return ThuongHieu_DAO.LayDS();
        }

        public static bool KiemTra(string tenTT)
        {
            return ThuongHieu_DAO.KiemTra(tenTT);
        }

        public static bool ThemTinhTrang(string tenTT)
        {
            return ThuongHieu_DAO.Them(tenTT);
        }

        public static bool SuaTinhTrang(int id, string text)
        {
            return ThuongHieu_DAO.Sua(id, text);
        }

        public static bool Xoa(int id)
        {
            return ThuongHieu_DAO.Xoa(id);
        }
    }
}
