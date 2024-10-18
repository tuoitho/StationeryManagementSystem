using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    internal class HoaDonNhapDAO
    {
        public static DataTable findAll()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM v_DanhSachHoaDonNhap", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    MyDB.CloseConnection();
                    return dt;
                }
            }
        }

        public static DataTable insert(int maNV, int maNCC)
        {
            using (SqlCommand cmd = new SqlCommand("exec sp_ThemHoaDonNhap @maNV,@maNcc", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                cmd.Parameters.AddWithValue("@maNV", maNV);
                cmd.Parameters.AddWithValue("@maNcc", maNCC);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MyDB.CloseConnection();
                return dt;
            }
        }

        internal static void delete(int maHD)
        {
            SqlCommand sqlCommand = new SqlCommand("exec sp_XoaHoaDonNhap @maHD", MyDB.GetConnection);
            sqlCommand.Parameters.AddWithValue("@maHD", SqlDbType.Int).Value = maHD;
            MyDB.OpenConnection();
            sqlCommand.ExecuteNonQuery();
            MyDB.CloseConnection();

        }

        internal static void update(int maHD, string trangThai)
        {
            SqlCommand cmd = new SqlCommand("exec sp_CapNhatTrangThaiThanhToanHoaDonNhap @maHD,@trangThai", MyDB.GetConnection);
            cmd.Parameters.AddWithValue("@maHD", SqlDbType.Int).Value = maHD;
            cmd.Parameters.AddWithValue("@trangThai", SqlDbType.NVarChar).Value = trangThai;
            MyDB.OpenConnection();
            cmd.ExecuteNonQuery();
            MyDB.CloseConnection();

        }
    }
}
