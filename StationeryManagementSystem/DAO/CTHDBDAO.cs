using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    internal class CTHDBDAO
    {
        public static DataTable findAllByMaHD(int maHD)
        {
            string sql = "select * from fn_DanhSachSanPhamTrongHoaDonBan(@maHD)";
            SqlCommand cmd = new SqlCommand(sql,MyDB.GetConnection);
            cmd.Parameters.AddWithValue("@maHD", SqlDbType.Int).Value = maHD;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
    }
}
