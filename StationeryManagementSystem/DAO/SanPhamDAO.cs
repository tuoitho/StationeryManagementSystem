using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    internal class SanPhamDAO
    {
        public static DataTable findAll()
        {
            using (SqlCommand cmd = new SqlCommand("select * from XemDanhSachSanPham", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MyDB.CloseConnection();
                return dt;
            }
        }

        internal static void delete(int maSP)
        {
            using (SqlCommand cmd = new SqlCommand("exec sp_XoaSanPham @maSP", MyDB.GetConnection))
            {
                cmd.Parameters.AddWithValue("@maSP", SqlDbType.Int).Value = maSP;
                MyDB.OpenConnection();
                cmd.ExecuteNonQuery();
                MyDB.CloseConnection();
            }
        }

        internal static DataTable getXemSoLuongSanPhamDaBanTrongNgay(DateTime dateTime)
        {
            using (SqlCommand cmd = new SqlCommand("select * from fn_DanhSachSanPhamDaBanTrongNgay(@ngay)", MyDB.GetConnection))
            {
                cmd.Parameters.AddWithValue("@ngay", SqlDbType.Date).Value = dateTime;
                MyDB.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MyDB.CloseConnection();
                return dt;
            }
        }

        internal static void insert(string tenSP, int maLoai)
        {
            using (SqlCommand cmd = new SqlCommand("exec sp_ThemSanPham @tenSP, @maLoai", MyDB.GetConnection))
            {
                cmd.Parameters.AddWithValue("@tenSP", SqlDbType.NVarChar).Value = tenSP;
                cmd.Parameters.AddWithValue("@maLoai", SqlDbType.Int).Value = maLoai;
                MyDB.OpenConnection();
                cmd.ExecuteNonQuery();
                MyDB.CloseConnection();
            }
        }

        internal static void update(int maSP, string tenSP, float giaNhap, float giaBan, int maLoai, int soLuong)
        {
            using (SqlCommand cmd = new SqlCommand("exec sp_SuaSanPham @maSP, @tenSP, @giaNhap, @giaBan, @maLoai, @soLuong", MyDB.GetConnection))
            {
                cmd.Parameters.AddWithValue("@maSP", SqlDbType.Int).Value = maSP;
                cmd.Parameters.AddWithValue("@tenSP", SqlDbType.NVarChar).Value = tenSP;
                cmd.Parameters.AddWithValue("@giaNhap", SqlDbType.Float).Value = giaNhap;
                cmd.Parameters.AddWithValue("@giaBan", SqlDbType.Float).Value = giaBan;
                cmd.Parameters.AddWithValue("@maLoai", SqlDbType.Int).Value = maLoai;
                cmd.Parameters.AddWithValue("@soLuong", SqlDbType.Int).Value = soLuong;
                MyDB.OpenConnection();
                cmd.ExecuteNonQuery();
                MyDB.CloseConnection();
            }   
        }
    }
}
