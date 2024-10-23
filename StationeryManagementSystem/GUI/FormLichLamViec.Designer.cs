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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbPhanCa = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblPhanCa = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbDuyetCa = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gvPhanCa = new System.Windows.Forms.DataGridView();
            this.dpChonNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gvDangKy = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCheckIn = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnPhanCa = new Guna.UI2.WinForms.Guna2Button();
            this.lblListCanDuyet = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnTuChoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnPheDuyet = new Guna.UI2.WinForms.Guna2Button();
            this.gbPhanCa.SuspendLayout();
            this.gbDuyetCa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDangKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPhanCa
            // 
            this.gbPhanCa.BorderRadius = 10;
            this.gbPhanCa.BorderThickness = 2;
            this.gbPhanCa.Controls.Add(this.btnCheckIn);
            this.gbPhanCa.Controls.Add(this.btnCheckOut);
            this.gbPhanCa.Controls.Add(this.gvPhanCa);
            this.gbPhanCa.Controls.Add(this.btnPhanCa);
            this.gbPhanCa.Controls.Add(this.dpEnd);
            this.gbPhanCa.Controls.Add(this.dpStart);
            this.gbPhanCa.Controls.Add(this.lblPhanCa);
            this.gbPhanCa.Controls.Add(this.lblDen);
            this.gbPhanCa.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbPhanCa.FillColor = System.Drawing.SystemColors.Control;
            this.gbPhanCa.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPhanCa.ForeColor = System.Drawing.Color.White;
            this.gbPhanCa.Location = new System.Drawing.Point(21, 33);
            this.gbPhanCa.Name = "gbPhanCa";
            this.gbPhanCa.Size = new System.Drawing.Size(563, 621);
            this.gbPhanCa.TabIndex = 59;
            this.gbPhanCa.Text = "Phân ca";
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
            this.dpEnd.Location = new System.Drawing.Point(114, 98);
            this.dpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(305, 36);
            this.dpEnd.TabIndex = 71;
            this.dpEnd.Value = new System.DateTime(2024, 10, 23, 0, 0, 0, 0);
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
            this.dpStart.Location = new System.Drawing.Point(114, 53);
            this.dpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(305, 36);
            this.dpStart.TabIndex = 70;
            this.dpStart.Value = new System.DateTime(2024, 10, 23, 0, 0, 0, 0);
            // 
            // lblPhanCa
            // 
            this.lblPhanCa.BackColor = System.Drawing.SystemColors.Control;
            this.lblPhanCa.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanCa.ForeColor = System.Drawing.Color.Teal;
            this.lblPhanCa.Location = new System.Drawing.Point(13, 58);
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
            this.lblDen.Location = new System.Drawing.Point(55, 117);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(35, 26);
            this.lblDen.TabIndex = 62;
            this.lblDen.Text = "đến";
            // 
            // gbDuyetCa
            // 
            this.gbDuyetCa.BorderRadius = 10;
            this.gbDuyetCa.BorderThickness = 2;
            this.gbDuyetCa.Controls.Add(this.btnTuChoi);
            this.gbDuyetCa.Controls.Add(this.btnPheDuyet);
            this.gbDuyetCa.Controls.Add(this.lblListCanDuyet);
            this.gbDuyetCa.Controls.Add(this.gvDangKy);
            this.gbDuyetCa.Controls.Add(this.pictureBox1);
            this.gbDuyetCa.Controls.Add(this.dpChonNgay);
            this.gbDuyetCa.Controls.Add(this.guna2HtmlLabel1);
            this.gbDuyetCa.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbDuyetCa.FillColor = System.Drawing.SystemColors.Control;
            this.gbDuyetCa.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDuyetCa.ForeColor = System.Drawing.Color.White;
            this.gbDuyetCa.Location = new System.Drawing.Point(619, 33);
            this.gbDuyetCa.Name = "gbDuyetCa";
            this.gbDuyetCa.Size = new System.Drawing.Size(612, 621);
            this.gbDuyetCa.TabIndex = 73;
            this.gbDuyetCa.Text = "Duyệt ca làm";
            // 
            // gvPhanCa
            // 
            this.gvPhanCa.BackgroundColor = System.Drawing.Color.White;
            this.gvPhanCa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPhanCa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gvPhanCa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPhanCa.DefaultCellStyle = dataGridViewCellStyle8;
            this.gvPhanCa.GridColor = System.Drawing.Color.White;
            this.gvPhanCa.Location = new System.Drawing.Point(22, 213);
            this.gvPhanCa.Name = "gvPhanCa";
            this.gvPhanCa.RowHeadersWidth = 51;
            this.gvPhanCa.RowTemplate.Height = 24;
            this.gvPhanCa.Size = new System.Drawing.Size(486, 279);
            this.gvPhanCa.TabIndex = 72;
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
            this.dpChonNgay.Location = new System.Drawing.Point(117, 71);
            this.dpChonNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpChonNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpChonNgay.Name = "dpChonNgay";
            this.dpChonNgay.Size = new System.Drawing.Size(282, 36);
            this.dpChonNgay.TabIndex = 59;
            this.dpChonNgay.Value = new System.DateTime(2024, 10, 23, 0, 0, 0, 0);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Teal;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(20, 81);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(91, 26);
            this.guna2HtmlLabel1.TabIndex = 58;
            this.guna2HtmlLabel1.Text = "Chọn ngày";
            // 
            // gvDangKy
            // 
            this.gvDangKy.BackgroundColor = System.Drawing.Color.White;
            this.gvDangKy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDangKy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDangKy.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvDangKy.GridColor = System.Drawing.Color.White;
            this.gvDangKy.Location = new System.Drawing.Point(20, 213);
            this.gvDangKy.Name = "gvDangKy";
            this.gvDangKy.RowHeadersWidth = 51;
            this.gvDangKy.RowTemplate.Height = 24;
            this.gvDangKy.Size = new System.Drawing.Size(572, 277);
            this.gvDangKy.TabIndex = 73;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::StationeryManagementSystem.Properties.Resources.Search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(424, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 36);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnCheckIn.BorderRadius = 10;
            this.btnCheckIn.BorderThickness = 2;
            this.btnCheckIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckIn.FillColor = System.Drawing.Color.Linen;
            this.btnCheckIn.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCheckIn.Image = global::StationeryManagementSystem.Properties.Resources.checkin1;
            this.btnCheckIn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCheckIn.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCheckIn.Location = new System.Drawing.Point(55, 518);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(139, 41);
            this.btnCheckIn.TabIndex = 74;
            this.btnCheckIn.Text = "     Check In";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnCheckOut.BorderRadius = 10;
            this.btnCheckOut.BorderThickness = 2;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.FillColor = System.Drawing.Color.Linen;
            this.btnCheckOut.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnCheckOut.Image = global::StationeryManagementSystem.Properties.Resources.checkOut;
            this.btnCheckOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCheckOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCheckOut.Location = new System.Drawing.Point(233, 518);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(139, 41);
            this.btnCheckOut.TabIndex = 73;
            this.btnCheckOut.Text = "      Check Out";
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
            this.btnPhanCa.Location = new System.Drawing.Point(114, 147);
            this.btnPhanCa.Name = "btnPhanCa";
            this.btnPhanCa.Size = new System.Drawing.Size(113, 41);
            this.btnPhanCa.TabIndex = 66;
            this.btnPhanCa.Text = "    Phân ca";
            this.btnPhanCa.Click += new System.EventHandler(this.btnPhanCa_Click);
            // 
            // lblListCanDuyet
            // 
            this.lblListCanDuyet.BackColor = System.Drawing.SystemColors.Control;
            this.lblListCanDuyet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListCanDuyet.ForeColor = System.Drawing.Color.Teal;
            this.lblListCanDuyet.Location = new System.Drawing.Point(20, 138);
            this.lblListCanDuyet.Name = "lblListCanDuyet";
            this.lblListCanDuyet.Size = new System.Drawing.Size(180, 26);
            this.lblListCanDuyet.TabIndex = 74;
            this.lblListCanDuyet.Text = "Danh sách chờ duyệt";
            // 
            // btnTuChoi
            // 
            this.btnTuChoi.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnTuChoi.BorderRadius = 10;
            this.btnTuChoi.BorderThickness = 2;
            this.btnTuChoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTuChoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTuChoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTuChoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTuChoi.FillColor = System.Drawing.Color.Linen;
            this.btnTuChoi.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuChoi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTuChoi.Image = global::StationeryManagementSystem.Properties.Resources.huy;
            this.btnTuChoi.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTuChoi.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTuChoi.Location = new System.Drawing.Point(322, 518);
            this.btnTuChoi.Name = "btnTuChoi";
            this.btnTuChoi.Size = new System.Drawing.Size(139, 41);
            this.btnTuChoi.TabIndex = 75;
            this.btnTuChoi.Text = "     Từ chối";
            // 
            // btnPheDuyet
            // 
            this.btnPheDuyet.BorderColor = System.Drawing.Color.MidnightBlue;
            this.btnPheDuyet.BorderRadius = 10;
            this.btnPheDuyet.BorderThickness = 2;
            this.btnPheDuyet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPheDuyet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPheDuyet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPheDuyet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPheDuyet.FillColor = System.Drawing.Color.Linen;
            this.btnPheDuyet.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPheDuyet.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPheDuyet.Image = global::StationeryManagementSystem.Properties.Resources.xacnhan;
            this.btnPheDuyet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPheDuyet.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPheDuyet.Location = new System.Drawing.Point(132, 518);
            this.btnPheDuyet.Name = "btnPheDuyet";
            this.btnPheDuyet.Size = new System.Drawing.Size(139, 41);
            this.btnPheDuyet.TabIndex = 76;
            this.btnPheDuyet.Text = "     Phê duyệt";
            // 
            // FormLichLamViec
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1276, 704);
            this.Controls.Add(this.gbDuyetCa);
            this.Controls.Add(this.gbPhanCa);
            this.Name = "FormLichLamViec";
            this.Text = "FormLichLamViec";
            this.Load += new System.EventHandler(this.FormLichLamViec_Load);
            this.gbPhanCa.ResumeLayout(false);
            this.gbPhanCa.PerformLayout();
            this.gbDuyetCa.ResumeLayout(false);
            this.gbDuyetCa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhanCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDangKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhanCa;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDen;
        private Guna.UI2.WinForms.Guna2Button btnPhanCa;
        private Guna.UI2.WinForms.Guna2GroupBox gbPhanCa;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpStart;
        private Guna.UI2.WinForms.Guna2GroupBox gbDuyetCa;
        private System.Windows.Forms.DataGridView gvPhanCa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpChonNgay;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridView gvDangKy;
        private Guna.UI2.WinForms.Guna2Button btnCheckIn;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblListCanDuyet;
        private Guna.UI2.WinForms.Guna2Button btnTuChoi;
        private Guna.UI2.WinForms.Guna2Button btnPheDuyet;
    }
}