using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    internal class ChiPhiDAO
    {
        public static decimal TongChiPhi(int thang, int nam)
        {
            decimal totalExpenses = 0;
            using (SqlCommand command = new SqlCommand("SELECT dbo.fn_TongChiTieuTheoThang(@Thang, @Nam)", MyDB.GetConnection))
            {
                command.Parameters.Add(new SqlParameter("@Thang", thang));
                command.Parameters.Add(new SqlParameter("@Nam", nam));

                MyDB.OpenConnection();
                totalExpenses = (decimal)command.ExecuteScalar();
            }

            return totalExpenses;
        }
    }
}
