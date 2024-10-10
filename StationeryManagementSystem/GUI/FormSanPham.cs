using Guna.UI2.WinForms;
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
            InitializePanel();
        }
        private void InitializePanel()
        {
            pnSP.BorderColor = System.Drawing.Color.Black; // Màu viền
            pnSP.BorderThickness = 1; // Độ dày viền
            pnSP.BackColor = System.Drawing.Color.Transparent;
            pnListSP.BorderColor = System.Drawing.Color.Black; // Màu viền
            pnListSP.BorderThickness = 1; // Độ dày viền
            pnListSP.BackColor = System.Drawing.Color.Transparent;
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
    }
}
