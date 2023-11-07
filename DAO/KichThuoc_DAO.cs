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
    public class KichThuoc_DAO
    {
        static SqlConnection con;


        public static bool Xoa(int id)
        {
            string sTruyVan = String.Format(@"delete kichthuoc where Id = '{0}'", id);
            con = DataProvider.MoKetNoi();

            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);

            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static KichThuoc_DTO Lay(int Id)
        {
            string query = @"select * from kichThuoc where id = '" + Id + "'";
            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            //Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            KichThuoc_DTO nd = new KichThuoc_DTO();
            nd.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
            nd.TenKichThuoc = dt.Rows[0]["TenKichThuoc"].ToString();
            return nd;
        }


        public static List<KichThuoc_DTO> LayDS()
        {
            string query = @"Select * from KichThuoc";


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<KichThuoc_DTO> listTinhTrang = new List<KichThuoc_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KichThuoc_DTO nv = new KichThuoc_DTO();
                nv.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                nv.TenKichThuoc = dt.Rows[i]["TenKichThuoc"].ToString();

                listTinhTrang.Add(nv);
            }

            return listTinhTrang;
        }

        public static bool Sua(int Id, string tenmoi)
        {
            string sTruyVan = String.Format(@"update KichThuoc set TenKichThuoc= N'{0}' where Id = '{1}'", tenmoi, Id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Them(string tenTT)
        {
            string sTruyVan = String.Format(@"insert into KichThuoc values(N'{0}')", tenTT);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool KiemTra(string tenTT)
        {
            string sTruyVan = String.Format(@"select 1 from KichThuoc where TenKichThuoc= N'{0}'", tenTT);
            con = DataProvider.MoKetNoi();
            DataTable kq = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq.Rows.Count > 0;
        }
    }
}
