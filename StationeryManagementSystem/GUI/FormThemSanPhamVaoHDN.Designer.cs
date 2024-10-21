namespace StationeryManagementSystem.GUI
{
    partial class FormThemSanPhamVaoHDN
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
            this.txtSearh = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbListSP = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblLoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSoLuong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbTenSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTenSP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbMaSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMaSP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMaHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaHD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtGiaNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.gvSP = new System.Windows.Forms.DataGridView();
            this.tenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbListSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearh
            // 
            this.txtSearh.BorderRadius = 20;
            this.txtSearh.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.txtSearh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearh.DefaultText = "";
            this.txtSearh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearh.FillColor = System.Drawing.Color.LightYellow;
            this.txtSearh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearh.ForeColor = System.Drawing.Color.Teal;
            this.txtSearh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearh.Location = new System.Drawing.Point(302, 56);
            this.txtSearh.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearh.Name = "txtSearh";
            this.txtSearh.PasswordChar = '\0';
            this.txtSearh.PlaceholderText = "";
            this.txtSearh.SelectedText = "";
            this.txtSearh.Size = new System.Drawing.Size(475, 36);
            this.txtSearh.TabIndex = 21;
            this.txtSearh.TextChanged += new System.EventHandler(this.txtSearh_TextChanged);
            // 
            // gbListSP
            // 
            this.gbListSP.BorderRadius = 10;
            this.gbListSP.BorderThickness = 2;
            this.gbListSP.Controls.Add(this.gvSP);
            this.gbListSP.Controls.Add(this.txtSearh);
            this.gbListSP.Controls.Add(this.lblLoc);
            this.gbListSP.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbListSP.FillColor = System.Drawing.SystemColors.Control;
            this.gbListSP.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListSP.ForeColor = System.Drawing.Color.White;
            this.gbListSP.Location = new System.Drawing.Point(39, 191);
            this.gbListSP.Name = "gbListSP";
            this.gbListSP.Size = new System.Drawing.Size(968, 441);
            this.gbListSP.TabIndex = 83;
            this.gbListSP.Text = "Danh sách sản phẩm";
            // 
            // lblLoc
            // 
            this.lblLoc.BackColor = System.Drawing.Color.Transparent;
            this.lblLoc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.ForeColor = System.Drawing.Color.Teal;
            this.lblLoc.Location = new System.Drawing.Point(181, 66);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(80, 26);
            this.lblLoc.TabIndex = 23;
            this.lblLoc.Text = "Tìm kiếm";
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
            this.txtSoLuong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.ForeColor = System.Drawing.Color.Teal;
            this.txtSoLuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuong.Location = new System.Drawing.Point(21, 132);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(145, 36);
            this.txtSoLuong.TabIndex = 80;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.BackColor = System.Drawing.SystemColors.Control;
            this.lblSoLuong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.Teal;
            this.lblSoLuong.Location = new System.Drawing.Point(21, 96);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(79, 26);
            this.lblSoLuong.TabIndex = 79;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // cbTenSP
            // 
            this.cbTenSP.BackColor = System.Drawing.Color.Transparent;
            this.cbTenSP.BorderColor = System.Drawing.Color.Teal;
            this.cbTenSP.BorderRadius = 10;
            this.cbTenSP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTenSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenSP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTenSP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenSP.ForeColor = System.Drawing.Color.Teal;
            this.cbTenSP.ItemHeight = 30;
            this.cbTenSP.Location = new System.Drawing.Point(355, 51);
            this.cbTenSP.Name = "cbTenSP";
            this.cbTenSP.Size = new System.Drawing.Size(378, 36);
            this.cbTenSP.TabIndex = 78;
            this.cbTenSP.SelectedIndexChanged += new System.EventHandler(this.cbTenSP_SelectedIndexChanged);
            // 
            // lblTenSP
            // 
            this.lblTenSP.BackColor = System.Drawing.SystemColors.Control;
            this.lblTenSP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.Color.Teal;
            this.lblTenSP.Location = new System.Drawing.Point(355, 15);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(121, 26);
            this.lblTenSP.TabIndex = 77;
            this.lblTenSP.Text = "Tên  sản phẩm";
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
            this.cbMaSP.Location = new System.Drawing.Point(196, 51);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(133, 36);
            this.cbMaSP.TabIndex = 76;
            this.cbMaSP.SelectedIndexChanged += new System.EventHandler(this.cbMaSP_SelectedIndexChanged);
            // 
            // lblMaSP
            // 
            this.lblMaSP.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaSP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.ForeColor = System.Drawing.Color.Teal;
            this.lblMaSP.Location = new System.Drawing.Point(196, 15);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(117, 26);
            this.lblMaSP.TabIndex = 75;
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
            this.txtMaHD.Enabled = false;
            this.txtMaHD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.ForeColor = System.Drawing.Color.Teal;
            this.txtMaHD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaHD.Location = new System.Drawing.Point(21, 51);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.PasswordChar = '\0';
            this.txtMaHD.PlaceholderText = "";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.SelectedText = "";
            this.txtMaHD.Size = new System.Drawing.Size(145, 36);
            this.txtMaHD.TabIndex = 74;
            // 
            // lblMaHD
            // 
            this.lblMaHD.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaHD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.ForeColor = System.Drawing.Color.Teal;
            this.lblMaHD.Location = new System.Drawing.Point(21, 18);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(144, 26);
            this.lblMaHD.TabIndex = 73;
            this.lblMaHD.Text = "Mã hóa đơn bán";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.BorderColor = System.Drawing.Color.Teal;
            this.txtGiaNhap.BorderRadius = 10;
            this.txtGiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaNhap.DefaultText = "0";
            this.txtGiaNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaNhap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.ForeColor = System.Drawing.Color.Teal;
            this.txtGiaNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaNhap.Location = new System.Drawing.Point(196, 129);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.PasswordChar = '\0';
            this.txtGiaNhap.PlaceholderText = "";
            this.txtGiaNhap.SelectedText = "";
            this.txtGiaNhap.Size = new System.Drawing.Size(145, 36);
            this.txtGiaNhap.TabIndex = 85;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Teal;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(196, 96);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(81, 26);
            this.guna2HtmlLabel1.TabIndex = 84;
            this.guna2HtmlLabel1.Text = "Giá Nhập";
            // 
            // btnHuy
            // 
            this.btnHuy.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.BorderThickness = 2;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.Linen;
            this.btnHuy.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnHuy.Image = global::StationeryManagementSystem.Properties.Resources.huy;
            this.btnHuy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHuy.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHuy.Location = new System.Drawing.Point(509, 127);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(93, 41);
            this.btnHuy.TabIndex = 82;
            this.btnHuy.Text = "      Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnXacNhan.BorderRadius = 10;
            this.btnXacNhan.BorderThickness = 2;
            this.btnXacNhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXacNhan.FillColor = System.Drawing.Color.Linen;
            this.btnXacNhan.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnXacNhan.Image = global::StationeryManagementSystem.Properties.Resources.xacnhan;
            this.btnXacNhan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXacNhan.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXacNhan.Location = new System.Drawing.Point(359, 127);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(124, 41);
            this.btnXacNhan.TabIndex = 81;
            this.btnXacNhan.Text = "       Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // gvSP
            // 
            this.gvSP.BackgroundColor = System.Drawing.Color.White;
            this.gvSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenSP,
            this.maSanPham,
            this.maLoai,
            this.tenLoai,
            this.maNCC,
            this.tenNCC,
            this.giaNhap,
            this.giaBan,
            this.soLuong});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSP.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvSP.GridColor = System.Drawing.Color.White;
            this.gvSP.Location = new System.Drawing.Point(35, 127);
            this.gvSP.Name = "gvSP";
            this.gvSP.ReadOnly = true;
            this.gvSP.RowHeadersWidth = 51;
            this.gvSP.RowTemplate.Height = 24;
            this.gvSP.Size = new System.Drawing.Size(894, 284);
            this.gvSP.TabIndex = 25;
            this.gvSP.Click += new System.EventHandler(this.gvSP_Click);
            // 
            // tenSP
            // 
            this.tenSP.DataPropertyName = "Tên SP";
            this.tenSP.HeaderText = "Tên sản phẩm";
            this.tenSP.MinimumWidth = 6;
            this.tenSP.Name = "tenSP";
            this.tenSP.ReadOnly = true;
            this.tenSP.Width = 170;
            // 
            // maSanPham
            // 
            this.maSanPham.DataPropertyName = "Mã SP";
            this.maSanPham.HeaderText = "Mã sản phẩm";
            this.maSanPham.MinimumWidth = 6;
            this.maSanPham.Name = "maSanPham";
            this.maSanPham.ReadOnly = true;
            this.maSanPham.Width = 170;
            // 
            // maLoai
            // 
            this.maLoai.DataPropertyName = "Mã Loại SP";
            this.maLoai.HeaderText = "Mã loại";
            this.maLoai.MinimumWidth = 6;
            this.maLoai.Name = "maLoai";
            this.maLoai.ReadOnly = true;
            this.maLoai.Width = 125;
            // 
            // tenLoai
            // 
            this.tenLoai.DataPropertyName = "Tên Loại SP";
            this.tenLoai.HeaderText = "Tên loại";
            this.tenLoai.MinimumWidth = 6;
            this.tenLoai.Name = "tenLoai";
            this.tenLoai.ReadOnly = true;
            this.tenLoai.Width = 150;
            // 
            // maNCC
            // 
            this.maNCC.DataPropertyName = "Mã NCC";
            this.maNCC.HeaderText = "Mã NCC";
            this.maNCC.MinimumWidth = 6;
            this.maNCC.Name = "maNCC";
            this.maNCC.ReadOnly = true;
            this.maNCC.Width = 125;
            // 
            // tenNCC
            // 
            this.tenNCC.DataPropertyName = "Tên NCC";
            this.tenNCC.HeaderText = "Tên nhà cung cấp";
            this.tenNCC.MinimumWidth = 6;
            this.tenNCC.Name = "tenNCC";
            this.tenNCC.ReadOnly = true;
            this.tenNCC.Width = 200;
            // 
            // giaNhap
            // 
            this.giaNhap.DataPropertyName = "Giá Nhập";
            this.giaNhap.HeaderText = "Giá nhập";
            this.giaNhap.MinimumWidth = 6;
            this.giaNhap.Name = "giaNhap";
            this.giaNhap.ReadOnly = true;
            this.giaNhap.Width = 120;
            // 
            // giaBan
            // 
            this.giaBan.DataPropertyName = "Giá Bán";
            this.giaBan.HeaderText = "Giá bán";
            this.giaBan.MinimumWidth = 6;
            this.giaBan.Name = "giaBan";
            this.giaBan.ReadOnly = true;
            this.giaBan.Width = 120;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "SL Tồn Kho";
            this.soLuong.HeaderText = "Số lượng trong kho";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 170;
            // 
            // FormThemSanPhamVaoHDN
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1064, 663);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.gbListSP);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.cbTenSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.cbMaSP);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.lblMaHD);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Name = "FormThemSanPhamVaoHDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemSanPhamVaoHDN";
            this.Load += new System.EventHandler(this.FormThemSanPhamVaoHDN_Load);
            this.gbListSP.ResumeLayout(false);
            this.gbListSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox txtSearh;
        private Guna.UI2.WinForms.Guna2GroupBox gbListSP;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblLoc;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoLuong;
        private Guna.UI2.WinForms.Guna2ComboBox cbTenSP;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenSP;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaSP;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaSP;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHD;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaHD;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaNhap;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridView gvSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
    }
}