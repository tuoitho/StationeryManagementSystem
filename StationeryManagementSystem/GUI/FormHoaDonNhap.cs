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
        }

        private void gvHD_Click(object sender, EventArgs e)
        {
            
        }

        private void UCHoaDonNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
