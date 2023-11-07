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
    public class CTHDNhap_DAO
    {
        static SqlConnection con;
        public static List<CTHDNhap_DTO> LayDS(int id)
        {
            string query = @"Select * from ChiTietHDN where idHDN = " + id;


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<CTHDNhap_DTO> lstCTHD = new List<CTHDNhap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                CTHDNhap_DTO ct = new CTHDNhap_DTO();
                ct.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                ct.Laptop = Laptop_DAO.LayLaptop(Convert.ToInt32(dt.Rows[i]["IdLaptop"]));
                ct.SoLuong = Convert.ToInt32(dt.Rows[i]["SoLuong"]);
                ct.DonGiaNhap = Convert.ToInt32(dt.Rows[i]["DonGiaNhap"]);
                ct.KhuyenMai = Convert.ToDouble(dt.Rows[i]["KhuyenMai"]);
                ct.ThanhTien = Convert.ToInt32(dt.Rows[i]["ThanhTien"]);
                lstCTHD.Add(ct);
            }

            return lstCTHD;
        }

        public static bool XoaTatCa(int id)
        {
            string sTruyVan = String.Format(@"delete ChitietHDN where idhdn = {0}", id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Xoa(int id)
        {
            string sTruyVan = String.Format(@"delete ChitietHDN where id = {0}", id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Them(CTHDNhap_DTO cthd, int idhd)
        {
            string sTruyVan = String.Format(@"insert into ChiTietHDN values({0}, {1}, {2}, {3}, {4}, {5})", 
                                    idhd, cthd.Laptop.Id, cthd.SoLuong, cthd.DonGiaNhap, cthd.KhuyenMai, cthd.ThanhTien);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
