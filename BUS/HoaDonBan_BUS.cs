using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBan_BUS
    {
        public static bool Them(HoaDonBan_DTO hd)
        {
            return HoaDonBan_DAO.Them(hd);
        }

        public static HoaDonBan_DTO Lay(int? p)
        {
            return HoaDonBan_DAO.Lay(p);
        }

        public static bool Xoa(int id)
        {
            return HoaDonBan_DAO.Xoa(id);
        }

        public static List<HoaDonBan_DTO> LayDS(DateTime d1, DateTime d2)
        {
            return HoaDonBan_DAO.LayDS(d1,d2);
        }
    }
}
