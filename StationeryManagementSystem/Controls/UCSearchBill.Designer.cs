namespace StationeryManagementSystem
{
    partial class UCSearchBill
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dpEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDen = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTimKiem = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dpEnd
            // 
            this.dpEnd.BackColor = System.Drawing.SystemColors.Control;
            this.dpEnd.BorderColor = System.Drawing.Color.Teal;
            this.dpEnd.BorderRadius = 10;
            this.dpEnd.BorderThickness = 1;
            this.dpEnd.Checked = true;
            this.dpEnd.FillColor = System.Drawing.Color.White;
            this.dpEnd.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpEnd.ForeColor = System.Drawing.Color.Teal;
            this.dpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpEnd.Location = new System.Drawing.Point(428, 12);
            this.dpEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(257, 36);
            this.dpEnd.TabIndex = 56;
            this.dpEnd.Value = new System.DateTime(2024, 10, 12, 0, 0, 0, 0);
            // 
            // lblDen
            // 
            this.lblDen.BackColor = System.Drawing.SystemColors.Control;
            this.lblDen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDen.ForeColor = System.Drawing.Color.Teal;
            this.lblDen.Location = new System.Drawing.Point(387, 22);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(35, 26);
            this.lblDen.TabIndex = 55;
            this.lblDen.Text = "đến";
            // 
            // dpStart
            // 
            this.dpStart.BackColor = System.Drawing.SystemColors.Control;
            this.dpStart.BorderColor = System.Drawing.Color.Teal;
            this.dpStart.BorderRadius = 10;
            this.dpStart.BorderThickness = 1;
            this.dpStart.Checked = true;
            this.dpStart.FillColor = System.Drawing.Color.White;
            this.dpStart.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpStart.ForeColor = System.Drawing.Color.Teal;
            this.dpStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpStart.Location = new System.Drawing.Point(124, 12);
            this.dpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(257, 36);
            this.dpStart.TabIndex = 53;
            this.dpStart.Value = new System.DateTime(2024, 10, 12, 0, 0, 0, 0);
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.BackColor = System.Drawing.SystemColors.Control;
            this.lblTimKiem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.ForeColor = System.Drawing.Color.Teal;
            this.lblTimKiem.Location = new System.Drawing.Point(13, 22);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(105, 26);
            this.lblTimKiem.TabIndex = 54;
            this.lblTimKiem.Text = "Tìm kiếm từ";
            // 
            // pbSearch
            // 
            this.pbSearch.BackgroundImage = global::StationeryManagementSystem.Properties.Resources.Search;
            this.pbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSearch.Location = new System.Drawing.Point(691, 12);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(50, 36);
            this.pbSearch.TabIndex = 57;
            this.pbSearch.TabStop = false;
            this.pbSearch.MouseEnter += new System.EventHandler(this.pbSearch_MouseEnter);
            this.pbSearch.MouseLeave += new System.EventHandler(this.pbSearch_MouseLeave);
            // 
            // UCSearchBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.dpEnd);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.dpStart);
            this.Controls.Add(this.lblTimKiem);
            this.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UCSearchBill";
            this.Size = new System.Drawing.Size(761, 60);
            this.Load += new System.EventHandler(this.UCSearchBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pbSearch;
        public Guna.UI2.WinForms.Guna2DateTimePicker dpEnd;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblDen;
        public Guna.UI2.WinForms.Guna2DateTimePicker dpStart;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTimKiem;
    }
}
