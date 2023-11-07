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
    public class BaoHanh_DAO
    {
        static SqlConnection con;

        public static BaoHanh_DTO Lay(int Id)
        {
            string query = @"select * from BaoHanh where id = '" + Id + "'";
            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            //Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            BaoHanh_DTO nd = new BaoHanh_DTO();
            nd.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
            nd.TenBaoHanh = dt.Rows[0]["SoThang"].ToString();
            return nd;
        }
        public static List<BaoHanh_DTO> LayDS()
        {
            string query = @"Select * from BaoHanh";


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<BaoHanh_DTO> listTinhTrang = new List<BaoHanh_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BaoHanh_DTO nv = new BaoHanh_DTO();
                nv.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                nv.TenBaoHanh = dt.Rows[i]["SoThang"].ToString();

                listTinhTrang.Add(nv);
            }

            return listTinhTrang;
        }

        public static bool Sua(int Id, string tenmoi)
        {
            string sTruyVan = String.Format(@"update BaoHanh set SoThang= N'{0}' where Id = '{1}'", tenmoi, Id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Them(string tenTT)
        {
            string sTruyVan = String.Format(@"insert into BaoHanh values(N'{0}')", tenTT);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool KiemTra(string tenTT)
        {
            string sTruyVan = String.Format(@"select 1 from BaoHanh where SoThang= N'{0}'", tenTT);
            con = DataProvider.MoKetNoi();
            DataTable kq = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq.Rows.Count > 0;
        }

        public static bool Xoa(int id)
        {
            string sTruyVan = String.Format(@"delete baohanh where Id = '{0}'", id);
            con = DataProvider.MoKetNoi();

            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);

            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
