using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BUS
{
    public class KhachHang_BUS
    {
        public static List<KhachHang_DTO> LayDS()
        {
            return KhachHang_DAO.LayDS();
        }

        public static bool KiemTra(string tenTT)
        {
            return KhachHang_DAO.KiemTra(tenTT);
        }

        public static bool Them(KhachHang_DTO tenTT)
        {
            return KhachHang_DAO.Them(tenTT);
        }

        public static bool Sua(int id, KhachHang_DTO ncc)
        {
            return KhachHang_DAO.Sua(id, ncc);
        }

        public static bool Xoa(int id)
        {
            return KhachHang_DAO.Xoa(id);
        }
    }
}
