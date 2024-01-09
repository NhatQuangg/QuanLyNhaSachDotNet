using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.DTO
{
    public class chitiethoadonDTO
    {
        public long id { get; set; }
        public long soluong {  get; set; }
        public long id_sanpham { get; set; }
        public long id_hoadon {  get; set; }
        public string tensanpham {  get; set; }
        public long dongia {  get; set; }
        public long thanhtien {  get; set; }
        public DateTime ngaytao {  get; set; }
    }
}
