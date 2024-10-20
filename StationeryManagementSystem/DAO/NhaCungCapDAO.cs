using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    internal class NhaCungCapDAO
    {
        public static DataTable findAll()
        {
            SqlCommand cmd = new SqlCommand("select * from v_DanhSachNhaCungCap", MyDB.GetConnection);
            MyDB.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            MyDB.CloseConnection();
            return dt;

        }

        public static void insert(string tenNhaCungCap, string diaChi, string soDienThoai)
        {
            MyDB.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("exec sp_ThemNhaCungCap @TenNhaCungCap, @DiaChi, @SoDienThoai", MyDB.GetConnection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@TenNhaCungCap", SqlDbType.NVarChar).Value = tenNhaCungCap;
                cmd.Parameters.AddWithValue("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
                cmd.Parameters.AddWithValue("@SoDienThoai", SqlDbType.NVarChar).Value = soDienThoai;
                cmd.ExecuteNonQuery();
            }
            MyDB.CloseConnection();
        }

        public static void update(int maNhaCungCap, string tenNhaCungCap, string diaChi, string soDienThoai)
        {
            MyDB.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("exec sp_SuaNhaCungCap @MaNhaCungCap, @TenNhaCungCap, @DiaChi, @SoDienThoai", MyDB.GetConnection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MaNhaCungCap", SqlDbType.Int).Value = maNhaCungCap;
                cmd.Parameters.AddWithValue("@TenNhaCungCap", SqlDbType.NVarChar).Value = tenNhaCungCap;
                cmd.Parameters.AddWithValue("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
                cmd.Parameters.AddWithValue("@SoDienThoai", SqlDbType.NVarChar).Value = soDienThoai;
                cmd.ExecuteNonQuery();
            }
            MyDB.CloseConnection();
        }
        public static void delete(int maNhaCungCap)
        {
            MyDB.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("exec sp_XoaNhaCungCap @MaNhaCungCap", MyDB.GetConnection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MaNhaCungCap", SqlDbType.Int).Value = maNhaCungCap;
                cmd.ExecuteNonQuery();
            }
            MyDB.CloseConnection();
        }
    }
}
