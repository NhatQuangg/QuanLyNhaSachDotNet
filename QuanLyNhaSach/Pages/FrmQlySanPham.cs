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
    public partial class FrmQlySanPham : Form
    {
        private sanphambo spbo;
        private string linkImage = "";
        public FrmQlySanPham()
        {
            spbo = new sanphambo();
            InitializeComponent();
            LoadProducts();
        }
        private void LoadProducts()
        {
            List<sanpham> listProducts = spbo.getProducts();
            dgvProducts.DataSource = listProducts;
            txtAmount.Text = spbo.CountProducts().ToString();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            string tensanpham = txttensanpham.Text;
            string soluong = txtsoluong.Text;
            string dongia = txtdongia.Text;
            if (string.IsNullOrEmpty(tensanpham) || string.IsNullOrEmpty(soluong) || string.IsNullOrEmpty(dongia))
            {
                MessageBox.Show("Không được để trống", "Thông báo");
            }
            else
            {
                var insertProducts = spbo.InsertProducts(tensanpham, long.Parse(soluong), long.Parse(dongia), linkImage);
                LoadProducts();
                txttensanpham.Text = "";
                txtsoluong.Text = "";
                txtdongia.Text = "";
            }
        }

        private void avtBook_Click(object sender, EventArgs e)
        {
            var openDialog = new OpenFileDialog()
            {
                Title = "Chọn hình đại diện",
                Filter = "File ảnh | *.png;*.jpg;*.jpeg",
            };
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                var fileDaiDien = openDialog.FileName;
                avtBook.Load(fileDaiDien);
                linkImage = fileDaiDien;
            }
        }

        private void FrmQlySanPham_Load(object sender, EventArgs e)
        {
        }

        private void btnDeleteProducts_Click(object sender, EventArgs e)
        {
            if (dgvProducts.Rows.Count > 0)
            {
                int selectedRowIndex = dgvProducts.CurrentCell.RowIndex;
                var cell = dgvProducts.Rows[selectedRowIndex].Cells[0];
                if (cell.Value != null && long.TryParse(cell.Value.ToString(), out long productId))
                {
                    var rs = MessageBox.Show("Bạn có thực sự muốn xóa không?", "Thông báo",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);
                    if (rs == DialogResult.OK)
                    {
                        var deleteProducts = spbo.DeleteProducts(productId);
                        LoadProducts();
                        txttensanpham.Text = "";
                        txtsoluong.Text = "";
                        txtdongia.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu trong DataGridView.");
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex == -1)
                return;
            row = dgvProducts.Rows[e.RowIndex];
            sanpham sp = (sanpham)row.DataBoundItem;
            txttensanpham.Text = sp.tensanpham;
            txtdongia.Text = sp.dongia.ToString();
            txtsoluong.Text = sp.soluong.ToString();
            if (!string.IsNullOrEmpty(sp.anh))
            {
                avtBook.ImageLocation = sp.anh;
                linkImage = sp.anh;
            }

        }
        private void btnUpdateProducts_Click(object sender, EventArgs e)
        {
            string tensanpham = txttensanpham.Text;
            string soluong = txtsoluong.Text;
            string dongia = txtdongia.Text;
            if (dgvProducts.Rows.Count > 0)
            {
                int selectedRowIndex = dgvProducts.CurrentCell.RowIndex;
                var cell = dgvProducts.Rows[selectedRowIndex].Cells[0];
                if (cell.Value != null && long.TryParse(cell.Value.ToString(), out long productId))
                {
                    var nameProduct = spbo.getNameProduct(productId);
                    if (string.IsNullOrEmpty(txtsoluong.Text) || string.IsNullOrEmpty(txtdongia.Text) || string.IsNullOrEmpty(txttensanpham.Text))
                    {
                        MessageBox.Show("Không được để trống");
                    }
                    else
                    {
                        if (nameProduct.Equals(tensanpham))
                        {
                            var updateProducts = spbo.UpdateProducts(productId, tensanpham, long.Parse(soluong), long.Parse(dongia), linkImage);
                            LoadProducts();
                            txttensanpham.Text = "";
                            txtsoluong.Text = "";
                            txtdongia.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Tên sản phẩm không tồn tại");
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu trong DataGridView.");
            }
        }

        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnTangDan_Click(object sender, EventArgs e)
        {
            int number = 1;
            List<sanpham> listProducts = spbo.GetProductsOrder(number);
            dgvProducts.DataSource = listProducts;
        }
        private void btnGiamDan_Click(object sender, EventArgs e)
        {
            int number = 2;
            List<sanpham> listProducts = spbo.GetProductsOrder(number);
            dgvProducts.DataSource = listProducts;
        }

        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string keyword = textBox1.Text;
                var sp = spbo.TimKiemSanPham(keyword);
                dgvProducts.DataSource = null;
                dgvProducts.DataSource = sp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Kiểm tra xem đang xử lý cột "dongia" không
            if (e.ColumnIndex == dgvProducts.Columns[3].Index && e.Value != null)
            {
                // Định dạng giá trị tiền tệ
                long dongia = Convert.ToInt64(e.Value);
                e.Value = dongia.ToString("N0");
            }
        }
    }
}
