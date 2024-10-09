
using StationeryManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryManagementSystem
{
    public partial class FormMain : Form
    {
        private Form activeForm;
        private Button currentButton;

        public FormMain()
        {
            InitializeComponent();
            //if (Info.role == "employee")
            //{

            //    if (Info.chucvu == 1)
            //    {
            //        button_account.Visible = false;
            //        roundedButton_khaibaotp.Visible = false;
            //    }
            //    else
            //    if (Info.chucvu == 2)
            //    {
            //        button_nv.Visible = false;
            //        button_account.Visible = false;
            //        roundedButton_khaibaotp.Visible = false;
            //        button_dichvu.Visible = false;
            //        roundedButton_bc_thu_chi.Visible = false;

            //    }
            //    else if (Info.chucvu == 3)
            //    {
            //        button_nv.Visible = false;
            //        button_account.Visible = false;
            //        button_bill.Visible = false;
            //        button_phong.Visible = false;
            //        button_dichvu.Visible = false;
            //        roundedButton_bc_thu_chi.Visible = false;
            //        button_khachhang.Visible = false;
            //        button_dangkythuetra.Visible = false;
            //    }
            //}
        }

        private void button_nv_Click(object sender, EventArgs e)
        {
            //FormNhanVien formNhanVien = new FormNhanVien();
            //OpenChildForm(formNhanVien, sender);
            //lblTiltle.Text = "Nhân viên";
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_childForm.Controls.Add(childForm);
            this.panel_childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTiltle.Text = childForm.Text;

        }
        private void ActivateButton(object btnSender)
        {

            Color color = Color.FromArgb(0, 108, 225);
            if (btnSender != null)
            {

                if (currentButton != (RoundedButton)btnSender)
                {

                    currentButton = (RoundedButton)btnSender;
                    DisableButton();
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //change pic
                    //neu la roundedButton_qltk thì
                    if (currentButton.Name == "roundedButton_qltk")
                    {
                        currentButton.Image = Image.FromFile("..\\..\\Resources\\usertrang.png"); // Thay đổi đường dẫn hình ảnh theo ý bạn
                    }
                    if (currentButton.Name == "roundedButton_qlnv")
                    {
                        currentButton.Image = Image.FromFile("..\\..\\Resources\\employeetrang.png");
                    }
                    if (currentButton.Name == "roundedButton_qlsp")
                    {
                        currentButton.Image = Image.FromFile("..\\..\\Resources\\sanpham_trang.png");
                    }
                    //panelTitleBar.BackColor = color;
                    panel_logo.BackColor = Color.Transparent;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel_menu.Controls)
            {
                if (previousBtn.GetType() == typeof(RoundedButton))
                {
                    RoundedButton roundedButton = (RoundedButton)previousBtn; // Ép kiểu về RoundedButton

                    roundedButton.BackColor = Color.White;
                    roundedButton.ForeColor = Color.Black;
                    roundedButton.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    // Kiểm tra nếu là button "roundedButton_qltk" thì trả về ảnh ban đầu
                    if (roundedButton.Name == "roundedButton_qltk")
                    {
                        roundedButton.Image = Image.FromFile("..\\..\\Resources\\userden.png"); // Đường dẫn tới ảnh mặc định
                    }
                    if (roundedButton.Name == "roundedButton_qlnv")
                    {
                        roundedButton.Image = Image.FromFile("..\\..\\Resources\\employeeden.png");
                    }
                    //roundedButton_qlsp
                    if (roundedButton.Name == "roundedButton_qlsp")
                    {
                        roundedButton.Image = Image.FromFile("..\\..\\Resources\\sanpham_den.png");
                    }

                }
            }

        }
        bool isCollapsed = false;
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (!isCollapsed)
            {
                panel_menu.Size = panel_menu.MinimumSize;
                foreach (Control bt in panel_menu.Controls)
                {
                    if (bt.GetType() == typeof(RoundedButton))
                    {
                        bt.Text = "";
                    }
                }
                isCollapsed = true;
            }
            else
            {
                panel_menu.Size = panel_menu.MaximumSize;
                isCollapsed = false;
                roundedButton_qltk.Text = "   Quản Lý Tài Khoản";
                roundedButton_qlnv.Text = "   Quản Lý Nhân viên";
                //btn_dangxuat.Text = "Đăng xuất";
                //button_account.Text = "  Quản lý tài khoản";
                //button_khachhang.Text = "  Khách hàng";
                //button_nv.Text = "  Nhân viên";
                ////button_trangchu.Text = "  Trang chủ";
                //button_phong.Text = "  Phòng";
                //button_dichvu.Text = "  Dịch vụ";
                //btn_dangxuat.Text = "  Đăng xuất";
                //button_bill.Text = "  Hoá đơn";
                //button_dangkythuetra.Text = "  Đăng ký thuê trả";
                //roundedButton_ca_lich.Text = "  Ca, lich làm việc";
                //roundedButton_bc_thu_chi.Text = "  Báo cáo thu chi";
                //roundedButton_khaibaotp.Text = "  Khai báo thực phẩm";

            }

        }



        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_logo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton_qltk_Click(object sender, EventArgs e)
        {
            FormTaiKhoan formtk = new FormTaiKhoan();
            OpenChildForm(formtk, sender);
            lblTiltle.Text = "Quản Lý Tài Khoản";
        }

        private void roundedButton_qlnv_Click(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new FormNhanVien();
            OpenChildForm(formNhanVien, sender);
            lblTiltle.Text = "Quản Lý Nhân viên";
        }

        private void roundedButton_qlsp_Click(object sender, EventArgs e)
        {
            FormSanPham formSanPham = new FormSanPham();
            OpenChildForm(formSanPham, sender);
            lblTiltle.Text = "Quản Lý Sản Phẩm";

        }
    }
}
