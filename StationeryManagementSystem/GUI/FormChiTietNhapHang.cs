﻿using StationeryManagementSystem.DAO;
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
    public partial class FormChiTietNhapHang : Form
    {
        private int thang;
        private int nam;
        public FormChiTietNhapHang(int month, int year)
        {

            InitializeComponent();
            this.thang = month;
            this.nam = year;
        }

        private void FormChiTietNhapHang_Load(object sender, EventArgs e)
        {
            gvNhapHang.DataSource = HoaDonNhapDAO.PhiNhapHangTrongThang(thang, nam);
        }
    }
}
