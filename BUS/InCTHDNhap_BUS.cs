using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class InCTHDNhap_BUS
    {
        static SqlConnection con;
        public static List<HDNhapHang> LayDSCTHD(int idHoaDon)
        {
            string query = string.Format(@"
                SELECT lt.TenLaptop, cthd.SoLuong, cthd.DonGiaNhap, cthd.KhuyenMai, cthd.ThanhTien, ncc.Ten, ncc.Sdt, ncc.DiaChi
                FROM ChiTietHDN cthd
                INNER JOIN Laptop lt ON cthd.IdLaptop=lt.Id
                INNER JOIN HoaDonNhap hdn ON cthd.IdHDN=hdn.Id
                INNER JOIN NhaCungCap ncc ON hdn.IdNCC=ncc.Id
                WHERE cthd.idHDN={0}
            ", idHoaDon);


            con = DataProvider.MoKetNoi();

            //DataTable chứa dữ liệu lấy về
            DataTable dt = DataProvider.TruyVanLayDuLieu(query, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            //Có dữ liệu thì chuyển dữ liệu từ Database qua dữ liệu đã định dạng DTO
            List<HDNhapHang> lstCTHD = new List<HDNhapHang>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HDNhapHang ct = new HDNhapHang();
                ct.TenLapTop = dt.Rows[i]["TenLaptop"].ToString();
                ct.SoLuong = int.Parse(dt.Rows[i]["SoLuong"].ToString());
                ct.DonGiaNhap = int.Parse(dt.Rows[i]["DonGiaNhap"].ToString());
                ct.KhuyenMai = int.Parse(dt.Rows[i]["KhuyenMai"].ToString());
                ct.ThanhTien = int.Parse(dt.Rows[i]["ThanhTien"].ToString());
                ct.TenNCC = dt.Rows[i]["ten"].ToString();
                ct.SdtNCC = int.Parse(dt.Rows[i]["sdt"].ToString());
                ct.DiaChiNCC = dt.Rows[i]["diachi"].ToString();
                
                lstCTHD.Add(ct);
            }

            return lstCTHD;
        }

        
    }
}
