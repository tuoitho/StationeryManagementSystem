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
            dpNgayThanhToan.Value = DateTime.Parse(gvHD.CurrentRow.Cells[8].Value.ToString());
        }
    }
}
