﻿namespace StationeryManagementSystem.GUI
{
    partial class FormHoaDonNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvHD = new System.Windows.Forms.DataGridView();
            this.txtTongTin = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTongThanhToan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dpNgayThanhToan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayThanhToan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTenNCC = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTenNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTrangThai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbMNNCC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnHoaDon = new Guna.UI2.WinForms.Guna2Panel();
            this.cbTrangThaiThanhToan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbMaNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTenNV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNCC = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaNV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMaHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaHD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UCHoaDonNhap = new StationeryManagementSystem.Controls.UCHoaDon();
            this.gbSP = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gvSP = new System.Windows.Forms.DataGridView();
            this.btnReLoad = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvHD)).BeginInit();
            this.pnHoaDon.SuspendLayout();
            this.gbSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // gvHD
            // 
            this.gvHD.BackgroundColor = System.Drawing.Color.White;
            this.gvHD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvHD.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvHD.GridColor = System.Drawing.Color.White;
            this.gvHD.Location = new System.Drawing.Point(28, 175);
            this.gvHD.Name = "gvHD";
            this.gvHD.ReadOnly = true;
            this.gvHD.RowHeadersWidth = 51;
            this.gvHD.RowTemplate.Height = 24;
            this.gvHD.Size = new System.Drawing.Size(730, 413);
            this.gvHD.TabIndex = 58;
            this.gvHD.Click += new System.EventHandler(this.gvHD_Click);
            // 
            // txtTongTin
            // 
            this.txtTongTin.BorderColor = System.Drawing.Color.Teal;
            this.txtTongTin.BorderRadius = 10;
            this.txtTongTin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTin.DefaultText = "0";
            this.txtTongTin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongTin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongTin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongTin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTin.ForeColor = System.Drawing.Color.Teal;
            this.txtTongTin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTin.Location = new System.Drawing.Point(267, 708);
            this.txtTongTin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongTin.Name = "txtTongTin";
            this.txtTongTin.PasswordChar = '\0';
            this.txtTongTin.PlaceholderText = "";
            this.txtTongTin.SelectedText = "";
            this.txtTongTin.Size = new System.Drawing.Size(156, 36);
            this.txtTongTin.TabIndex = 48;
            // 
            // lblTongThanhToan
            // 
            this.lblTongThanhToan.BackColor = System.Drawing.SystemColors.Control;
            this.lblTongThanhToan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongThanhToan.ForeColor = System.Drawing.Color.Teal;
            this.lblTongThanhToan.Location = new System.Drawing.Point(267, 669);
            this.lblTongThanhToan.Name = "lblTongThanhToan";
            this.lblTongThanhToan.Size = new System.Drawing.Size(82, 26);
            this.lblTongThanhToan.TabIndex = 47;
            this.lblTongThanhToan.Text = "Tổng tiền";
            // 
            // dpNgayThanhToan
            // 
            this.dpNgayThanhToan.BackColor = System.Drawing.SystemColors.Control;
            this.dpNgayThanhToan.BorderColor = System.Drawing.Color.Teal;
            this.dpNgayThanhToan.BorderRadius = 10;
            this.dpNgayThanhToan.BorderThickness = 1;
            this.dpNgayThanhToan.Checked = true;
            this.dpNgayThanhToan.FillColor = System.Drawing.Color.White;
            this.dpNgayThanhToan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpNgayThanhToan.ForeColor = System.Drawing.Color.Teal;
            this.dpNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpNgayThanhToan.Location = new System.Drawing.Point(22, 620);
            this.dpNgayThanhToan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpNgayThanhToan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpNgayThanhToan.Name = "dpNgayThanhToan";
            this.dpNgayThanhToan.Size = new System.Drawing.Size(327, 36);
            this.dpNgayThanhToan.TabIndex = 23;
            this.dpNgayThanhToan.Value = new System.DateTime(2024, 10, 12, 0, 0, 0, 0);
            // 
            // lblNgayThanhToan
            // 
            this.lblNgayThanhToan.BackColor = System.Drawing.SystemColors.Control;
            this.lblNgayThanhToan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThanhToan.ForeColor = System.Drawing.Color.Teal;
            this.lblNgayThanhToan.Location = new System.Drawing.Point(22, 587);
            this.lblNgayThanhToan.Name = "lblNgayThanhToan";
            this.lblNgayThanhToan.Size = new System.Drawing.Size(143, 26);
            this.lblNgayThanhToan.TabIndex = 22;
            this.lblNgayThanhToan.Text = "Ngày thanh toán";
            // 
            // lblTenNCC
            // 
            this.lblTenNCC.BackColor = System.Drawing.SystemColors.Control;
            this.lblTenNCC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNCC.ForeColor = System.Drawing.Color.Teal;
            this.lblTenNCC.Location = new System.Drawing.Point(22, 180);
            this.lblTenNCC.Name = "lblTenNCC";
            this.lblTenNCC.Size = new System.Drawing.Size(74, 26);
            this.lblTenNCC.TabIndex = 21;
            this.lblTenNCC.Text = "Tên NCC";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.BorderColor = System.Drawing.Color.Teal;
            this.txtTenNCC.BorderRadius = 10;
            this.txtTenNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNCC.DefaultText = "";
            this.txtTenNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNCC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.ForeColor = System.Drawing.Color.Teal;
            this.txtTenNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNCC.Location = new System.Drawing.Point(22, 213);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.PasswordChar = '\0';
            this.txtTenNCC.PlaceholderText = "";
            this.txtTenNCC.SelectedText = "";
            this.txtTenNCC.Size = new System.Drawing.Size(341, 36);
            this.txtTenNCC.TabIndex = 20;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.BackColor = System.Drawing.SystemColors.Control;
            this.lblTrangThai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.Color.Teal;
            this.lblTrangThai.Location = new System.Drawing.Point(22, 669);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(187, 26);
            this.lblTrangThai.TabIndex = 50;
            this.lblTrangThai.Text = "Trạng thái thanh toán";
            // 
            // cbMNNCC
            // 
            this.cbMNNCC.BackColor = System.Drawing.Color.Transparent;
            this.cbMNNCC.BorderColor = System.Drawing.Color.Teal;
            this.cbMNNCC.BorderRadius = 10;
            this.cbMNNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMNNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMNNCC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMNNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMNNCC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMNNCC.ForeColor = System.Drawing.Color.Teal;
            this.cbMNNCC.ItemHeight = 30;
            this.cbMNNCC.Location = new System.Drawing.Point(269, 46);
            this.cbMNNCC.Name = "cbMNNCC";
            this.cbMNNCC.Size = new System.Drawing.Size(117, 36);
            this.cbMNNCC.TabIndex = 19;
            // 
            // pnHoaDon
            // 
            this.pnHoaDon.BorderColor = System.Drawing.Color.Teal;
            this.pnHoaDon.BorderRadius = 10;
            this.pnHoaDon.BorderThickness = 2;
            this.pnHoaDon.Controls.Add(this.gbSP);
            this.pnHoaDon.Controls.Add(this.cbTrangThaiThanhToan);
            this.pnHoaDon.Controls.Add(this.lblTrangThai);
            this.pnHoaDon.Controls.Add(this.txtTongTin);
            this.pnHoaDon.Controls.Add(this.lblTongThanhToan);
            this.pnHoaDon.Controls.Add(this.dpNgayThanhToan);
            this.pnHoaDon.Controls.Add(this.lblNgayThanhToan);
            this.pnHoaDon.Controls.Add(this.lblTenNCC);
            this.pnHoaDon.Controls.Add(this.txtTenNCC);
            this.pnHoaDon.Controls.Add(this.cbMNNCC);
            this.pnHoaDon.Controls.Add(this.txtTenNV);
            this.pnHoaDon.Controls.Add(this.cbMaNV);
            this.pnHoaDon.Controls.Add(this.lblTenNV);
            this.pnHoaDon.Controls.Add(this.lblNCC);
            this.pnHoaDon.Controls.Add(this.lblMaNV);
            this.pnHoaDon.Controls.Add(this.txtMaHD);
            this.pnHoaDon.Controls.Add(this.lblMaHD);
            this.pnHoaDon.ForeColor = System.Drawing.Color.Teal;
            this.pnHoaDon.Location = new System.Drawing.Point(787, 22);
            this.pnHoaDon.Name = "pnHoaDon";
            this.pnHoaDon.Size = new System.Drawing.Size(470, 770);
            this.pnHoaDon.TabIndex = 57;
            // 
            // cbTrangThaiThanhToan
            // 
            this.cbTrangThaiThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.cbTrangThaiThanhToan.BorderColor = System.Drawing.Color.Teal;
            this.cbTrangThaiThanhToan.BorderRadius = 10;
            this.cbTrangThaiThanhToan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTrangThaiThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThaiThanhToan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThaiThanhToan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThaiThanhToan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThaiThanhToan.ForeColor = System.Drawing.Color.Teal;
            this.cbTrangThaiThanhToan.ItemHeight = 30;
            this.cbTrangThaiThanhToan.Location = new System.Drawing.Point(27, 708);
            this.cbTrangThaiThanhToan.Name = "cbTrangThaiThanhToan";
            this.cbTrangThaiThanhToan.Size = new System.Drawing.Size(210, 36);
            this.cbTrangThaiThanhToan.TabIndex = 51;
            // 
            // txtTenNV
            // 
            this.txtTenNV.BorderColor = System.Drawing.Color.Teal;
            this.txtTenNV.BorderRadius = 10;
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.DefaultText = "";
            this.txtTenNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.Teal;
            this.txtTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Location = new System.Drawing.Point(22, 124);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PasswordChar = '\0';
            this.txtTenNV.PlaceholderText = "";
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.Size = new System.Drawing.Size(341, 36);
            this.txtTenNV.TabIndex = 18;
            // 
            // cbMaNV
            // 
            this.cbMaNV.BackColor = System.Drawing.Color.Transparent;
            this.cbMaNV.BorderColor = System.Drawing.Color.Teal;
            this.cbMaNV.BorderRadius = 10;
            this.cbMaNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNV.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaNV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNV.ForeColor = System.Drawing.Color.Teal;
            this.cbMaNV.ItemHeight = 30;
            this.cbMaNV.Location = new System.Drawing.Point(136, 46);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(117, 36);
            this.cbMaNV.TabIndex = 17;
            // 
            // lblTenNV
            // 
            this.lblTenNV.BackColor = System.Drawing.SystemColors.Control;
            this.lblTenNV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.Color.Teal;
            this.lblTenNV.Location = new System.Drawing.Point(22, 92);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(122, 26);
            this.lblTenNV.TabIndex = 16;
            this.lblTenNV.Text = "Tên nhân viên";
            // 
            // lblNCC
            // 
            this.lblNCC.BackColor = System.Drawing.SystemColors.Control;
            this.lblNCC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNCC.ForeColor = System.Drawing.Color.Teal;
            this.lblNCC.Location = new System.Drawing.Point(269, 14);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(70, 26);
            this.lblNCC.TabIndex = 15;
            this.lblNCC.Text = "Mã NCC";
            // 
            // lblMaNV
            // 
            this.lblMaNV.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaNV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.ForeColor = System.Drawing.Color.Teal;
            this.lblMaNV.Location = new System.Drawing.Point(137, 14);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(118, 26);
            this.lblMaNV.TabIndex = 14;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // txtMaHD
            // 
            this.txtMaHD.BorderColor = System.Drawing.Color.Teal;
            this.txtMaHD.BorderRadius = 10;
            this.txtMaHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaHD.DefaultText = "";
            this.txtMaHD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.ForeColor = System.Drawing.Color.Teal;
            this.txtMaHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.Location = new System.Drawing.Point(20, 46);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.PasswordChar = '\0';
            this.txtMaHD.PlaceholderText = "";
            this.txtMaHD.SelectedText = "";
            this.txtMaHD.Size = new System.Drawing.Size(92, 36);
            this.txtMaHD.TabIndex = 1;
            // 
            // lblMaHD
            // 
            this.lblMaHD.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaHD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.ForeColor = System.Drawing.Color.Teal;
            this.lblMaHD.Location = new System.Drawing.Point(20, 13);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(107, 26);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã hóa đơn";
            // 
            // UCHoaDonNhap
            // 
            this.UCHoaDonNhap.Location = new System.Drawing.Point(-4, 3);
            this.UCHoaDonNhap.Name = "UCHoaDonNhap";
            this.UCHoaDonNhap.Size = new System.Drawing.Size(785, 806);
            this.UCHoaDonNhap.TabIndex = 59;
            this.UCHoaDonNhap.Load += new System.EventHandler(this.UCHoaDonNhap_Load);
            // 
            // gbSP
            // 
            this.gbSP.BorderRadius = 10;
            this.gbSP.BorderThickness = 2;
            this.gbSP.Controls.Add(this.guna2Button3);
            this.gbSP.Controls.Add(this.guna2Button2);
            this.gbSP.Controls.Add(this.guna2Button1);
            this.gbSP.Controls.Add(this.gvSP);
            this.gbSP.Controls.Add(this.btnReLoad);
            this.gbSP.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbSP.FillColor = System.Drawing.SystemColors.Control;
            this.gbSP.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSP.ForeColor = System.Drawing.Color.White;
            this.gbSP.Location = new System.Drawing.Point(20, 266);
            this.gbSP.Name = "gbSP";
            this.gbSP.Size = new System.Drawing.Size(427, 315);
            this.gbSP.TabIndex = 59;
            this.gbSP.Text = "Sản phẩm";
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderColor = System.Drawing.Color.MidnightBlue;
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.BorderThickness = 2;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.Linen;
            this.guna2Button3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.guna2Button3.Image = global::StationeryManagementSystem.Properties.Resources.loading;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Location = new System.Drawing.Point(117, 256);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(97, 41);
            this.guna2Button3.TabIndex = 60;
            this.guna2Button3.Text = "    Reload";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.MidnightBlue;
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Linen;
            this.guna2Button2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.guna2Button2.Image = global::StationeryManagementSystem.Properties.Resources.edit;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Location = new System.Drawing.Point(220, 256);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(97, 41);
            this.guna2Button2.TabIndex = 59;
            this.guna2Button2.Text = "    Sửa";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.MidnightBlue;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Linen;
            this.guna2Button1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.guna2Button1.Image = global::StationeryManagementSystem.Properties.Resources.cross;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(321, 256);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(97, 41);
            this.guna2Button1.TabIndex = 58;
            this.guna2Button1.Text = "    Xóa";
            // 
            // gvSP
            // 
            this.gvSP.BackgroundColor = System.Drawing.Color.White;
            this.gvSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSP.DefaultCellStyle = dataGridViewCellStyle10;
            this.gvSP.GridColor = System.Drawing.Color.White;
            this.gvSP.Location = new System.Drawing.Point(7, 65);
            this.gvSP.Name = "gvSP";
            this.gvSP.ReadOnly = true;
            this.gvSP.RowHeadersWidth = 51;
            this.gvSP.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gvSP.RowTemplate.Height = 24;
            this.gvSP.Size = new System.Drawing.Size(411, 170);
            this.gvSP.TabIndex = 57;
            // 
            // btnReLoad
            // 
            this.btnReLoad.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnReLoad.BorderRadius = 10;
            this.btnReLoad.BorderThickness = 2;
            this.btnReLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReLoad.FillColor = System.Drawing.Color.Linen;
            this.btnReLoad.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReLoad.Image = global::StationeryManagementSystem.Properties.Resources.plus;
            this.btnReLoad.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReLoad.Location = new System.Drawing.Point(10, 256);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(97, 41);
            this.btnReLoad.TabIndex = 1;
            this.btnReLoad.Text = "    Thêm";
            // 
            // FormHoaDonNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1397, 947);
            this.Controls.Add(this.gvHD);
            this.Controls.Add(this.UCHoaDonNhap);
            this.Controls.Add(this.pnHoaDon);
            this.Name = "FormHoaDonNhap";
            this.Text = "FormHoaDonNhap";
            this.Load += new System.EventHandler(this.FormHoaDonNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvHD)).EndInit();
            this.pnHoaDon.ResumeLayout(false);
            this.pnHoaDon.PerformLayout();
            this.gbSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvHD;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTongThanhToan;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpNgayThanhToan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayThanhToan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenNCC;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNCC;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTrangThai;
        private Controls.UCHoaDon UCHoaDonNhap;
        private Guna.UI2.WinForms.Guna2ComboBox cbMNNCC;
        private Guna.UI2.WinForms.Guna2Panel pnHoaDon;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNV;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaNV;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenNV;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNCC;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaNV;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHD;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaHD;
        private Guna.UI2.WinForms.Guna2ComboBox cbTrangThaiThanhToan;
        public Guna.UI2.WinForms.Guna2GroupBox gbSP;
        public Guna.UI2.WinForms.Guna2Button guna2Button3;
        public Guna.UI2.WinForms.Guna2Button guna2Button2;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
        public System.Windows.Forms.DataGridView gvSP;
        public Guna.UI2.WinForms.Guna2Button btnReLoad;
    }
}