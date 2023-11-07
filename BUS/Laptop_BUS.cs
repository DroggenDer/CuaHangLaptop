using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Laptop_BUS
    {
        public static List<Laotop_DTO> LayDS(string search)
        {
            return Laptop_DAO.LayDS(search);
        }

        public static bool Them(Laotop_DTO tenTT)
        {
            return Laptop_DAO.Them(tenTT);
        }

        public static bool Sua(int Id, Laotop_DTO tenmoi)
        {
            return Laptop_DAO.Sua(Id, tenmoi);
        }

        public static bool KiemTra(string tenTT)
        {
            return Laptop_DAO.KiemTra(tenTT);
        }

        public static bool Xoa(int id)
        {
            return Laptop_DAO.Xoa(id);
        }

        public static void CapNhatKho(int soLuong, int donGiaNhap, int id)
        {
            Laptop_DAO.CapNhatKho(soLuong, donGiaNhap, id);
        }
    }
}
