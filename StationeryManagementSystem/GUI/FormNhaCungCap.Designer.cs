namespace StationeryManagementSystem.GUI
{
    partial class FormNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhaCungCap));
            this.gbListNCC = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gvNhaCungCap = new System.Windows.Forms.DataGridView();
            this.maNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtSearh = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbTacVu = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnReLoad = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtSDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHoTen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMaNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDiaChi = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblNgaySinh = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSDT = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblMaNCC = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbThongTin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gbListNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhaCungCap)).BeginInit();
            this.gbTacVu.SuspendLayout();
            this.gbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbListNCC
            // 
            this.gbListNCC.BorderRadius = 10;
            this.gbListNCC.BorderThickness = 2;
            this.gbListNCC.Controls.Add(this.gvNhaCungCap);
            this.gbListNCC.Controls.Add(this.lblLoc);
            this.gbListNCC.Controls.Add(this.txtSearh);
            this.gbListNCC.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbListNCC.FillColor = System.Drawing.SystemColors.Control;
            this.gbListNCC.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListNCC.ForeColor = System.Drawing.Color.White;
            this.gbListNCC.Location = new System.Drawing.Point(533, 29);
            this.gbListNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbListNCC.Name = "gbListNCC";
            this.gbListNCC.Size = new System.Drawing.Size(537, 629);
            this.gbListNCC.TabIndex = 18;
            this.gbListNCC.Text = "Danh sách nhà cung cấp ";
            // 
            // gvNhaCungCap
            // 
            this.gvNhaCungCap.BackgroundColor = System.Drawing.Color.White;
            this.gvNhaCungCap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvNhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNCC,
            this.tenNCC,
            this.diaChi,
            this.soDienThoai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvNhaCungCap.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvNhaCungCap.GridColor = System.Drawing.Color.White;
            this.gvNhaCungCap.Location = new System.Drawing.Point(22, 141);
            this.gvNhaCungCap.Name = "gvNhaCungCap";
            this.gvNhaCungCap.ReadOnly = true;
            this.gvNhaCungCap.RowHeadersWidth = 51;
            this.gvNhaCungCap.RowTemplate.Height = 24;
            this.gvNhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvNhaCungCap.Size = new System.Drawing.Size(492, 464);
            this.gvNhaCungCap.TabIndex = 25;
            this.gvNhaCungCap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvNhaCungCap_CellClick_1);
            // 
            // maNCC
            // 
            this.maNCC.DataPropertyName = "Mã NCC";
            this.maNCC.HeaderText = "Mã NCC";
            this.maNCC.MinimumWidth = 6;
            this.maNCC.Name = "maNCC";
            this.maNCC.ReadOnly = true;
            this.maNCC.Width = 170;
            // 
            // tenNCC
            // 
            this.tenNCC.DataPropertyName = "Tên NCC";
            this.tenNCC.HeaderText = "Tên NCC";
            this.tenNCC.MinimumWidth = 6;
            this.tenNCC.Name = "tenNCC";
            this.tenNCC.ReadOnly = true;
            this.tenNCC.Width = 200;
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
            this.soDienThoai.HeaderText = "Số điên thoại";
            this.soDienThoai.MinimumWidth = 6;
            this.soDienThoai.Name = "soDienThoai";
            this.soDienThoai.ReadOnly = true;
            this.soDienThoai.Width = 200;
            // 
            // lblLoc
            // 
            this.lblLoc.BackColor = System.Drawing.Color.Transparent;
            this.lblLoc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.ForeColor = System.Drawing.Color.Teal;
            this.lblLoc.Location = new System.Drawing.Point(40, 92);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(80, 26);
            this.lblLoc.TabIndex = 24;
            this.lblLoc.Text = "Tìm kiếm";
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
            this.txtSearh.Location = new System.Drawing.Point(145, 78);
            this.txtSearh.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearh.Name = "txtSearh";
            this.txtSearh.PasswordChar = '\0';
            this.txtSearh.PlaceholderText = "";
            this.txtSearh.SelectedText = "";
            this.txtSearh.Size = new System.Drawing.Size(324, 36);
            this.txtSearh.TabIndex = 22;
            this.txtSearh.TextChanged += new System.EventHandler(this.txtSearh_TextChanged);
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
            this.gbTacVu.Location = new System.Drawing.Point(19, 369);
            this.gbTacVu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTacVu.Name = "gbTacVu";
            this.gbTacVu.Size = new System.Drawing.Size(388, 216);
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
            this.btnXoa.Location = new System.Drawing.Point(192, 133);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(141, 46);
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
            this.btnSua.Location = new System.Drawing.Point(14, 133);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(143, 46);
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
            this.btnReLoad.Location = new System.Drawing.Point(192, 69);
            this.btnReLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReLoad.Name = "btnReLoad";
            this.btnReLoad.Size = new System.Drawing.Size(141, 46);
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
            this.btnThem.Location = new System.Drawing.Point(14, 69);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(143, 46);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "  Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
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
            this.txtSDT.Location = new System.Drawing.Point(179, 256);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.PlaceholderText = "";
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(240, 40);
            this.txtSDT.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.txtDiaChi.Location = new System.Drawing.Point(179, 202);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.PasswordChar = '\0';
            this.txtDiaChi.PlaceholderText = "";
            this.txtDiaChi.SelectedText = "";
            this.txtDiaChi.Size = new System.Drawing.Size(240, 40);
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
            this.txtHoTen.Location = new System.Drawing.Point(179, 141);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.Size = new System.Drawing.Size(240, 40);
            this.txtHoTen.TabIndex = 7;
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.Color.Teal;
            this.lblHoTen.Location = new System.Drawing.Point(19, 155);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(149, 26);
            this.lblHoTen.TabIndex = 6;
            this.lblHoTen.Text = "Tên nhà cung cấp";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.BorderColor = System.Drawing.Color.Teal;
            this.txtMaNCC.BorderRadius = 10;
            this.txtMaNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNCC.DefaultText = "";
            this.txtMaNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNCC.Enabled = false;
            this.txtMaNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNCC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.ForeColor = System.Drawing.Color.Teal;
            this.txtMaNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNCC.Location = new System.Drawing.Point(179, 74);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.PasswordChar = '\0';
            this.txtMaNCC.PlaceholderText = "";
            this.txtMaNCC.ReadOnly = true;
            this.txtMaNCC.SelectedText = "";
            this.txtMaNCC.Size = new System.Drawing.Size(106, 40);
            this.txtMaNCC.TabIndex = 5;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaChi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.Teal;
            this.lblDiaChi.Location = new System.Drawing.Point(23, 216);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lblNgaySinh.Location = new System.Drawing.Point(23, 155);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lblSDT.Location = new System.Drawing.Point(23, 270);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(114, 26);
            this.lblSDT.TabIndex = 1;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.BackColor = System.Drawing.Color.Transparent;
            this.lblMaNCC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.ForeColor = System.Drawing.Color.Teal;
            this.lblMaNCC.Location = new System.Drawing.Point(23, 88);
            this.lblMaNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(145, 26);
            this.lblMaNCC.TabIndex = 0;
            this.lblMaNCC.Text = "Mã nhà cung cấp ";
            // 
            // gbThongTin
            // 
            this.gbThongTin.BorderRadius = 10;
            this.gbThongTin.BorderThickness = 2;
            this.gbThongTin.Controls.Add(this.gbTacVu);
            this.gbThongTin.Controls.Add(this.txtSDT);
            this.gbThongTin.Controls.Add(this.txtDiaChi);
            this.gbThongTin.Controls.Add(this.txtHoTen);
            this.gbThongTin.Controls.Add(this.lblHoTen);
            this.gbThongTin.Controls.Add(this.txtMaNCC);
            this.gbThongTin.Controls.Add(this.lblDiaChi);
            this.gbThongTin.Controls.Add(this.lblNgaySinh);
            this.gbThongTin.Controls.Add(this.lblSDT);
            this.gbThongTin.Controls.Add(this.lblMaNCC);
            this.gbThongTin.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbThongTin.FillColor = System.Drawing.SystemColors.Control;
            this.gbThongTin.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongTin.ForeColor = System.Drawing.Color.White;
            this.gbThongTin.Location = new System.Drawing.Point(12, 29);
            this.gbThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(498, 629);
            this.gbThongTin.TabIndex = 17;
            this.gbThongTin.Text = "Thông tin nhà cung cấp";
            // 
            // FormNhaCungCap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 733);
            this.Controls.Add(this.gbListNCC);
            this.Controls.Add(this.gbThongTin);
            this.Name = "FormNhaCungCap";
            this.Text = "FormNhaCungCap";
            this.Load += new System.EventHandler(this.FormNhaCungCap_Load);
            this.gbListNCC.ResumeLayout(false);
            this.gbListNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhaCungCap)).EndInit();
            this.gbTacVu.ResumeLayout(false);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbListNCC;
        private Guna.UI2.WinForms.Guna2GroupBox gbTacVu;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnReLoad;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2TextBox txtSDT;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNCC;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDiaChi;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNgaySinh;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSDT;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaNCC;
        private Guna.UI2.WinForms.Guna2GroupBox gbThongTin;
        public Guna.UI2.WinForms.Guna2TextBox txtSearh;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblLoc;
        private System.Windows.Forms.DataGridView gvNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDienThoai;
    }
}