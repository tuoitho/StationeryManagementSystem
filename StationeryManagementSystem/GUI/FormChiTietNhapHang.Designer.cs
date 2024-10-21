namespace StationeryManagementSystem.GUI
{
    partial class FormChiTietNhapHang
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
            this.gbNhapHang = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gvNhapHang = new System.Windows.Forms.DataGridView();
            this.tenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbNhapHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNhapHang
            // 
            this.gbNhapHang.BorderRadius = 10;
            this.gbNhapHang.BorderThickness = 2;
            this.gbNhapHang.Controls.Add(this.gvNhapHang);
            this.gbNhapHang.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbNhapHang.FillColor = System.Drawing.SystemColors.Control;
            this.gbNhapHang.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNhapHang.ForeColor = System.Drawing.Color.White;
            this.gbNhapHang.Location = new System.Drawing.Point(12, 25);
            this.gbNhapHang.Name = "gbNhapHang";
            this.gbNhapHang.Size = new System.Drawing.Size(662, 315);
            this.gbNhapHang.TabIndex = 58;
            this.gbNhapHang.Text = "Nhập hàng";
            // 
            // gvNhapHang
            // 
            this.gvNhapHang.BackgroundColor = System.Drawing.Color.White;
            this.gvNhapHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvNhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenSanPham,
            this.giaNhap,
            this.soLuong,
            this.thanhToan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvNhapHang.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvNhapHang.GridColor = System.Drawing.Color.White;
            this.gvNhapHang.Location = new System.Drawing.Point(17, 65);
            this.gvNhapHang.Name = "gvNhapHang";
            this.gvNhapHang.ReadOnly = true;
            this.gvNhapHang.RowHeadersWidth = 51;
            this.gvNhapHang.RowTemplate.Height = 24;
            this.gvNhapHang.Size = new System.Drawing.Size(620, 230);
            this.gvNhapHang.TabIndex = 57;
            // 
            // tenSanPham
            // 
            this.tenSanPham.HeaderText = "Tên sản phẩm";
            this.tenSanPham.MinimumWidth = 6;
            this.tenSanPham.Name = "tenSanPham";
            this.tenSanPham.ReadOnly = true;
            this.tenSanPham.Width = 200;
            // 
            // giaNhap
            // 
            this.giaNhap.HeaderText = "Giá nhập";
            this.giaNhap.MinimumWidth = 6;
            this.giaNhap.Name = "giaNhap";
            this.giaNhap.ReadOnly = true;
            this.giaNhap.Width = 150;
            // 
            // soLuong
            // 
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 200;
            // 
            // thanhToan
            // 
            this.thanhToan.HeaderText = "Tổng thanh toán";
            this.thanhToan.MinimumWidth = 6;
            this.thanhToan.Name = "thanhToan";
            this.thanhToan.ReadOnly = true;
            this.thanhToan.Width = 200;
            // 
            // FormChiTietNhapHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(687, 376);
            this.Controls.Add(this.gbNhapHang);
            this.Name = "FormChiTietNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết nhập hàng";
            this.gbNhapHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvNhapHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbNhapHang;
        private System.Windows.Forms.DataGridView gvNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhToan;
    }
}