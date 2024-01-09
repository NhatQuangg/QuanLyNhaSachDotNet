using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Data
{
    public class chitietsanpham
    {
        public long id {  get; set; }
        public long soluong {  get; set; }

        [ForeignKey("hoadon")]
        public long id_hoadon {  get; set; }
        public hoadon hoadon { get; set; }

        [ForeignKey("sanpham")]
        public long id_sanpham { get; set; }
        public sanpham sanpham { get; set; }
    }
}
