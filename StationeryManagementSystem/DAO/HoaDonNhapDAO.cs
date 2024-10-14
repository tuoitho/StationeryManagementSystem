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
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
