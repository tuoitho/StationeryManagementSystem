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
    public partial class FormThemSanPhamVaoHDB : Form
    {
        public FormThemSanPhamVaoHDB()
        {
            InitializeComponent();
        }
        public FormThemSanPhamVaoHDB(int maHD):this()
        {   
            this.maHD = maHD;
        }
        int maHD;
        bool isLoaded = false;
        private void FormThemSanPhamVaoHDB_Load(object sender, EventArgs e)
        {
            cbTenSP.DataSource = DAO.SanPhamDAO.findAll();
            cbTenSP.DisplayMember = "TenSanPham";
            cbTenSP.ValueMember = "MaSanPham";
            cbTenSP.SelectedIndex = -1;
            cbMaSP.DataSource = DAO.SanPhamDAO.findAll();
            cbMaSP.DisplayMember = "MaSanPham";
            cbMaSP.ValueMember = "MaSanPham";
            cbMaSP.SelectedIndex = -1;
            txtMaHD.Text = maHD.ToString();
            isLoaded = true;
        }

        private void cbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            cbMaSP.SelectedValue = cbTenSP.SelectedValue;
        }

        private void cbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;

            cbTenSP.SelectedValue = cbMaSP.SelectedValue;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(cbMaSP.SelectedValue.ToString());
            int soLuong = int.Parse(txtSoLuong.Text);
            try
            {
                CTHDBDAO.insert(maHD, maSP, soLuong);
                MessageBox.Show("Thêm sản phẩm vào hóa đơn thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
