using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoan_DAO
    {
        static SqlConnection con;
        public static TaiKhoan_DTO layTaiKhoan(string sTen, string sMatKhau)
        {
            string query = @"select * from taikhoan where username = '" + sTen + "' and password = '" + sMatKhau + "'";
            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            //Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            TaiKhoan_DTO nd = new TaiKhoan_DTO();
            nd.TenDangNhap = dt.Rows[0]["username"].ToString();
            nd.MatKhau = dt.Rows[0]["password"].ToString();
            nd.NhanVien = NhanVien_DAO.LayNhanVien(dt.Rows[0]["Manv"].ToString());

            return nd;
        }

        public static bool DoiMatKhau(TaiKhoan_DTO nd, string mkMoi)
        {
            string query = @"update taikhoan set password = '" + mkMoi + "' where username = '" + nd.TenDangNhap + "'";
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(query, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static void Them(int manv, string ten)
        {
            string sTruyVan = String.Format(@"insert into taikhoan values('{0}', '{1}', '{2}')", manv, ten, "e99a18c428cb38d5f260853678922e03");
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
        }
    }
}
