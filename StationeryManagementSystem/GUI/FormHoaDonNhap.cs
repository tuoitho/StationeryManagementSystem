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
    public partial class FormHoaDonNhap : Form
    {
        public FormHoaDonNhap()
        {
            InitializeComponent();
        }

        private void FormHoaDonNhap_Load(object sender, EventArgs e)
        {
            dpNgayThanhToan.Value = DateTime.Today;
            gvHD.DataSource = HoaDonNhapDAO.findAll();
            //style date dd/mm/yyyy col1,8
            gvHD.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            gvHD.Columns[8].DefaultCellStyle.Format = "dd/MM/yyyy";


            cbMNNCC.DataSource = NhaCungCapDAO.findAll();
            cbMNNCC.DisplayMember = "Mã NCC";
            cbMNNCC.ValueMember = "Mã NCC";

            cbMaNV.DataSource = NhanVienDao.findAll();
            cbMaNV.DisplayMember = "MaNhanVien";
            cbMaNV.ValueMember = "MaNhanVien";
            cbTrangThaiThanhToan.DataSource = new List<string> { "Chưa thanh toán", "Đã thanh toán" };
        }

        private void gvHD_Click(object sender, EventArgs e)
        {
            if (gvHD.CurrentRow == null) return;
            int maHD = int.Parse(gvHD.CurrentRow.Cells[0].Value.ToString());
            txtMaHD.Text = maHD.ToString();
            cbMNNCC.SelectedValue = gvHD.CurrentRow.Cells[4].Value.ToString();
            cbMaNV.SelectedValue = gvHD.CurrentRow.Cells[2].Value.ToString();
            txtTongTin.Text = gvHD.CurrentRow.Cells[6].Value.ToString();
            if (gvHD.CurrentRow.Cells[8].Value is DBNull)
            {
                dpNgayThanhToan.Visible = false;
            }
            else
            {
                dpNgayThanhToan.Visible = true;
                dpNgayThanhToan.Value = DateTime.Parse(gvHD.CurrentRow.Cells[8].Value.ToString());
            }
            txtTenNCC.Text = gvHD.CurrentRow.Cells[5].Value.ToString();
            txtTenNV.Text = gvHD.CurrentRow.Cells[3].Value.ToString();
            cbTrangThaiThanhToan.Text = gvHD.CurrentRow.Cells[7].Value.ToString();
            gvSP.DataSource = CTHDNDAO.findAllByMaHD(maHD);
        }

        private void UCHoaDonNhap_Load(object sender, EventArgs e)
        {
            int maNcc = int.Parse(cbMNNCC.SelectedValue.ToString());
            int maNV = int.Parse(cbMaNV.SelectedValue.ToString());
            try
            {
                HoaDonNhapDAO.insert(maNV, maNcc);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvHD.DataSource = HoaDonBanDAO.findAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                MessageBox.Show("Chọn hóa đơn cần thêm sp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormThemSanPhamVaoHDN formThemSanPhamVaoHDB = new FormThemSanPhamVaoHDN(int.Parse(txtMaHD.Text));
            formThemSanPhamVaoHDB.ShowDialog();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int maNCC = int.Parse(cbMNNCC.SelectedValue.ToString());
            int maNV = int.Parse(cbMaNV.SelectedValue.ToString());
            try
            {
                HoaDonNhapDAO.insert(maNV, maNCC);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvHD.DataSource = HoaDonNhapDAO.findAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            int maHD = int.Parse(txtMaHD.Text);
            String trangThai = cbTrangThaiThanhToan.Text;
            try
            {
                HoaDonNhapDAO.update(maHD, trangThai);
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gvHD.DataSource = HoaDonNhapDAO.findAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            gvHD.DataSource = HoaDonNhapDAO.findAll();

        }

        private void pbSearch_Click(object sender, EventArgs e)
        {
            DateTime dps = dpStart.Value;
            DateTime dpe = dpEnd.Value;

            DataTable dt = (DataTable)gvHD.DataSource;


            dt.DefaultView.RowFilter = "[Ngày Lập] >= #" + dps.ToString("MM/dd/yyyy") + "# AND [Ngày Lập] <= #" + dpe.ToString("MM/dd/yyyy") + "#";



            gvSP.DataSource = dt;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            int maHD = int.Parse(txtMaHD.Text);
            try
            {
                HoaDonNhapDAO.delete(maHD);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
