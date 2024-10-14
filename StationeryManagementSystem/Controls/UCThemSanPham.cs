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
    public partial class UCThemSanPham : UserControl
    {
        public UCThemSanPham()
        {
            InitializeComponent();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            FormThemSanPhamVaoHoaDon f = new FormThemSanPhamVaoHoaDon();
            f.ShowDialog();
        }

        private void gbSP_Click(object sender, EventArgs e)
        {

        }
    }
}
