using StationeryManagementSystem.DAO;
using StationeryManagementSystem.GUI;
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
    public partial class FormHoaDonBan : Form
    {
        public FormHoaDonBan()
        {
            InitializeComponent();
        }

        private void FormHoaDonBan_Load(object sender, EventArgs e)
        {
            dpNgayThanhToan.Value = DateTime.Today;
            gvHD.DataSource = HoaDonBanDAO.findAll();
            cbMaKH.DataSource = KhachHangDAO.findAll();
            cbMaKH.DisplayMember = "Mã KH";
            cbMaKH.ValueMember = "Mã KH";

            cbMaNV.DataSource = NhanVienDao.findAll();
            cbMaNV.DisplayMember = "MaNhanVien";
            cbMaNV.ValueMember = "MaNhanVien";
        }

        private void UCThemSanPham_Load(object sender, EventArgs e)
        {

        }

        private void gvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvHD_Click(object sender, EventArgs e)
        {
            int maHD = int.Parse(gvHD.CurrentRow.Cells[0].Value.ToString());
            txtMaHD.Text = maHD.ToString();
            cbMaKH.SelectedValue = gvHD.CurrentRow.Cells[4].Value.ToString();
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
            txtTenKH.Text = gvHD.CurrentRow.Cells[5].Value.ToString();
            txtTenNV.Text = gvHD.CurrentRow.Cells[3].Value.ToString();
            guna2TextBox1_tttt.Text = gvHD.CurrentRow.Cells[7].Value.ToString();
            gvSP.DataSource = CTHDBDAO.findAllByMaHD(maHD);
        }

        private void UCHoaDonBan_Load(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int maKH = int.Parse(cbMaKH.SelectedValue.ToString());
            int maNV = int.Parse(cbMaNV.SelectedValue.ToString());
            try
            {
                HoaDonBanDAO.insert(maNV, maKH);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            gvHD.DataSource = HoaDonBanDAO.findAll();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            FormThemSanPhamVaoHDB formThemSanPhamVaoHDB = new FormThemSanPhamVaoHDB(int.Parse(txtMaHD.Text));
            formThemSanPhamVaoHDB.ShowDialog();
            int maHD = int.Parse(txtMaHD.Text);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            int maHD = int.Parse(txtMaHD.Text);
            gvSP.DataSource = CTHDBDAO.findAllByMaHD(maHD);

        }
    }
}