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
    public class TinhTrang_DAO
    {
        static SqlConnection con;

        public static bool Xoa(int id)
        {
            string sTruyVan = String.Format(@"delete tinhtrang where Id = '{0}'", id);
            con = DataProvider.MoKetNoi();

            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);

            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static TinhTrang_DTO Lay(int Id)
        {
            string query = @"select * from tinhtrang where id = '" + Id + "'";
            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            //Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            TinhTrang_DTO nd = new TinhTrang_DTO();
            nd.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
            nd.TenTinhTrang = dt.Rows[0]["TenTinhTrang"].ToString();
            return nd;
        }
        public static List<TinhTrang_DTO> LayDSTinhTrang()
        {
            string query = @"Select * from tinhtrang";


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<TinhTrang_DTO> listTinhTrang = new List<TinhTrang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                TinhTrang_DTO nv = new TinhTrang_DTO();
                nv.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                nv.TenTinhTrang = dt.Rows[i]["TenTinhTrang"].ToString();
                
                listTinhTrang.Add(nv);
            }

            return listTinhTrang;
        }

        public static bool Sua(int Id, string tenmoi)
        {
            string sTruyVan = String.Format(@"update tinhtrang set TenTinhTrang = N'{0}' where Id = '{1}'", tenmoi, Id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool ThemTinhTrang(string tenTT)
        {
            string sTruyVan = String.Format(@"insert into tinhtrang values(N'{0}')", tenTT);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool KiemTraTinhTrang(string tenTT)
        {
            string sTruyVan = String.Format(@"select 1 from tinhtrang where tentinhtrang = N'{0}'", tenTT);
            con = DataProvider.MoKetNoi();
            DataTable kq = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq.Rows.Count>0;
        }
    }
}
