using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonNhap_BUS
    {
        public static bool Them(HoaDonNhap_DTO hd)
        {
            return HoaDonNhap_DAO.Them(hd);
        }

        public static HoaDonNhap_DTO Lay(int? p)
        {
            return HoaDonNhap_DAO.Lay(p);
        }

        public static bool Xoa(int id)
        {
            return HoaDonNhap_DAO.Xoa(id);
        }

        public static List<HoaDonNhap_DTO> LayDS(DateTime d1, DateTime d2)
        {
            return HoaDonNhap_DAO.LayDS(d1,d2);
        }
    }
}
