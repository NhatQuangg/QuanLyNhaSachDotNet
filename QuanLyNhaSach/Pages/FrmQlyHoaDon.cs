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
    public partial class FrmQlyHoaDon : Form
    {
        private chitietbo ctbo;
        private hoadonbo hdbo;
        long idUser = -1;
        public FrmQlyHoaDon(long iduser)
        {
            ctbo = new chitietbo();
            hdbo = new hoadonbo();
            InitializeComponent();
            LoadHoaDon();

            idUser = iduser;
        }

        private void LoadHoaDon()
        {
            displayselect(0);
        }
        private void displayselect(int stt)
        {
            var id_hoadon = hdbo.getIdHD();
            cbbMaHoaDon.DataSource = id_hoadon;
            cbbMaHoaDon.DisplayMember = "display_id";
            cbbMaHoaDon.SelectedItem = id_hoadon[stt];
        }
        public hoadonDTO selectedHoaDon
        {
            get
            {
                return cbbMaHoaDon.SelectedItem as hoadonDTO;
            }
        }
        private void cbbMaHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDetail();
            var inforUser = hdbo.LayThongTinNguoiDungTheoHoaDonId(selectedHoaDon.id);
            var ngaytao = hdbo.GetNgayTaoHoaDonById(selectedHoaDon.id);
            txtmnv.Text = inforUser.id_taikhoan.ToString();
            txtngaytao.Text = ngaytao.ToString("dd/MM/yyyy");
            // txthotenn.Text = inforUser.hoten;
            txthoten.Text = inforUser.hoten;
        }
        private void LoadDetail()
        {
            if (selectedHoaDon != null)
            {
                dgvDetailProducts.DataSource = ctbo.GetDetailsBill(selectedHoaDon.id);

                decimal tongTien = ctbo.SumDetailsBill(selectedHoaDon.id);
                txttongtien.Text = string.Format("{0:N0} VNĐ", tongTien);

                // txttongtien.Text = ctbo.SumDetailsBill(selectedHoaDon.id).ToString();
                txttongsanpham.Text = ctbo.SumDetailProducts(selectedHoaDon.id).ToString();

               //  txtmnv.Text = 
            }
            else
            {
                MessageBox.Show("Chưa chọn hoặc không có hóa đơn nào được chọn.");
            }

        }

        private void txtmnv_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e.Handled = true;
        }

        private void txthoten_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e.Handled = true;
        }

        private void btnAddHD_Click(object sender, EventArgs e)
        {

            FrmChiTietHD frmchitiethd = new FrmChiTietHD(idUser);
            frmchitiethd.ShowDialog();
            LoadHoaDon();
        }

        private void dgvDetailProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Chỉ áp dụng định dạng cho cột "thanhtien"
            if (e.ColumnIndex == dgvDetailProducts.Columns[4].Index && e.Value != null)
            {
                decimal thanhTien = Convert.ToDecimal(e.Value);
                e.Value = string.Format("{0:N0}", thanhTien);
                e.FormattingApplied = true; // Đánh dấu đã áp dụng định dạng
            }
            if (e.ColumnIndex == dgvDetailProducts.Columns[3].Index && e.Value != null)
            {
                decimal donGia = Convert.ToDecimal(e.Value);
                e.Value = string.Format("{0:N0}", donGia);
                e.FormattingApplied = true; // Đánh dấu đã áp dụng định dạng
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvDetailProducts.SelectAll();
            DataObject copydata = dgvDetailProducts.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Worksheet xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();

            xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }
    }
}
