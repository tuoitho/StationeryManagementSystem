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
    public partial class UCSearchBill : UserControl
    {
        public UCSearchBill()
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

        private void UCSearchBill_Load(object sender, EventArgs e)
        {
            if (dpStart.Value.Date != DateTime.Today || dpEnd.Value.Date != DateTime.Today)
            {
                dpStart.Value = DateTime.Today;
                dpEnd.Value = DateTime.Today;
            }
        }
    }
}
