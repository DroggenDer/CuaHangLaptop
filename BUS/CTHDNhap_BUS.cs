using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CTHDNhap_BUS
    {
        public static List<CTHDNhap_DTO> LayDS(int id)
        {
            return CTHDNhap_DAO.LayDS(id);
        }

        public static bool Them(CTHDNhap_DTO cthd, int idhd)
        {
            return CTHDNhap_DAO.Them(cthd, idhd);
        }

        public static bool Xoa(int id)
        {
            return CTHDNhap_DAO.Xoa(id);
        }

        public static bool XoaTatCa(int id)
        {
            return CTHDNhap_DAO.XoaTatCa(id);
        }
    }
}
