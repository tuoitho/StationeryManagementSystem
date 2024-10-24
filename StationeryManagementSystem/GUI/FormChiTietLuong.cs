using StationeryManagementSystem.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryManagementSystem.GUI
{
    public partial class FormChiTietLuong : Form
    {
        private int thang;
        private int nam;
        public FormChiTietLuong(int month, int year)
        {
            InitializeComponent();
            this.thang = month;
            this.nam = year;

        }

        private void FormChiTietLuong_Load(object sender, EventArgs e)
        {
            gvLuong.DataSource = LuongDAO.LuongTrongThang(thang, nam);
        }
    }
}
