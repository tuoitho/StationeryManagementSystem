using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    internal class CommonDAO
    {
        public static DataTable search(String table, String keywork)
        {
            using (SqlCommand cmd = new SqlCommand("exec SearchTable @table, @keywork", MyDB.GetConnection))
            {
                cmd.Parameters.AddWithValue("@table", SqlDbType.NVarChar).Value = table;
                cmd.Parameters.AddWithValue("@keywork", SqlDbType.NVarChar).Value = keywork;
                MyDB.OpenConnection();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                MyDB.CloseConnection();
                return dt;
            }
        }
        //SearchHoaDon
        public static DataTable searchHoaDon(DateTime start, DateTime end, Boolean isHoaDonNhap)
        {
            using (SqlCommand cmd = new SqlCommand("exec SearchHoaDon @start, @end, @isHoaDonNhap", MyDB.GetConnection))
            {
                cmd.Parameters.AddWithValue("@start", SqlDbType.Date).Value = start;
                cmd.Parameters.AddWithValue("@end", SqlDbType.Date).Value = end;
                cmd.Parameters.AddWithValue("@isHoaDonNhap", SqlDbType.Bit).Value = isHoaDonNhap;
                MyDB.OpenConnection();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                MyDB.CloseConnection();
                return dt;
            }
        }
        //        -- 3.2.2. Thủ tục xoá một bản ghi nhận tham số tên bảng, tên cột khoá chính và id của bảng ghi đó.
        //CREATE OR ALTER PROCEDURE DeleteRecord
        //    @TableName NVARCHAR(128),
        //    @PrimaryKeyColumn NVARCHAR(128),
        //    @PrimaryKeyValue INT
        //AS
        //
        public static void deleteRecord(String tableName, String primaryKeyColumn, int primaryKeyValue)
        {
            using (SqlCommand cmd = new SqlCommand("exec DeleteRecord @TableName, @PrimaryKeyColumn, @PrimaryKeyValue", MyDB.GetConnection))
            {
                cmd.Parameters.AddWithValue("@TableName", SqlDbType.NVarChar).Value = tableName;
                cmd.Parameters.AddWithValue("@PrimaryKeyColumn", SqlDbType.NVarChar).Value = primaryKeyColumn;
                cmd.Parameters.AddWithValue("@PrimaryKeyValue", SqlDbType.Int).Value = primaryKeyValue;
                MyDB.OpenConnection();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MyDB.CloseConnection();
            }
        }

        //        CREATE PROCEDURE sp_XoaVinhVien
        //            @tableName NVARCHAR(128),
        //    @recordID INT
        //AS
        public static void deleteForever(String tableName, int recordID)
        {
            using (SqlCommand cmd = new SqlCommand("exec sp_XoaVinhVien @tableName, @recordID", MyDB.GetConnection))
            {
                cmd.Parameters.AddWithValue("@tableName", SqlDbType.NVarChar).Value = tableName;
                cmd.Parameters.AddWithValue("@recordID", SqlDbType.Int).Value = recordID;
                MyDB.OpenConnection();
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                MyDB.CloseConnection();
            }
        }
    }
}
