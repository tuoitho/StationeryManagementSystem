namespace StationeryManagementSystem.GUI
{
    partial class FormChiTietLuong
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
            this.gbLuong = new Guna.UI2.WinForms.Guna2GroupBox();
            this.gvLuong = new System.Windows.Forms.DataGridView();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLuong
            // 
            this.gbLuong.BorderRadius = 10;
            this.gbLuong.BorderThickness = 2;
            this.gbLuong.Controls.Add(this.gvLuong);
            this.gbLuong.CustomBorderColor = System.Drawing.Color.Teal;
            this.gbLuong.FillColor = System.Drawing.SystemColors.Control;
            this.gbLuong.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLuong.ForeColor = System.Drawing.Color.White;
            this.gbLuong.Location = new System.Drawing.Point(12, 29);
            this.gbLuong.Name = "gbLuong";
            this.gbLuong.Size = new System.Drawing.Size(662, 315);
            this.gbLuong.TabIndex = 59;
            this.gbLuong.Text = "Lương nhân viên";
            // 
            // gvLuong
            // 
            this.gvLuong.BackgroundColor = System.Drawing.Color.White;
            this.gvLuong.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVien,
            this.tenNhanVien,
            this.tongLuong});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvLuong.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvLuong.GridColor = System.Drawing.Color.White;
            this.gvLuong.Location = new System.Drawing.Point(17, 65);
            this.gvLuong.Name = "gvLuong";
            this.gvLuong.ReadOnly = true;
            this.gvLuong.RowHeadersWidth = 51;
            this.gvLuong.RowTemplate.Height = 24;
            this.gvLuong.Size = new System.Drawing.Size(620, 230);
            this.gvLuong.TabIndex = 57;
            // 
            // maNhanVien
            // 
            this.maNhanVien.DataPropertyName = "Mã NV";
            this.maNhanVien.HeaderText = "Mã nhân viên";
            this.maNhanVien.MinimumWidth = 6;
            this.maNhanVien.Name = "maNhanVien";
            this.maNhanVien.ReadOnly = true;
            this.maNhanVien.Width = 200;
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "Họ Tên";
            this.tenNhanVien.HeaderText = "Tên nhân viên";
            this.tenNhanVien.MinimumWidth = 6;
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.ReadOnly = true;
            this.tenNhanVien.Width = 200;
            // 
            // tongLuong
            // 
            this.tongLuong.DataPropertyName = "Lương Tháng";
            this.tongLuong.HeaderText = "Tổng lương trong tháng";
            this.tongLuong.MinimumWidth = 6;
            this.tongLuong.Name = "tongLuong";
            this.tongLuong.ReadOnly = true;
            this.tongLuong.Width = 250;
            // 
            // FormChiTietLuong
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(703, 371);
            this.Controls.Add(this.gbLuong);
            this.Name = "FormChiTietLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết lương";
            this.Load += new System.EventHandler(this.FormChiTietLuong_Load);
            this.gbLuong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gbLuong;
        private System.Windows.Forms.DataGridView gvLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongLuong;
    }
}