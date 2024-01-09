using QuanLyNhaSach.Bo;
using QuanLyNhaSach.Data;
using QuanLyNhaSach.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class FrmDangKy : Form
    {
        private taikhoanbo tkbo;
        public FrmDangKy()
        {
            tkbo = new taikhoanbo();
            InitializeComponent();
        }

        private void linkdangnhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            FrmDangNhap frmdangnhap = new FrmDangNhap();

            frmdangnhap.Show();
        }

        private void btndangky_Click(object sender, EventArgs e)
        {
            var user_register = tkbo.Register(txthoten.Text, txttendangnhap.Text, txtmatkhau.Text);
            if (user_register == null)
            {
                MessageBox.Show("that bai");
            }
            else
            {
                MessageBox.Show($" {user_register.id} + thanh cong");
            }
        }
    }
}
