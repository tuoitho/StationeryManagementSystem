namespace StationeryManagementSystem.GUI
{
    partial class FormLichLamViec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbTaoCa = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gvPhanCa = new System.Windows.Forms.DataGridView();
            this.dpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnPhanCa = new Guna.UI2.WinForms.Guna2Button();
            this.lblPhanCa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbLichLamViec = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gvDangKy = new System.Windows.Forms.DataGridView();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.dpChonNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblChonNgay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbChamCong = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.maNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbTaoCa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanCa)).BeginInit();
            this.gbLichLamViec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.gbChamCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTaoCa
            // 
            this.gbTaoCa.BorderRadius = 10;
            this.gbTaoCa.BorderThickness = 2;
            this.gbTaoCa.Controls.Add(this.gvPhanCa);
            this.gbTaoCa.Controls.Add(this.dpEnd);
            this.gbTaoCa.Controls.Add(this.dpStart);
            this.gbTaoCa.Controls.Add(this.btnPhanCa);
            this.gbTaoCa.Controls.Add(this.lblPhanCa);
            this.gbTaoCa.Controls.Add(this.lblDen);
            this.gbTaoCa.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbTaoCa.FillColor = System.Drawing.SystemColors.Control;
            this.gbTaoCa.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTaoCa.ForeColor = System.Drawing.Color.White;
            this.gbTaoCa.Location = new System.Drawing.Point(173, 12);
            this.gbTaoCa.Name = "gbTaoCa";
            this.gbTaoCa.Size = new System.Drawing.Size(901, 330);
            this.gbTaoCa.TabIndex = 59;
            this.gbTaoCa.Text = "Phân ca";
            // 
            // gvPhanCa
            // 
            this.gvPhanCa.BackgroundColor = System.Drawing.Color.White;
            this.gvPhanCa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPhanCa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvPhanCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPhanCa.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvPhanCa.GridColor = System.Drawing.Color.White;
            this.gvPhanCa.Location = new System.Drawing.Point(28, 129);
            this.gvPhanCa.Name = "gvPhanCa";
            this.gvPhanCa.RowHeadersWidth = 51;
            this.gvPhanCa.RowTemplate.Height = 24;
            this.gvPhanCa.Size = new System.Drawing.Size(847, 181);
            this.gvPhanCa.TabIndex = 61;
            this.gvPhanCa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvLichLamViec_CellContentClick);
            this.gvPhanCa.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gvLichLamViec_CellMouseClick);
            // 
            // dpEnd
            // 
            this.dpEnd.BackColor = System.Drawing.SystemColors.Control;
            this.dpEnd.BorderColor = System.Drawing.Color.Teal;
            this.dpEnd.BorderRadius = 10;
            this.dpEnd.BorderThickness = 1;
            this.dpEnd.Checked = true;
            this.dpEnd.FillColor = System.Drawing.Color.White;
            this.dpEnd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpEnd.ForeColor = System.Drawing.Color.Teal;
            this.dpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpEnd.Location = new System.Drawing.Point(466, 53);
            this.dpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(279, 36);
            this.dpEnd.TabIndex = 71;
            this.dpEnd.Value = new System.DateTime(2024, 10, 19, 0, 0, 0, 0);
            // 
            // dpStart
            // 
            this.dpStart.BackColor = System.Drawing.SystemColors.Control;
            this.dpStart.BorderColor = System.Drawing.Color.Teal;
            this.dpStart.BorderRadius = 10;
            this.dpStart.BorderThickness = 1;
            this.dpStart.Checked = true;
            this.dpStart.FillColor = System.Drawing.Color.White;
            this.dpStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpStart.ForeColor = System.Drawing.Color.Teal;
            this.dpStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpStart.Location = new System.Drawing.Point(140, 53);
            this.dpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(279, 36);
            this.dpStart.TabIndex = 70;
            this.dpStart.Value = new System.DateTime(2024, 10, 19, 0, 0, 0, 0);
            // 
            // btnPhanCa
            // 
            this.btnPhanCa.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnPhanCa.BorderRadius = 10;
            this.btnPhanCa.BorderThickness = 2;
            this.btnPhanCa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPhanCa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPhanCa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPhanCa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPhanCa.FillColor = System.Drawing.Color.Linen;
            this.btnPhanCa.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCa.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPhanCa.Image = global::StationeryManagementSystem.Properties.Resources.plus;
            this.btnPhanCa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPhanCa.Location = new System.Drawing.Point(762, 48);
            this.btnPhanCa.Name = "btnPhanCa";
            this.btnPhanCa.Size = new System.Drawing.Size(113, 41);
            this.btnPhanCa.TabIndex = 66;
            this.btnPhanCa.Text = "    Phân ca";
            this.btnPhanCa.Click += new System.EventHandler(this.btnPhanCa_Click);
            // 
            // lblPhanCa
            // 
            this.lblPhanCa.BackColor = System.Drawing.SystemColors.Control;
            this.lblPhanCa.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanCa.ForeColor = System.Drawing.Color.Teal;
            this.lblPhanCa.Location = new System.Drawing.Point(28, 63);
            this.lblPhanCa.Name = "lblPhanCa";
            this.lblPhanCa.Size = new System.Drawing.Size(95, 26);
            this.lblPhanCa.TabIndex = 60;
            this.lblPhanCa.Text = "Phân ca từ";
            // 
            // lblDen
            // 
            this.lblDen.BackColor = System.Drawing.SystemColors.Control;
            this.lblDen.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDen.ForeColor = System.Drawing.Color.Teal;
            this.lblDen.Location = new System.Drawing.Point(425, 63);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(35, 26);
            this.lblDen.TabIndex = 62;
            this.lblDen.Text = "đến";
            // 
            // gbLichLamViec
            // 
            this.gbLichLamViec.BorderRadius = 10;
            this.gbLichLamViec.BorderThickness = 2;
            this.gbLichLamViec.Controls.Add(this.gvDangKy);
            this.gbLichLamViec.Controls.Add(this.pbSearch);
            this.gbLichLamViec.Controls.Add(this.dpChonNgay);
            this.gbLichLamViec.Controls.Add(this.lblChonNgay);
            this.gbLichLamViec.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbLichLamViec.FillColor = System.Drawing.SystemColors.Control;
            this.gbLichLamViec.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLichLamViec.ForeColor = System.Drawing.Color.White;
            this.gbLichLamViec.Location = new System.Drawing.Point(66, 373);
            this.gbLichLamViec.Name = "gbLichLamViec";
            this.gbLichLamViec.Size = new System.Drawing.Size(544, 304);
            this.gbLichLamViec.TabIndex = 60;
            this.gbLichLamViec.Text = "Đăng ký ca làm";
            // 
            // gvDangKy
            // 
            this.gvDangKy.BackgroundColor = System.Drawing.Color.White;
            this.gvDangKy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDangKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDangKy.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvDangKy.GridColor = System.Drawing.Color.White;
            this.gvDangKy.Location = new System.Drawing.Point(20, 103);
            this.gvDangKy.Name = "gvDangKy";
            this.gvDangKy.RowHeadersWidth = 51;
            this.gvDangKy.RowTemplate.Height = 24;
            this.gvDangKy.Size = new System.Drawing.Size(504, 181);
            this.gvDangKy.TabIndex = 72;
            // 
            // pbSearch
            // 
            this.pbSearch.BackgroundImage = global::StationeryManagementSystem.Properties.Resources.Search;
            this.pbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSearch.Location = new System.Drawing.Point(394, 61);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(50, 36);
            this.pbSearch.TabIndex = 60;
            this.pbSearch.TabStop = false;
            this.pbSearch.MouseEnter += new System.EventHandler(this.pbSearch_MouseEnter);
            this.pbSearch.MouseLeave += new System.EventHandler(this.pbSearch_MouseLeave);
            // 
            // dpChonNgay
            // 
            this.dpChonNgay.BackColor = System.Drawing.SystemColors.Control;
            this.dpChonNgay.BorderColor = System.Drawing.Color.Teal;
            this.dpChonNgay.BorderRadius = 10;
            this.dpChonNgay.BorderThickness = 1;
            this.dpChonNgay.Checked = true;
            this.dpChonNgay.FillColor = System.Drawing.Color.White;
            this.dpChonNgay.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpChonNgay.ForeColor = System.Drawing.Color.Teal;
            this.dpChonNgay.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpChonNgay.Location = new System.Drawing.Point(117, 61);
            this.dpChonNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpChonNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpChonNgay.Name = "dpChonNgay";
            this.dpChonNgay.Size = new System.Drawing.Size(257, 36);
            this.dpChonNgay.TabIndex = 59;
            this.dpChonNgay.Value = new System.DateTime(2024, 10, 14, 0, 0, 0, 0);
            // 
            // lblChonNgay
            // 
            this.lblChonNgay.BackColor = System.Drawing.SystemColors.Control;
            this.lblChonNgay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonNgay.ForeColor = System.Drawing.Color.Teal;
            this.lblChonNgay.Location = new System.Drawing.Point(20, 71);
            this.lblChonNgay.Name = "lblChonNgay";
            this.lblChonNgay.Size = new System.Drawing.Size(91, 26);
            this.lblChonNgay.TabIndex = 58;
            this.lblChonNgay.Text = "Chọn ngày";
            // 
            // gbChamCong
            // 
            this.gbChamCong.BorderRadius = 10;
            this.gbChamCong.BorderThickness = 2;
            this.gbChamCong.Controls.Add(this.dataGridView2);
            this.gbChamCong.Controls.Add(this.pictureBox1);
            this.gbChamCong.Controls.Add(this.guna2DateTimePicker1);
            this.gbChamCong.Controls.Add(this.guna2HtmlLabel1);
            this.gbChamCong.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbChamCong.FillColor = System.Drawing.SystemColors.Control;
            this.gbChamCong.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbChamCong.ForeColor = System.Drawing.Color.White;
            this.gbChamCong.Location = new System.Drawing.Point(664, 373);
            this.gbChamCong.Name = "gbChamCong";
            this.gbChamCong.Size = new System.Drawing.Size(544, 304);
            this.gbChamCong.TabIndex = 73;
            this.gbChamCong.Text = "Chấm công";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNV,
            this.tenNV,
            this.maCa,
            this.gioBatDau,
            this.gioKetThuc});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.GridColor = System.Drawing.Color.White;
            this.dataGridView2.Location = new System.Drawing.Point(20, 103);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(504, 181);
            this.dataGridView2.TabIndex = 72;
            // 
            // maNV
            // 
            this.maNV.HeaderText = "Mã nhân viên";
            this.maNV.MinimumWidth = 6;
            this.maNV.Name = "maNV";
            this.maNV.Width = 125;
            // 
            // tenNV
            // 
            this.tenNV.HeaderText = "Tên nhân viên";
            this.tenNV.MinimumWidth = 6;
            this.tenNV.Name = "tenNV";
            this.tenNV.Width = 125;
            // 
            // maCa
            // 
            this.maCa.HeaderText = "Mã ca";
            this.maCa.MinimumWidth = 6;
            this.maCa.Name = "maCa";
            this.maCa.Width = 125;
            // 
            // gioBatDau
            // 
            this.gioBatDau.HeaderText = "Giờ bắt đầu";
            this.gioBatDau.MinimumWidth = 6;
            this.gioBatDau.Name = "gioBatDau";
            this.gioBatDau.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gioBatDau.Width = 125;
            // 
            // gioKetThuc
            // 
            this.gioKetThuc.HeaderText = "Giờ kêt thúc";
            this.gioKetThuc.MinimumWidth = 6;
            this.gioKetThuc.Name = "gioKetThuc";
            this.gioKetThuc.Width = 125;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::StationeryManagementSystem.Properties.Resources.Search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(394, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 36);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.Teal;
            this.guna2DateTimePicker1.BorderRadius = 10;
            this.guna2DateTimePicker1.BorderThickness = 1;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.Teal;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(117, 61);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(257, 36);
            this.guna2DateTimePicker1.TabIndex = 59;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 10, 14, 0, 0, 0, 0);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Teal;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(20, 71);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(91, 26);
            this.guna2HtmlLabel1.TabIndex = 58;
            this.guna2HtmlLabel1.Text = "Chọn ngày";
            // 
            // FormLichLamViec
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1263, 854);
            this.Controls.Add(this.gbChamCong);
            this.Controls.Add(this.gbLichLamViec);
            this.Controls.Add(this.gbTaoCa);
            this.Name = "FormLichLamViec";
            this.Text = "FormLichLamViec";
            this.Load += new System.EventHandler(this.FormLichLamViec_Load);
            this.gbTaoCa.ResumeLayout(false);
            this.gbTaoCa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanCa)).EndInit();
            this.gbLichLamViec.ResumeLayout(false);
            this.gbLichLamViec.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.gbChamCong.ResumeLayout(false);
            this.gbChamCong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox gbTaoCa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhanCa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDen;
        private Guna.UI2.WinForms.Guna2Button btnPhanCa;
        private Guna.UI2.WinForms.Guna2GroupBox gbLichLamViec;
        private System.Windows.Forms.PictureBox pbSearch;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpChonNgay;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblChonNgay;
        private System.Windows.Forms.DataGridView gvPhanCa;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpStart;
        private System.Windows.Forms.DataGridView gvDangKy;
        private Guna.UI2.WinForms.Guna2GroupBox gbChamCong;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioKetThuc;
    }
}