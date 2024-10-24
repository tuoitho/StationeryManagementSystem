using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    internal class LuongDAO
    {
        public static DataTable LuongTrongNgay(DateTime date)
        {
            using (SqlCommand cmd = new SqlCommand("select * from fn_DanhSachLuongNhanVienTheoNgay(@Ngay)", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Ngay", SqlDbType.Date).Value = date;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                MyDB.CloseConnection();
                return dt;
            }

        }

        internal static DataTable LuongTrongThang(int thang, int nam)
        {
            using (SqlCommand cmd = new SqlCommand("select * from fn_DanhSachLuongNhanVienTheoThang(@thang, @nam)", MyDB.GetConnection))
            {
                cmd.Parameters.AddWithValue("@thang", SqlDbType.Int).Value = thang;
                cmd.Parameters.AddWithValue("@nam", SqlDbType.Int).Value = nam;
                MyDB.OpenConnection();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MyDB.CloseConnection();
                return dt;
            }
        }
        public static decimal TongLuongTrongThang(int thang, int nam)
        {
            decimal luong = 0;
            using (SqlCommand command = new SqlCommand("SELECT dbo.fn_TongLuongPhaiTraTheoThang(@Thang, @Nam)", MyDB.GetConnection))
            {
                command.Parameters.Add(new SqlParameter("@Thang", thang));
                command.Parameters.Add(new SqlParameter("@Nam", nam));

                MyDB.OpenConnection();
                luong = (decimal)command.ExecuteScalar();
            }

            return luong;
        }
    }
}
