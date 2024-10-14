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
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
