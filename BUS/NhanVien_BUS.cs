using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVien_BUS
    {
        public static List<NhanVien_DTO> LayDS()
        {
            return NhanVien_DAO.LayDS();
        }

        public static bool Them(NhanVien_DTO tenTT)
        {
            return NhanVien_DAO.Them(tenTT);
        }

        public static bool Sua(int id, NhanVien_DTO ncc)
        {
            return NhanVien_DAO.Sua(id, ncc);
        }

        public static bool Xoa(int id)
        {
            return NhanVien_DAO.Xoa(id);
        }
    }
}
