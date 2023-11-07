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
    public class Laptop_DAO
    {
        static SqlConnection con;
        public static Laotop_DTO LayLaptop(int Id)
        {
            string query = @"select * from Laptop where id = '" + Id + "'";
            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            //Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            Laotop_DTO nd = new Laotop_DTO();
            nd.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
            nd.TenLaptop = dt.Rows[0]["TenLaptop"].ToString();
            nd.ThuongHieu = ThuongHieu_DAO.Lay(Convert.ToInt32(dt.Rows[0]["IdThuongHieu"]));
            nd.KichThuoc = KichThuoc_DAO.Lay(Convert.ToInt32(dt.Rows[0]["IdKichThuoc"]));
            nd.BaoHanh = BaoHanh_DAO.Lay(Convert.ToInt32(dt.Rows[0]["IdBaoHanh"]));
            nd.TinhTrang = TinhTrang_DAO.Lay(Convert.ToInt32(dt.Rows[0]["IdTinhTrang"]));
            nd.GiaNhap = Convert.ToInt32(dt.Rows[0]["GiaNhap"]);
            nd.GiaBan = Convert.ToInt32(dt.Rows[0]["GiaBan"]);
            nd.Slton = Convert.ToInt32(dt.Rows[0]["SoLuongTon"]); 
            return nd;
        }

        public static bool Xoa(int id)
        {
            string sTruyVan = String.Format(@"update laptop set an = 1 where id = {0}", id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<Laotop_DTO> LayDS(string search)
        {
            string sTruyVan = String.Format(@"Select * from Laptop where an = 0");

            if (!String.IsNullOrEmpty(search))
            {
                sTruyVan = String.Format(@"Select * from Laptop where (an = 0 and id like '%{0}%') or (an = 0 and TenLaptop like '%{1}%')", search, search);
            }

            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<Laotop_DTO> listLaptop = new List<Laotop_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Laotop_DTO nd = new Laotop_DTO();

                nd.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                nd.TenLaptop = dt.Rows[i]["TenLaptop"].ToString();
                nd.ThuongHieu = ThuongHieu_DAO.Lay(Convert.ToInt32(dt.Rows[i]["IdThuongHieu"]));
                nd.KichThuoc = KichThuoc_DAO.Lay(Convert.ToInt32(dt.Rows[i]["IdKichThuoc"]));
                nd.BaoHanh = BaoHanh_DAO.Lay(Convert.ToInt32(dt.Rows[i]["IdBaoHanh"]));
                nd.TinhTrang = TinhTrang_DAO.Lay(Convert.ToInt32(dt.Rows[i]["IdTinhTrang"]));
                nd.GiaNhap = Convert.ToInt32(dt.Rows[i]["GiaNhap"]);
                nd.GiaBan = Convert.ToInt32(dt.Rows[i]["GiaBan"]);
                nd.Slton = Convert.ToInt32(dt.Rows[i]["SoLuongTon"]);

                listLaptop.Add(nd);
            }

            return listLaptop;
        }

        public static bool Sua(int Id, Laotop_DTO laptop)
        {
            string sTruyVan = String.Format(@"exec sua_Laptop N'{0}',{1},{2},{3},{4},{5},{6}",
                              laptop.TenLaptop, laptop.ThuongHieu.Id, laptop.KichThuoc.Id, laptop.BaoHanh.Id, laptop.TinhTrang.Id, laptop.GiaBan, Id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static void CapNhatKho(int soluong, int gianhap, int id)
        {
            string sTruyVan = String.Format(@"update laptop set soluongton = soluongton + {0} , gianhap = {1} where id = {2}", soluong, gianhap, id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
        }

        public static bool Them(Laotop_DTO tivi)
        {
            string sTruyVan = String.Format(@"exec them_laptop N'{0}',{1},{2},{3},{4},{5},{6},{7}", 
                              tivi.TenLaptop, tivi.ThuongHieu.Id, tivi.KichThuoc.Id, tivi.BaoHanh.Id, tivi.TinhTrang.Id, tivi.GiaNhap, tivi.GiaBan, 0);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool KiemTra(string tenTT)
        {
            string sTruyVan = String.Format(@"select 1 from Laptop where tenLaptop = N'{0}'", tenTT);
            con = DataProvider.MoKetNoi();
            DataTable kq = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq.Rows.Count > 0;
        }
    }
}
