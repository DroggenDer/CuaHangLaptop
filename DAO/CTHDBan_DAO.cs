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
    public class CTHDBan_DAO
    {
        static SqlConnection con;
        public static List<CTHDBan_DTO> LayDS(int id)
        {
            string query = @"Select * from ChiTietHDB where idHDB = " + id;


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<CTHDBan_DTO> lstCTHD = new List<CTHDBan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CTHDBan_DTO ct = new CTHDBan_DTO();
                ct.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                ct.Laptop = Laptop_DAO.LayLaptop(Convert.ToInt32(dt.Rows[i]["IdLaptop"]));
                ct.SoLuong = Convert.ToInt32(dt.Rows[i]["SoLuong"]);
                ct.DonGiaBan = Convert.ToInt32(dt.Rows[i]["DonGiaBan"]);
                ct.KhuyenMai = Convert.ToDouble(dt.Rows[i]["KhuyenMai"]);
                ct.ThanhTien = Convert.ToInt32(dt.Rows[i]["ThanhTien"]);
                lstCTHD.Add(ct);
            }

            return lstCTHD;
        }

        public static bool XoaTatCa(int id)
        {
            string sTruyVan = String.Format(@"delete ChitietHDB where idhdb = {0}", id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Xoa(int id)
        {
            string sTruyVan = String.Format(@"delete ChitietHDB where id = {0}", id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Them(CTHDBan_DTO cthd, int idhd)
        {
            string sTruyVan = String.Format(@"insert into ChiTietHDB values({0}, {1}, {2}, {3}, {4}, {5})",
                                    idhd, cthd.Laptop.Id, cthd.SoLuong, cthd.DonGiaBan, cthd.KhuyenMai, cthd.ThanhTien);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
