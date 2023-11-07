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
    public class KhachHang_DAO
    {
        static SqlConnection con;
        public static List<KhachHang_DTO> LayDS()
        {
            string query = @"Select * from KhachHang where an = 0";


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<KhachHang_DTO> listTinhTrang = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO nv = new KhachHang_DTO();
                nv.Makh = Convert.ToInt32(dt.Rows[i]["Makh"]);
                nv.HoLot = dt.Rows[i]["HoLot"].ToString();
                nv.Ten = dt.Rows[i]["Ten"].ToString();
                nv.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                nv.NamSinh = DateTime.Parse(dt.Rows[i]["NamSinh"].ToString());
                nv.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                nv.Sdt = dt.Rows[i]["Sdt"].ToString();

                listTinhTrang.Add(nv);
            }

            return listTinhTrang;
        }

        public static bool Xoa(int id)
        {
            string sTruyVan = String.Format(@"update khachhang set an = 1 where makh = {0}", id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        internal static KhachHang_DTO LayKH(string id)
        {
            string query = @"Select * from KhachHang where an = 0 and Makh = " + id;


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO

            KhachHang_DTO nv = new KhachHang_DTO();
            nv.Makh = Convert.ToInt32(dt.Rows[0]["Makh"]);
            nv.HoLot = dt.Rows[0]["HoLot"].ToString();
            nv.Ten = dt.Rows[0]["Ten"].ToString();
            nv.GioiTinh = dt.Rows[0]["GioiTinh"].ToString();
            nv.NamSinh = DateTime.Parse(dt.Rows[0]["NamSinh"].ToString());
            nv.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            nv.Sdt = dt.Rows[0]["Sdt"].ToString();

 
            return nv;
        }

        public static bool Sua(int Id, KhachHang_DTO ncc)
        {
            string sTruyVan = String.Format(@"EXEC update_KHACHHANG N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}'",Id, ncc.HoLot, ncc.Ten, ncc.GioiTinh, ncc.NamSinh.ToString("MM/dd/yyyy"), ncc.DiaChi, ncc.Sdt);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Them(KhachHang_DTO ncc)
        {
            string sTruyVan = String.Format(@"EXEC THEM_KHACHHANG N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}'", ncc.HoLot, ncc.Ten, ncc.GioiTinh, ncc.NamSinh.ToString("MM/dd/yyyy"), ncc.DiaChi, ncc.Sdt);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool KiemTra(string tenTT)
        {
            string sTruyVan = String.Format(@"select 1 from KhachHang where Ten= N'{0}'", tenTT);
            con = DataProvider.MoKetNoi();
            DataTable kq = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq.Rows.Count > 0;
        }
    }
}
