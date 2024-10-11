using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    internal class NhanVienDao
    {
        public static DataTable findAll()
        {
            using (SqlCommand cmd = new SqlCommand("select * from thongtinnhanvien", MyDB.GetConnection))
            {
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                return dt;
            }
        }
    }
}
