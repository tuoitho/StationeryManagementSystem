namespace StationeryManagementSystem
{
    partial class FormNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.gbThongTin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLuong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbChucVu = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdQuanLy = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdBanHang = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdKiemKho = new Guna.UI2.WinForms.Guna2RadioButton();
            this.gbGioiTinh = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdNu = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdNam = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.dpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHoTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDiaChi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNgaySinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSDT = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaNV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbListNV = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gvNhanVien = new System.Windows.Forms.DataGridView();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongTheoGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTacVu = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnReLoad = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.UCTimKiemNhanVien = new StationeryManagementSystem.UCTimKiem();
            this.gbThongTin.SuspendLayout();
            this.gbChucVu.SuspendLayout();
            this.gbGioiTinh.SuspendLayout();
            this.gbListNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).BeginInit();
            this.gbTacVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThongTin
            // 
            this.gbThongTin.BorderRadius = 10;
            this.gbThongTin.BorderThickness = 2;
            this.gbThongTin.Controls.Add(this.txtLuong);
            this.gbThongTin.Controls.Add(this.lblLuong);
            this.gbThongTin.Controls.Add(this.gbChucVu);
            this.gbThongTin.Controls.Add(this.gbGioiTinh);
            this.gbThongTin.Controls.Add(this.txtEmail);
            this.gbThongTin.Controls.Add(this.txtSDT);
            this.gbThongTin.Controls.Add(this.txtDiaChi);
            this.gbThongTin.Controls.Add(this.dpNgaySinh);
            this.gbThongTin.Controls.Add(this.txtHoTen);
            this.gbThongTin.Controls.Add(this.lblHoTen);
            this.gbThongTin.Controls.Add(this.txtMaNV);
            this.gbThongTin.Controls.Add(this.lblEmail);
            this.gbThongTin.Controls.Add(this.lblDiaChi);
            this.gbThongTin.Controls.Add(this.lblNgaySinh);
            this.gbThongTin.Controls.Add(this.lblSDT);
            this.gbThongTin.Controls.Add(this.lblMaNV);
            this.gbThongTin.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbThongTin.FillColor = System.Drawing.SystemColors.Control;
            this.gbThongTin.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.ForeColor = System.Drawing.Color.White;
            this.gbThongTin.Location = new System.Drawing.Point(38, 3);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(1073, 340);
            this.gbThongTin.TabIndex = 0;
            this.gbThongTin.Text = "Thông tin nhân viên";
            // 
            // txtLuong
            // 
            this.txtLuong.BorderColor = System.Drawing.Color.Teal;
            this.txtLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuong.DefaultText = "0";
            this.txtLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLuong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.ForeColor = System.Drawing.Color.Teal;
            this.txtLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLuong.Location = new System.Drawing.Point(156, 286);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.PasswordChar = '\0';
            this.txtLuong.PlaceholderText = "";
            this.txtLuong.SelectedText = "";
            this.txtLuong.Size = new System.Drawing.Size(282, 30);
            this.txtLuong.TabIndex = 13;
            // 
            // lblLuong
            // 
            this.lblLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblLuong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuong.ForeColor = System.Drawing.Color.Teal;
            this.lblLuong.Location = new System.Drawing.Point(16, 290);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(133, 26);
            this.lblLuong.TabIndex = 12;
            this.lblLuong.Text = "Lương theo giờ";
            // 
            // gbChucVu
            // 
            this.gbChucVu.BorderRadius = 10;
            this.gbChucVu.Controls.Add(this.rdQuanLy);
            this.gbChucVu.Controls.Add(this.rdBanHang);
            this.gbChucVu.Controls.Add(this.rdKiemKho);
            this.gbChucVu.CustomBorderColor = System.Drawing.Color.MidnightBlue;
            this.gbChucVu.FillColor = System.Drawing.SystemColors.Control;
            this.gbChucVu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChucVu.ForeColor = System.Drawing.Color.White;
            this.gbChucVu.Location = new System.Drawing.Point(513, 183);
            this.gbChucVu.Name = "gbChucVu";
            this.gbChucVu.Size = new System.Drawing.Size(476, 106);
            this.gbChucVu.TabIndex = 2;
            this.gbChucVu.Text = "Chức vụ";
            // 
            // rdQuanLy
            // 
            this.rdQuanLy.AutoSize = true;
            this.rdQuanLy.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdQuanLy.CheckedState.BorderThickness = 0;
            this.rdQuanLy.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdQuanLy.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdQuanLy.CheckedState.InnerOffset = -4;
            this.rdQuanLy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdQuanLy.Location = new System.Drawing.Point(269, 56);
            this.rdQuanLy.Name = "rdQuanLy";
            this.rdQuanLy.Size = new System.Drawing.Size(96, 28);
            this.rdQuanLy.TabIndex = 2;
            this.rdQuanLy.Text = "Quản lý";
            this.rdQuanLy.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdQuanLy.UncheckedState.BorderThickness = 2;
            this.rdQuanLy.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdQuanLy.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdBanHang
            // 
            this.rdBanHang.AutoSize = true;
            this.rdBanHang.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdBanHang.CheckedState.BorderThickness = 0;
            this.rdBanHang.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdBanHang.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdBanHang.CheckedState.InnerOffset = -4;
            this.rdBanHang.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdBanHang.Location = new System.Drawing.Point(135, 56);
            this.rdBanHang.Name = "rdBanHang";
            this.rdBanHang.Size = new System.Drawing.Size(109, 28);
            this.rdBanHang.TabIndex = 1;
            this.rdBanHang.Text = "Bán hàng";
            this.rdBanHang.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdBanHang.UncheckedState.BorderThickness = 2;
            this.rdBanHang.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdBanHang.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdKiemKho
            // 
            this.rdKiemKho.AutoSize = true;
            this.rdKiemKho.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdKiemKho.CheckedState.BorderThickness = 0;
            this.rdKiemKho.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdKiemKho.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdKiemKho.CheckedState.InnerOffset = -4;
            this.rdKiemKho.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdKiemKho.Location = new System.Drawing.Point(19, 56);
            this.rdKiemKho.Name = "rdKiemKho";
            this.rdKiemKho.Size = new System.Drawing.Size(110, 28);
            this.rdKiemKho.TabIndex = 0;
            this.rdKiemKho.Text = "Kiểm kho";
            this.rdKiemKho.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdKiemKho.UncheckedState.BorderThickness = 2;
            this.rdKiemKho.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdKiemKho.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // gbGioiTinh
            // 
            this.gbGioiTinh.BorderRadius = 10;
            this.gbGioiTinh.Controls.Add(this.rdNu);
            this.gbGioiTinh.Controls.Add(this.rdNam);
            this.gbGioiTinh.CustomBorderColor = System.Drawing.Color.MidnightBlue;
            this.gbGioiTinh.FillColor = System.Drawing.SystemColors.Control;
            this.gbGioiTinh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGioiTinh.ForeColor = System.Drawing.Color.White;
            this.gbGioiTinh.Location = new System.Drawing.Point(513, 57);
            this.gbGioiTinh.Name = "gbGioiTinh";
            this.gbGioiTinh.Size = new System.Drawing.Size(260, 94);
            this.gbGioiTinh.TabIndex = 1;
            this.gbGioiTinh.Text = "Giới tính";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdNu.CheckedState.BorderThickness = 0;
            this.rdNu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdNu.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdNu.CheckedState.InnerOffset = -4;
            this.rdNu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdNu.Location = new System.Drawing.Point(115, 52);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(57, 28);
            this.rdNu.TabIndex = 1;
            this.rdNu.Text = "Nữ";
            this.rdNu.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdNu.UncheckedState.BorderThickness = 2;
            this.rdNu.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdNu.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdNam.CheckedState.BorderThickness = 0;
            this.rdNam.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdNam.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdNam.CheckedState.InnerOffset = -4;
            this.rdNam.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdNam.Location = new System.Drawing.Point(19, 52);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(70, 28);
            this.rdNam.TabIndex = 0;
            this.rdNam.Text = "Nam";
            this.rdNam.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdNam.UncheckedState.BorderThickness = 2;
            this.rdNam.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdNam.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.Teal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Teal;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(156, 246);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(282, 30);
            this.txtEmail.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderColor = System.Drawing.Color.Teal;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.DefaultText = "";
            this.txtSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.Teal;
            this.txtSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSDT.Location = new System.Drawing.Point(156, 206);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(282, 30);
            this.txtSDT.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderColor = System.Drawing.Color.Teal;
            this.txtDiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaChi.DefaultText = "";
            this.txtDiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.Teal;
            this.txtDiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaChi.Location = new System.Drawing.Point(156, 166);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(282, 30);
            this.txtDiaChi.TabIndex = 9;
            // 
            // dpNgaySinh
            // 
            this.dpNgaySinh.BackColor = System.Drawing.Color.White;
            this.dpNgaySinh.BorderColor = System.Drawing.Color.Teal;
            this.dpNgaySinh.Checked = true;
            this.dpNgaySinh.FillColor = System.Drawing.Color.White;
            this.dpNgaySinh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpNgaySinh.ForeColor = System.Drawing.Color.Teal;
            this.dpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpNgaySinh.Location = new System.Drawing.Point(156, 128);
            this.dpNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpNgaySinh.Name = "dpNgaySinh";
            this.dpNgaySinh.Size = new System.Drawing.Size(282, 30);
            this.dpNgaySinh.TabIndex = 8;
            this.dpNgaySinh.Value = new System.DateTime(2024, 10, 10, 10, 23, 43, 490);
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderColor = System.Drawing.Color.Teal;
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Teal;
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.Location = new System.Drawing.Point(156, 90);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(282, 30);
            this.txtHoTen.TabIndex = 7;
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.Teal;
            this.lblHoTen.Location = new System.Drawing.Point(16, 94);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(60, 26);
            this.lblHoTen.TabIndex = 6;
            this.lblHoTen.Text = "Họ tên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderColor = System.Drawing.Color.Teal;
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNV.DefaultText = "";
            this.txtMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.Teal;
            this.txtMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.Location = new System.Drawing.Point(156, 50);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PasswordChar = '\0';
            this.txtMaNV.PlaceholderText = "";
            this.txtMaNV.SelectedText = "";
            this.txtMaNV.Size = new System.Drawing.Size(282, 30);
            this.txtMaNV.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Teal;
            this.lblEmail.Location = new System.Drawing.Point(16, 250);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 26);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaChi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.Teal;
            this.lblDiaChi.Location = new System.Drawing.Point(16, 170);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(60, 26);
            this.lblDiaChi.TabIndex = 3;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.Color.Teal;
            this.lblNgaySinh.Location = new System.Drawing.Point(16, 132);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(84, 26);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblSDT
            // 
            this.lblSDT.BackColor = System.Drawing.Color.Transparent;
            this.lblSDT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.Teal;
            this.lblSDT.Location = new System.Drawing.Point(16, 210);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(114, 26);
            this.lblSDT.TabIndex = 1;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblMaNV
            // 
            this.lblMaNV.BackColor = System.Drawing.Color.Transparent;
            this.lblMaNV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.ForeColor = System.Drawing.Color.Teal;
            this.lblMaNV.Location = new System.Drawing.Point(16, 59);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(118, 26);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã nhân viên ";
            // 
            // gbListNV
            // 
            this.gbListNV.BorderRadius = 10;
            this.gbListNV.BorderThickness = 2;
            this.gbListNV.Controls.Add(this.UCTimKiemNhanVien);
            this.gbListNV.Controls.Add(this.gvNhanVien);
            this.gbListNV.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbListNV.FillColor = System.Drawing.SystemColors.Control;
            this.gbListNV.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListNV.ForeColor = System.Drawing.Color.White;
            this.gbListNV.Location = new System.Drawing.Point(38, 364);
            this.gbListNV.Name = "gbListNV";
            this.gbListNV.Size = new System.Drawing.Size(1073, 244);
            this.gbListNV.TabIndex = 12;
            this.gbListNV.Text = "Danh sách nhân viên";
            // 
            // gvNhanVien
            // 
            this.gvNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.gvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.tenNV,
            this.ngaySinh,
            this.gioiTinh,
            this.chuVu,
            this.diaChi,
            this.sdt,
            this.email,
            this.luongTheoGio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvNhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvNhanVien.GridColor = System.Drawing.Color.White;
            this.gvNhanVien.Location = new System.Drawing.Point(3, 117);
            this.gvNhanVien.Name = "gvNhanVien";
            this.gvNhanVien.RowHeadersWidth = 51;
            this.gvNhanVien.RowTemplate.Height = 24;
            this.gvNhanVien.Size = new System.Drawing.Size(1067, 124);
            this.gvNhanVien.TabIndex = 2;
            // 
            // maNV
            // 
            this.maNV.DataPropertyName = "manhanvien";
            this.maNV.HeaderText = "Mã nhân viên";
            this.maNV.MinimumWidth = 6;
            this.maNV.Name = "maNV";
            this.maNV.Width = 170;
            // 
            // tenNV
            // 
            this.tenNV.DataPropertyName = "hoten";
            this.tenNV.HeaderText = "Họ tên";
            this.tenNV.MinimumWidth = 6;
            this.tenNV.Name = "tenNV";
            this.tenNV.Width = 150;
            // 
            // ngaySinh
            // 
            this.ngaySinh.DataPropertyName = "ngaysinh";
            this.ngaySinh.HeaderText = "Ngày sinh";
            this.ngaySinh.MinimumWidth = 6;
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Width = 150;
            // 
            // gioiTinh
            // 
            this.gioiTinh.DataPropertyName = "GioiTinh";
            this.gioiTinh.HeaderText = "Giới tính";
            this.gioiTinh.MinimumWidth = 6;
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Width = 150;
            // 
            // chuVu
            // 
            this.chuVu.DataPropertyName = "TenChucVu";
            this.chuVu.HeaderText = "Chức vụ";
            this.chuVu.MinimumWidth = 6;
            this.chuVu.Name = "chuVu";
            this.chuVu.Width = 150;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "DiaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.Width = 200;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "SoDienThoai";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 200;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 200;
            // 
            // luongTheoGio
            // 
            this.luongTheoGio.DataPropertyName = "LuongTheoGio";
            this.luongTheoGio.HeaderText = "Lương theo giờ";
            this.luongTheoGio.MinimumWidth = 6;
            this.luongTheoGio.Name = "luongTheoGio";
            this.luongTheoGio.Width = 170;
            // 
            // gbTacVu
            // 
            this.gbTacVu.BorderRadius = 10;
            this.gbTacVu.BorderThickness = 2;
            this.gbTacVu.Controls.Add(this.btnXoa);
            this.gbTacVu.Controls.Add(this.btnSua);
            this.gbTacVu.Controls.Add(this.btnReLoad);
            this.gbTacVu.Controls.Add(this.btnThem);
            this.gbTacVu.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbTacVu.FillColor = System.Drawing.SystemColors.Control;
            this.gbTacVu.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTacVu.ForeColor = System.Drawing.Color.White;
            this.gbTacVu.Location = new System.Drawing.Point(38, 628);
            this.gbTacVu.Name = "gbTacVu";
            this.gbTacVu.Size = new System.Drawing.Size(1070, 117);
            this.gbTacVu.TabIndex = 13;
            this.gbTacVu.Text = "Tác vụ";
            // 
            // btnXoa
            // 
            this.btnXoa.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.BorderThickness = 2;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.LightYellow;
            this.btnXoa.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoa.Location = new System.Drawing.Point(788, 58);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 45);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "   Xóa";
            // 
            // btnSua
            // 
            this.btnSua.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnSua.BorderRadius = 20;
            this.btnSua.BorderThickness = 2;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.LightYellow;
            this.btnSua.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSua.Location = new System.Drawing.Point(568, 58);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(133, 45);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "  Sửa";
            // 
            // btnReLoad
            // 
            this.btnReLoad.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnReLoad.BorderRadius = 20;
            this.btnReLoad.BorderThickness = 2;
            this.btnReLoad.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReLoad.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReLoad.FillColor = System.Drawing.Color.LightYellow;
            this.btnReLoad.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReLoad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnReLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnReLoad.Image")));
            this.btnReLoad.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReLoad.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReLoad.Location = new System.Drawing.Point(348, 58);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(133, 45);
            this.btnReLoad.TabIndex = 1;
            this.btnReLoad.Text = "     Reload";
            // 
            // btnThem
            // 
            this.btnThem.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnThem.BorderRadius = 20;
            this.btnThem.BorderThickness = 2;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.LightYellow;
            this.btnThem.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThem.Location = new System.Drawing.Point(125, 58);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "  Thêm";
            // 
            // UCTimKiemNhanVien
            // 
            this.UCTimKiemNhanVien.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCTimKiemNhanVien.Location = new System.Drawing.Point(289, 46);
            this.UCTimKiemNhanVien.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.UCTimKiemNhanVien.Name = "UCTimKiemNhanVien";
            this.UCTimKiemNhanVien.Size = new System.Drawing.Size(738, 59);
            this.UCTimKiemNhanVien.TabIndex = 3;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1179, 764);
            this.Controls.Add(this.gbTacVu);
            this.Controls.Add(this.gbListNV);
            this.Controls.Add(this.gbThongTin);
            this.Name = "FormNhanVien";
            this.Text = "FormNhanVien";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.gbChucVu.ResumeLayout(false);
            this.gbChucVu.PerformLayout();
            this.gbGioiTinh.ResumeLayout(false);
            this.gbGioiTinh.PerformLayout();
            this.gbListNV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvNhanVien)).EndInit();
            this.gbTacVu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbThongTin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaNV;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNV;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDiaChi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgaySinh;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSDT;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHoTen;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpNgaySinh;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2GroupBox gbGioiTinh;
        private Guna.UI2.WinForms.Guna2GroupBox gbChucVu;
        private Guna.UI2.WinForms.Guna2RadioButton rdBanHang;
        private Guna.UI2.WinForms.Guna2RadioButton rdKiemKho;
        private Guna.UI2.WinForms.Guna2RadioButton rdNu;
        private Guna.UI2.WinForms.Guna2RadioButton rdNam;
        private Guna.UI2.WinForms.Guna2RadioButton rdQuanLy;
        private Guna.UI2.WinForms.Guna2GroupBox gbListNV;
        private System.Windows.Forms.DataGridView gvNhanVien;
        private Guna.UI2.WinForms.Guna2GroupBox gbTacVu;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnReLoad;
        private UCTimKiem ucTimKiemNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongTheoGio;
        private Guna.UI2.WinForms.Guna2TextBox txtLuong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLuong;
        private UCTimKiem UCTimKiemNhanVien;
    }
}