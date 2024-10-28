using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationeryManagementSystem.DAO
{
    internal class NhanVienDAO
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
        //public static void delete(int maNV)
        //{
        //    MyDB.OpenConnection();
        //    using (SqlCommand cmd = new SqlCommand("exec sp_XoaNhanVien @MaNV", MyDB.GetConnection))
        //    {
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Parameters.AddWithValue("@MaNV", SqlDbType.Int).Value = maNV;
        //        cmd.ExecuteNonQuery();
        //    }
        //    MyDB.CloseConnection();
        //}
        
    }
}
