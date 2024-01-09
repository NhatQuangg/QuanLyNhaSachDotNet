using QuanLyNhaSach.Bo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace QuanLyNhaSach.Pages
{
    public partial class FrmDangNhap : Form
    {
        private taikhoanbo tkbo;
        public FrmDangNhap()
        {
            tkbo = new taikhoanbo();
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void linkdangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Ẩn form hiện tại
            this.Hide();

            // Tạo một đối tượng mới của form bạn muốn chuyển đến
            FrmDangKy frmdangky = new FrmDangKy();

            // Hiển thị form mới
            frmdangky.Show();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {


            var user_login = tkbo.Login(txttendangnhap.Text, txtmatkhau.Text);
            if (user_login == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai. Vui lòng thử lại");
            }
            else
            {
                this.Hide();
                FrmHome frmhome = new FrmHome(user_login.id);
                frmhome.Show();
                // MessageBox.Show($" {user_login.hoten} + thanh cong");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
