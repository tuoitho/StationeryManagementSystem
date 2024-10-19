using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    internal class ChiTietHDNDAO
    {
        public static DataTable findAllByMaHD(int maHD)
        {
            MyDB.OpenConnection();
            string sql = "select * from fn_DanhSachSanPhamTrongHoaDonNhap(@maHD)";
            SqlCommand cmd = new SqlCommand(sql, MyDB.GetConnection);
            cmd.Parameters.AddWithValue("@maHD", SqlDbType.Int).Value = maHD;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MyDB.CloseConnection();
            return dt;

        }
        public static void insert(int maHD, int maSP, int soLuong, float donGia)
        {
            using (SqlCommand cmd = new SqlCommand("exec sp_ThemChiTietHoaDonNhap @maHD,@maSP,@soLuong,@donGia", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                cmd.Parameters.AddWithValue("@maHD", SqlDbType.Int).Value = maHD;
                cmd.Parameters.AddWithValue("@maSP", SqlDbType.Int).Value = maSP;
                cmd.Parameters.AddWithValue("@soLuong", SqlDbType.Int).Value = soLuong;
                cmd.Parameters.AddWithValue("@donGia", SqlDbType.Float).Value = donGia;
                cmd.ExecuteNonQuery();
                MyDB.CloseConnection();
            }
        }

        internal static void update(int maHD, int maSP, int soLuong, float donGia)
        {
            using (SqlCommand cmd = new SqlCommand("exec sp_CapNhatChiTietHoaDonNhap @maHD,@maSP,@soLuong,@donGia", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                cmd.Parameters.AddWithValue("@maHD", SqlDbType.Int).Value = maHD;
                cmd.Parameters.AddWithValue("@maSP", SqlDbType.Int).Value = maSP;
                cmd.Parameters.AddWithValue("@soLuong", SqlDbType.Int).Value = soLuong;
                cmd.Parameters.AddWithValue("@donGia", SqlDbType.Float).Value = donGia;
                cmd.ExecuteNonQuery();
                MyDB.CloseConnection();
            }
        }
        public static void delete(int maHD, int maSP)
        {
            using (SqlCommand cmd = new SqlCommand("exec sp_XoaChiTietHoaDonNhap @maHD,@maSP", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                cmd.Parameters.AddWithValue("@maHD", SqlDbType.Int).Value = maHD;
                cmd.Parameters.AddWithValue("@maSP", SqlDbType.Int).Value = maSP;
                cmd.ExecuteNonQuery();
                MyDB.CloseConnection();
            }
        }
    }
}
