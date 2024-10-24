using StationeryManagementSystem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryManagementSystem.GUI
{
    public partial class FormLichLamViec : Form
    {
        public FormLichLamViec()
        {
            InitializeComponent();
        }

        private void FormLichLamViec_Load(object sender, EventArgs e)
        {
            dpStart.Value = DateTime.Today;
            dpEnd.Value = DateTime.Today;
            dpChonNgay.Value = DateTime.Today;
            dpHienThi.Value = DateTime.Today;
            dpCa3.Value = DateTime.Today;
            dpNgayLuong.Value = DateTime.Today;
            gvPhanCa.DataSource = PhanCaDAO.findAll(DateTime.Today, true);
            gvPhanCa.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            cbMaNV.DataSource = NhanVienDAO.findAll();
            cbMaNV.DisplayMember = "MaNhanVien";
            cbMaNV.ValueMember = "MaNhanVien";
            cbMaNV.SelectedIndex = -1;
            gvDangKy.DataSource = PhanCaDAO.findAll(DateTime.Today, false);
            gvDangKy.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";


        }


        private void btnPhanCa_Click(object sender, EventArgs e)
        {
            DateTime start = dpStart.Value;
            DateTime end = dpEnd.Value;
            try
            {
                PhanCaDAO.phanCa(start, end);
                MessageBox.Show("Phân ca thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(gvPhanCa.CurrentRow.Cells[0].Value.ToString());
            int maca = int.Parse(gvPhanCa.CurrentRow.Cells[1].Value.ToString());
            DateTime ngay = DateTime.Parse(gvPhanCa.CurrentRow.Cells[2].Value.ToString());
            DateTime moctime = dp_moctime.Value;
            try
            {
                PhanCaDAO.checkIn(manv, maca, ngay, moctime);
                MessageBox.Show("Check in thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(gvPhanCa.CurrentRow.Cells[0].Value.ToString());
            int maca = int.Parse(gvPhanCa.CurrentRow.Cells[1].Value.ToString());
            DateTime ngay = DateTime.Parse(gvPhanCa.CurrentRow.Cells[2].Value.ToString());
            DateTime moctime = dp_moctime.Value;
            try
            {
                PhanCaDAO.checkout(manv, maca, ngay, moctime);
                MessageBox.Show("Check out thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
  
       

        private void btnPheDuyet_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(gvDangKy.CurrentRow.Cells[0].Value.ToString());
            DateTime ngay = DateTime.Parse(gvDangKy.CurrentRow.Cells[2].Value.ToString());
            try
            {
                PhanCaDAO.duyetCa3(manv, ngay);
                MessageBox.Show("Phê duyệt ca 3 thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvDangKy.DataSource = PhanCaDAO.findAll(ngay, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(gvDangKy.CurrentRow.Cells[0].Value.ToString());
            DateTime ngay = DateTime.Parse(gvDangKy.CurrentRow.Cells[2].Value.ToString());
            try
            {
                PhanCaDAO.tuChoiCa3(manv, ngay);
                MessageBox.Show("Từ chối  ca 3 thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvDangKy.DataSource = PhanCaDAO.findAll(ngay, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDKCa3_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(cbMaNV.Text);
            DateTime ngayca3 = dpCa3.Value;
            try
            {
                PhanCaDAO.dangKiCa3(manv, ngayca3);
                MessageBox.Show("Đăng kí ca 3 thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvDangKy.DataSource = PhanCaDAO.findAll(ngayca3, false);
                cbMaNV.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            DateTime chonngay = dpChonNgay.Value;
            gvDangKy.DataSource = PhanCaDAO.findAll(chonngay, false);
        }

        private void pbSearch_MouseEnter(object sender, EventArgs e)
        {
            pbSearch.Size = new Size(pbSearch.Width + 10, pbSearch.Height + 10);
            pbSearch.Location = new Point(pbSearch.Location.X - 5, pbSearch.Location.Y - 5);
        }

        private void pbSearch_MouseLeave(object sender, EventArgs e)
        {
            pbSearch.Size = new Size(pbSearch.Width - 10, pbSearch.Height - 10);
            pbSearch.Location = new Point(pbSearch.Location.X + 5, pbSearch.Location.Y + 5);
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            gvPhanCa.DataSource = PhanCaDAO.findAll(dpHienThi.Value, true);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            gvPhanCa.DataSource = PhanCaDAO.findAll(dpHienThi.Value, true);
        }

        private void pbSearchLuong_Click(object sender, EventArgs e)
        {
            gvLuong.DataSource = LuongDAO.LuongTrongNgay(dpNgayLuong.Value);
        }

        private void pbSearchLuong_MouseEnter(object sender, EventArgs e)
        {
            pbSearchLuong.Size = new Size(pbSearchLuong.Width + 10, pbSearchLuong.Height + 10);
            pbSearchLuong.Location = new Point(pbSearchLuong.Location.X - 5, pbSearchLuong.Location.Y - 5);
        }

        private void pbSearchLuong_MouseLeave(object sender, EventArgs e)
        {
            pbSearchLuong.Size = new Size(pbSearchLuong.Width - 10, pbSearchLuong.Height - 10);
            pbSearchLuong.Location = new Point(pbSearchLuong.Location.X + 5, pbSearchLuong.Location.Y + 5);
        }
    }
}
