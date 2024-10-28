using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    internal class HoaDonBanDAO
    {
        public static DataTable findAll()
        {
            using (SqlCommand cmd = new SqlCommand("select * from v_DanhSachHoaDonBan", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MyDB.CloseConnection();
                return dt;
            }
        }

        public static DataTable DoanhThuTrongThang(int thang, int nam)
        {
            using (SqlCommand cmd = new SqlCommand("select * from fn_DoanhThuBanHangTheoThang(@Thang, @Nam)", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                cmd.Parameters.AddWithValue("@Thang", thang);
                cmd.Parameters.AddWithValue("@nam", nam);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MyDB.CloseConnection();
                return dt;
            }
        }

        public static DataTable insert(int maNV, int maKH)
        {
            using (SqlCommand cmd = new SqlCommand("exec sp_ThemHoaDonBan @maNV,@maKH", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                cmd.Parameters.AddWithValue("@maNV", maNV);
                cmd.Parameters.AddWithValue("@maKH", maKH);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MyDB.CloseConnection();
                return dt;
            }
        }

        //internal static void delete(int maHD)
        //{
        //    SqlCommand sqlCommand = new SqlCommand("exec sp_XoaHoaDonBan @maHD", MyDB.GetConnection);
        //    sqlCommand.Parameters.AddWithValue("@maHD", SqlDbType.Int).Value = maHD;
        //    MyDB.OpenConnection();
        //    sqlCommand.ExecuteNonQuery();
        //    MyDB.CloseConnection();
        //}

        internal static void update(int maHD, string trangThai)
        {
            SqlCommand cmd = new SqlCommand("exec sp_CapNhatTrangThaiThanhToanHoaDonBan @maHD,@trangThai", MyDB.GetConnection);
            cmd.Parameters.AddWithValue("@maHD", SqlDbType.Int).Value = maHD;
            cmd.Parameters.AddWithValue("@trangThai", SqlDbType.NVarChar).Value = trangThai;
            MyDB.OpenConnection();
            cmd.ExecuteNonQuery();
            MyDB.CloseConnection();

        }
    }
}
