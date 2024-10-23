namespace StationeryManagementSystem.GUI
{
    partial class FormKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbListKH = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbTacVu = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnReLoad = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.gvKH = new System.Windows.Forms.DataGridView();
            this.maKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThongTin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHoTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiaChi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNgaySinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSDT = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaKH = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbListKH.SuspendLayout();
            this.gbTacVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvKH)).BeginInit();
            this.gbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListKH
            // 
            this.gbListKH.BorderRadius = 10;
            this.gbListKH.BorderThickness = 2;
            this.gbListKH.Controls.Add(this.txtSearch);
            this.gbListKH.Controls.Add(this.lblLoc);
            this.gbListKH.Controls.Add(this.gbTacVu);
            this.gbListKH.Controls.Add(this.gvKH);
            this.gbListKH.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbListKH.FillColor = System.Drawing.SystemColors.Control;
            this.gbListKH.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListKH.ForeColor = System.Drawing.Color.White;
            this.gbListKH.Location = new System.Drawing.Point(165, 271);
            this.gbListKH.Name = "gbListKH";
            this.gbListKH.Size = new System.Drawing.Size(790, 435);
            this.gbListKH.TabIndex = 14;
            this.gbListKH.Text = "Danh sách khách hàng";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 20;
            this.txtSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.LightYellow;
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Teal;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(167, 50);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(475, 36);
            this.txtSearch.TabIndex = 28;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblLoc
            // 
            this.lblLoc.BackColor = System.Drawing.Color.Transparent;
            this.lblLoc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.ForeColor = System.Drawing.Color.Teal;
            this.lblLoc.Location = new System.Drawing.Point(80, 60);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(80, 26);
            this.lblLoc.TabIndex = 29;
            this.lblLoc.Text = "Tìm kiếm";
            // 
            // gbTacVu
            // 
            this.gbTacVu.BorderRadius = 10;
            this.gbTacVu.BorderThickness = 2;
            this.gbTacVu.Controls.Add(this.btnXoa);
            this.gbTacVu.Controls.Add(this.btnSua);
            this.gbTacVu.Controls.Add(this.btnReLoad);
            this.gbTacVu.Controls.Add(this.btnThem);
            this.gbTacVu.CustomBorderColor = System.Drawing.Color.MidnightBlue;
            this.gbTacVu.FillColor = System.Drawing.SystemColors.Control;
            this.gbTacVu.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTacVu.ForeColor = System.Drawing.Color.White;
            this.gbTacVu.Location = new System.Drawing.Point(80, 293);
            this.gbTacVu.Name = "gbTacVu";
            this.gbTacVu.Size = new System.Drawing.Size(610, 115);
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
            this.btnXoa.Location = new System.Drawing.Point(453, 54);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 45);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "   Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(300, 54);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(133, 45);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "  Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnReLoad.Location = new System.Drawing.Point(151, 54);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(133, 45);
            this.btnReLoad.TabIndex = 1;
            this.btnReLoad.Text = "     Reload";
            this.btnReLoad.Click += new System.EventHandler(this.btnReLoad_Click);
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
            this.btnThem.Location = new System.Drawing.Point(11, 54);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "  Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gvKH
            // 
            this.gvKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvKH.BackgroundColor = System.Drawing.Color.White;
            this.gvKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKH,
            this.tenKH,
            this.diaChi,
            this.soDienThoai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvKH.GridColor = System.Drawing.Color.White;
            this.gvKH.Location = new System.Drawing.Point(16, 104);
            this.gvKH.Name = "gvKH";
            this.gvKH.ReadOnly = true;
            this.gvKH.RowHeadersWidth = 51;
            this.gvKH.RowTemplate.Height = 24;
            this.gvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvKH.Size = new System.Drawing.Size(718, 168);
            this.gvKH.TabIndex = 2;
            this.gvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvKH_CellClick);
            this.gvKH.Click += new System.EventHandler(this.gvKH_Click);
            // 
            // maKH
            // 
            this.maKH.DataPropertyName = "Mã KH";
            this.maKH.HeaderText = "Mã khách hàng";
            this.maKH.MinimumWidth = 6;
            this.maKH.Name = "maKH";
            this.maKH.ReadOnly = true;
            this.maKH.Width = 170;
            // 
            // tenKH
            // 
            this.tenKH.DataPropertyName = "Họ Tên";
            this.tenKH.HeaderText = "Tên khách hàng";
            this.tenKH.MinimumWidth = 6;
            this.tenKH.Name = "tenKH";
            this.tenKH.ReadOnly = true;
            this.tenKH.Width = 170;
            // 
            // diaChi
            // 
            this.diaChi.DataPropertyName = "Địa Chỉ";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.MinimumWidth = 6;
            this.diaChi.Name = "diaChi";
            this.diaChi.ReadOnly = true;
            this.diaChi.Width = 200;
            // 
            // soDienThoai
            // 
            this.soDienThoai.DataPropertyName = "Số Điện Thoại";
            this.soDienThoai.HeaderText = "Số điện thoại";
            this.soDienThoai.MinimumWidth = 6;
            this.soDienThoai.Name = "soDienThoai";
            this.soDienThoai.ReadOnly = true;
            this.soDienThoai.Width = 200;
            // 
            // gbThongTin
            // 
            this.gbThongTin.BorderRadius = 10;
            this.gbThongTin.BorderThickness = 2;
            this.gbThongTin.Controls.Add(this.txtSDT);
            this.gbThongTin.Controls.Add(this.txtDiaChi);
            this.gbThongTin.Controls.Add(this.txtHoTen);
            this.gbThongTin.Controls.Add(this.lblHoTen);
            this.gbThongTin.Controls.Add(this.txtMaKH);
            this.gbThongTin.Controls.Add(this.lblDiaChi);
            this.gbThongTin.Controls.Add(this.lblNgaySinh);
            this.gbThongTin.Controls.Add(this.lblSDT);
            this.gbThongTin.Controls.Add(this.lblMaKH);
            this.gbThongTin.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbThongTin.FillColor = System.Drawing.SystemColors.Control;
            this.gbThongTin.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.ForeColor = System.Drawing.Color.White;
            this.gbThongTin.Location = new System.Drawing.Point(165, 25);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(790, 227);
            this.gbThongTin.TabIndex = 13;
            this.gbThongTin.Text = "Thông tin khách hàng";
            // 
            // txtSDT
            // 
            this.txtSDT.BorderColor = System.Drawing.Color.Teal;
            this.txtSDT.BorderRadius = 10;
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
            this.txtSDT.Location = new System.Drawing.Point(156, 171);
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
            this.txtDiaChi.BorderRadius = 10;
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
            this.txtDiaChi.Location = new System.Drawing.Point(156, 131);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(282, 30);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderColor = System.Drawing.Color.Teal;
            this.txtHoTen.BorderRadius = 10;
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
            // txtMaKH
            // 
            this.txtMaKH.BorderColor = System.Drawing.Color.Teal;
            this.txtMaKH.BorderRadius = 10;
            this.txtMaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKH.DefaultText = "";
            this.txtMaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKH.Enabled = false;
            this.txtMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.ForeColor = System.Drawing.Color.Teal;
            this.txtMaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKH.Location = new System.Drawing.Point(156, 50);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.PasswordChar = '\0';
            this.txtMaKH.PlaceholderText = "";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.SelectedText = "";
            this.txtMaKH.Size = new System.Drawing.Size(67, 30);
            this.txtMaKH.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaChi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.Teal;
            this.lblDiaChi.Location = new System.Drawing.Point(16, 135);
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
            this.lblNgaySinh.Size = new System.Drawing.Size(3, 2);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = null;
            // 
            // lblSDT
            // 
            this.lblSDT.BackColor = System.Drawing.Color.Transparent;
            this.lblSDT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.ForeColor = System.Drawing.Color.Teal;
            this.lblSDT.Location = new System.Drawing.Point(16, 175);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(114, 26);
            this.lblSDT.TabIndex = 1;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblMaKH
            // 
            this.lblMaKH.BackColor = System.Drawing.Color.Transparent;
            this.lblMaKH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.ForeColor = System.Drawing.Color.Teal;
            this.lblMaKH.Location = new System.Drawing.Point(16, 59);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(131, 26);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // FormKhachHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1217, 799);
            this.Controls.Add(this.gbListKH);
            this.Controls.Add(this.gbThongTin);
            this.Name = "FormKhachHang";
            this.Text = "FormKhachHang";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            this.gbListKH.ResumeLayout(false);
            this.gbListKH.PerformLayout();
            this.gbTacVu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvKH)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbListKH;
        private Guna.UI2.WinForms.Guna2GroupBox gbTacVu;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnReLoad;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.DataGridView gvKH;
        private Guna.UI2.WinForms.Guna2GroupBox gbThongTin;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKH;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDiaChi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgaySinh;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSDT;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaKH;
        public Guna.UI2.WinForms.Guna2TextBox txtSearch;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoai;
    }
}