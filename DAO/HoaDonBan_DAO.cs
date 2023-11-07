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
    public class HoaDonBan_DAO
    {
        static SqlConnection con;

        public static List<HoaDonBan_DTO> LayDS(DateTime d1, DateTime d2)
        {
            string query = @"Select * from HoaDonBan where ngayban < '" + d2.ToString("MM/dd/yyyy") + "' and ngayban > '" + d1.ToString("MM/dd/yyyy") + "'";


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<HoaDonBan_DTO> listTinhTrang = new List<HoaDonBan_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonBan_DTO nd = new HoaDonBan_DTO();
                nd.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                nd.NgayBan = DateTime.Parse(dt.Rows[i]["NgayBan"].ToString());
                nd.NhanVien = NhanVien_DAO.LayNhanVien(dt.Rows[i]["Manv"].ToString());
                nd.KhachHang = KhachHang_DAO.LayKH(dt.Rows[i]["Makh"].ToString());

                listTinhTrang.Add(nd);
            }

            return listTinhTrang;
        }

        public static bool Xoa(int id)
        {
            string sTruyVan = String.Format(@"delete hoadonBan where id = {0}", id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static HoaDonBan_DTO Lay(int? id)
        {
            string query = "Select * from HoaDonBan where id = " + id;

            if (id == null)
            {
                //lay hoa don cuoi
                query = "Select top 1 * from HoaDonBan order by id desc";
            }


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO

            HoaDonBan_DTO nd = new HoaDonBan_DTO();
            nd.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
            nd.NgayBan = DateTime.Parse(dt.Rows[0]["NgayBan"].ToString());
            nd.NhanVien = NhanVien_DAO.LayNhanVien(dt.Rows[0]["Manv"].ToString());
            nd.KhachHang = KhachHang_DAO.LayKH(dt.Rows[0]["Makh"].ToString());

            //lay danh sach chitiethd
            nd.ChiTiet = CTHDBan_DAO.LayDS(Convert.ToInt32(dt.Rows[0]["Id"]));

            return nd;
        }


        public static bool Them(HoaDonBan_DTO hd)
        {
            string sTruyVan = String.Format(@"insert into hoadonBan values('{0}',{1}, {2})",
                                    hd.NgayBan.ToString("MM/dd/yyyy"), hd.NhanVien.Manv, hd.KhachHang.Makh);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}