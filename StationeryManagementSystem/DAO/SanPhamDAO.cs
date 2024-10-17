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
    }
}
