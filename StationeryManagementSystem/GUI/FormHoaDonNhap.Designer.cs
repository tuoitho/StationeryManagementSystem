namespace StationeryManagementSystem.GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbTacVu = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnReLoad = new Guna.UI2.WinForms.Guna2Button();
            this.gbListHDN = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gvHD = new System.Windows.Forms.DataGridView();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnHoaDonNhap = new Guna.UI2.WinForms.Guna2Panel();
            this.txtTongTin = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTongThanhToan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.dpNgayThanhToan = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblNgayThanhToan = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTenKH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbMaKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTenNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbMaNV = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTenNV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblKH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaNV = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtDonGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDonGia = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSoLuong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTenLoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenLoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbMaLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaLoai = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTenSP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbMaSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMaSP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMaHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaHD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UCSearchBillNhap = new StationeryManagementSystem.UCSearchBill();
            this.gbTacVu.SuspendLayout();
            this.gbListHDN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHD)).BeginInit();
            this.pnHoaDonNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTacVu
            // 
            this.gbTacVu.BorderRadius = 10;
            this.gbTacVu.BorderThickness = 2;
            this.gbTacVu.Controls.Add(this.btnXoa);
            this.gbTacVu.Controls.Add(this.btnSua);
            this.gbTacVu.Controls.Add(this.btnReLoad);
            this.gbTacVu.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbTacVu.FillColor = System.Drawing.SystemColors.Control;
            this.gbTacVu.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTacVu.ForeColor = System.Drawing.Color.White;
            this.gbTacVu.Location = new System.Drawing.Point(12, 511);
            this.gbTacVu.Name = "gbTacVu";
            this.gbTacVu.Size = new System.Drawing.Size(820, 165);
            this.gbTacVu.TabIndex = 52;
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
            this.btnXoa.Image = global::StationeryManagementSystem.Properties.Resources.cross;
            this.btnXoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoa.Location = new System.Drawing.Point(320, 75);
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
            this.btnSua.Image = global::StationeryManagementSystem.Properties.Resources.edit;
            this.btnSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSua.Location = new System.Drawing.Point(514, 75);
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
            this.btnReLoad.Image = global::StationeryManagementSystem.Properties.Resources.loading;
            this.btnReLoad.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnReLoad.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReLoad.Location = new System.Drawing.Point(127, 75);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(133, 45);
            this.btnReLoad.TabIndex = 1;
            this.btnReLoad.Text = "     Reload";
            // 
            // gbListHDN
            // 
            this.gbListHDN.BorderRadius = 10;
            this.gbListHDN.BorderThickness = 2;
            this.gbListHDN.Controls.Add(this.UCSearchBillNhap);
            this.gbListHDN.Controls.Add(this.gvHD);
            this.gbListHDN.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbListHDN.FillColor = System.Drawing.SystemColors.Control;
            this.gbListHDN.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListHDN.ForeColor = System.Drawing.Color.White;
            this.gbListHDN.Location = new System.Drawing.Point(12, 26);
            this.gbListHDN.Name = "gbListHDN";
            this.gbListHDN.Size = new System.Drawing.Size(823, 466);
            this.gbListHDN.TabIndex = 53;
            this.gbListHDN.Text = "                                      Danh sách hóa đơn nhập hàng";
            // 
            // gvHD
            // 
            this.gvHD.BackgroundColor = System.Drawing.Color.White;
            this.gvHD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHD,
            this.maSP,
            this.tenSP,
            this.maLoai,
            this.tenLoai,
            this.soLuong,
            this.donGia,
            this.nvLap,
            this.khachHang,
            this.ngayThanhToan,
            this.tongThanhToan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvHD.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvHD.GridColor = System.Drawing.Color.White;
            this.gvHD.Location = new System.Drawing.Point(3, 130);
            this.gvHD.Name = "gvHD";
            this.gvHD.RowHeadersWidth = 51;
            this.gvHD.RowTemplate.Height = 24;
            this.gvHD.Size = new System.Drawing.Size(817, 333);
            this.gvHD.TabIndex = 3;
            // 
            // maHD
            // 
            this.maHD.HeaderText = "Mã hóa đơn";
            this.maHD.MinimumWidth = 6;
            this.maHD.Name = "maHD";
            this.maHD.Width = 170;
            // 
            // maSP
            // 
            this.maSP.HeaderText = "Mã sản phẩm";
            this.maSP.MinimumWidth = 6;
            this.maSP.Name = "maSP";
            this.maSP.Width = 170;
            // 
            // tenSP
            // 
            this.tenSP.HeaderText = "Tên sản phẩm";
            this.tenSP.MinimumWidth = 6;
            this.tenSP.Name = "tenSP";
            this.tenSP.Width = 170;
            // 
            // maLoai
            // 
            this.maLoai.HeaderText = "Mã loại";
            this.maLoai.MinimumWidth = 6;
            this.maLoai.Name = "maLoai";
            this.maLoai.Width = 150;
            // 
            // tenLoai
            // 
            this.tenLoai.HeaderText = "Tên loại";
            this.tenLoai.MinimumWidth = 6;
            this.tenLoai.Name = "tenLoai";
            this.tenLoai.Width = 150;
            // 
            // soLuong
            // 
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.Width = 150;
            // 
            // donGia
            // 
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.MinimumWidth = 6;
            this.donGia.Name = "donGia";
            this.donGia.Width = 150;
            // 
            // nvLap
            // 
            this.nvLap.HeaderText = "Nhân viên lập";
            this.nvLap.MinimumWidth = 6;
            this.nvLap.Name = "nvLap";
            this.nvLap.Width = 150;
            // 
            // khachHang
            // 
            this.khachHang.HeaderText = "Khách hàng";
            this.khachHang.MinimumWidth = 6;
            this.khachHang.Name = "khachHang";
            this.khachHang.Width = 170;
            // 
            // ngayThanhToan
            // 
            this.ngayThanhToan.HeaderText = "Ngày thanh toán";
            this.ngayThanhToan.MinimumWidth = 6;
            this.ngayThanhToan.Name = "ngayThanhToan";
            this.ngayThanhToan.Width = 170;
            // 
            // tongThanhToan
            // 
            this.tongThanhToan.HeaderText = "Tổng thanh toán";
            this.tongThanhToan.MinimumWidth = 6;
            this.tongThanhToan.Name = "tongThanhToan";
            this.tongThanhToan.Width = 170;
            // 
            // pnHoaDonNhap
            // 
            this.pnHoaDonNhap.BorderColor = System.Drawing.Color.Teal;
            this.pnHoaDonNhap.BorderRadius = 10;
            this.pnHoaDonNhap.BorderThickness = 2;
            this.pnHoaDonNhap.Controls.Add(this.txtTongTin);
            this.pnHoaDonNhap.Controls.Add(this.lblTongThanhToan);
            this.pnHoaDonNhap.Controls.Add(this.btnThanhToan);
            this.pnHoaDonNhap.Controls.Add(this.dpNgayThanhToan);
            this.pnHoaDonNhap.Controls.Add(this.lblNgayThanhToan);
            this.pnHoaDonNhap.Controls.Add(this.lblTenKH);
            this.pnHoaDonNhap.Controls.Add(this.txtTenKH);
            this.pnHoaDonNhap.Controls.Add(this.cbMaKH);
            this.pnHoaDonNhap.Controls.Add(this.txtTenNV);
            this.pnHoaDonNhap.Controls.Add(this.cbMaNV);
            this.pnHoaDonNhap.Controls.Add(this.lblTenNV);
            this.pnHoaDonNhap.Controls.Add(this.lblKH);
            this.pnHoaDonNhap.Controls.Add(this.lblMaNV);
            this.pnHoaDonNhap.Controls.Add(this.txtDonGia);
            this.pnHoaDonNhap.Controls.Add(this.lblDonGia);
            this.pnHoaDonNhap.Controls.Add(this.lblSoLuong);
            this.pnHoaDonNhap.Controls.Add(this.txtTenLoai);
            this.pnHoaDonNhap.Controls.Add(this.lblTenLoai);
            this.pnHoaDonNhap.Controls.Add(this.cbMaLoai);
            this.pnHoaDonNhap.Controls.Add(this.txtSoLuong);
            this.pnHoaDonNhap.Controls.Add(this.lblMaLoai);
            this.pnHoaDonNhap.Controls.Add(this.txtTenSP);
            this.pnHoaDonNhap.Controls.Add(this.lblTenSP);
            this.pnHoaDonNhap.Controls.Add(this.cbMaSP);
            this.pnHoaDonNhap.Controls.Add(this.lblMaSP);
            this.pnHoaDonNhap.Controls.Add(this.txtMaHD);
            this.pnHoaDonNhap.Controls.Add(this.lblMaHD);
            this.pnHoaDonNhap.ForeColor = System.Drawing.Color.Teal;
            this.pnHoaDonNhap.Location = new System.Drawing.Point(854, 26);
            this.pnHoaDonNhap.Name = "pnHoaDonNhap";
            this.pnHoaDonNhap.Size = new System.Drawing.Size(405, 650);
            this.pnHoaDonNhap.TabIndex = 51;
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
            this.txtTongTin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTongTin.ForeColor = System.Drawing.Color.Teal;
            this.txtTongTin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongTin.Location = new System.Drawing.Point(36, 581);
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
            this.lblTongThanhToan.Location = new System.Drawing.Point(36, 547);
            this.lblTongThanhToan.Name = "lblTongThanhToan";
            this.lblTongThanhToan.Size = new System.Drawing.Size(82, 26);
            this.lblTongThanhToan.TabIndex = 47;
            this.lblTongThanhToan.Text = "Tổng tiền";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnThanhToan.BorderRadius = 20;
            this.btnThanhToan.BorderThickness = 2;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.LightYellow;
            this.btnThanhToan.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnThanhToan.Image = global::StationeryManagementSystem.Properties.Resources.thanhtoan;
            this.btnThanhToan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThanhToan.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThanhToan.Location = new System.Drawing.Point(211, 570);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(169, 57);
            this.btnThanhToan.TabIndex = 46;
            this.btnThanhToan.Text = "      Thanh toán";
            // 
            // dpNgayThanhToan
            // 
            this.dpNgayThanhToan.BackColor = System.Drawing.Color.White;
            this.dpNgayThanhToan.BorderColor = System.Drawing.Color.Teal;
            this.dpNgayThanhToan.BorderRadius = 10;
            this.dpNgayThanhToan.BorderThickness = 1;
            this.dpNgayThanhToan.Checked = true;
            this.dpNgayThanhToan.FillColor = System.Drawing.Color.White;
            this.dpNgayThanhToan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpNgayThanhToan.ForeColor = System.Drawing.Color.Teal;
            this.dpNgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpNgayThanhToan.Location = new System.Drawing.Point(36, 505);
            this.dpNgayThanhToan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpNgayThanhToan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpNgayThanhToan.Name = "dpNgayThanhToan";
            this.dpNgayThanhToan.Size = new System.Drawing.Size(331, 36);
            this.dpNgayThanhToan.TabIndex = 23;
            this.dpNgayThanhToan.Value = new System.DateTime(2024, 10, 10, 20, 44, 24, 93);
            // 
            // lblNgayThanhToan
            // 
            this.lblNgayThanhToan.BackColor = System.Drawing.SystemColors.Control;
            this.lblNgayThanhToan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayThanhToan.ForeColor = System.Drawing.Color.Teal;
            this.lblNgayThanhToan.Location = new System.Drawing.Point(36, 472);
            this.lblNgayThanhToan.Name = "lblNgayThanhToan";
            this.lblNgayThanhToan.Size = new System.Drawing.Size(143, 26);
            this.lblNgayThanhToan.TabIndex = 22;
            this.lblNgayThanhToan.Text = "Ngày thanh toán";
            // 
            // lblTenKH
            // 
            this.lblTenKH.BackColor = System.Drawing.SystemColors.Control;
            this.lblTenKH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.ForeColor = System.Drawing.Color.Teal;
            this.lblTenKH.Location = new System.Drawing.Point(193, 398);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(74, 26);
            this.lblTenKH.TabIndex = 21;
            this.lblTenKH.Text = "Ten NCC";
            // 
            // txtTenKH
            // 
            this.txtTenKH.BorderColor = System.Drawing.Color.Teal;
            this.txtTenKH.BorderRadius = 10;
            this.txtTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKH.DefaultText = "";
            this.txtTenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKH.ForeColor = System.Drawing.Color.Teal;
            this.txtTenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKH.Location = new System.Drawing.Point(193, 430);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.PlaceholderText = "";
            this.txtTenKH.SelectedText = "";
            this.txtTenKH.Size = new System.Drawing.Size(197, 36);
            this.txtTenKH.TabIndex = 20;
            // 
            // cbMaKH
            // 
            this.cbMaKH.BackColor = System.Drawing.Color.Transparent;
            this.cbMaKH.BorderColor = System.Drawing.Color.Teal;
            this.cbMaKH.BorderRadius = 10;
            this.cbMaKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaKH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaKH.ForeColor = System.Drawing.Color.Teal;
            this.cbMaKH.ItemHeight = 30;
            this.cbMaKH.Location = new System.Drawing.Point(36, 430);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(117, 36);
            this.cbMaKH.TabIndex = 19;
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
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNV.ForeColor = System.Drawing.Color.Teal;
            this.txtTenNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenNV.Location = new System.Drawing.Point(193, 356);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PasswordChar = '\0';
            this.txtTenNV.PlaceholderText = "";
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.Size = new System.Drawing.Size(197, 36);
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
            this.cbMaNV.Location = new System.Drawing.Point(35, 356);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(117, 36);
            this.cbMaNV.TabIndex = 17;
            // 
            // lblTenNV
            // 
            this.lblTenNV.BackColor = System.Drawing.SystemColors.Control;
            this.lblTenNV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.Color.Teal;
            this.lblTenNV.Location = new System.Drawing.Point(193, 324);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(122, 26);
            this.lblTenNV.TabIndex = 16;
            this.lblTenNV.Text = "Tên nhân viên";
            // 
            // lblKH
            // 
            this.lblKH.BackColor = System.Drawing.SystemColors.Control;
            this.lblKH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKH.ForeColor = System.Drawing.Color.Teal;
            this.lblKH.Location = new System.Drawing.Point(36, 398);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(70, 26);
            this.lblKH.TabIndex = 15;
            this.lblKH.Text = "Mã NCC";
            // 
            // lblMaNV
            // 
            this.lblMaNV.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaNV.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.ForeColor = System.Drawing.Color.Teal;
            this.lblMaNV.Location = new System.Drawing.Point(36, 324);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(118, 26);
            this.lblMaNV.TabIndex = 14;
            this.lblMaNV.Text = "Mã nhân viên";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BorderColor = System.Drawing.Color.Teal;
            this.txtDonGia.BorderRadius = 10;
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.DefaultText = "0";
            this.txtDonGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDonGia.ForeColor = System.Drawing.Color.Teal;
            this.txtDonGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.Location = new System.Drawing.Point(193, 281);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PasswordChar = '\0';
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.Size = new System.Drawing.Size(137, 36);
            this.txtDonGia.TabIndex = 13;
            // 
            // lblDonGia
            // 
            this.lblDonGia.BackColor = System.Drawing.SystemColors.Control;
            this.lblDonGia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.ForeColor = System.Drawing.Color.Teal;
            this.lblDonGia.Location = new System.Drawing.Point(193, 248);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(69, 26);
            this.lblDonGia.TabIndex = 12;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.BackColor = System.Drawing.SystemColors.Control;
            this.lblSoLuong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.Teal;
            this.lblSoLuong.Location = new System.Drawing.Point(35, 248);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(79, 26);
            this.lblSoLuong.TabIndex = 11;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.BorderColor = System.Drawing.Color.Teal;
            this.txtTenLoai.BorderRadius = 10;
            this.txtTenLoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenLoai.DefaultText = "";
            this.txtTenLoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenLoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenLoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenLoai.ForeColor = System.Drawing.Color.Teal;
            this.txtTenLoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenLoai.Location = new System.Drawing.Point(193, 130);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.PasswordChar = '\0';
            this.txtTenLoai.PlaceholderText = "";
            this.txtTenLoai.SelectedText = "";
            this.txtTenLoai.Size = new System.Drawing.Size(197, 36);
            this.txtTenLoai.TabIndex = 10;
            // 
            // lblTenLoai
            // 
            this.lblTenLoai.BackColor = System.Drawing.SystemColors.Control;
            this.lblTenLoai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenLoai.ForeColor = System.Drawing.Color.Teal;
            this.lblTenLoai.Location = new System.Drawing.Point(193, 97);
            this.lblTenLoai.Name = "lblTenLoai";
            this.lblTenLoai.Size = new System.Drawing.Size(70, 26);
            this.lblTenLoai.TabIndex = 9;
            this.lblTenLoai.Text = "Tên loại";
            // 
            // cbMaLoai
            // 
            this.cbMaLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbMaLoai.BorderColor = System.Drawing.Color.Teal;
            this.cbMaLoai.BorderRadius = 10;
            this.cbMaLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaLoai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaLoai.ForeColor = System.Drawing.Color.Teal;
            this.cbMaLoai.ItemHeight = 30;
            this.cbMaLoai.Location = new System.Drawing.Point(31, 130);
            this.cbMaLoai.Name = "cbMaLoai";
            this.cbMaLoai.Size = new System.Drawing.Size(117, 36);
            this.cbMaLoai.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BorderColor = System.Drawing.Color.Teal;
            this.txtSoLuong.BorderRadius = 10;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.DefaultText = "0";
            this.txtSoLuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuong.ForeColor = System.Drawing.Color.Teal;
            this.txtSoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.Location = new System.Drawing.Point(35, 281);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(137, 36);
            this.txtSoLuong.TabIndex = 7;
            // 
            // lblMaLoai
            // 
            this.lblMaLoai.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaLoai.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLoai.ForeColor = System.Drawing.Color.Teal;
            this.lblMaLoai.Location = new System.Drawing.Point(32, 98);
            this.lblMaLoai.Name = "lblMaLoai";
            this.lblMaLoai.Size = new System.Drawing.Size(66, 26);
            this.lblMaLoai.TabIndex = 6;
            this.lblMaLoai.Text = "Mã loại";
            // 
            // txtTenSP
            // 
            this.txtTenSP.BorderColor = System.Drawing.Color.Teal;
            this.txtTenSP.BorderRadius = 10;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.DefaultText = "";
            this.txtTenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenSP.ForeColor = System.Drawing.Color.Teal;
            this.txtTenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Location = new System.Drawing.Point(31, 205);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PasswordChar = '\0';
            this.txtTenSP.PlaceholderText = "";
            this.txtTenSP.SelectedText = "";
            this.txtTenSP.Size = new System.Drawing.Size(359, 36);
            this.txtTenSP.TabIndex = 5;
            // 
            // lblTenSP
            // 
            this.lblTenSP.BackColor = System.Drawing.SystemColors.Control;
            this.lblTenSP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.Color.Teal;
            this.lblTenSP.Location = new System.Drawing.Point(32, 172);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(121, 26);
            this.lblTenSP.TabIndex = 4;
            this.lblTenSP.Text = "Tên sản phẩm";
            // 
            // cbMaSP
            // 
            this.cbMaSP.BackColor = System.Drawing.Color.Transparent;
            this.cbMaSP.BorderColor = System.Drawing.Color.Teal;
            this.cbMaSP.BorderRadius = 10;
            this.cbMaSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaSP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaSP.ForeColor = System.Drawing.Color.Teal;
            this.cbMaSP.ItemHeight = 30;
            this.cbMaSP.Location = new System.Drawing.Point(193, 55);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(117, 36);
            this.cbMaSP.TabIndex = 3;
            // 
            // lblMaSP
            // 
            this.lblMaSP.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaSP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.ForeColor = System.Drawing.Color.Teal;
            this.lblMaSP.Location = new System.Drawing.Point(193, 22);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(117, 26);
            this.lblMaSP.TabIndex = 2;
            this.lblMaSP.Text = "Mã sản phẩm";
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
            this.txtMaHD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaHD.ForeColor = System.Drawing.Color.Teal;
            this.txtMaHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.Location = new System.Drawing.Point(31, 55);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.PasswordChar = '\0';
            this.txtMaHD.PlaceholderText = "";
            this.txtMaHD.SelectedText = "";
            this.txtMaHD.Size = new System.Drawing.Size(117, 36);
            this.txtMaHD.TabIndex = 1;
            // 
            // lblMaHD
            // 
            this.lblMaHD.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaHD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.ForeColor = System.Drawing.Color.Teal;
            this.lblMaHD.Location = new System.Drawing.Point(31, 22);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(107, 26);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã hóa đơn";
            // 
            // UCSearchBillNhap
            // 
            this.UCSearchBillNhap.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UCSearchBillNhap.Location = new System.Drawing.Point(5, 55);
            this.UCSearchBillNhap.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.UCSearchBillNhap.Name = "UCSearchBillNhap";
            this.UCSearchBillNhap.Size = new System.Drawing.Size(803, 62);
            this.UCSearchBillNhap.TabIndex = 4;
            // 
            // FormHoaDonNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1305, 700);
            this.Controls.Add(this.gbTacVu);
            this.Controls.Add(this.gbListHDN);
            this.Controls.Add(this.pnHoaDonNhap);
            this.Name = "FormHoaDonNhap";
            this.Text = "FormHoaDonNhap";
            this.gbTacVu.ResumeLayout(false);
            this.gbListHDN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvHD)).EndInit();
            this.pnHoaDonNhap.ResumeLayout(false);
            this.pnHoaDonNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbTacVu;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnReLoad;
        private Guna.UI2.WinForms.Guna2GroupBox gbListHDN;
        private UCSearchBill UCSearchBillNhap;
        private System.Windows.Forms.DataGridView gvHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn khachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongThanhToan;
        private Guna.UI2.WinForms.Guna2Panel pnHoaDonNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtTongTin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTongThanhToan;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpNgayThanhToan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgayThanhToan;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKH;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaKH;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNV;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaNV;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenNV;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblKH;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaNV;
        private Guna.UI2.WinForms.Guna2TextBox txtDonGia;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDonGia;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoLuong;
        private Guna.UI2.WinForms.Guna2TextBox txtTenLoai;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenLoai;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaLoai;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaLoai;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSP;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenSP;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaSP;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaSP;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHD;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaHD;
    }
}