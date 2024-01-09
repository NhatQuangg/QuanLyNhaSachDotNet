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
    public partial class FrmChiTietHD : Form
    {
        private chitietbo ctbo;
        private hoadonbo hdbo;
        private sanphambo spbo;
        private taikhoanbo tkbo;
        private List<sanphamDTO> selectedProductsList = new List<sanphamDTO>();
        long idUser = -1;
        public FrmChiTietHD(long iduser)
        {
            ctbo = new chitietbo();
            hdbo = new hoadonbo();
            spbo = new sanphambo();
            tkbo = new taikhoanbo();
            InitializeComponent();
            LoadProducts();
            // LoadNameUsers();

            idUser = iduser;
            string un = tkbo.getUserName(iduser);
            txthoten.Text = un;
        }
        /*        private void LoadNameUsers()
                {
                    displayselectUser(0);
                }*/
        /*        private void displayselectUser(int stt)
                {
                    var nameUser = tkbo.getNameUser();
                    cbbTennhanvien.DataSource = nameUser;
                    cbbTennhanvien.DisplayMember = "hoten";
                    cbbTennhanvien.ValueMember = "id";
                    cbbTennhanvien.SelectedItem = nameUser[stt];
                }*/
        private void LoadProducts()
        {
            displayselect(0);
        }
        private void displayselect(int stt)
        {
            var nameProducts = spbo.getNameProducts();
            cbbTensanpham.DataSource = nameProducts;
            cbbTensanpham.DisplayMember = "tensanpham";
            cbbTensanpham.ValueMember = "id";
            cbbTensanpham.SelectedItem = nameProducts[stt];
        }
        public sanphamDTO selectedProducts
        {
            get
            {
                return cbbTensanpham.SelectedItem as sanphamDTO;
            }
        }
        private void LoadPrice()
        {
            if (selectedProducts != null)
            {
                decimal donGia = spbo.GetPrice(selectedProducts.id);
                txtDonGia.Text = string.Format("{0:N0} VNĐ", donGia);
                txtSLCon.Text = spbo.GetAmount(selectedProducts.id).ToString();
            }
            else
            {
                MessageBox.Show("Chưa chọn hoặc không có hóa đơn nào được chọn.");
            }
        }

        private void cbbTensanpham_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPrice();
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (selectedProducts != null)
            {
                if (string.IsNullOrEmpty(txtSoLuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập số lượng.");
                    return;
                }
                int soluongmua = int.Parse(txtSoLuong.Text);
                long dongia = spbo.GetPrice(selectedProducts.id);
                if (spbo.GetAmount(selectedProducts.id) < soluongmua)
                {
                    MessageBox.Show("Số lượng còn ít hơn số lượng mua");
                }
                else
                {
                    txtSLCon.Text = (spbo.GetAmount(selectedProducts.id) - soluongmua).ToString();
                    if (string.IsNullOrEmpty(txtSoLuong.Text) || soluongmua != 0)
                    {
                        long thanhtien = soluongmua * dongia;

                        selectedProductsList.Add(new sanphamDTO
                        {
                            id = selectedProducts.id,
                            tensanpham = selectedProducts.tensanpham,
                            soluongmua = soluongmua.ToString(),
                            dongia = dongia,
                            thanhtien = thanhtien.ToString()
                        });
                        UpdateTotalAmount();
                        UpdateDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm trước khi nhập.");
            }
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            if (selectedProductsList.Count > 0)
            {
                // long idUser = (long)cbbTennhanvien.SelectedValue;

                // MessageBox.Show(idUser.ToString());
                if (hdbo.ThemHoaDon(selectedProductsList, idUser))
                {
                    MessageBox.Show("Thêm hóa đơn thành công", "Thông báo");
                }
                else
                    MessageBox.Show("Thêm hóa đơn thất bại", "Thông báo");

                selectedProductsList.Clear();
                txtTongTien.Text = "0";
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Danh sách sản phẩm trống. Vui lòng nhập ít nhất một sản phẩm trước khi thêm hóa đơn.");
            }
        }
        private void UpdateDataGridView()
        {
            dgvCTSP.DataSource = null;
            dgvCTSP.DataSource = selectedProductsList;
        }
        private void UpdateTotalAmount()
        {
            long totalAmount = 0;

            foreach (var selectedProduct in selectedProductsList)
            {
                totalAmount += long.Parse(selectedProduct.thanhtien);
            }

            txtTongTien.Text = string.Format("{0:N0} VNĐ", totalAmount);
            // txtTongTien.Text = totalAmount.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvCTSP.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dgvCTSP.SelectedRows[0].Index;

                var deletedProduct = selectedProductsList[selectedRowIndex];
                var sanpham = spbo.GetSanPhamById(deletedProduct.id);
                // MessageBox.Show(deletedProduct.soluongmua.ToString());
                if (sanpham != null)
                {
                    txtSLCon.Text = (long.Parse(txtSLCon.Text) + long.Parse(deletedProduct.soluongmua)).ToString();
                }

                selectedProductsList.RemoveAt(selectedRowIndex);

                UpdateDataGridView();
                UpdateTotalAmount();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.");
            }
        }

        private void dgvCTSP_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Chỉ áp dụng định dạng cho cột "thanhtien"
            if (e.ColumnIndex == dgvCTSP.Columns[3].Index && e.Value != null)
            {
                decimal donGia = Convert.ToDecimal(e.Value);
                e.Value = string.Format("{0:N0}", donGia);
                e.FormattingApplied = true; // Đánh dấu đã áp dụng định dạng
            }
            if (e.ColumnIndex == dgvCTSP.Columns[4].Index && e.Value != null)
            {
                decimal thanhTien = Convert.ToDecimal(e.Value);
                e.Value = string.Format("{0:N0}", thanhTien);
                e.FormattingApplied = true; // Đánh dấu đã áp dụng định dạng
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ngăn chặn kí tự không hợp lệ được nhập vào TextBox
            }
        }
    }
}
