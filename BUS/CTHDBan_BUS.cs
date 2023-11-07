using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CTHDBan_BUS
    {
        public static List<CTHDBan_DTO> LayDS(int id)
        {
            return CTHDBan_DAO.LayDS(id);
        }

        public static bool Them(CTHDBan_DTO cthd, int idhd)
        {
            return CTHDBan_DAO.Them(cthd, idhd);
        }

        public static bool Xoa(int id)
        {
            return CTHDBan_DAO.Xoa(id);
        }

        public static bool XoaTatCa(int id)
        {
            return CTHDBan_DAO.XoaTatCa(id);
        }
    }
}
