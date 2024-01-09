using QuanLyNhaSach.Bo;
using QuanLyNhaSach.Data;
using QuanLyNhaSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach.Pages
{
    public partial class FrmQlyTaiKhoan : Form
    {
        private taikhoanbo tkbo;
        public FrmQlyTaiKhoan()
        {
            tkbo = new taikhoanbo();
            InitializeComponent();
            LoadUser();
        }

        private void FrmQlyTaiKhoan_Load(object sender, EventArgs e)
        {
            List<taikhoan> danhSachTaiKhoan = tkbo.getUsers();
            dgvTaiKhoan.DataSource = danhSachTaiKhoan;
        }
        private void LoadUser()
        {
            List<taikhoan> danhSachTaiKhoan = tkbo.getUsers();
            dgvTaiKhoan.DataSource = danhSachTaiKhoan;
            txtAmount.Text = tkbo.CountUser().ToString();
        }

        private void btnTKAdd_Click(object sender, EventArgs e)
        {
            string hoten = txthoten.Text;
            string tendangnhap = txttendangnhap.Text;
            string matkhau = txtmatkhau.Text;
            if (string.IsNullOrEmpty(tendangnhap) || string.IsNullOrEmpty(matkhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tên đăng nhập và mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tkbo.CheckDuplicateUsername(tendangnhap))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var insertAccount = tkbo.InsertUser(hoten, tendangnhap, matkhau);
                MessageBox.Show("Thêm tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUser();
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex == -1)
                return;
            row = dgvTaiKhoan.Rows[e.RowIndex];
            taikhoan tk = (taikhoan)row.DataBoundItem;
            txthoten.Text = tk.hoten;
            txttendangnhap.Text = tk.tendangnhap;
            txtmatkhau.Text = tk.matkhau;
        }

        private void btnTKDelete_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.Rows.Count > 0)
            {
                int selectedRowIndex = dgvTaiKhoan.CurrentCell.RowIndex;
                var cell = dgvTaiKhoan.Rows[selectedRowIndex].Cells[0];
                if (cell.Value != null && long.TryParse(cell.Value.ToString(), out long userId))
                {
                    var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);
                    if (rs == DialogResult.OK)
                    {
                        var deleteProducts = tkbo.DeleteUser(userId);
                        LoadUser();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu trong DataGridView.");
            }
        }

        private void btnTKUpdate_Click(object sender, EventArgs e)
        {
            string hoten = txthoten.Text;
            string tendangnhap = txttendangnhap.Text;
            string matkhau = txtmatkhau.Text;
            if (dgvTaiKhoan.Rows.Count > 0)
            {
                int selectedRowIndex = dgvTaiKhoan.CurrentCell.RowIndex;
                var cell = dgvTaiKhoan.Rows[selectedRowIndex].Cells[0];
                if (cell.Value != null && long.TryParse(cell.Value.ToString(), out long userId))
                {
                    var userName = tkbo.getUserName(userId);
                    if (string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(matkhau) || string.IsNullOrEmpty(tendangnhap))
                    {
                        MessageBox.Show("Không được để trống");
                    }
                    else
                    {
                        // MessageBox.Show(userId.ToString());
                        if (userName.Equals(tendangnhap))
                        {
                            var updateUser = tkbo.UpdateUser(userId, hoten, tendangnhap, matkhau);
                            LoadUser();
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản không tồn tại");
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu trong DataGridView.");
            }
        }
    }
}
