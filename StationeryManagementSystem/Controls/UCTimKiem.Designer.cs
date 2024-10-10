namespace StationeryManagementSystem
{
    partial class UCTimKiem
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
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.txtSearh = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbLoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblLoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSearch
            // 
            this.pbSearch.BackgroundImage = global::StationeryManagementSystem.Properties.Resources.Search;
            this.pbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSearch.Location = new System.Drawing.Point(664, 11);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(50, 36);
            this.pbSearch.TabIndex = 18;
            this.pbSearch.TabStop = false;
            this.pbSearch.MouseEnter += new System.EventHandler(this.pbSearch_MouseEnter);
            this.pbSearch.MouseLeave += new System.EventHandler(this.pbSearch_MouseLeave);
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
            this.txtSearh.Location = new System.Drawing.Point(242, 11);
            this.txtSearh.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearh.Name = "txtSearh";
            this.txtSearh.PasswordChar = '\0';
            this.txtSearh.PlaceholderText = "";
            this.txtSearh.SelectedText = "";
            this.txtSearh.Size = new System.Drawing.Size(416, 36);
            this.txtSearh.TabIndex = 17;
            // 
            // cbLoc
            // 
            this.cbLoc.BackColor = System.Drawing.Color.Transparent;
            this.cbLoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoc.FillColor = System.Drawing.Color.LightYellow;
            this.cbLoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbLoc.ItemHeight = 30;
            this.cbLoc.Location = new System.Drawing.Point(98, 11);
            this.cbLoc.Margin = new System.Windows.Forms.Padding(0);
            this.cbLoc.Name = "cbLoc";
            this.cbLoc.Size = new System.Drawing.Size(137, 36);
            this.cbLoc.TabIndex = 20;
            // 
            // lblLoc
            // 
            this.lblLoc.BackColor = System.Drawing.Color.Transparent;
            this.lblLoc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.ForeColor = System.Drawing.Color.Teal;
            this.lblLoc.Location = new System.Drawing.Point(19, 21);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(74, 26);
            this.lblLoc.TabIndex = 19;
            this.lblLoc.Text = "Lọc theo";
            // 
            // UCTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.txtSearh);
            this.Controls.Add(this.cbLoc);
            this.Controls.Add(this.lblLoc);
            this.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UCTimKiem";
            this.Size = new System.Drawing.Size(738, 59);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearh;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoc;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLoc;
    }
}
