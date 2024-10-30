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

namespace StationeryManagementSystem.GUI
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            gvKH.DataSource = KhachHangDAO.findAll();
        }

        private void LamTrongField()
        {
            txtMaKH.Text = "";
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            LamTrongField();
            gvKH.DataSource = KhachHangDAO.findAll();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (gvKH.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = gvKH.SelectedRows[0];

            if (selectedRow.IsNewRow || string.IsNullOrWhiteSpace(selectedRow.Cells["maKH"].Value?.ToString()))
            {
                MessageBox.Show("Dòng được chọn không hợp lệ. Vui lòng chọn một dòng dữ liệu hợp lệ để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                int maKH = int.Parse(txtMaKH.Text);
                string hoTen = txtHoTen.Text;
                string diaChi = txtDiaChi.Text;
                string sdt = txtSDT.Text;
                KhachHangDAO.update(maKH, hoTen, diaChi, sdt);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Chọn khách hàng để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String hoTen = txtHoTen.Text;
            String diaChi = txtDiaChi.Text;
            String sdt = txtSDT.Text;
            try
            {
                KhachHangDAO.insert(hoTen, diaChi, sdt);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (gvKH.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng dữ liệu nhân viên để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                try
                {
                    int maKH = int.Parse(txtMaKH.Text);
                    CommonDAO.deleteRecord("KhachHang", "MaKhachHang", maKH);
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Chọn sản khách hàng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            /*if (txtSearch.Text == "")
            {
                gvKH.DataSource = KhachHangDAO.findAll();
                return;
            }
            string input = txtSearch.Text;
            int maKH;
            DataTable dt = (DataTable)gvKH.DataSource;
            bool isNumber = int.TryParse(input, out maKH);  // Chuyển đổi chuỗi thành số (nếu có thể)

            if (isNumber)
            {
                // Nếu input là số, sử dụng bộ lọc cho Mã SP là số và các cột khác là chuỗi
                dt.DefaultView.RowFilter = "[Mã KH] = " + maKH +
                                           " OR [Họ Tên] LIKE '%" + input + "%' ";
            }
            else
            {
                // Nếu input không phải là số, chỉ áp dụng bộ lọc cho các cột chuỗi
                dt.DefaultView.RowFilter = "[Họ Tên] LIKE '%" + input + "%' ";
            }

            gvKH.DataSource = dt;*/
            gvKH.DataSource = CommonDAO.search("KhachHang", txtSearch.Text);
        }

        private void gvKH_Click(object sender, EventArgs e)
        {
            var selectedRow = gvKH.SelectedRows[0];
            if (selectedRow.IsNewRow || string.IsNullOrWhiteSpace(selectedRow.Cells["maKH"].Value?.ToString()))
            {
                MessageBox.Show("Vui lòng chọn dữ liệu hợp lệ để thao tác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int maKH = int.Parse(gvKH.CurrentRow.Cells["maKH"].Value.ToString());
                txtMaKH.Text = maKH.ToString();
                txtHoTen.Text = gvKH.CurrentRow.Cells["tenKH"].Value.ToString();
                txtDiaChi.Text = gvKH.CurrentRow.Cells["diaChi"].Value.ToString();
                txtSDT.Text = gvKH.CurrentRow.Cells["soDienThoai"].Value.ToString();
            }
        }
    }
}
