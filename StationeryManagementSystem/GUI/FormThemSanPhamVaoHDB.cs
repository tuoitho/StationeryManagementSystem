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
        public FormThemSanPhamVaoHDB(int maHD,bool isSua,int maSP) : this()
        {
            this.maHD = maHD;
            this.isSua= true;
            this.maSP= maSP;
        }
        int maHD,maSP;
        bool isSua = false;
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
            if (isSua)
            {
                cbMaSP.SelectedValue = maSP; 
                cbTenSP.SelectedValue = maSP;
                cbMaSP.Enabled = false;
                cbTenSP.Enabled = false;
            }
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
            if (!isSua)
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
            else
            {
                int maSP = int.Parse(cbMaSP.SelectedValue.ToString());
                int soLuong = int.Parse(txtSoLuong.Text);
                try
                {
                    CTHDBDAO.update(maHD, maSP, soLuong);
                    MessageBox.Show("Sữa sản phẩm vào hóa đơn thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
