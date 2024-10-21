using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    internal class LoaiSanPhamDAO
    {
        public static DataTable findAll()
        {
            SqlCommand cmd = new SqlCommand("select * from LoaiSanPham", MyDB.GetConnection);
            MyDB.OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            MyDB.CloseConnection();
            return dt;
        }
    }
}
