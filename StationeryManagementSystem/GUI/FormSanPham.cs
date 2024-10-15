using Guna.UI2.WinForms;
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
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
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
        private void FormSanPham_Load(object sender, EventArgs e)
        {
            gvSP.DataSource = SanPhamDAO.findAll();
            dataGridView1.DataSource = SanPhamDAO.getXemSoLuongSanPhamDaBanTrongNgay();
            cbMaLoai.DataSource = LoaiSanPhamDAO.findAll();
            cbMaLoai.DisplayMember = "MaLoaiSanPham";
            cbMaLoai.ValueMember = "TenLoaiSanPham";
            txtTenLoai.Enabled = false;
            cbMaNCC.DataSource = NhaCungCapDAO.findAll();
            cbMaNCC.DisplayMember = "Mã NCC";
            //cbMaNCC.ValueMember = "Mã NCC";
        }

        private void gvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvSP_Click(object sender, EventArgs e)
        {
            //display
            txtMaSP.Text = gvSP.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text = gvSP.CurrentRow.Cells[1].Value.ToString();
            txtTenLoai.Text = gvSP.CurrentRow.Cells[2].Value.ToString();
            txtGiaNhap.Text = gvSP.CurrentRow.Cells[4].Value.ToString();
            txtGiaBan.Text = gvSP.CurrentRow.Cells[5].Value.ToString();
            txtSoLuong.Text = gvSP.CurrentRow.Cells[6].Value.ToString();
            if (gvSP.CurrentRow.Cells[7].Value is DBNull)
            {
         }
            else
            {
                cbMaNCC.SelectedValue = gvSP.CurrentRow.Cells[3].Value.ToString();

            }

        }

        private void cbMaLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenLoai.Text = cbMaLoai.SelectedValue.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
      
}
