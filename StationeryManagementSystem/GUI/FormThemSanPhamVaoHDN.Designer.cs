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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbListSP = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtSearh = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblLoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gvSP = new System.Windows.Forms.DataGridView();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnXacNhan = new Guna.UI2.WinForms.Guna2Button();
            this.txtSoLuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSoLuong = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbTenSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTenSP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbMaSP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblMaSP = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMaHD = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMaHD = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gbListSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSP)).BeginInit();
            this.SuspendLayout();
            // 
            // gbListSP
            // 
            this.gbListSP.BorderRadius = 10;
            this.gbListSP.BorderThickness = 2;
            this.gbListSP.Controls.Add(this.txtSearh);
            this.gbListSP.Controls.Add(this.lblLoc);
            this.gbListSP.Controls.Add(this.gvSP);
            this.gbListSP.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbListSP.FillColor = System.Drawing.SystemColors.Control;
            this.gbListSP.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListSP.ForeColor = System.Drawing.Color.White;
            this.gbListSP.Location = new System.Drawing.Point(101, 266);
            this.gbListSP.Name = "gbListSP";
            this.gbListSP.Size = new System.Drawing.Size(1120, 630);
            this.gbListSP.TabIndex = 72;
            this.gbListSP.Text = "Danh sách sản phẩm";
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
            this.txtSearh.Location = new System.Drawing.Point(367, 56);
            this.txtSearh.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearh.Name = "txtSearh";
            this.txtSearh.PasswordChar = '\0';
            this.txtSearh.PlaceholderText = "";
            this.txtSearh.SelectedText = "";
            this.txtSearh.Size = new System.Drawing.Size(416, 36);
            this.txtSearh.TabIndex = 21;
            // 
            // lblLoc
            // 
            this.lblLoc.BackColor = System.Drawing.Color.Transparent;
            this.lblLoc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.ForeColor = System.Drawing.Color.Teal;
            this.lblLoc.Location = new System.Drawing.Point(158, 66);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(80, 26);
            this.lblLoc.TabIndex = 23;
            this.lblLoc.Text = "Tìm kiếm";
            // 
            // gvSP
            // 
            this.gvSP.AllowUserToAddRows = false;
            this.gvSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSP.BackgroundColor = System.Drawing.Color.White;
            this.gvSP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSP.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvSP.GridColor = System.Drawing.Color.White;
            this.gvSP.Location = new System.Drawing.Point(25, 122);
            this.gvSP.Name = "gvSP";
            this.gvSP.ReadOnly = true;
            this.gvSP.RowHeadersWidth = 51;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green;
            this.gvSP.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvSP.RowTemplate.Height = 24;
            this.gvSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSP.Size = new System.Drawing.Size(1065, 487);
            this.gvSP.TabIndex = 3;
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
            this.btnHuy.Location = new System.Drawing.Point(1011, 185);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(116, 41);
            this.btnHuy.TabIndex = 71;
            this.btnHuy.Text = "    Hủy";
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
            this.btnXacNhan.Location = new System.Drawing.Point(844, 185);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(132, 41);
            this.btnXacNhan.TabIndex = 70;
            this.btnXacNhan.Text = "       Xác nhận";
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
            this.txtSoLuong.Location = new System.Drawing.Point(657, 190);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(127, 36);
            this.txtSoLuong.TabIndex = 69;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.BackColor = System.Drawing.SystemColors.Control;
            this.lblSoLuong.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.Teal;
            this.lblSoLuong.Location = new System.Drawing.Point(657, 157);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(79, 26);
            this.lblSoLuong.TabIndex = 68;
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
            this.cbTenSP.Location = new System.Drawing.Point(270, 189);
            this.cbTenSP.Name = "cbTenSP";
            this.cbTenSP.Size = new System.Drawing.Size(331, 36);
            this.cbTenSP.TabIndex = 67;
            // 
            // lblTenSP
            // 
            this.lblTenSP.BackColor = System.Drawing.SystemColors.Control;
            this.lblTenSP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.ForeColor = System.Drawing.Color.Teal;
            this.lblTenSP.Location = new System.Drawing.Point(270, 157);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(121, 26);
            this.lblTenSP.TabIndex = 66;
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
            this.cbMaSP.Location = new System.Drawing.Point(91, 189);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(117, 36);
            this.cbMaSP.TabIndex = 65;
            // 
            // lblMaSP
            // 
            this.lblMaSP.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaSP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.ForeColor = System.Drawing.Color.Teal;
            this.lblMaSP.Location = new System.Drawing.Point(91, 157);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(117, 26);
            this.lblMaSP.TabIndex = 64;
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
            this.txtMaHD.Location = new System.Drawing.Point(91, 57);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.PasswordChar = '\0';
            this.txtMaHD.PlaceholderText = "";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.SelectedText = "";
            this.txtMaHD.Size = new System.Drawing.Size(127, 36);
            this.txtMaHD.TabIndex = 63;
            // 
            // lblMaHD
            // 
            this.lblMaHD.BackColor = System.Drawing.SystemColors.Control;
            this.lblMaHD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.ForeColor = System.Drawing.Color.Teal;
            this.lblMaHD.Location = new System.Drawing.Point(91, 24);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(194, 33);
            this.lblMaHD.TabIndex = 62;
            this.lblMaHD.Text = "Mã hóa đơn nhập";
            // 
            // FormThemSanPhamVaoHDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 920);
            this.Controls.Add(this.gbListSP);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.cbTenSP);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.cbMaSP);
            this.Controls.Add(this.lblMaSP);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.lblMaHD);
            this.Name = "FormThemSanPhamVaoHDN";
            this.Text = "FormThemSanPhamVaoHDN";
            this.gbListSP.ResumeLayout(false);
            this.gbListSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbListSP;
        public Guna.UI2.WinForms.Guna2TextBox txtSearh;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblLoc;
        private System.Windows.Forms.DataGridView gvSP;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnXacNhan;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuong;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSoLuong;
        private Guna.UI2.WinForms.Guna2ComboBox cbTenSP;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenSP;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaSP;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaSP;
        private Guna.UI2.WinForms.Guna2TextBox txtMaHD;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMaHD;
    }
}