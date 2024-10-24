using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    internal class DoanhThuDAO
    {
        public static decimal TongDoanhThu(int thang, int nam)
        {
            decimal dt = 0;
            using (SqlCommand command = new SqlCommand("SELECT dbo.fn_TongDoanhThuTheoThang(@Thang, @Nam)", MyDB.GetConnection))
            {
                command.Parameters.Add(new SqlParameter("@Thang", thang));
                command.Parameters.Add(new SqlParameter("@Nam", nam));

                MyDB.OpenConnection();
                dt = (decimal)command.ExecuteScalar();
            }

            return dt;
        }
    }
}
