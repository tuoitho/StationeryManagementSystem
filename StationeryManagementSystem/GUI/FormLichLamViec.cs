using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryManagementSystem.GUI
{
    public partial class FormLichLamViec : Form
    {
        public FormLichLamViec()
        {
            InitializeComponent();
        }

        private void FormLichLamViec_Load(object sender, EventArgs e)
        {
            dpStart.Value = DateTime.Today;
            dpEnd.Value = DateTime.Today;

        }

        private void pbSearch_MouseEnter(object sender, EventArgs e)
        {
            //pbSearch.Size = new Size(pbSearch.Width + 10, pbSearch.Height + 10);
            //pbSearch.Location = new Point(pbSearch.Location.X - 5, pbSearch.Location.Y - 5);
        }

        private void pbSearch_MouseLeave(object sender, EventArgs e)
        {
            //pbSearch.Size = new Size(pbSearch.Width - 10, pbSearch.Height - 10);
            //pbSearch.Location = new Point(pbSearch.Location.X + 5, pbSearch.Location.Y + 5);
        }

        private void btnPhanCa_Click(object sender, EventArgs e)
        {

        }
    }
}
