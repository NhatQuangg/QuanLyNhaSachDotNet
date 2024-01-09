using QuanLyNhaSach.Bo;
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
    public partial class FrmQlyDoanhThu : Form
    {
        private doanhthubo dtbo;
        public FrmQlyDoanhThu()
        {
            dtbo = new doanhthubo();
            InitializeComponent();
            //LoadAllDoanhThu();
        }

        private void LoadAllDoanhThu()
        {
            var allDoanhthu = dtbo.GetDoanhThu();
            dgvProducts.DataSource = allDoanhthu;
            // HienThiSanPhamBanChayBanDau();
        }
        private void LoadDoanhThu()
        {
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;
            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc.", "Lỗi");
            }
            else
            {
                var doanhThuData = dtbo.GetDoanhThu(startDate, endDate);
                dgvProducts.DataSource = doanhThuData;
                HienThiSanPhamBanChayNhat(startDate, endDate);
                decimal tongTien = dtbo.GetTongDoanhThu(startDate, endDate);
                lbtongdoanhthu.Text = string.Format("{0:N0} VNĐ", tongTien);
            }


        }
        private void LoadDoanhThuOrderBy(int value)
        {
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;
            //var doanhThuData = dtbo.GetDoanhThuOrderBy(startDate, endDate, value);
            var doanhthu = dtbo.SapXepTheoTongTien(startDate, endDate, value);
            //dgvProducts.DataSource = doanhThuData;
            dgvProducts.DataSource = doanhthu;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            LoadDoanhThu();
        }

        private void btngiamdan_Click(object sender, EventArgs e)
        {
            LoadDoanhThuOrderBy(1);
        }

        private void btntangdan_Click(object sender, EventArgs e)
        {
            LoadDoanhThuOrderBy(0);
        }

        private void dgvProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvProducts.Columns[3].Index && e.Value != null)
            {
                decimal thanhTien = Convert.ToDecimal(e.Value);
                e.Value = string.Format("{0:N0}", thanhTien);
                e.FormattingApplied = true; // Đánh dấu đã áp dụng định dạng
            }
        }
        private void HienThiSanPhamBanChayNhat(DateTime startDate, DateTime endDate)
        {

            doanhthuDTO spbc = dtbo.GetSanPhamBanChayNhatThoiGian(startDate, endDate);
            if (spbc != null)
            {
                avtBook.ImageLocation = spbc.anh;
                lbId.Text = spbc.id.ToString();
                lbName.Text = spbc.tensanpham;
                lbPrice.Text = string.Format("{0:N0} VNĐ", spbc.dongia);
                //decimal tongTien = dtbo.GetTongDoanhThu(startDate, endDate);
                lbSumDoanhThu.Text = string.Format("{0:N0} VNĐ", spbc.tongtienbanduoc);
            }
        }

        private void HienThiSanPhamBanChayBanDau()
        {
            doanhthuDTO sanPhamBanChayNhat = dtbo.GetSanPhamBanChayNhatBanDau();

            if (sanPhamBanChayNhat != null)
            {
                avtBook.ImageLocation = sanPhamBanChayNhat.anh;
                lbId.Text = sanPhamBanChayNhat.id.ToString();
                lbName.Text = sanPhamBanChayNhat.tensanpham;
                lbPrice.Text = string.Format("{0:N0} VNĐ", sanPhamBanChayNhat.dongia);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvProducts.SelectAll();
            DataObject copydata = dgvProducts.GetClipboardContent();
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
