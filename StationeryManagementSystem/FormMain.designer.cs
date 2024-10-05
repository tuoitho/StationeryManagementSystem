using StationeryManagementSystem;
using System.Windows.Forms;

namespace StationeryManagementSystem
{
    partial class FormMain
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
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTiltle = new System.Windows.Forms.Label();
            this.panel_childForm = new System.Windows.Forms.Panel();
            this.roundedButton2 = new StationeryManagementSystem.RoundedButton();
            this.roundedButton3 = new StationeryManagementSystem.RoundedButton();
            this.roundedButton4 = new StationeryManagementSystem.RoundedButton();
            this.roundedButton5 = new StationeryManagementSystem.RoundedButton();
            this.roundedButton6 = new StationeryManagementSystem.RoundedButton();
            this.roundedButton7 = new StationeryManagementSystem.RoundedButton();
            this.roundedButton8 = new StationeryManagementSystem.RoundedButton();
            this.roundedButton9 = new StationeryManagementSystem.RoundedButton();
            this.roundedButton10 = new StationeryManagementSystem.RoundedButton();
            this.roundedButton11 = new StationeryManagementSystem.RoundedButton();
            this.panel_menu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.White;
            this.panel_menu.Controls.Add(this.roundedButton11);
            this.panel_menu.Controls.Add(this.roundedButton10);
            this.panel_menu.Controls.Add(this.roundedButton9);
            this.panel_menu.Controls.Add(this.roundedButton8);
            this.panel_menu.Controls.Add(this.roundedButton7);
            this.panel_menu.Controls.Add(this.roundedButton5);
            this.panel_menu.Controls.Add(this.roundedButton4);
            this.panel_menu.Controls.Add(this.roundedButton3);
            this.panel_menu.Controls.Add(this.roundedButton2);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_menu.MaximumSize = new System.Drawing.Size(281, 2061);
            this.panel_menu.MinimumSize = new System.Drawing.Size(72, 811);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(281, 1055);
            this.panel_menu.TabIndex = 0;
            this.panel_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_menu_Paint);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.Transparent;
            this.panel_logo.Controls.Add(this.roundedButton6);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Margin = new System.Windows.Forms.Padding(2);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(281, 92);
            this.panel_logo.TabIndex = 0;
            this.panel_logo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_logo_Paint);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(225)))));
            this.panelTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTitleBar.Controls.Add(this.lblTiltle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitleBar.Location = new System.Drawing.Point(281, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1440, 82);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.TabStop = true;
            // 
            // lblTiltle
            // 
            this.lblTiltle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiltle.ForeColor = System.Drawing.Color.White;
            this.lblTiltle.Location = new System.Drawing.Point(81, 9);
            this.lblTiltle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiltle.Name = "lblTiltle";
            this.lblTiltle.Size = new System.Drawing.Size(1106, 50);
            this.lblTiltle.TabIndex = 0;
            this.lblTiltle.Text = "Home";
            this.lblTiltle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_childForm
            // 
            this.panel_childForm.BackColor = System.Drawing.Color.Transparent;
            this.panel_childForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_childForm.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.panel_childForm.Location = new System.Drawing.Point(281, 82);
            this.panel_childForm.Margin = new System.Windows.Forms.Padding(2);
            this.panel_childForm.Name = "panel_childForm";
            this.panel_childForm.Size = new System.Drawing.Size(1440, 973);
            this.panel_childForm.TabIndex = 2;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.White;
            this.roundedButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton2.ForeColor = System.Drawing.Color.Black;
            this.roundedButton2.Image = global::StationeryManagementSystem.Properties.Resources.userden;
            this.roundedButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton2.Location = new System.Drawing.Point(0, 92);
            this.roundedButton2.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton2.Size = new System.Drawing.Size(281, 61);
            this.roundedButton2.TabIndex = 3;
            this.roundedButton2.Text = "   roundedButton2";
            this.roundedButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton2.UseVisualStyleBackColor = true;
            this.roundedButton2.Click += new System.EventHandler(this.roundedButton2_Click);
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.White;
            this.roundedButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton3.ForeColor = System.Drawing.Color.Black;
            this.roundedButton3.Image = global::StationeryManagementSystem.Properties.Resources.userden;
            this.roundedButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton3.Location = new System.Drawing.Point(0, 153);
            this.roundedButton3.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton3.Size = new System.Drawing.Size(281, 61);
            this.roundedButton3.TabIndex = 4;
            this.roundedButton3.Text = "   roundedButton2";
            this.roundedButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton3.UseVisualStyleBackColor = true;
            // 
            // roundedButton4
            // 
            this.roundedButton4.BackColor = System.Drawing.Color.White;
            this.roundedButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton4.FlatAppearance.BorderSize = 0;
            this.roundedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton4.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton4.ForeColor = System.Drawing.Color.Black;
            this.roundedButton4.Image = global::StationeryManagementSystem.Properties.Resources.userden;
            this.roundedButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton4.Location = new System.Drawing.Point(0, 214);
            this.roundedButton4.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton4.Name = "roundedButton4";
            this.roundedButton4.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton4.Size = new System.Drawing.Size(281, 61);
            this.roundedButton4.TabIndex = 5;
            this.roundedButton4.Text = "   roundedButton2";
            this.roundedButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton4.UseVisualStyleBackColor = true;
            // 
            // roundedButton5
            // 
            this.roundedButton5.BackColor = System.Drawing.Color.White;
            this.roundedButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton5.FlatAppearance.BorderSize = 0;
            this.roundedButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton5.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton5.ForeColor = System.Drawing.Color.Black;
            this.roundedButton5.Image = global::StationeryManagementSystem.Properties.Resources.userden;
            this.roundedButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton5.Location = new System.Drawing.Point(0, 275);
            this.roundedButton5.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton5.Name = "roundedButton5";
            this.roundedButton5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton5.Size = new System.Drawing.Size(281, 61);
            this.roundedButton5.TabIndex = 6;
            this.roundedButton5.Text = "   roundedButton2";
            this.roundedButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton5.UseVisualStyleBackColor = true;
            // 
            // roundedButton6
            // 
            this.roundedButton6.BackColor = System.Drawing.Color.White;
            this.roundedButton6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.roundedButton6.FlatAppearance.BorderSize = 0;
            this.roundedButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton6.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton6.ForeColor = System.Drawing.Color.Black;
            this.roundedButton6.Image = global::StationeryManagementSystem.Properties.Resources.menu;
            this.roundedButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton6.Location = new System.Drawing.Point(0, 31);
            this.roundedButton6.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton6.Name = "roundedButton6";
            this.roundedButton6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton6.Size = new System.Drawing.Size(281, 61);
            this.roundedButton6.TabIndex = 6;
            this.roundedButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton6.UseVisualStyleBackColor = true;
            this.roundedButton6.Click += new System.EventHandler(this.roundedButton1_Click);
            // 
            // roundedButton7
            // 
            this.roundedButton7.BackColor = System.Drawing.Color.White;
            this.roundedButton7.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton7.FlatAppearance.BorderSize = 0;
            this.roundedButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton7.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton7.ForeColor = System.Drawing.Color.Black;
            this.roundedButton7.Image = global::StationeryManagementSystem.Properties.Resources.userden;
            this.roundedButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton7.Location = new System.Drawing.Point(0, 336);
            this.roundedButton7.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton7.Name = "roundedButton7";
            this.roundedButton7.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton7.Size = new System.Drawing.Size(281, 61);
            this.roundedButton7.TabIndex = 7;
            this.roundedButton7.Text = "   roundedButton2";
            this.roundedButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton7.UseVisualStyleBackColor = true;
            // 
            // roundedButton8
            // 
            this.roundedButton8.BackColor = System.Drawing.Color.White;
            this.roundedButton8.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton8.FlatAppearance.BorderSize = 0;
            this.roundedButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton8.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton8.ForeColor = System.Drawing.Color.Black;
            this.roundedButton8.Image = global::StationeryManagementSystem.Properties.Resources.userden;
            this.roundedButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton8.Location = new System.Drawing.Point(0, 397);
            this.roundedButton8.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton8.Name = "roundedButton8";
            this.roundedButton8.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton8.Size = new System.Drawing.Size(281, 61);
            this.roundedButton8.TabIndex = 8;
            this.roundedButton8.Text = "   roundedButton2";
            this.roundedButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton8.UseVisualStyleBackColor = true;
            // 
            // roundedButton9
            // 
            this.roundedButton9.BackColor = System.Drawing.Color.White;
            this.roundedButton9.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton9.FlatAppearance.BorderSize = 0;
            this.roundedButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton9.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton9.ForeColor = System.Drawing.Color.Black;
            this.roundedButton9.Image = global::StationeryManagementSystem.Properties.Resources.userden;
            this.roundedButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton9.Location = new System.Drawing.Point(0, 458);
            this.roundedButton9.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton9.Name = "roundedButton9";
            this.roundedButton9.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton9.Size = new System.Drawing.Size(281, 61);
            this.roundedButton9.TabIndex = 9;
            this.roundedButton9.Text = "   roundedButton2";
            this.roundedButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton9.UseVisualStyleBackColor = true;
            // 
            // roundedButton10
            // 
            this.roundedButton10.BackColor = System.Drawing.Color.White;
            this.roundedButton10.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton10.FlatAppearance.BorderSize = 0;
            this.roundedButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton10.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton10.ForeColor = System.Drawing.Color.Black;
            this.roundedButton10.Image = global::StationeryManagementSystem.Properties.Resources.userden;
            this.roundedButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton10.Location = new System.Drawing.Point(0, 519);
            this.roundedButton10.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton10.Name = "roundedButton10";
            this.roundedButton10.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton10.Size = new System.Drawing.Size(281, 61);
            this.roundedButton10.TabIndex = 10;
            this.roundedButton10.Text = "   roundedButton2";
            this.roundedButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton10.UseVisualStyleBackColor = true;
            // 
            // roundedButton11
            // 
            this.roundedButton11.BackColor = System.Drawing.Color.White;
            this.roundedButton11.Dock = System.Windows.Forms.DockStyle.Top;
            this.roundedButton11.FlatAppearance.BorderSize = 0;
            this.roundedButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton11.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.roundedButton11.ForeColor = System.Drawing.Color.Black;
            this.roundedButton11.Image = global::StationeryManagementSystem.Properties.Resources.userden;
            this.roundedButton11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton11.Location = new System.Drawing.Point(0, 580);
            this.roundedButton11.Margin = new System.Windows.Forms.Padding(2);
            this.roundedButton11.Name = "roundedButton11";
            this.roundedButton11.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.roundedButton11.Size = new System.Drawing.Size(281, 61);
            this.roundedButton11.TabIndex = 11;
            this.roundedButton11.Text = "   roundedButton2";
            this.roundedButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roundedButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton11.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1721, 1055);
            this.Controls.Add(this.panel_childForm);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel_menu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTiltle;
        private System.Windows.Forms.Panel panel_childForm;
        private RoundedButton button_nv;
        private RoundedButton button_khachhang;
        private RoundedButton button_account;
        private RoundedButton btn_dangxuat;
        private Panel panel_logo;
        private RoundedButton roundedButton1;
        private RoundedButton button_phong;
        private RoundedButton button_bill;
        private RoundedButton button_dichvu;
        private RoundedButton button_dangkythuetra;
        private RoundedButton roundedButton_ca_lich;
        private RoundedButton roundedButton_bc_thu_chi;
        private RoundedButton roundedButton_khaibaotp = new RoundedButton();
        private RoundedButton button1;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton3;
        private RoundedButton roundedButton5;
        private RoundedButton roundedButton4;
        private RoundedButton roundedButton6;
        private RoundedButton roundedButton11;
        private RoundedButton roundedButton10;
        private RoundedButton roundedButton9;
        private RoundedButton roundedButton8;
        private RoundedButton roundedButton7;
    }
}