namespace StationeryManagementSystem.GUI
{
    partial class FormChiTietDoanhThu
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
            this.gbDoanhThu = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gvDoanhThu = new System.Windows.Forms.DataGridView();
            this.tenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDoanhThu
            // 
            this.gbDoanhThu.BorderRadius = 10;
            this.gbDoanhThu.BorderThickness = 2;
            this.gbDoanhThu.Controls.Add(this.gvDoanhThu);
            this.gbDoanhThu.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbDoanhThu.FillColor = System.Drawing.SystemColors.Control;
            this.gbDoanhThu.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDoanhThu.ForeColor = System.Drawing.Color.White;
            this.gbDoanhThu.Location = new System.Drawing.Point(12, 22);
            this.gbDoanhThu.Name = "gbDoanhThu";
            this.gbDoanhThu.Size = new System.Drawing.Size(662, 315);
            this.gbDoanhThu.TabIndex = 60;
            this.gbDoanhThu.Text = "Danh thu bán sản phẩm";
            // 
            // gvDoanhThu
            // 
            this.gvDoanhThu.BackgroundColor = System.Drawing.Color.White;
            this.gvDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvDoanhThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDoanhThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenSanPham,
            this.giaBan,
            this.soLuong,
            this.tongTien});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvDoanhThu.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvDoanhThu.GridColor = System.Drawing.Color.White;
            this.gvDoanhThu.Location = new System.Drawing.Point(17, 65);
            this.gvDoanhThu.Name = "gvDoanhThu";
            this.gvDoanhThu.ReadOnly = true;
            this.gvDoanhThu.RowHeadersWidth = 51;
            this.gvDoanhThu.RowTemplate.Height = 24;
            this.gvDoanhThu.Size = new System.Drawing.Size(620, 230);
            this.gvDoanhThu.TabIndex = 57;
            // 
            // tenSanPham
            // 
            this.tenSanPham.HeaderText = "Tên sản phẩm";
            this.tenSanPham.MinimumWidth = 6;
            this.tenSanPham.Name = "tenSanPham";
            this.tenSanPham.ReadOnly = true;
            this.tenSanPham.Width = 200;
            // 
            // giaBan
            // 
            this.giaBan.HeaderText = "Giá bán";
            this.giaBan.MinimumWidth = 6;
            this.giaBan.Name = "giaBan";
            this.giaBan.ReadOnly = true;
            this.giaBan.Width = 150;
            // 
            // soLuong
            // 
            this.soLuong.HeaderText = "Số lượng bán";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 250;
            // 
            // tongTien
            // 
            this.tongTien.HeaderText = "Tổng tiền";
            this.tongTien.MinimumWidth = 6;
            this.tongTien.Name = "tongTien";
            this.tongTien.ReadOnly = true;
            this.tongTien.Width = 170;
            // 
            // FormChiTietDoanhThu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(696, 363);
            this.Controls.Add(this.gbDoanhThu);
            this.Name = "FormChiTietDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết doanh thu";
            this.gbDoanhThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbDoanhThu;
        private System.Windows.Forms.DataGridView gvDoanhThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
    }
}