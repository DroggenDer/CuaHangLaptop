using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoan_BUS
    {
        public static TaiKhoan_DTO layTaiKhoan(string sTen, string sMatKhau)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = TaiKhoan_BUS.getMD5Hash(md5Hash, sMatKhau);
            return TaiKhoan_DAO.layTaiKhoan(sTen, matkhauMH);
        }

        public static bool DoiMatKhau(TaiKhoan_DTO nd, string mkMoi)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = TaiKhoan_BUS.getMD5Hash(md5Hash, mkMoi);
            return TaiKhoan_DAO.DoiMatKhau(nd, matkhauMH);
        }




        private static string getMD5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static void Them(int manv, string ten)
        {
            TaiKhoan_DAO.Them(manv, ten);
        }
    }
}
