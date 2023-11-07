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
    public class ChucVu_DAO
    {
        static SqlConnection con;
        public static ChucVu_DTO LayChucVu(int Id)
        {
            string query = @"select * from chucvu where id = '" + Id + "'";
            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            //Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            ChucVu_DTO nd = new ChucVu_DTO();
            nd.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
            nd.TenChucVu = dt.Rows[0]["TenChucVu"].ToString();
            return nd;
        }

        public static bool Xoa(int id)
        {
            string sTruyVan = String.Format(@"delete ChucVu where Id = '{0}'", id);
            con = DataProvider.MoKetNoi();
            
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<ChucVu_DTO> LayDS()
        {
            string query = @"Select * from ChucVu";


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<ChucVu_DTO> listChucVu = new List<ChucVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChucVu_DTO nv = new ChucVu_DTO();
                nv.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                nv.TenChucVu = dt.Rows[i]["TenChucVu"].ToString();

                listChucVu.Add(nv);
            }

            return listChucVu;
        }

        public static bool Sua(int Id, string tenmoi)
        {
            string sTruyVan = String.Format(@"update ChucVu set TenChucVu = N'{0}' where Id = '{1}'", tenmoi, Id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Them(string tenTT)
        {
            string sTruyVan = String.Format(@"insert into ChucVu values(N'{0}')", tenTT);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool KiemTra(string tenTT)
        {
            string sTruyVan = String.Format(@"select 1 from ChucVu where tenChucVu = N'{0}'", tenTT);
            con = DataProvider.MoKetNoi();
            DataTable kq = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq.Rows.Count > 0;
        }
    }
}
