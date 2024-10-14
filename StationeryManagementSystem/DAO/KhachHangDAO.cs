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
    }
}
