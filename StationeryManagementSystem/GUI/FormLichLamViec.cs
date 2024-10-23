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
            gvPhanCa.DataSource = PhanCaDAO.findAll(DateTime.Today, true);
            guna2ComboBox1_manv.DataSource = NhanVienDAO.findAll();
            guna2ComboBox1_manv.DisplayMember = "MaNhanVien";
            guna2ComboBox1_manv.ValueMember = "MaNhanVien";
            guna2ComboBox1_manv.SelectedIndex = -1;
            gvDangKy.DataSource = PhanCaDAO.findAll(DateTime.Today, false);

        }

        private void pbSearch_MouseEnter(object sender, EventArgs e)
        {
            //pbSearch.Size = new Size(pbSearch.Width + 10, pbSearch.Height + 10);
            //pbSearch.Location = new Point(pbSearch.Location.X - 5, pbSearch.Location.Y - 5);
        }

        private void pbSearch_MouseLeave(object sender, EventArgs e)
        {
            //pbSearch.Size = new Size(pbSearch.Width - 10, pbSearch.Height - 10);
            //pbSearch.Location = new Point(pbSearch.Location.X + 5, pbSearch.Location.Y + 5);
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

        private void guna2Button2_show_Click(object sender, EventArgs e)
        {
            gvPhanCa.DataSource = PhanCaDAO.findAll(guna2DateTimePicker1.Value, true);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            gvPhanCa.DataSource = PhanCaDAO.findAll(guna2DateTimePicker1.Value, true);
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(gvPhanCa.CurrentRow.Cells[0].Value.ToString());
            int maca = int.Parse(gvPhanCa.CurrentRow.Cells[1].Value.ToString());
            DateTime ngay = DateTime.Parse(gvPhanCa.CurrentRow.Cells[2].Value.ToString());
            DateTime moctime = guna2DateTimePicker2_moctime.Value;
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
            DateTime moctime = guna2DateTimePicker2_moctime.Value;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DateTime chonngay = dpChonNgay.Value;
            gvDangKy.DataSource = PhanCaDAO.findAll(chonngay, false);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(guna2ComboBox1_manv.Text);
            DateTime ngayca3 = guna2DateTimePicker2_ca3.Value;
            try
            {
                PhanCaDAO.dangKiCa3(manv, ngayca3);
                MessageBox.Show("Đăng kí ca 3 thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvDangKy.DataSource = PhanCaDAO.findAll(ngayca3, false);
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
                MessageBox.Show("Tu choi ca 3 thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvDangKy.DataSource = PhanCaDAO.findAll(ngay, false);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
