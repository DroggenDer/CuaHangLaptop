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
    public class NhaCungCap_DAO
    {
        static SqlConnection con;


        public static NhaCungCap_DTO LayNCC(string id)
        {
            string query = @"select * from nhaCungcap where an = 0 and id = '" + id + "'";
            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            //Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            NhaCungCap_DTO nv = new NhaCungCap_DTO();
            nv.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
            nv.Ten = dt.Rows[0]["Ten"].ToString();
            nv.DiaChi = dt.Rows[0]["DiaChi"].ToString();
            nv.Sdt = dt.Rows[0]["Sdt"].ToString();
            nv.Email = dt.Rows[0]["Email"].ToString();
            return nv;
        }

        public static bool Xoa(int id)
        {
            string sTruyVan = String.Format(@"update nhacungcap set an = 1 where Id = {0}", id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<NhaCungCap_DTO> LayDS()
        {
            string query = @"Select * from NhaCungCap where an = 0";


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<NhaCungCap_DTO> listTinhTrang = new List<NhaCungCap_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhaCungCap_DTO nv = new NhaCungCap_DTO();
                nv.Id = Convert.ToInt32(dt.Rows[i]["Id"]);
                nv.Ten = dt.Rows[i]["Ten"].ToString();
                nv.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                nv.Sdt = dt.Rows[i]["Sdt"].ToString();
                nv.Email = dt.Rows[i]["Email"].ToString();

                listTinhTrang.Add(nv);
            }

            return listTinhTrang;
        }

        public static bool Sua(int Id, NhaCungCap_DTO ncc)
        {
            string sTruyVan = String.Format(@"update NhaCungCap set ten= N'{0}', diachi= N'{1}', sdt= N'{2}', email= N'{3}' where Id = '{4}'", ncc.Ten, ncc.DiaChi, ncc.Sdt, ncc.Email, Id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Them(NhaCungCap_DTO ncc)
        {
            string sTruyVan = String.Format(@"insert into NhaCungCap values(N'{0}',N'{1}',N'{2}',N'{3}', 0)", ncc.Ten, ncc.DiaChi, ncc.Sdt, ncc.Email);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool KiemTra(string tenTT)
        {
            string sTruyVan = String.Format(@"select 1 from NhaCungCap where Ten= N'{0}'", tenTT);
            con = DataProvider.MoKetNoi();
            DataTable kq = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq.Rows.Count > 0;
        }
    }
}
