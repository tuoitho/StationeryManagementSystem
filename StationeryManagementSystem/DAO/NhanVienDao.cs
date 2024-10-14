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
                MyDB.OpenConnection();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                MyDB.CloseConnection();
                return dt;
            }
        }
        public static bool isValidEmail(String email)
        {
            MyDB.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("select dbo.fn_CheckValidEmail(@Email)", MyDB.GetConnection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.NVarChar).Value = email;
                bool result = (bool)cmd.ExecuteScalar();
                MyDB.CloseConnection();
                return result;
            }
        }
        public static bool isValidPhoneNumber(String phoneNumber)
        {
            MyDB.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("select dbo.fn_CheckValidPhoneNumber(@PhoneNumber)", MyDB.GetConnection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@PhoneNumber", SqlDbType.NVarChar).Value = phoneNumber;
                bool result = (bool)cmd.ExecuteScalar();
                MyDB.CloseConnection();
                return result;
            }

        }
        public static bool isUniqueEmail(String email)
        {
            MyDB.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("select * from fn_FindNhanVienByEmail (@Email)", MyDB.GetConnection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.NVarChar).Value = email;
                return cmd.ExecuteScalar() == null;
            }
            MyDB.CloseConnection();
        }
        public static bool isUniquePhoneNumber(String phoneNumber)
        {
            MyDB.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("select * from fn_FindNhanVienBySDT (@PhoneNumber)", MyDB.GetConnection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@PhoneNumber", SqlDbType.NVarChar).Value = phoneNumber;
                bool result = cmd.ExecuteScalar() == null;
                MyDB.CloseConnection();
                return result;
            }
            MyDB.CloseConnection();
        }
        public static void insert(String hoTen, DateTime ngaySinh, String gioiTinh, String diaChi, String sdt, String email, int machucVu)
        {
            MyDB.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("exec sp_ThemNhanVien @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @Email, @MaChucVu", MyDB.GetConnection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@HoTen", SqlDbType.NVarChar).Value = hoTen;
                cmd.Parameters.AddWithValue("@NgaySinh", SqlDbType.Date).Value = ngaySinh;
                cmd.Parameters.AddWithValue("@GioiTinh", SqlDbType.NVarChar).Value = gioiTinh;
                cmd.Parameters.AddWithValue("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
                cmd.Parameters.AddWithValue("@SDT", SqlDbType.NVarChar).Value = sdt;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.NVarChar).Value = email;
                cmd.Parameters.AddWithValue("@MaChucVu", SqlDbType.NVarChar).Value = machucVu;
                cmd.ExecuteNonQuery();
            }
            MyDB.CloseConnection();
        }
        public static void update(int maNV, String hoTen, DateTime ngaySinh, String gioiTinh, String diaChi, String sdt, String email, int maChucVu)
        {
            MyDB.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("exec sp_UpdateNhanVien @MaNV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @Email, @MaChucVu", MyDB.GetConnection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MaNV", SqlDbType.NVarChar).Value = maNV;
                cmd.Parameters.AddWithValue("@HoTen", SqlDbType.NVarChar).Value = hoTen;
                cmd.Parameters.AddWithValue("@NgaySinh", SqlDbType.Date).Value = ngaySinh;
                cmd.Parameters.AddWithValue("@GioiTinh", SqlDbType.NVarChar).Value = gioiTinh;
                cmd.Parameters.AddWithValue("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
                cmd.Parameters.AddWithValue("@SDT", SqlDbType.NVarChar).Value = sdt;
                cmd.Parameters.AddWithValue("@Email", SqlDbType.NVarChar).Value = email;
                cmd.Parameters.AddWithValue("@MaChucVu", SqlDbType.Int).Value = maChucVu;
                cmd.ExecuteNonQuery();
            }
            MyDB.CloseConnection();
        }
        public static bool checkNotEmpty(String field)
        {
            using (SqlCommand cmd = new SqlCommand("select dbo.fn_CheckNotEmpty(@Field)", MyDB.GetConnection))
            {
                MyDB.OpenConnection();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Field", field);
                bool result = (bool)cmd.ExecuteScalar();
                MyDB.CloseConnection();
                return result;
            }
        }
        public static void delete(int maNV)
        {
            MyDB.OpenConnection();
            using (SqlCommand cmd = new SqlCommand("exec sp_XoaNhanVien @MaNV", MyDB.GetConnection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@MaNV", SqlDbType.Int).Value = maNV;
                cmd.ExecuteNonQuery();
            }
            MyDB.CloseConnection();
        }
    }
}
