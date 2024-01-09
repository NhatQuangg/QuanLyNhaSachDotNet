using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaSach.Data
{
    public class hoadon
    {
        public long id {  get; set; }
        public long thanhtien {  get; set; }
        public DateTime ngaytao { get; set; }
        // tạo khóa ngoại
        [ForeignKey("taikhoan")]
        public long id_taikhoan {  get; set; }
        public taikhoan taikhoan { get; set; }
    }
}
