using StationeryManagementSystem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryManagementSystem
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            gvNhanVien.DataSource = NhanVienDao.findAll();
        }


        private void gvNhanVien_Click(object sender, EventArgs e)
        {
            if (gvNhanVien.CurrentRow == null || gvNhanVien.CurrentRow.Cells[0].Value == null)
            {
                return;
            }
            txtMaNV.Text = gvNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = gvNhanVien.CurrentRow.Cells[1].Value.ToString();
            dpNgaySinh.Value = DateTime.Parse(gvNhanVien.CurrentRow.Cells[2].Value.ToString());
            rdNam.Checked = (bool)gvNhanVien.CurrentRow.Cells[3].Value.ToString().Equals("Nam");
            rdNu.Checked = (bool)gvNhanVien.CurrentRow.Cells[3].Value.ToString().Equals("Nữ");
            txtDiaChi.Text = gvNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtSDT.Text = gvNhanVien.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = gvNhanVien.CurrentRow.Cells[6].Value.ToString();
            rdBanHang.Checked = (bool)gvNhanVien.CurrentRow.Cells[7].Value.ToString().Contains("án");
            rdKiemKho.Checked = (bool)gvNhanVien.CurrentRow.Cells[7].Value.ToString().Contains("ho");
            txtLuong.Text = gvNhanVien.CurrentRow.Cells[8].Value.ToString();

        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            gvNhanVien.DataSource = NhanVienDao.findAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(txtMaNV.Text);
            String hoTen = txtHoTen.Text;
            DateTime ngaySinh = dpNgaySinh.Value;
            String gioiTinh = rdNam.Checked ? "Nam" : "Nữ";
            String diaChi = txtDiaChi.Text;
            String sdt = txtSDT.Text;
            String email = txtEmail.Text;
            int chucVu = 1;
            if (rdBanHang.Checked)
            {
                chucVu = 1;
            }
            else if (rdKiemKho.Checked)
            {
                chucVu = 2;
            }
                     
            try
            {
                NhanVienDao.update(maNV, hoTen, ngaySinh, gioiTinh, diaChi, sdt, email, chucVu);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String hoTen = txtHoTen.Text;
            DateTime ngaySinh = dpNgaySinh.Value;
            String gioiTinh = rdNam.Checked ? "Nam" : "Nữ";
            String diaChi = txtDiaChi.Text;
            String sdt = txtSDT.Text;
            String email = txtEmail.Text;
            int chucVu = 1;
            if (rdBanHang.Checked)
            {
                chucVu = 1;
            }
            else if (rdKiemKho.Checked)
            {
                chucVu = 2;
            }
            
            try
            {
                NhanVienDao.insert(hoTen, ngaySinh, gioiTinh, diaChi, sdt, email, chucVu);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int maNV = int.Parse(txtMaNV.Text);
            try
            {
                NhanVienDao.delete(maNV);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
