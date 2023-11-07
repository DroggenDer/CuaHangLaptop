using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChucVu_BUS
    {
        public static List<ChucVu_DTO> LayDS()
        {
            return ChucVu_DAO.LayDS();
        }

        public static bool Them(string tenTT)
        {
            return ChucVu_DAO.Them(tenTT);
        }

        public static bool Sua(int Id, string tenmoi)
        {
            return ChucVu_DAO.Sua(Id, tenmoi);
        }

        public static bool KiemTra(string tenTT)
        {
            return ChucVu_DAO.KiemTra(tenTT);
        }

        public static bool Xoa(int id)
        {
            return ChucVu_DAO.Xoa(id);
        }
    }
}
