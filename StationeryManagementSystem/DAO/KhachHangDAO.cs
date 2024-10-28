using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    internal class KhachHangDAO
    {
        public static DataTable findAll()
        {
            string sql = "select * from v_DanhSachKhachHang";
            SqlCommand cmd = new SqlCommand(sql, MyDB.GetConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void insert(String hoTen, String diaChi, String sdt)
        {
            MyDB.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("exec sp_ThemKhachHang @HoTen, @DiaChi, @SDT", MyDB.GetConnection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@HoTen", SqlDbType.NVarChar).Value = hoTen;
                cmd.Parameters.AddWithValue("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
                cmd.Parameters.AddWithValue("@SDT", SqlDbType.NVarChar).Value = sdt;
                cmd.ExecuteNonQuery();
            }
            MyDB.CloseConnection();
        }
        public static void update(int maKH, String hoTen, String diaChi, String sdt)
        {
            MyDB.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("exec sp_SuaKhachHang @MaKH, @HoTen, @DiaChi, @SDT", MyDB.GetConnection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MaKH", SqlDbType.NVarChar).Value = maKH;
                cmd.Parameters.AddWithValue("@HoTen", SqlDbType.NVarChar).Value = hoTen;
                cmd.Parameters.AddWithValue("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
                cmd.Parameters.AddWithValue("@SDT", SqlDbType.NVarChar).Value = sdt;
                cmd.ExecuteNonQuery();
            }
            MyDB.CloseConnection();
        }
        //public static void delete(int maKH)
        //{
        //    MyDB.OpenConnection();
        //    using (SqlCommand cmd = new SqlCommand("exec sp_XoaKhachHang @MaKH", MyDB.GetConnection))
        //    {
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Parameters.AddWithValue("@MaKH", SqlDbType.Int).Value = maKH;
        //        cmd.ExecuteNonQuery();
        //    }
        //    MyDB.CloseConnection();
        //}
    }
}
