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
    public partial class FormThemSanPhamVaoHDN : Form
    {
        public FormThemSanPhamVaoHDN()
        {
            InitializeComponent();
        }
        public FormThemSanPhamVaoHDN(int maHD) : this()
        {
            this.maHD = maHD;
        }
        public FormThemSanPhamVaoHDN(int maHD, bool isSua, int maSP) : this()
        {
            this.maHD = maHD;
            this.isSua = true;
            this.maSP = maSP;
        }
        int maHD, maSP;
        bool isSua = false;
        bool isLoaded = false;

        private void cbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;
            cbMaSP.SelectedValue = cbTenSP.SelectedValue;
            //click vào sản phẩm trong data grid view
            for (int i = 0; i < gvSP.Rows.Count; i++)
            {
                if (int.Parse(gvSP.Rows[i].Cells[0].Value.ToString()) == int.Parse(cbMaSP.SelectedValue.ToString()))
                {
                    gvSP.Rows[i].Selected = true;
                    gvSP.CurrentCell = gvSP.Rows[i].Cells[0];
                    break;
                }
            }
        }

        private void cbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;

            cbTenSP.SelectedValue = cbMaSP.SelectedValue;
            //click vào sản phẩm trong data grid view
            for (int i = 0; i < gvSP.Rows.Count; i++)
            {
                if (int.Parse(gvSP.Rows[i].Cells[0].Value.ToString()) == int.Parse(cbMaSP.SelectedValue.ToString()))
                {
                    gvSP.Rows[i].Selected = true;
                    gvSP.CurrentCell = gvSP.Rows[i].Cells[0];
                    break;
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!isSua)
            {

                int maSP = int.Parse(cbMaSP.SelectedValue.ToString());
                int soLuong = int.Parse(txtSoLuong.Text);
                float giaNhap = float.Parse(txtGiaNhap.Text);
                try
                {
                    CTHDNDAO.insert(maHD, maSP, soLuong, giaNhap);
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
                float giaNhap = float.Parse(txtGiaNhap.Text);
                try
                {
                    CTHDNDAO.update(maHD, maSP, soLuong, giaNhap);
                    MessageBox.Show("Sữa sản phẩm vào hóa đơn thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void gvSP_Click(object sender, EventArgs e)
        {
            int maSP = int.Parse(gvSP.CurrentRow.Cells[0].Value.ToString());
            cbMaSP.SelectedValue = maSP;
            cbTenSP.SelectedValue = maSP;
        }

        private void txtSearh_TextChanged(object sender, EventArgs e)
        {
            if (txtSearh.Text == "")
            {
                gvSP.DataSource = SanPhamDAO.findAll();
                return;
            }
            String input = txtSearh.Text;
            int maSP;
            DataTable dt = (DataTable)gvSP.DataSource;
            bool isNumber = int.TryParse(input, out maSP);  // Chuyển đổi chuỗi thành số (nếu có thể)
            if (isNumber)
            {
                DataRow[] rows = dt.Select("Mã SP = " + maSP);
                if (rows.Length == 0)
                {
                    gvSP.DataSource = null;
                    return;
                }
                DataTable newDt = dt.Clone();
                foreach (DataRow row in rows)
                {
                    newDt.ImportRow(row);
                }
                gvSP.DataSource = newDt;
            }
            else
            {
                DataRow[] rows = dt.Select("[Tên SP] like '%" + input + "%'");
                if (rows.Length == 0)
                {
                    gvSP.DataSource = null;
                    return;
                }
                DataTable newDt = dt.Clone();
                foreach (DataRow row in rows)
                {
                    newDt.ImportRow(row);
                }
                gvSP.DataSource = newDt;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void FormThemSanPhamVaoHDN_Load(object sender, EventArgs e)
        {
            gvSP.DataSource = SanPhamDAO.findAll();

            cbTenSP.DataSource = DAO.SanPhamDAO.findAll();
            cbTenSP.DisplayMember = "Tên SP";
            cbTenSP.ValueMember = "Mã SP";
            cbTenSP.SelectedIndex = -1;
            cbMaSP.DataSource = DAO.SanPhamDAO.findAll();
            cbMaSP.DisplayMember = "Mã SP";
            cbMaSP.ValueMember = "Mã SP";
            cbMaSP.SelectedIndex = -1;
            txtMaHD.Text = maHD.ToString();
            isLoaded = true;
            if (isSua)
            {
                cbMaSP.SelectedValue = maSP;
                cbTenSP.SelectedValue = maSP;
                cbMaSP.Enabled = false;
                cbTenSP.Enabled = false;
                gvSP.Enabled = false;

            }
        }
    }
}
