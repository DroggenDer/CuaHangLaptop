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
    public class NhanVien_DAO
    {
        static SqlConnection con;
        public static NhanVien_DTO LayNhanVien(string manv)
        {
            string query = @"select * from nhanvien where manv = '"+manv+"'";
            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            //Không có dữ liệu
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            NhanVien_DTO nd = new NhanVien_DTO();
            nd.Manv = Convert.ToInt32(dt.Rows[0]["Manv"]);
            nd.Holot = dt.Rows[0]["HoLot"].ToString();
            nd.Ten = dt.Rows[0]["Ten"].ToString();
            nd.Diachi = dt.Rows[0]["DiaChi"].ToString();
            nd.GioiTinh  = dt.Rows[0]["GioiTInh"].ToString();
            nd.NamSinh = DateTime.Parse(dt.Rows[0]["NanSinh"].ToString());
            nd.Sdt = dt.Rows[0]["Sdt"].ToString();
            nd.ChucVu = ChucVu_DAO.LayChucVu(Convert.ToInt32(dt.Rows[0]["IdChucVu"]));
            return nd;
        }

        public static bool Xoa(int id)
        {
            string sTruyVan = String.Format(@"update nhanvien set an = 1 where manv = {0}", id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<NhanVien_DTO> LayDS()
        {
            string query = @"Select * from NhanVien where an = 0";


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<NhanVien_DTO> listTinhTrang = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nd = new NhanVien_DTO();
                nd.Manv = Convert.ToInt32(dt.Rows[i]["Manv"]);
                nd.Holot = dt.Rows[i]["HoLot"].ToString();
                nd.Ten = dt.Rows[i]["Ten"].ToString();
                nd.Diachi = dt.Rows[i]["DiaChi"].ToString();
                nd.GioiTinh = dt.Rows[i]["GioiTInh"].ToString();
                nd.NamSinh = DateTime.Parse(dt.Rows[i]["NanSinh"].ToString());
                nd.Sdt = dt.Rows[i]["Sdt"].ToString();
                nd.ChucVu = ChucVu_DAO.LayChucVu(Convert.ToInt32(dt.Rows[i]["IdChucVu"]));

                listTinhTrang.Add(nd);
            }

            return listTinhTrang;
        }

        public static bool Sua(int Id, NhanVien_DTO ncc)
        {
            string sTruyVan = String.Format(@"EXEC update_nhanvien N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}'", Id, ncc.Holot, ncc.Ten, ncc.Diachi, ncc.GioiTinh, ncc.NamSinh.ToString("MM/dd/yyyy"), ncc.Sdt, ncc.ChucVu.Id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool Them(NhanVien_DTO ncc)
        {
            string sTruyVan = String.Format(@"EXEC THEM_Nhanvien N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}'", ncc.Holot, ncc.Ten,ncc.Diachi, ncc.GioiTinh, ncc.NamSinh.ToString("MM/dd/yyyy"),  ncc.Sdt, ncc.ChucVu.Id);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
    }
}
