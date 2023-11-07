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
    public class HoaDonNhap_DAO
    {
        static SqlConnection con;

        public static List<HoaDonNhap_DTO> LayDS(DateTime d1, DateTime d2)
        {
            string query = @"Select * from HoaDonNhap where ngaynhap < '"+d2.ToString("MM/dd/yyyy")+"' and ngaynhap > '"+d1.ToString("MM/dd/yyyy") + "'";


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<HoaDonNhap_DTO> listTinhTrang = new List<HoaDonNhap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDonNhap_DTO nd = new HoaDonNhap_DTO();
                nd.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                nd.NgayNhap = DateTime.Parse(dt.Rows[i]["NgayNhap"].ToString());
                nd.NhanVien = NhanVien_DAO.LayNhanVien(dt.Rows[i]["Manv"].ToString());
                nd.NhaCungCap = NhaCungCap_DAO.LayNCC(dt.Rows[i]["IdNCC"].ToString());

                listTinhTrang.Add(nd);
            }

            return listTinhTrang;
        }

        public static bool Xoa(int id)
        {
            string sTruyVan = String.Format(@"delete hoadonnhap where id = {0}", id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static HoaDonNhap_DTO Lay(int? id)
        {
            string query = "Select * from HoaDonNhap where id = " + id;

            if (id == null)
            {
                //lay hoa don cuoi
                query = "Select top 1 * from HoaDonNhap order by id desc";
            }
            

            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO

            HoaDonNhap_DTO nd = new HoaDonNhap_DTO();
            nd.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
            nd.NgayNhap = DateTime.Parse(dt.Rows[0]["NgayNhap"].ToString());
            nd.NhanVien = NhanVien_DAO.LayNhanVien(dt.Rows[0]["Manv"].ToString());
            nd.NhaCungCap = NhaCungCap_DAO.LayNCC(dt.Rows[0]["IdNCC"].ToString());

            //lay danh sach chitiethd
            nd.ChiTiet = CTHDNhap_DAO.LayDS(Convert.ToInt32(dt.Rows[0]["Id"]));

            return nd;
        }


        public static bool Them(HoaDonNhap_DTO hd)
        {
            string sTruyVan = String.Format(@"insert into hoadonnhap values('{0}',{1}, {2})", 
                                    hd.NgayNhap.ToString("MM/dd/yyyy"), hd.NhanVien.Manv, hd.NhaCungCap.Id);
         
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
